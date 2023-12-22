using System;

class Program
{
    static void Main()
    {
        //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram



        Console.WriteLine("yazi yaz");
        string text = Console.ReadLine();

        int Count = 0;


        char letter = 'A';

        

        for (int i = 0; i < text.Length; i++)
        {

            if (text[i] == letter )
            {

                Count++;





            }
        }
            Console.WriteLine("yazi icherisinde" + " " + Count + " " + "sayda A var");    


        






























    }
}

