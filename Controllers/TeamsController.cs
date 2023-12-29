using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAppassign15.Models;

namespace WebAppassign15.Controllers
{
    public class TeamsController : ApiController
    {
        static List<Team> teamList = new List<Team>()
        {
            new Team { Id=1,TName = "Team A", TEmail = "teamA@example.com", TSlogan = "Achieving Excellence" },
            new Team {Id=2, TName = "Team B", TEmail = "teamB@example.com", TSlogan = "Innovation Driven" },
            new Team { Id=3,TName = "Team C", TEmail = "teamC@example.com", TSlogan = "Collaboration at its Best" }
        };

        // Get all teams
        public IEnumerable<Team> Get()
        {
            return teamList;
        }

        // Get a specific team by ID
        public IHttpActionResult Get(int id)
        {
            Team team = teamList.SingleOrDefault(e => e.Id == id);

            if (team != null)
            {
                return Ok(team);
            }
            else
            {
                return NotFound();
            }
        }

        // This is just a basic example. You can add more actions for CRUD operations.
    }
}
