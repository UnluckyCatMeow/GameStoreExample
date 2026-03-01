namespace GameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("-------------");
            Game game = new Game("Minecraft", 999, "Ахуєть, работає");
            game.PrintInfo();
            Console.WriteLine("-------------");

            User dasha = new User(20, "Даша");
            Game portal = new Game("Portal", 125, "Гра головоломка");
            Game stray = new Game("Stray", 250, "Гра про кота");

            dasha.AddGameToWishlist(portal);
            dasha.AddGameToWishlist(stray);
            dasha.PrintWishlist();
            dasha.DeleteGameFromWishlist(portal);
            dasha.PrintWishlist();

        }
    }
}
