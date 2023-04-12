using lolsgg;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lols.GG Terminal");
                Console.Write("Região: ");
                string region = Console.ReadLine();
                Console.Write("Nome de Invocador: ");
                string name = Console.ReadLine();

                string result = Lolsgg.search(region, name);
                Console.WriteLine(result + " " + "\n");

                Console.Write("Deseja pesquisar um novo nome de invocador? (s/n) ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                    Environment.Exit(0);

                Console.Clear();
            }
        }
    }
}