/**************************************************************
 * 
 * Exam Class containing method to form json to send to server and extract json returned from server
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika          Addition                Added class Exam, PassingValues, and method examJson()
 *   Kanika          Addition                Added methods getExamJson(),updateExamStatusJson(),getAllExamsJson(), getReportJson()
 **************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace exam_portal
{
    public class Exam
    {
        public int exam_id;
        public string exam_title;
        public int no_of_question;
        public string status = "Inactive";
        public string created_by;
        public bool timer_enabled;
        public int timer_duration;
        public string msg;
        public int gradeA;
        public int gradeB;
        public int gradeC;
		public string grade;

        public void examJson(Exam exam, string operation)
        {
            String response="";
            exam.created_by = "admin";
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            if(operation == "AddExam")
            {
                response = client.send_data(json, "addExam");
            } else if(operation == "UpdateExam")
            {
                response = client.send_data(json, "updateExam");
            }
            Exam examResObj = JsonConvert.DeserializeObject<Exam>(response);
            PassingValues.ExamId = examResObj.exam_id;
            Console.WriteLine("Exam Id " + examResObj.exam_id);
        }

        public Exam getExamJson(Exam exam)
        {
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "getExam");
            Exam examResObj = JsonConvert.DeserializeObject<Exam>(response);
            return examResObj;
        }

        public string updateExamStatusJson(Exam exam)
        {
            exam.exam_id = PassingValues.ExamId;
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "updateExamStatus");
            Exam respObj = JsonConvert.DeserializeObject<Exam>(response);
            return respObj.msg;
        }

        public List<Exam> getAllExamsJson()
        {
            Exam exam = new Exam();
            exam.created_by = "admin";
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "getAllExams");
            List<Exam> examsList = JsonConvert.DeserializeObject<List<Exam>>(response);
            return examsList;
        }

        public List<Exam> getReportJson()
        {
            Exam exam = new Exam();
            exam.created_by = "admin";
            string json = JsonConvert.SerializeObject(exam);
            Console.WriteLine("json " + json);
            Client client = new Client();
            String response = client.send_data(json, "getReport");
            List<Exam> report = JsonConvert.DeserializeObject<List<Exam>>(response);
            return report;
        }
    }

    public static class PassingValues
    {
        public static int NoOfQuestion { get; set; }
        public static int ExamId { get; set; }
        public static int NoOfAverageQuestions { get; set; }
        public static int NoOfDifficultQuestions { get; set; }
        public static string Action { get; set; }
		public static string grade { get; set; }
        public static string name { get; set; }
        public static int userID { get; set; }
        public static List<Question> quesList { get; set; }
        //public static int QuestionId { get; set; }
    }
}
