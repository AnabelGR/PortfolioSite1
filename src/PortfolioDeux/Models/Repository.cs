using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PortfolioDeux.Models
{
    public class Repository
    {
        public string starred_url { get; set; }

    public static List<Repository> GetRepositories()
    {
        var client = new RestClient("https://api.github.com/user");
        var request = new RestRequest(Method.GET);
        client.Authenticator = new HttpBasicAuthenticator(EnviromentalVariables.username, EnviromentalVariables.password);
        var response = new RestResponse();
        Task.Run(async () =>
        {
            response = await GetResponseContentAsync(client, request) as RestResponse;
        }).Wait();
        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
        var repositoryList = JsonConvert.DeserializeObject<List<Repository>>(jsonResponse["repositories"].ToString());
        return repositoryList;
    }

    public void Send()
    {
        var client = new RestClient("https://api.github.com/user");
        var request = new RestRequest(Method.POST);
        request.AddParameter("Starred Repositories: ", starred_url);
        client.Authenticator = new HttpBasicAuthenticator(EnviromentalVariables.username, EnviromentalVariables.password);
        client.ExecuteAsync(request, response => {
            Console.WriteLine(response.Content);
        });
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