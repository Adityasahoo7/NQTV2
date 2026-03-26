using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class LongestSubString
    {
        public static int substring(string str) {

            HashSet<char> seen = new HashSet<char>();
            int left = 0;
            int maxlength = 0;

            for(int start = 0; start < str.Length; start++)
            {
                while (seen.Contains(str[start])) { 
                seen.Remove(str[left]);
                left++;

                }

                seen.Add(str[start]);
                int currentlenght = (start - left) + 1;
                maxlength = Math.Max(maxlength, currentlenght);
            }

        return maxlength;
        }
        public static void Mainv7(string[] args)
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();


            int result = substring(str);
            Console.WriteLine(result);
        }
    }
}
