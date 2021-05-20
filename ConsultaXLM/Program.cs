using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ConsultaXLM
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = GetXml();

            //XmlDocument documento = new XmlDocument();
            XDocument documento = XDocument.Parse(xml);

            //Sintaxe de consulta
            IEnumerable<XElement> consulta1 = 
                from f in documento.Descendants("Filme") select f;
            Imprime(consulta1, 1);

            IEnumerable<XElement> consulta2 =
                from f in documento.Descendants("Filme")
                //where f.Element("Diretor").FirstNode.ToString() == "James Cameron"
                where (string)f.Element("Diretor") == "James Cameron"
                select f;
            Imprime(consulta2, 2);

            //Sintaxe de método
            IEnumerable<XElement> consulta3 =
                documento.Descendants("Filme").Where(e => (string)e.Element("Diretor") == "James Cameron");                
            Imprime(consulta3, 3);

            var path = @"C:\Users\evert\source\workspace\DesignPatterns\ConsultaXLM\Musicas.xml";
            XElement root = XElement.Load(path);
            var query = from g in root.Element("Generos").Elements("Genero")
                        join m in root.Element("Musicas").Elements("Musica")
                            on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                        select new
                        {
                            MusicaId = m.Element("MusicaId").Value,
                            Musica = m.Element("Nome").Value,
                            Genero = g.Element("Nome").Value
                        };
            
            Console.WriteLine($"Consulta nº: 4");
            foreach (var item in query)
            {
                Console.WriteLine($"Id: {item.MusicaId, -5} Musica: {item.Musica, -20} Genero: {item.Genero}");
            }

            Console.WriteLine($"\nConsulta nº: 5");
            IEnumerable<XElement> consulta5 =
                  from f in documento.Descendants("Filme") select f;

            XElement consulta = consulta5.Where(c => (string)c.Element("Titulo") == "Avatar").SingleOrDefault();
            if (!consulta.IsEmpty)
            {
                consulta.Add(new XElement("Genero", "Ficção"));
            }

            Console.WriteLine($"Diretor: {(string)consulta.Element("Diretor"),-20} Filme: {(string)consulta.Element("Titulo"),-20} Genero: {(string)consulta.Element("Genero")}");

        }

        private static void Imprime(IEnumerable<XElement> consulta, int numConsulta )
        {
            Console.WriteLine($"Consulta nº: {numConsulta}");
            foreach (var item in consulta)
            {
               // Console.WriteLine($"Diretor: {item.Element("Diretor").FirstNode, -20} Filme: {item.Element("Titulo").FirstNode}");                
                Console.WriteLine($"Diretor: {(string)item.Element("Diretor"), -20} Filme: {(string)item.Element("Titulo")}");                
            }
            Console.WriteLine();
        }

        public static string GetXml()
        {
            return @"
                <Filmes>    
                    <Filme>
                        <Diretor>Quentin Tarantino</Diretor>
                        <Titulo>Pulp Ficton</Titulo>
                        <Minutos>154</Minutos>    
                    </Filme>
                    <Filme>
                        <Diretor>James Cameron</Diretor>
                        <Titulo>Avatar</Titulo>
                        <Minutos>162</Minutos>    
                    </Filme>
                </Filmes>    
            ";
        }
    }
}
