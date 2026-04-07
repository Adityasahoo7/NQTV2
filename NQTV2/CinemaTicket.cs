using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV2
{
    public class CinemaTicket
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people in the queue: ");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) { 
            
            Console.WriteLine("Enter the bill Amount of " + i + " person in the queue: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
