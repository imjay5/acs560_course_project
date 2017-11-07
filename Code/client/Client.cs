using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace exam_portal{
    class Client
    {
        public void send_data(string json)
        {
            var httpWebRequest = getConnection();
            //To be removed once this method is called from outside
            json = "{\"user\":\"test\",\"password\":\"p123\"}";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
                Console.WriteLine("Data Transmitted: " + json);
            }
            string response = get_response(httpWebRequest);
        }

        public HttpWebRequest getConnection()
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting.....");
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://exam-portal-kanika14.c9users.io:8081");
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";
            Console.WriteLine("Connected to Server.");
            return httpWebRequest;   
        }

        public string get_response(HttpWebRequest httpWebRequest)
        {
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //var result = streamReader.ReadToEnd();
                response = streamReader.ReadToEnd();
                Console.WriteLine("Response from Server: " + response);
            }
            return response;
        }
    }
}
