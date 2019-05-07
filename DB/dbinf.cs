using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    interface dbinf
    {
        bool insertCarinfo(string tablename,string carno,string userid,int count,string carid);
        bool insertContactinfo(string tablename,string userid,string carno,DateTime times);
        bool insertrfidman(string tablename,string cardid,string userid,string carno,string status);


        
    }
}
