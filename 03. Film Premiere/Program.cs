using System;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            string packet = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double price = 0;

            switch (name)
            {

                case "John Wick":
                    switch (packet)
                    {
                        case "Drink":
                            price = 12;
                            break;
                        case "Popcorn":
                            price = 15;
                            break;
                        case "Menu":
                            price = 19;
                            break;
                        default:
                            break;
                    }

                    break;
                case "Star Wars":
                    switch (packet)
                    {
                        case "Drink":
                            price = 18;
                            break;
                        case "Popcorn":
                            price = 25;
                            break;
                        case "Menu":
                            price = 30;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Jumanji":
                    switch (packet)
                    {
                        case "Drink":
                            price = 9;
                            break;
                        case "Popcorn":
                            price = 11;
                            break;
                        case "Menu":
                            price = 14;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            if (name == "Star Wars" && num >= 4)
            {
                price = price - price * 30 / 100;
            }
            else if (name == "Jumanji" && num==2)
            {
                price = price - price * 15 / 100;
            }

            Console.WriteLine($"Your bill is {(price*num):f2} leva.");

        }
    }
}
