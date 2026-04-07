using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class CinemaTicket
    {
        public static (int sum, int count, double avg) gettotal(int num,int[] arr) {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < num; i++) {

                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                    count++;
                }
            
            }

            double avg = count > 0 ? (double)sum / count : 0;

            return (sum, count, avg);
        
        
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people in the queue: ");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) { 
            
            Console.WriteLine("Enter the bill Amount of " + i + " person in the queue: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            var result = gettotal(num, arr);
            Console.WriteLine("[" + result.sum + ", " + result.count + ", " + result.avg + " ]");

        }
    }
}
