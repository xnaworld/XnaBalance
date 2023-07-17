using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace RavencoinApiExample
{
    public class Ravencore
    {
        static string hostName = "127.0.0.1";
        static string port = "19001";//"8766";//
        static string userName = "cryptobullsh";
        static string password = "test12311";

        public static string Connect(RavencoinRequest rreq)
        {
            HttpClient client = new HttpClient();
            Uri baseUri = new Uri($"http://{hostName}:{port}");
            client.BaseAddress = baseUri;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.ConnectionClose = true;
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            //Set up authentication
            var authenticationString = $"{userName}:{password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

            //Set up the body of the message.
            //This adds the authorization header and encoding the RavencoinRequest object into json.
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

            //Set the content of the body
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(rreq), Encoding.UTF8, "application/json");
            string test = JsonConvert.SerializeObject(rreq);

            //make the request
            var task = client.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

            return responseBody;
        }
    }
}

