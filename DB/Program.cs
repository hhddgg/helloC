using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    class Program
    {
        
        static void Main(string[] args)
        {
            helpFunc helpfunc = new helpFunc();
            
            disposeDB disposedb = new disposeDB();
            string carno="123,1333";
            string userid = helpfunc.randomizer(); ;
            int count = 0;
            string carid = "";
            DateTime times = DateTime.Now;
            string status = "";
            string username = "";
            string usersex = "";
            string IDcard = "";
           // disposedb.insertCarinfo(carno,userid,count,carid);
           if (disposedb.insertContactinfo(userid, carno, times))
            {
                Console.WriteLine("插入成功");
            }
           // disposedb.insertRfidman(carid,userid,carno,status);
           // disposedb.insertUserinfo(userid, IDcard, username, usersex);
            Console.WriteLine(userid);
            Console.ReadKey();
           
        }

        
    }
}
