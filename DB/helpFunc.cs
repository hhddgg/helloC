using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
 
    class helpFunc
    {
        private static char[] ch = {                                                                             //随机字符
             '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        //随机字符生成器
        public string randomizer()
        {
            try
            {
                string userid = "";
                Random ran = new Random();
                int num1 = ran.Next(15);
                int num2 = 15 - num1;
                for (int i=0;i< num1;i++)
                {
                    userid += ch[ran.Next(61)];
                }
                for(int i = 0; i < num2; i++)
                {
                    userid += ch[ran.Next(61)];
                }
                int num3 = ran.Next(10);
                int num4 = 10 - num3;
                for(int i = 0; i < num3; i++)
                {
                    userid += ch[ran.Next(61)];
                }
                for(int i = 0; i < num4; i++)
                {
                    userid += ch[ran.Next(61)];
                }
                return userid;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
