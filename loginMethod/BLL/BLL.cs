using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLayer;

namespace BLayer
{
    
    public class BLL
    {
        public string _id { get; set; }
        public string _pw { get; set; }
        public DAL dAL = new DAL();
        
    }
}
