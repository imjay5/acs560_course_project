/**************************************************************
 * 
 * Exam Class containing method to form json to send to server and extract json returned from server
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
    class Exam
    {
        public int exam_id;
        public string exam_title;
        public int no_of_question;
        public string status;
        public string created_by;
        public bool timer_enabled;
        public int timer_duration;
        public string msg;
        
        public void createExamJson(Exam exam)
        {
            exam.status = "Active";
            exam.created_by = "admin";
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json,"create");
            Exam examResObj = JsonConvert.DeserializeObject<Exam>(response);
            PassingValues.ExamId = examResObj.exam_id;
            Console.WriteLine("Exam Id " + examResObj.exam_id);
            Console.WriteLine("Msg " + examResObj.msg);
            //extract id
            //examResObj.exam_id;

        }
    }

    public static class PassingValues
    {
        public static int NoOfQuestion { get; set; }
        public static int ExamId { get; set; }
        public static int NoOfAverageQuestions { get; set; }
        public static int NoOfDifficultQuestions { get; set; }
    }
}
