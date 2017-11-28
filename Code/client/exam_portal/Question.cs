/**************************************************************
 * 
 * Question Class containing method to form json to send to server and extract json returned from server
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika          Addition                Added  createQuestionJson(), getQuestionJson(), deleteQuestionJson(), updateQuestionJson()
 *   Kanika          Addition                Added updateQuestionCount(), getAllQuestionsJson(), updateExamStatusJson()

 **************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace exam_portal
{
    class Question
    {
        public int exam_id;
        public int question_id;
        public string question;
        public string option_a;
        public string option_b;
        public string option_c;
        public string option_d;
        public string answer;
        public string difficulty_level;
        public int count=1;
        public string msg;

        public string createQuestionJson(Question question)
        {
            question.exam_id = PassingValues.ExamId;
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            updateQuestionCount(question);
            string response = client.send_data(json, "addQuestion");
            Question quesResponseObj = JsonConvert.DeserializeObject<Question>(response);
            return quesResponseObj.msg;    
        }

        /*
        public Question getQuestionJson(Question question)
        {
            question.question_id = PassingValues.QuestionId;
            question.exam_id = PassingValues.ExamId;
            //updateQuestionCount(question, "increment");
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "getQuestion");
            Question quesResponseObj = JsonConvert.DeserializeObject<Question>(response);
            PassingValues.QuestionId = quesResponseObj.question_id;
            return quesResponseObj;
        }*/

        public string deleteQuestionJson(Question question)
        {
            question.exam_id = PassingValues.ExamId;
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "deleteQuestion");
            Question quesResponseObj = JsonConvert.DeserializeObject<Question>(response);
            return quesResponseObj.msg;
        }

        public string updateQuestionJson(Question question)
        {
            question.exam_id = PassingValues.ExamId;
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "updateQuestion");
            Question quesResponseObj = JsonConvert.DeserializeObject<Question>(response);
            return quesResponseObj.msg;
        }

        public void updateQuestionCount(Question question)
        {
            if (question.difficulty_level == "Average")
            {
                PassingValues.NoOfAverageQuestions += 1;
            }
            else if(question.difficulty_level == "Difficult")
            {
                PassingValues.NoOfDifficultQuestions += 1;
            }
        }

        public List<Question> getAllQuestionsJson()
        {
            Question question = new Question();
            question.exam_id = PassingValues.ExamId;
            
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "getAllQuestions");
            List<Question> questionsList= JsonConvert.DeserializeObject<List<Question>>(response);
            return questionsList;
        }
    }
}
