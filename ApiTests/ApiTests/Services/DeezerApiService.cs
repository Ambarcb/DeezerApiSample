using ApiTests.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiTests.Services
{
    public class DeezerApiService : IDeezerApiService
    {

        const string ApiHost = "x-rapidapi-host";
        const string ApiHostValue = "deezerdevs-deezer.p.rapidapi.com";
        const string ApiKey = "x-rapidapi-key";
        const string ApiKeyValue = "069264c0f2msha5bc2069b48b455p1cf35ajsnf9502b386e2a";

        public async Task<Artist> GetArtistInfo(string Id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add($"{ApiHost}", $"{ApiHostValue}");
                client.DefaultRequestHeaders.Add($"{ApiKey}", $"{ApiKeyValue}");
                var result = await client.GetStringAsync($"https://deezerdevs-deezer.p.rapidapi.com/artist/{Id}");
                return JsonConvert.DeserializeObject<Artist>(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"API EXCEPTION {ex}");
                
            }
            return default;
        }
        
                   
    }

}
