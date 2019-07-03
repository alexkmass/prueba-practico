using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractico
{
    public class DBPlayerDataAccess
    {
        private object players;

        public void AddPlayer(Player aPlayer)
        {
            using (var context = new Context())
            {
                context.players.Add(aPlayer);
                context.SaveChanges();
            }
        }

        public void UpdatePlayer(Player oldPlayer, Player newPlayer)
        {
            using (var context = new Context())
            {
                var player = context.players.First(p => p.Id == oldPlayer.Id);
                player.DateOfBirth = newPlayer.DateOfBirth;
                player.Name = newPlayer.Name;
                player.skillLevel = newPlayer.skillLevel;
                context.SaveChanges();
            }
        }

        public void RemovePlayer(Player aPlayer)
        {
            using (var context = new Context())
            {
                var playerToRemove = context.players.First(p => p.Id == aPlayer.Id);
                context.players.Remove(playerToRemove);
                context.SaveChanges();
            }
        }

        public Player GetPlayer(int Id)
        {
            using (var context = new Context())
            {
                return context.players.First(p => p.Id == Id);
            }
        }

        public Player GetLessSkillsPlayer()
        {
            List<Player> playerList;
            using (var context = new Context())
            {
                playerList = context.players.ToList();
            }
            playerList = playerList.OrderBy(p => p.skillLevel).ToList();
            if (playerList.Count > 0)
            {
                return playerList[0];
            }
            else
            {
                return null;
            }
        }
    }
}
