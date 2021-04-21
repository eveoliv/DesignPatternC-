using System;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Nome = "Cliente1";
            c.Endereco = "Barueri";
            c.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXml(c);

            Console.WriteLine(xml);
        }
    }
}
