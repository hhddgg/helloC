using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    interface dbinf
    {
        bool insertCarinfo(string carno,string userid,int count,string carid);
        bool insertContactinfo(string userid,string carno,DateTime times);
        bool insertRfidman(string cardid,string userid,string carno,string status);
        bool insertUserinfo(string userid, string IDcard, string username, string usersex);

        
    }
}
