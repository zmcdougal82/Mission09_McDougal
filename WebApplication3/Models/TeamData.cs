using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CollegeTeamsRazor.Models
{
    public class TeamData
    {
        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; }
    }
}