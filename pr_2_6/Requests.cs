using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Pr_2_6
{
    public class Requests
    {
        HttpWebRequest request;
        string geolocation;
        public string Response { get; set; }
        public Requests(string Geolocation)
        {
            geolocation = Geolocation;
        }
        public void Launch()
        {
            request = (HttpWebRequest)WebRequest.Create(geolocation);
            request.Method = "Get";
            try
            {
                HttpWebResponse conclusion = (HttpWebResponse)request.GetResponse();
                var Conclusion = conclusion.GetResponseStream();
                if (Conclusion != null)
                {
                    Response = new StreamReader(Conclusion).ReadToEnd();
                }
            }
            catch(Exception){ }
        }
    }
}