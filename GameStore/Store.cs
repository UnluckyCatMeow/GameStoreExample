using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Store
    {
        List<Game> Games = new List<Game>();
        List<User> Users = new List<User>();
        public void AddGame(Game game)
        {
            Games.Add(game);
        }
        //public void AddGames(params Game[] games)
        //{
        //    Games.AddRange(games);  
        //} - for add <1 game
        public void DeleteGame(Game game)
        {
            Games.Remove(game);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void DeleteUser(User user)
        {
            Users.Remove(user);
        }

    }
}
 