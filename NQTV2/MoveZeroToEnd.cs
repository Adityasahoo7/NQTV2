using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class MoveZeroToEnd
    {
        public static int[] movezero(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++) {

                if (arr[i] != 0)
                {
                    arr[n] = arr[i];
                    n++;
                }
            
            }

            while (n < arr.Length)
            {
                arr[n] = 0;
                n++;
            }

            return arr;
        }


        public static void Mainv5(string[] args)
        {
            Console.Write("Enter the number of Array Element : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++) { 
            
            Console.Write("Enter the Array Element of " + i + " Position/Index : ");
                arr[i] = int.Parse(Console.ReadLine());

            }

            int[] result = movezero(arr);

            Console.WriteLine("Output:[ " + string.Join(", ", result) + " ]");

        }
    }
}
