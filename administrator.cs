using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace ConsumerSurvey
{
    class administrator : User
    {
        DatabaseConnection connect = new DatabaseConnection();
        Survey details = new Survey();



        public int AddSurvey(string sName, string date)
        {
            const string query = "INSERT INTO Survey (Survey_Name, Date_Of_Creation) VALUES (@SurveyName, @DateAdded)";

            var args = new Dictionary<string, object>
            {
                {"@SurveyName", sName},
                {"@DateAdded",date},
            };
            return connect.CommandExecuter(query, args);
        }

        public string getSurveyID(string surveyname)
        {
            string returnId;

            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT SurveyID FROM Survey WHERE Survey_Name =@surveyname", conn))
                {

                    command.Parameters.Add(new SQLiteParameter("@surveyname", surveyname));

                    returnId = command.ExecuteScalar().ToString();
                }

                return returnId;
            }

        }

        public int addSurveyQuestions(int surveyid, string Qname, string Qtype)
        {
            const string query = "INSERT INTO Question (SurveyID, Question_Name, Question_Type) VALUES (@SurveyId, @QuestionName, @QuestionType)";

            var args = new Dictionary<string, object>
            {
                {"@SurveyId", surveyid},
                {"@QuestionName", Qname},
                {"@QuestionType", Qtype},
                
            };
            return connect.CommandExecuter(query, args);
        }

        public DataTable GetRespondentsData()
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT  R.response_id, S.Survey_Name, S.Date_Of_Creation, Q.Question_Name ,R.Response FROM Survey S , Question Q , SurveyResponse R WHERE S.SurveyID = R.SurveyID AND Q.Question_ID = R.Question_ID;", conn))
                {
                    command.ExecuteNonQuery();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
                
            }

        }

    }
}
