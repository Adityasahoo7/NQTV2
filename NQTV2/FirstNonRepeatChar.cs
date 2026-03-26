using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class FirstNonRepeatChar
    {
        public static char nonrepeat(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            
            foreach(char ch in str)
            {
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }
            foreach(char c in str)
            {
                if (freq[c] == 1) {
                    return c;
                }
            }
            return '\0';
        }
        public static void Mainv4(string[] args)
        {
            Console.Write("Enter the String  here: ");
            string str = Console.ReadLine();

            char c = nonrepeat(str);
            Console.WriteLine("New String is ");
            Console.Write(c);
        }
    }
}
