using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {

        //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram
        //Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
        //"system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

        Console.WriteLine("tehsil novu daxil edin"); 
        
        string nov =Console.ReadLine();


        if (nov == "programming")
        {
            Console.WriteLine("400 saat");

        }
        
        

        if (nov == "design")
        {
                Console.WriteLine("250 saat");
        }

        

        if (nov == "system")
        {
            Console.WriteLine("200 saat");


        }



        if (nov != "system" && nov != "programming" && nov != "design")
        {
            Console.WriteLine("tehsil novu yanlisdir");
        }
        


        













    }
}
