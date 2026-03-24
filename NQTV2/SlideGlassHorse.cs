using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace NQTV2
{
    public class SlideGlassHorse
    {
        public static int Slide(int n, int k, int[] arr) {

            int sum = 0;
            int start = 0;
            int maxlength = 0;

            for (int end = 0; end < n; end++) {

                sum += arr[end];

                while(sum>=k && start <= end)
                {
                    sum -= arr[start];
                    start++;
                }


                int currentlength = (end - start) + 1;

                maxlength = Math.Max(maxlength, currentlength);
            }
        
            return maxlength;


        }

        public static void Mainv3(string[] args) { 
        
            Console.Write("Enter the number of Element in array : ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter the total Sum Amount : ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) { 
            
            Console.Write("Enter the Element of array of " + i + " Position/Index : ");
                arr[i] = int.Parse(Console.ReadLine());


            }

            int result = Slide(num, k, arr);
                        Console.WriteLine(result);

        }
    }
}
