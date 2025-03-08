using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using CollegeTeamsRazor.Models;

namespace CollegeTeamsRazor.Services
{
    public class TeamService
    {
        private readonly string _jsonFilePath;

        public TeamService(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }

        public async Task<TeamData> GetTeamDataAsync()
        {
            if (!File.Exists(_jsonFilePath))
            {
                throw new FileNotFoundException("JSON file not found.", _jsonFilePath);
            }

            using var stream = File.OpenRead(_jsonFilePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var teamData = await JsonSerializer.DeserializeAsync<TeamData>(stream, options);

            return teamData;
        }
    }
}