using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            var rec = new List<numJaigasht>();
            for (int i = 0; i < 40000; i++)
            {

                string v = GetVoucherNumber(14, random).ToString();
                string b = Regex.Replace(v, ".{1}", "$0-");
                string sub = "1-3-5-7-9-11-13-15-17-19-21-23-25-27";
                rec.Add(new numJaigasht { getnum = b, subcode = sub });
                
            }
            var dbmodel = rec.Distinct().ToList();
            int counter = 0;
            foreach(var item in dbmodel)
            {
                counter = counter + 1;
                Console.WriteLine("Number: " + counter);
                Console.WriteLine(item.getnum);
                Console.WriteLine(item.subcode);
                Console.WriteLine("____________________________________");
            }
            Console.ReadLine();
        }
        class numJaigasht
        {
            public string id { get; set; }
            public string getnum { get; set; }
            public string subcode { get; set; }
        }
        public static string GetVoucherNumber(int length, Random random)
        {
            var chars = "AN";

            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            var resultitem = result;

            return result;


        }
    }
}
