using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DeerCafe_Repo.Services.Impl
{
    public class AuthenticationService : IAuthentication
    {
        // development constants
        private const string API_URL = "https://admin.reso.vn/";
        private const string username = "test";
        private const string password = "123";
        public AuthenticationService() { }

        public string Authenticate(string username, string password)
        {
            var client = new RestClient(API_URL);
            var request = new RestRequest("api/v1/auth/login", Method.Post);
            request.AddJsonBody(new { username, password });
            var response = client.Execute(request);
            // log response.Content
            Console.WriteLine(response.Content);
            // return token
            return response.Content;
        }
    }
}
