using lolsgg;

namespace League
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Lols.GG Terminal");
                Console.Write("Região: ");
                string? region = Console.ReadLine();
                Console.Write("Nome de Invocador: ");
                string? name = Console.ReadLine();

                string result = Lolsgg.Search(region, name);
                Console.WriteLine(result + " " + "\n");

                Console.Write("Deseja pesquisar um novo nome de invocador? (s/n) ");
                string? answer = Console.ReadLine();

                if (answer?.ToLower() == "n")
                    Environment.Exit(0);

                Console.Clear();
            }
        }
    }
}