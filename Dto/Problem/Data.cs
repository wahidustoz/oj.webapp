namespace oj.webapp.Dto;

using System.Text.Json.Serialization;

public class Data
    {
        [JsonPropertyName("results")]
        public List<Problem> Problems { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }


