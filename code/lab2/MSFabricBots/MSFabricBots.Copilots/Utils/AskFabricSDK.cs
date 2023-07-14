using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

namespace MSFabricBots.Copilots
{
    

    public class Question
    {
        public string questionText { get; set; }
    }

    // public class GPTAnswer
    // {
    //     public string answer { get; set; }
    // }

    public class AskFabricSDK
	{
        // HttpRequestMessage request;


        public async Task<string> GetAnswer(string question)
        {

            var prompt = new Question { questionText = question };

            var jsonObj = JsonSerializer.Serialize(prompt);


            var httpClient = new HttpClient();

            Console.WriteLine("aaaaa" + httpClient.BaseAddress);

            var uriBuilder = new UriBuilder(httpClient.BaseAddress);
            // uriBuilder.Path = "/api/AIOnnxHttpTrigger";

            uriBuilder.Path = "/api/AskChat";



            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri(uriBuilder.ToString()),
                Content = new StringContent(jsonObj, System.Text.Encoding.UTF8, "application/json")
            };



            var response = await httpClient.SendAsync(request);

            var responseContent = await response.Content.ReadAsStringAsync();

            var answer = responseContent;

            return answer;


        }

    }
}