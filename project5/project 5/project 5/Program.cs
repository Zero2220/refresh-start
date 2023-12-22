using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        // Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram



        int[] list = new int[5];

        int count = 1;

        int sum = 0;

        for (int i = 0; i < list.Length; i++) 
        {

            Console.WriteLine("eded daxil et" +" " + count);
            string numstr = Console.ReadLine();
            int num  = Convert.ToInt32(numstr);
            list[i] = num;

            count++;

             sum += num;


            

            

        }

        Console.WriteLine(sum);


       









    }
}
