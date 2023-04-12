using HtmlAgilityPack;

namespace lolsgg
{
    internal class Lolsgg
    {
        private static readonly string[] Regions = new string[16]
        {
            "br", "eune", "euw", "jp", "kr", "lan", "las", "na", "oce", "ph", "sg", "th", "tw", "vn", "tr", "ru"
        };
        public static string Search(string? region, string? summoner)
        {

            if (!Regions.Contains(region?.ToLower()))
            {
                return $"O Lolsgg não possui suporte para a região {region?.ToUpper()}";
            };

            
            if (summoner?.Length <= 2 || summoner?.Length >= 17)
            {
                return "O nome de invocador tem que ser maior que 3 e menor 16 digitos.";
            };

            try
            {
                var url = $"https://lols.gg/pt/name/checker/{region}/{summoner}/";
                HtmlWeb web = new();
                var htmlDoc = web.Load(url);

                var node = htmlDoc.DocumentNode.SelectSingleNode("//h4[@class='text-center']");
                return node.InnerHtml;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}