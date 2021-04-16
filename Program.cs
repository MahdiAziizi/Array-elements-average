using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public void sumaverageelements(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
                 for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("jam araye :" + sum);
            Console.WriteLine("miyangin araye ha :" + average);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("size ra vered kinid:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("adad ra vared kinid:");
            for (int i = 0; i < size; i++)

            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;
            Program pg = new Program();
            pg.sumaverageelements(a,len);


        }
    }
}
