namespace oj.webapp.Models;

public class Problem
{
    public int Id { get; set; }
    public List<string> Tags { get; set; }
    public Owner CreatedBy { get; set; }
    public Template Template { get; set; }
    public string _Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string InputDescription { get; set; }
    public string OutputDescription { get; set; }
    public List<Sample> Samples { get; set; }
    public string Hint { get; set; }
    public List<string> Languages { get; set; }
    public DateTime CreateTime { get; set; }
    public object LastUpdateTime { get; set; }
    public int TimeLimit { get; set; }
    public int MemoryLimit { get; set; }
    public IOMode IoMode { get; set; }
    public bool Spj { get; set; }
    public string SpjLanguage { get; set; }
    public string RuleType { get; set; }
    public string Difficulty { get; set; }
    public string Source { get; set; }
    public int TotalScore { get; set; }
    public int SubmissionNumber { get; set; }
    public int AcceptedNumber { get; set; }
    public Dictionary<string, int> StatisticInfo { get; set; }
    public bool ShareSubmission { get; set; }
    public object Contest { get; set; }
    public int MyStatus { get; set; }
}