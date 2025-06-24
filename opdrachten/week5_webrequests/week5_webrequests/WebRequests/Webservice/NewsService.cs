using System.Net.Http;
using System.Net.Http.Json;

namespace WebRequests.Webservice
{
    public class NewsService
    {
        public string[] GetNewsHeaders()
        {
            string url = "http://localhost:5138/news"; // Pas poort aan indien nodig!
            using (HttpClient httpClient = new HttpClient())
            {
                string[] result = httpClient.GetFromJsonAsync<string[]>(url).Result;
                return result;
            }
        }
    }
}