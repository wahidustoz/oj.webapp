namespace oj.webapp.Dto;

using System.Text.Json.Serialization;

public class IOMode
{
    [JsonPropertyName("input")]
    public string Input { get; set; }

    [JsonPropertyName("output")]
    public string Output { get; set; }

    [JsonPropertyName("io_mode")]
    public string IoMode { get; set; }
}


