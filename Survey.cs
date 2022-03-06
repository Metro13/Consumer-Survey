using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;


namespace ConsumerSurvey
{
    class Survey
    {
        DatabaseConnection Database = new DatabaseConnection();
      
        private string surveyName;
        private string date;
        private string question;
        private string questionType;
        private string response;

       
        public string SurveyName
        {
            set
            {
                surveyName = value;
            }
            get
            {
                return surveyName;
            }
        }

        public string Date
        {
            set
            {
                date = value;       
            }
            get
            {
                return date;
            }
        }
        public string Question
        {
            set
            {
                question = value;
            }
            get
            {
                return question;
            }
        }
        public string QuestionType
        {
            set
            {
                questionType = value;
            }
            get
            {
                return questionType;
            }
        }
        public string Response
        {
            set
            {
                response = value;
            }
            get
            {
                return response;
            }
        }

        public string GetQuestionId(int survey)
        {
            string returnId;
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT Question_ID FROM Question WHERE SurveyID =@id", conn))
                {
                    command.Parameters.AddWithValue("@id", survey);

                    returnId = command.ExecuteScalar().ToString();
                }
                return returnId;
            }
        }

       public string Num_rows(int id)
        {
            string returnCount;

            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT COUNT(*) AS QuestionCount FROM Question WHERE SurveyID =@SurvId", conn))
                {
                    command.Parameters.AddWithValue("@SurvId", id);
                  
                    returnCount = command.ExecuteScalar().ToString();

                    command.ExecuteNonQuery();
                }
                return returnCount;
            }
       }

        public string GetQuestions(int SurveyId,int questionId)
        {
          
            try
            {
                string returnQuestion;

                using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    conn.Open();
                    using (var command = new SQLiteCommand("SELECT Question_Name FROM Question WHERE SurveyID =@id AND Question_ID =@Qid ", conn))
                    {
                        command.Parameters.AddWithValue("@id", SurveyId);
                        command.Parameters.AddWithValue("@Qid", questionId);

                        returnQuestion = command.ExecuteScalar().ToString();

                        command.ExecuteNonQuery();
                    }
                    return returnQuestion;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Thanks for Completing the Survey \n" + "There are no More Questions for this Survey...");
            }

            return "";
            
        }

        public static List<string> getSurvey()
        {
           
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT Survey_Name FROM Survey", conn))
                {

                    List<string> surveyList = new List<string>();
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var myNames = reader.GetString(0);
                        surveyList.Add(myNames);

                    }

                    return surveyList;
                }

            } 
        }
    }
}
