namespace GameStore
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Game> Wishlist { get; private set; }
        
        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Wishlist = new List<Game>();
        }

        public void AddGameToWishlist(Game game)
        {
            Wishlist.Add(game);

        }
        public void DeleteGameFromWishlist(Game game)
        {
            Wishlist.Remove(game);
        }
        public void PrintWishlist()
        {
            Console.WriteLine("Обранно: ");
            foreach(var game in Wishlist)
            {
                Console.WriteLine($"- {game.Name}, {game.Description}");
            }
           
        }
    }
}
