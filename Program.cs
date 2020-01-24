using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace polidrom
{
    public static class Extension
    {
        public static bool BoolPolindrom(this string text)
        {
            string str = Regex.Replace(text, "[ .,!?]", "");
            char[] tempstr = str.ToCharArray();
            Array.Reverse(tempstr);
            string reverse = new string(tempstr); 
            bool pol = true;
            if (str.Equals(reverse))
            {
                return pol;
            }
            else
            {
                pol = false;
                return pol;
            }
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");
            while (!input.EndOfStream)
            {
                string str = input.ReadLine().ToLower();
                //Console.WriteLine(str);
                var result = str.BoolPolindrom();
                output.WriteLine(result);
            }
            input.Close();
            output.Close();
        }
    }
}
