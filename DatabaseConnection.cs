using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;


namespace ConsumerSurvey
{
    class DatabaseConnection
    {
       
        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public int CommandExecuter(string query, Dictionary<string, object> args)
        {
            int numsrows;

            // setting up database connection using Connection string
            using (var connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        // check arguments given i a query
                        foreach (var pair in args)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    // execute the Query and return the numbner of rows
                    numsrows = command.ExecuteNonQuery();
    
                    }
                return numsrows;
            }

          
        }

        public static List<Survey> GetSurvey()
        {
            using (IDbConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var Output = conn.Query<Survey>("SELECT Survey_Name FROM Survey", new DynamicParameters());
                return Output.ToList();

            }
        }

       
    }
}


