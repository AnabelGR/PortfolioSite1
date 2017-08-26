using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Build.Utilities;
using System.Threading.Tasks;

namespace PortfolioDeux.Models
{
    public class Repo
    {
        public string name { get; set; }
        public int stargazers_count { get; set; }

        public static List<Repo> GetRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("/users/anabelgr/starred", Method.GET);
            client.AddDefaultHeader("User-Agent", "AnabelGR PortfolioDeux");
            var response = new RestResponse();
            System.Threading.Tasks.Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var repoList = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse.ToString());
            return repoList;
        }
        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}