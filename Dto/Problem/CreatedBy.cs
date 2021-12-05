namespace oj.webapp.Dto;
using System.Text.Json.Serialization;

public class CreatedBy
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("real_name")]
    public string RealName { get; set; }
}


