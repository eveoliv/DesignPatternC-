using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace JsonExpando
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = "{\"De\": \"Paulo Silveira\",\"Para\": \"Guilherme Silveira\"}";

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);
            //atribuindo texto
            mensagem.Texto = "Uma mensagem qualquer.";

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        public static void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}
