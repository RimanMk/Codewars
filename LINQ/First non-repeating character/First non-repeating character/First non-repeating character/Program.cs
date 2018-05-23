using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("sTRests"));
            Console.ReadKey();
            
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            string result = "";

            string input = s.ToString().ToLower();
            char c = input.Where((t) => { return input.IndexOf(t) == input.LastIndexOf(t); }).FirstOrDefault();
            int index = input.IndexOf(c);
            if (index >= 0) result = s[index].ToString();

            return result;
        }

    }
}
