using System;

namespace Programming_Basics_Online_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            double bitcoin = double.Parse(Console.ReadLine());
            double chinaMoney = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());


            double moneyLeva = bitcoin*1168;
            double moneyDolares = 0.15 * chinaMoney;
            moneyLeva = (moneyLeva + moneyDolares * 1.76)/1.95;
            double moneyAfterDiscount = moneyLeva * comision / 100;
            moneyAfterDiscount = moneyLeva - moneyAfterDiscount;
            Console.WriteLine($"{moneyAfterDiscount:f2}");
              



        }
    }
}
