using System;

class Program
{
    static void Main()
    {

        //Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram


        Console.WriteLine("yazi yaz");
        
        string text = Console.ReadLine();

        bool has = false;

        char letter = 'A';


        for (int i = 0; i < text.Length; i++)
        {

            if (text[i] == letter)
            {
                has = true; break;


            }

        }
            if (has == true)
            {
                Console.WriteLine("A herfi var");


            }
            else Console.WriteLine("A herfi yoxdur");



        



















    }
}
