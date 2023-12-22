// See using System;

class Program
{
    static void Main()
    {
        // Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram

        Console.WriteLine("1ci ededi daxil et");
        string astr = Console.ReadLine();
        int a = Convert.ToInt32(astr);

        Console.WriteLine("2ci ededi daxil et");
        string bstr = Console.ReadLine();
        int b = Convert.ToInt32(bstr);

        Console.WriteLine("3cu ededi daxil et");
        string cstr = Console.ReadLine();
        int c = Convert.ToInt32(cstr);

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("en boyuk eded:" + a);
            }
            else
            {
                Console.WriteLine("en boyuk eded:" + c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("en boyuk eded:" + b);
            }
            else
            {
                Console.WriteLine("en boyuk eded:" + c);
            }
        }
    }
}
