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
        }
    }
}
