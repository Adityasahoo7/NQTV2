using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class FindDuplicate
    {
        public static int Duplicate(int[] arr) {
            HashSet < int > hfind= new HashSet<int>();

            for(int i = 0; i < arr.Length ; i++)
            {
                if (hfind.Contains(arr[i]))
                {
                    return arr[i];
                }
                if (!hfind.Contains(arr[i])) {

                    hfind.Add(arr[i]);
                
                }
            }

            return -1;
        }

        public static void Mainv2(string[] args) { 
        
            Console.Write("Enter the size of array");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) {

                Console.Write("Enter the Values of array of " + i + " Position/Index : ");
                arr[i] = int.Parse(Console.ReadLine());
            
            }
            int result = Duplicate(arr);
            Console.WriteLine(result);


        }
    }
}
