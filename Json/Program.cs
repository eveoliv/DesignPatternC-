using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class Program
    {
        static void Main(string[] args)
        {

            string json = "{\"De\": \"Paulo Silveira\",\"Para\": \"Guilherme Silveira\",\"Texto\": \"Um texto qualquer...\"}";

            var mensagem = JsonConvert.DeserializeObject<Mensagem>(json);

            EnviarMensagem(mensagem);

        }

        public static void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }

        public class Mensagem
        {
            public string De { get; set; }
            public string Para { get; set; }
            public string Texto { get; set; }
        }
    }
}
