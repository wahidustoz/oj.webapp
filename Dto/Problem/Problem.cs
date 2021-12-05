namespace oj.webapp.Dto;

using System.Text.Json.Serialization;

public class Problem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("created_by")]
    public CreatedBy CreatedBy { get; set; }

    [JsonPropertyName("template")]
    public Template Template { get; set; }

    [JsonPropertyName("_id")]
    public string _Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("input_description")]
    public string InputDescription { get; set; }

    [JsonPropertyName("output_description")]
    public string OutputDescription { get; set; }

    [JsonPropertyName("samples")]
    public List<Sample> Samples { get; set; }

    [JsonPropertyName("hint")]
    public string Hint { get; set; }

    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; }

    [JsonPropertyName("create_time")]
    public DateTime CreateTime { get; set; }

    [JsonPropertyName("last_update_time")]
    public object LastUpdateTime { get; set; }

    [JsonPropertyName("time_limit")]
    public int TimeLimit { get; set; }

    [JsonPropertyName("memory_limit")]
    public int MemoryLimit { get; set; }

    [JsonPropertyName("io_mode")]
    public IOMode IoMode { get; set; }

    [JsonPropertyName("spj")]
    public bool Spj { get; set; }

    [JsonPropertyName("spj_language")]
    public string SpjLanguage { get; set; }

    [JsonPropertyName("rule_type")]
    public string RuleType { get; set; }

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("total_score")]
    public int TotalScore { get; set; }

    [JsonPropertyName("submission_number")]
    public int SubmissionNumber { get; set; }

    [JsonPropertyName("accepted_number")]
    public int AcceptedNumber { get; set; }

    [JsonPropertyName("statistic_info")]
    public Dictionary<string, int> StatisticInfo { get; set; }

    [JsonPropertyName("share_submission")]
    public bool ShareSubmission { get; set; }

    [JsonPropertyName("contest")]
    public object Contest { get; set; }

    [JsonPropertyName("my_status")]
    public int MyStatus { get; set; }
}


