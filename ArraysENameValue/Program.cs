using System;
using System.Collections.Specialized;

namespace ArraysENameValue
{
    class Program
    {
        static void Main(string[] args)
        {

            //Recebendo um array de inteiros com 5 posições e adicionando numero 2
            int[] numeros = new int[5];
            numeros[0] = (2);

            //Exibindo numeros
            foreach (var item in numeros)
            {
                if (item != 0)
                    Console.WriteLine($"Numero encontrado: {item}");
            }
            Console.WriteLine();

            //Recebendo um NameValueCollection com chave string null e string 1,15,16            
            var dias = new NameValueCollection
            {
                { null, "1|15" }
            };

            //Passando dias para um array de strings
            string[] result = { };
            for (int i = 0; i < dias.Count; i++)
            {

                result = dias[i].Split("|");
            }

            //Exibindo dias
            foreach (var dia in result)
            {
                Console.WriteLine($"Dias encontrados: {dia}");
            }
            Console.WriteLine();

            //Verificando quais posições no array numeros estão preenchidos
            int check = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != 0)
                    check += 1;
            }

            //Atribuindo os dias recebidos no array de numeros
            for (int i = 0; i < result.Length; i++)
            {
                numeros[check + i] = Convert.ToInt32(result[i]);
            }

            //transformando o array de numeros em datas           
            foreach (var dia in numeros)
            {
                if (dia != 0)
                {
                    var data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia);
                    Console.WriteLine($"Data Composta: { data }");
                }
            }
        }
    }
}
