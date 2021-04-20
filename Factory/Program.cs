using System;
using System.Data;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();

            comando.CommandText = "Select * from Produtos";
            var result = comando.ExecuteReader();

            while (result.Read())
            {
                Console.WriteLine(String.Format("Id {0}, Estoque {1}, Nome {2}, Preço {3}", 
                        result[0], result[1], result[2], result[3]));
            }
            Console.ReadKey();
            conexao.Close();
            
        }
    }
}
