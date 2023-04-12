using HtmlAgilityPack;

namespace lolsgg
{
    internal class Lolsgg
    {
        private static readonly string[] Regions = new string[16]
        {
            "br", "eune", "euw", "jp", "kr", "lan", "las", "na", "oce", "ph", "sg", "th", "tw", "vn", "tr", "ru"
        };
        public static string search(string region, string summoner)
        {

            if (string.IsNullOrWhiteSpace(region) || string.IsNullOrWhiteSpace(summoner))
            {
                return "Está faltando Região ou Nome de Invocador";
            };

            if (!Regions.Contains(region.ToLower()))
            {
                return $"O Lolsgg não possui suporte para a região {region.ToUpper()}";
            };

            try
            {
                var url = $"https://lols.gg/pt/name/checker/{region}/{summoner}/";
                HtmlWeb web = new HtmlWeb();
                web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36 OPR/97.0.0.0"; ;
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