/**************************************************************
 * 
 * Question Class containing method to form json to send to server and extract json returned from server
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

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
        public int count=0;
        public string msg;

        public string addQuestionJson(Question question)
        {
            question.exam_id = PassingValues.ExamId;
            if (question.difficulty_level == "Average")
            {
                PassingValues.NoOfAverageQuestions += 1;
            } else
            {
                PassingValues.NoOfDifficultQuestions += 1;
            }
            string json = JsonConvert.SerializeObject(question);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "addQ");
            Question quesResponseObj = JsonConvert.DeserializeObject<Question>(response);
            return quesResponseObj.msg;    
        }
    }
}
