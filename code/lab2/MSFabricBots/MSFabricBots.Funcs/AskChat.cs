using System;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using MSFabricBots.Kernel;

namespace MSFabricBots.Funcs
{
    public class AskChat
    {
        private readonly ILogger _logger;
        IConfigurationRoot configuration ;
        KernelSettings kernel;

        public AskChat(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<AskChat>();

            configuration = new ConfigurationBuilder().AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true).Build() ;

            
            var skillsDirectory =  System.IO.Directory.GetCurrentDirectory() + "/Skills";

            kernel= new(configuration,skillsDirectory);

        }

        [Function("AskChat")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            // _logger.LogInformation("C# HTTP trigger function processed a request.");

            
            var query = JsonSerializer.Deserialize<Questions>(req.Body);

            var answers = kernel.AskSkill(query.questionText);

            Console.WriteLine(query.questionText);

            
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            await foreach(var item in answers)
            {
                var result =  kernel.SummarySkill(item.Metadata.Text);
                Console.WriteLine(result.Result);
                Console.WriteLine(item.Metadata.Text + " : " + item.Relevance);
                response.WriteString(result.Result.ToString());
            } 

            return response;
        }
    }
}
