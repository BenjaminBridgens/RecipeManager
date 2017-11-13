using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RecipeManager.DataAccess
{
    public class QueryExecuter
    {
        #region Fields
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecipeManagerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        #endregion

        #region Constructors
        public QueryExecuter()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
            }
            catch( Exception )
            {
                throw;
            }
        }
        #endregion
        
        #region Methods
        public DataSet Execute(string sql)
        {
            try
            {
                DataSet resultSet = new DataSet();
                using( SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sql, new SqlConnection(connectionString))) )
                {
                    adapter.Fill(resultSet);
                }
                return resultSet;
            }
            catch( Exception )
            {
                throw;
            }
        }
        #endregion
    }
}
