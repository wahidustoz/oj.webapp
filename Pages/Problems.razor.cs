using Microsoft.AspNetCore.Components;
using oj.webapp.Dto;
using oj.webapp.Services;

namespace oj.webapp.Pages;

public partial class Problems
{
    private List<string> Tags = new List<string>() { "if-else", "switch", "conditional", "relations" };

    [Inject]
    public IProblemService ProblemService { get; set; }

    [Inject]
    public ILogger<Problems> Logger { get; set; }
    
    

    public List<Problem> _Problems { get; set; } = new List<Problem>();
    
    
    
    protected override async Task OnInitializedAsync()
    {
        Logger.LogInformation("Page loading...");
        var _Problems = await ProblemService.GetProblemsAsync();

        Logger.LogInformation(_Problems.Count.ToString());
    }
    
}