namespace GameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("-------------------");
            Game game = new Game("Minecraft", 999, "Проявіть свою творчість");
            game.PrintInfo();
            Console.WriteLine("-------------------");

            User nikita = new User(13, "Нікіта");
            Game minecraft = new Game("Minecraft", 999, "Проявіть свою творчість");
            Game overcooked = new Game("Overcooked", 200, "Надзвичайно смачна гра!");
            nikita.AddGameToLibrary(minecraft);
            nikita.AddGameToLibrary(overcooked);
            nikita.PrintLibrary();


        }
    }
}
