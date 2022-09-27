using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {


            double budjet = double.Parse(Console.ReadLine());
            double littrePawer = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double allNeedMoney = littrePawer * 2.1;
            if (dayOfWeek == "Saturday")
            {
                allNeedMoney = (allNeedMoney + 100) - (allNeedMoney + 100) * 10 / 100;
            }
            else if (dayOfWeek == "Sunday")
            {
                allNeedMoney = (allNeedMoney + 100) - (allNeedMoney + 100) * 20 / 100;
            }

            if (budjet >= allNeedMoney)
            {
                Console.WriteLine($"Safari time! Money left: {(budjet-allNeedMoney):f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(allNeedMoney-budjet):f2} lv.");
            }

        }
    }
}
