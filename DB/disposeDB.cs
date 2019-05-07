using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB
{
    public class disposeDB : dbinf
    {
        private string username = "root";
        private string password = "!!xc1228";
        private MySqlConnection myconn;
        public disposeDB()
        {
         
        }

        public bool insertCarinfo(string carno, string userid, int count, string carid)
        {
            string tablename = "carinfo";
            throw new NotImplementedException();
        }

        public bool insertContactinfo(string userid, string carno, DateTime times)
        {
            string tablename = "contctinfo";
            throw new NotImplementedException();
        }

        public bool insertRfidman(string cardid, string userid, string carno, string status)
        {
            string tablename = "rfidman";
            throw new NotImplementedException();
        }

        public bool insertUserinfo(string userid, string IDcard, string username, string usersex)
        {
            string tablename = "userinfo";
            throw new NotImplementedException();
        }
    }
}
