using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLayer
{
    class Users
    {
        public string _id { get; set; }
        public string _pw { get; set; }
        public Users(string _id,string _pw)
        {
            this._id = _id;
            this._pw = _pw;
        }
    }
}
