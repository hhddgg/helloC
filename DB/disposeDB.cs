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

        /*构造函数，创建MySQL数据库的连接*/

        public disposeDB()
        {
            try {
                string connsql = "server=localhost;port=3306;user=" + this.username + ";" +
                     "password=" + this.password + ";database=carmanager";
                this.myconn = new MySqlConnection(connsql);
                Console.WriteLine("连接成功");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*插入数据到carinfo表的方法*/
        public bool insertCarinfo(string carno, string userid, int count, string carid)
        {
            string tablename = "carinfo";
            string sql = "INSERT INTO  " + tablename + " (carno,userid,count,carid) " +
                "VALUE ('" + carno + "','" + userid + "','" + count + "','" + carid + "')";                                         //插入语句
            this.openConn();
            return this.insertData(sql);
        }

        /*插入数据到contactinfo表*/
        public bool insertContactinfo(string userid, string carno, DateTime times)
        {
            string tablename = "contactinfo";
            string sql = "INSERT INTO " + tablename + " (userid,carno,times) VALUE ('" + userid + "','" + carno + "','"+times+"')";
            Console.WriteLine(sql);
            this.openConn();
            return this.insertData(sql);
        }

        /*插入数据到RFIDman表*/
        public bool insertRfidman(string cardid, string userid, string carno, string status)
        {
            string tablename = "rfidman";
            string sql = "INSERT INTO  " + tablename + " (cardid,userid,carno,status) " +
                           "VALUE ('" + cardid + "','" + userid + "','" + carno + "','" + status + "')";
            this.openConn();
            return this.insertData(sql);
        }

        /*插入数据到userinfo数据表*/
        public bool insertUserinfo(string userid, string IDcard, string username, string usersex)
        {
            string tablename = "userinfo";
            string sql = "INSERT INTO  " + tablename + " (userid,IDcard,username,usersex) " +
                           "VALUE ('" + userid + "','" + IDcard + "','" + username + "','" + usersex + "')";
            this.openConn();
            return this.insertData(sql);
        }

        /*关闭数据的连接*/
        public void closeConn()
        {
            this.myconn.Close();
        }

        /*打开数据库的连接*/
        public void openConn()
        {
            this.myconn.Open();
        }

        /*公共的插入语句*/
        private bool insertData(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.myconn);                      //返回一个command的对象
                cmd.ExecuteNonQuery();                                                                       //执行对数据库操作的语句
                return true;
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);                                                              //打印错误名称
                return false;
            }
            finally
            {
                this.closeConn();
            }
        }
        /*表中数据的选择语句*/
        public MySqlDataReader selData(string tablename,string whereFieldname,string fieldValue)
        {
            string sql = "SELECT * FROM " + tablename + " WHERE "+whereFieldname+" = '"+fieldValue+"'";
            return selDataFunc(sql);
        }
        public MySqlDataReader unioSelData(string table1,string table2,string field,string table1FieldValue)
        {
            string sql1 = "WHERE" + " " + "" + table1 + "" + "." + "" + field + "" + " " + "=" + " " + "" + table2 + "" + "." + "" + field + "" + " " + "AND" + " " + "" + table1 + "" + "." + "" + field + "" + " " + "=" + " " + "'" + table1FieldValue + "'";
            string sql = "SELECT * FROM " + table1 + "," + table2 + "" + " " + sql1;
            return selDataFunc(sql);
        }
        public MySqlDataReader selDataFunc(string sql)
        {
            try
            {
                this.openConn();
                MySqlCommand cmd = new MySqlCommand(sql, this.myconn);
                return cmd.ExecuteReader();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
                return null;
            }
        }
    }
}
