using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Singleton
{
    public class UserFetcher:IUserFetcher
    {
        private readonly string _url = "https://api.github.com/users";
        private readonly HttpClient _httpClient;
        private string _users;

        public UserFetcher(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }

        public async Task<string> Fetch()
        {            
            var request = new HttpRequestMessage(HttpMethod.Get, _url);
            request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PostmanRuntime", "7.28.4"));
            var resp = await _httpClient.SendAsync(request);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());

            _users = await resp.Content.ReadAsStringAsync();
            return _users;
        }
    }

       
    }
}
