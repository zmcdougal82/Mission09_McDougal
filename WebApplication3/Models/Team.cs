using System.Text.Json.Serialization;

namespace CollegeTeamsRazor.Models
{
    public class Team
    {
        [JsonPropertyName("tid")]
        public int Tid { get; set; }

        [JsonPropertyName("cid")]
        public int Cid { get; set; }

        [JsonPropertyName("did")]
        public int Did { get; set; }

        [JsonPropertyName("school")]
        public string School { get; set; }

        // "name" in the JSON is really the team’s mascot
        [JsonPropertyName("name")]
        public string Mascot { get; set; }

        [JsonPropertyName("abbrev")]
        public string Abbrev { get; set; }

        [JsonPropertyName("pop")]
        public int Population { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}