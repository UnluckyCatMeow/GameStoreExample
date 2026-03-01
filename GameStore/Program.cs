namespace GameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            User dasha = new User(20, "Даша");
            User nikita = new User(13, "Нікіта");
          
            Game portal = new Game("Portal", 125, "Гра головоломка");
            Game stray = new Game("Stray", 250, "Гра про кота");
            Game minecraft = new Game("Minecraft", 999, "Проявіть свою творчість");
            Game overcooked = new Game("Overcooked", 200, "Надзвичайно смачна гра!");

            dasha.AddGameToWishlist(portal);
            dasha.AddGameToWishlist(stray);
            dasha.PrintWishlist();
            dasha.DeleteGameFromWishlist(portal);
            dasha.PrintWishlist();
          
            nikita.AddGameToLibrary(minecraft);
            nikita.AddGameToLibrary(overcooked);
            nikita.PrintLibrary();
        }
    }
}
