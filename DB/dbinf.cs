using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DB
{
    interface dbinf
    {
        /*数据库的插入的操作，一张表对应一个插入的方法*/
        bool insertCarinfo(string carno,string userid,int count,string carid);
        bool insertContactinfo(string userid,string carno,DateTime times);
        bool insertRfidman(string cardid,string userid,string carno,string status);
        bool insertUserinfo(string userid, string IDcard, string username, string usersex);
        //查询代码
        MySqlDataReader selData(string tablename, string whereFieldname, string fieldName);

    }
}
