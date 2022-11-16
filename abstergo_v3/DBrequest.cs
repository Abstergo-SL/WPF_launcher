using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace abstergo_v3
{
    class DBrequest
    {
        //http://172.16.51.3:5000/select?table=usuarios&column=*


        public string DB()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://172.16.51.3:5000/select?table=usuarios&column=*");
            request.Method = "GET";
            string test = string.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                test = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }


            return test;
        }
    }
}
