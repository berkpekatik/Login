using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DLayer
{
    class DAL
    {
        public OleDbConnection onConnect()
        {
            OleDbConnection connect = new OleDbConnection(@"ata Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connect.Open();
            return connect;
        }
        public OleDbCommand crateQuery(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, onConnect());
            return cmd;
        }
    }
}
