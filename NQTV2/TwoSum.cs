using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class TwoSum
    {

        public static int[] tsum(int k, int[] arr)
        {
            Dictionary<int, int> dsum = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length - 1; i++) {

                int num = k - arr[i];
                if (dsum.ContainsKey(num))
                {
                    return new int[] { dsum[num], i };
                }
                if (!dsum.ContainsKey(num))
                {
                    dsum.Add(arr[i], i);
                }


            
            
            }

            return new int[] { -1, -1 };
        }
        public static void Mainv1(string[] args) {


            Console.Write("Enter the targete value");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Entar the size of array");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) {

                Console.Write("Enter the array value of " + i + " Position/Index : ");
                arr[i] = int.Parse(Console.ReadLine());
            
            
            }


            //int[] arr = { 2, 7, 11, 15 };
            //int target = 9;

            int[] result = tsum(target, arr);

            Console.WriteLine($"[{result[0]},{result[1]}]");



        }
    }
}
