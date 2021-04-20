using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection
            {
                ConnectionString = "Server=localhost,1401;Database=CadastroDB;User Id=sa;Password=Root@root!;"
            };
            conexao.Open();

            return conexao;
        }
    }
}
