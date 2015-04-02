using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class HttpTester
    {
        public static void Request()
        {
            string result = "";
            using (WebClient wb = new WebClient())
            {
                var data = new NameValueCollection();
                //data["request"] = "ADD_KEYWORD";
                //data["keyword"] = "android";
                //data["UserID"] = Guid.NewGuid().ToString();
                //data["data"] = "something";
                var response = wb.UploadValues("http://localhost:37828/api/socialmonitor?data=data","POST", data);
                
                result = Encoding.ASCII.GetString(response);
            }
            Console.WriteLine(result);
            Console.ReadKey();


            //string data=
            //HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(
            //    string.Format("http://localhost:37828/api/socialmonitor?request=ADD_KEYWORD&UserId={0}&keyword={1}",
            //    Guid.NewGuid().ToString(), "android")
            //);
            //httpWebRequest.Method = "POST";
            //httpWebRequest.ContentLength=
            //using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            //{
            //    Console.WriteLine(httpWebResponse.StatusCode.ToString());

            //}
            //Console.ReadKey();




            //string id = Guid.Empty.ToString();
            //string domain = "https://conductor4100crm.azurewebsites.net" + "/api/CRM2013";
            //string password = "crmdelete";
            //string query = string.Format("?action=DELETE&data={0}&password={1}", id, password);

            //string url = domain + query;
            //string returnMessage = null;
            //using (WebClient client = new WebClient())
            //{
            //    byte[] myDataBuffer = client.DownloadData(new Uri(url));
            //    returnMessage = Encoding.ASCII.GetString(myDataBuffer);
            //}
            //returnMessage = returnMessage.Trim().Replace("\"", "");



            //Console.WriteLine(returnMessage);
            //Console.ReadKey();

            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            //request.Method = "POST";

            //request.BeginGetResponse((x) =>
            //{
            //    using (HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(x))
            //    {
            //        using (Stream stream = response.GetResponseStream())
            //        {
                        
            //        }
            //    }
            //}, null);
            //Console.ReadKey();
        }
    }
}
