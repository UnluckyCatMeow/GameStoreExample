namespace GameStore
{
    public class Game
    {
        public string Name {get; private set;}
        public int Price { get; private set; }
        public string Description { get; private set; }

        public Game(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Гра: {Name}\n" +
                $"Ціна: {Price}\n" +
                $"Опис: {Description}");
        }
    }
}
