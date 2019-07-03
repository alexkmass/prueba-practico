using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractico
{
    public class DBTeamDataAccess
    {
        public void AddTeam(Team aTeam)
        {
            using (var context = new Context())
            {
                context.teams.Add(aTeam);
                context.SaveChanges();
            }
        }

        public void UpdateTeam(Team oldTeam, Team newTeam)
        {
            using (var context = new Context())
            {
                var team = context.teams.First(t => t.Id == oldTeam.Id);
                team.Players = newTeam.Players;
                team.City = newTeam.City;
                team.FoundationalYear = newTeam.FoundationalYear;
                team.Name = newTeam.Name;
                context.SaveChanges();
            }
        }

        public void RemoveTeam(Team aTeam)
        {
            using (var context = new Context())
            {
                var teamToRemove = context.teams.First(t => t.Id == aTeam.Id);
                context.teams.Remove(teamToRemove);
                context.SaveChanges();
            }
        }

        public Team GetTeam(int Id)
        {
            using (var context = new Context())
            {
                return context.teams.First(t => t.Id == Id);
            }
        }

        public Player GetOldestPlayer(int Id)
        {
            Team team;
            using (var context = new Context())
            {
                team = context.teams.First(t => t.Id == Id);
            }
            List<Player> orderedPlayers = team.Players.OrderBy(p => p.DateOfBirth).ToList();
            if (orderedPlayers.Count > 0)
            {
                return orderedPlayers[0];
            }
            else
            {
                return null;
            }
        }
    }
}
