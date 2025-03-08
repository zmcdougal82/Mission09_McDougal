using Microsoft.AspNetCore.Mvc.RazorPages;
using CollegeTeamsRazor.Models;
using CollegeTeamsRazor.Services;
using System.Threading.Tasks;

namespace CollegeTeamsRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TeamService _teamService;

        public IndexModel(TeamService teamService)
        {
            _teamService = teamService;
        }

        // We'll store the teams here so the .cshtml can access them
        public List<Team> Teams { get; set; }

        public async Task OnGetAsync()
        {
            // Call the service to get the JSON data
            var data = await _teamService.GetTeamDataAsync();
            Teams = data.Teams;
        }
    }
}