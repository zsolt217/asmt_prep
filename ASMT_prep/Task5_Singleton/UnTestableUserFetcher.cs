using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Singleton
{
    public class UnTestableUserFetcher
    {
        private readonly static UnTestableUserFetcher _userFetcher;
        public static UnTestableUserFetcher Fetcher => _userFetcher;
        private readonly string _url = "https://api.github.com/users";
        private string _users;

        private UnTestableUserFetcher() { }

        //each static contrustor of a class is thread-safe
        static UnTestableUserFetcher()
        {
            _userFetcher = new UnTestableUserFetcher();
        }

        public async Task<string> FetchData()
        {
            using HttpClient client = new HttpClient();
            var request=new HttpRequestMessage(HttpMethod.Get, _url);
            request.Headers.UserAgent.Add(new ProductInfoHeaderValue("PostmanRuntime","7.28.4"));
            var resp = await client.SendAsync(request);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());

            _users = await resp.Content.ReadAsStringAsync();
            return _users;
        }
    }
}


