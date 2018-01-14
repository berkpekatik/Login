using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace loginMethod
{
    class DAL
    {
        public DAL()
        {
            string file = @"c:\users\user\source\repos\loginMethod\loginMethod\users.json";
            StreamReader readerStream = new StreamReader(file, System.Text.Encoding.GetEncoding("utf-8"));
            string json = readerStream.ReadToEnd();
            readerStream.Close();
            var jo = JObject.Parse(json);
            string id = (string)jo["id"];
            string pw = (string)jo["pw"];

        }
        
       
    }
}
