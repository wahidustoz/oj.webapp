// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
namespace oj.webapp.Dto;
using System.Text.Json.Serialization;

public class Sample
{
    [JsonPropertyName("input")]
    public string Input { get; set; }

    [JsonPropertyName("output")]
    public string Output { get; set; }
}


