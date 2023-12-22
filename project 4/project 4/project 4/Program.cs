using System;

class Program
{
    static void Main()
    {


        //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir


        int num;

        do
        {
            Console.WriteLine("eded daxil edin");

            string numstr = Console.ReadLine();

            num = Convert.ToInt32(numstr);






        }
        while ( num <= 0 || num%2 != 0) ;


        int result = num * num;


        Console.WriteLine(result);













    }
}
