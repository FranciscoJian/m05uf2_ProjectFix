using System;
using System.Text;

namespace Replace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine("What character to replace?");
            char search = Console.ReadLine()[0];
            Console.WriteLine("What character to replace to?");
            char replace = Console.ReadLine()[0];
            string result = Replace(response, search, replace);
            Console.WriteLine(result);
        }
        public static string Replace(string text, char a, char b)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == a)
                {
                    sb.Append(b);
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }
    }
}
