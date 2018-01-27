using System;
using System.Collections.Generic;
using System.Linq;
using MyLibrary;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<String> strList = new List<string>();
            strList.Add("abcd");
            strList.Add("ajdgkashdjklas");
            strList.Add("a");
            strList.Add("abc");
            strList.Add("Merhaba Hüsryin Nasılsın?");
            strList.Add("aetyu");
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(100));
            }

           MyLibrary.MyLinq my = new MyLibrary.MyLinq();
           IEnumerable<String> k = my.ReverseList(strList);

            var harf = strList.OrderBy(te => te.Length);

            foreach (var item in k)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
