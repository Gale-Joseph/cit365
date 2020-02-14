using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MegaDesk_Gale
{
    public static class Json
    {
       
        /*methods*/
        public static void Store(DeskQuote o)
        {
            var filepath = @"..\..\quotes.json";
            string quoteInfo = JsonConvert.SerializeObject(o);
            quoteInfo += System.Environment.NewLine;
            File.AppendAllText(filepath, quoteInfo);
        }

        public static List<DeskQuote> GetQuotes()
        {
            var filepath = @"..\..\quotes.json";
            StreamReader lineReader = new StreamReader(filepath);
            List<DeskQuote> quoteList = new List<DeskQuote>();
            String line;
            while ((line = lineReader.ReadLine()) != null)
            {
                DeskQuote quotes = JsonConvert.DeserializeObject<DeskQuote>(line);
                quoteList.Add(quotes);
            }
            return quoteList;
        }

    }

   
}
