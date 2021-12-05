namespace oj.webapp.Dto;

using System.Text.Json.Serialization;

public class ProblemResponseDto
{
    [JsonPropertyName("error")]
    public string Error { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }
}


