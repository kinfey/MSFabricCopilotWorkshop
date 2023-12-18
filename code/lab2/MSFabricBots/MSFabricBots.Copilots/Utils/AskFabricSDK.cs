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

            var uriBuilder = new UriBuilder(httpClient.BaseAddress);

            uriBuilder.Path = "/api/AskChat";

            // create HttpRequestMessage , method POST , RequestUri = uriBuilder.Uri , Content = new StringContent(jsonObj, Encoding.UTF8, "application/json")

            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = uriBuilder.Uri,
                Content = new StringContent(jsonObj, Encoding.UTF8, "application/json")
            };
            
            //generate response with httpClient.SendAsync(request)

            var response = await httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            var answer = responseContent;

            return answer;


        }

    }
}