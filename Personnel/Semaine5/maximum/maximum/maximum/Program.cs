namespace maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 players
            Player p1 = new Player("Joe", 32);
            Player p2 = new Player("Jack", 30);
            Player p3 = new Player("William", 37);
            Player p4 = new Player("Averell", 25);

            // Comparison of all players without mutating any variables
            Player elder = GetElder(GetElder(p1, p2), GetElder(p3, p4));

            Console.WriteLine($"Le plus agé est {elder.Name} qui a {elder.Age} ans");

            Console.ReadKey();
        }

        
        static Player GetElder(Player player1, Player player2)
        {
            return player1.Age > player2.Age ? player1 : player2;
        }

        public class Player
        {
            private readonly string _name;
            private readonly int _age;

            public Player(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string Name => _name;

            public int Age => _age;
        }
    }
}
