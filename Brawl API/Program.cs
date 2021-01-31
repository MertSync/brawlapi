using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Brawl_API
{
    class Program
    {
        static string PlayerAPI = "https://api.brawlstars.com/v1/players/";
        static string ID;
        static string TOKEN = "yourtoken";
        static void Main(string[] args)
        {
            Console.Write("Player ID : ");
            ID = Console.ReadLine();

            Task.Run((API));
            Console.Read();
        }
        public static async Task API()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("authorization", "Bearer "+TOKEN+"");
            client.DefaultRequestHeaders.Add("accept", "application/json");

            var playerresponse = await client.GetStringAsync($"{PlayerAPI}{ID}");

            Console.Write(playerresponse);

        }
    }
}
