namespace GameStore
{
    public class User
    {
            //список ігор які вже є, бібліотека. Які поля і методи туди треба
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Game> Library { get; private set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Library = new List<Game>();  //ініціалізація змінної в конструкторі, а не в класі 
        }

        public void AddGameToLibrary(Game game)
        {
            Library.Add(game);
        }

        public void DeleteGameFromLibrary(Game game)
        {
            Library.Remove(game);
        }
        public void PrintLibrary()
        {
            Console.WriteLine("Library:");
            foreach (var game in Library)
            {
                Console.WriteLine($" - {game.Name}"); //ми отримуємо доступ до назви гри
            }
        }//while коли виконується умова. Do while робить один раз і тоді перевіряє умову і далі робить,
        //наприклад в ду оголошуш змінну, а вайл її виконує
        //для перебору колекцій треба:
        //for - якщо треба змінювати дані (наприклад передати цикли і щось змінити), або коли потрібна індексація
        //foreach - просто прочитати колекцію, отримати дані, нічого не змінює
    }
}
