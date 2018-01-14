using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BLayer;


namespace loginMethod
{
   
    class Program
    {
        public BLL bLL = new BLL();
        public void Main(string[] args)
        {
            Console.Write("id; ");
            string id = Console.ReadLine();
            Console.WriteLine("pw; ");
            string pw = Console.ReadLine();
            bLL._id = id;
            bLL._pw = pw;
            
        }
    }
}

