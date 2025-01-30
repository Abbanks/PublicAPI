using System.Text.Json.Serialization;

namespace PublicAPI.Models
{
    public class Result
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("current_datetime")]
        public string CurrentDatetime { get; set; } = string.Empty;

        [JsonPropertyName("github_url")]
        public string GithubUrl { get; set; } = string.Empty;
    }
}
