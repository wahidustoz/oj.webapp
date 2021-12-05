using System.Text.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using oj.webapp.Dto;

namespace oj.webapp.Services;

public class ProblemService : IProblemService
{
    private readonly ILogger<ProblemService> _logger;
    private readonly HttpClient _client;

    public ProblemService(IHttpClientFactory clientFactory, ILogger<ProblemService> logger)
    {
        _logger = logger;
        _client = clientFactory.CreateClient("ProblemsClient");
    }
    public async Task<List<Problem>> GetProblemsAsync(int limit = 10, int page = 1, string difficulty = "", string keyword = "")
    {
        _logger.LogInformation("Starting request...");
        var query = $"?limit={limit}&page={page}&difficulty={difficulty}&keyword={keyword}";
        
        var request = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri(_client.BaseAddress, query)
        };
        request.SetBrowserRequestMode(BrowserRequestMode.NoCors); 

        var response = await _client.SendAsync(request);
        _logger.LogInformation(await response.Content.ReadAsStringAsync());

        if(response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            _logger.LogInformation($"Received respones from API: {responseString}");
            try
            {
                var responseObject = JsonSerializer.Deserialize<ProblemResponseDto>(responseString);
                return responseObject.Data.Problems;
            }
            catch(Exception e)
            {
                _logger.LogWarning(e.Message);
            }
        }
        else
        {
            _logger.LogError(await response.Content.ReadAsStringAsync());
        }

        return new List<Problem>();
    }
}