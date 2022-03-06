using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConsumerSurvey
{
    class Consumer:User
    {

        DatabaseConnection Link = new DatabaseConnection();
        Survey param = new Survey();
       
      

        public int AddConsumer()
        {
            const string query = "INSERT INTO User (Username, Firstname, Lastname, Age, Gender, Password) VALUES (@Username, @Firstname, @Lastname, @Age, @Gender, @Password)";

            var args = new Dictionary<string, object>
            {
                {"@Username", Username},
                {"@Firstname", Firstname},
                {"@Lastname",Lastname},
                {"@Age", Age },
                {"@Gender", Gender },
                {"@Password",Password},
               
            };

            return Link.CommandExecuter(query, args);
        }

        public int ConsumerLogin(int ret)
        {
           
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM User WHERE Username =@Username AND Password =@Password",conn))
                {
                   
                    command.Parameters.Add(new SQLiteParameter("@Username", Username));
                    command.Parameters.Add(new SQLiteParameter("@Password", Password));

                    using (var reader = command.ExecuteReader())
                   {
                        var count = 0;
                        while (reader.Read())
                        {
                            count = count + 1;
                            ret = count;
                        }
                       
                        return count;
                    }
                   
                }

            }

        }

        public int SurveyReply(int Surv, int Qid, string res)
        {
            const string query = "INSERT INTO SurveyResponse (SurveyID, Question_ID,Response) VALUES (@SurvId, @Qid, @Res)";

            var args = new Dictionary<string, object>
            {
                {"@SurvId", Surv},
                {"@Qid", Qid},
                {"@Res",res},
               
            };

            return Link.CommandExecuter(query, args);
        }
        
    }
}