using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            double resW = 0;
            double resD = 0;
            double resL = 0;
            //int resRes = 0;

            if (num < 1)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }

            else
            {
                for (int i = 0; i < num; i++)
                {
                    string res = Console.ReadLine();

                    switch (res)
                    {

                        case "W":
                            resW++;
                            break;
                        case "D":
                            resD++;
                            break;
                        case "L":
                            resL++;
                            break;
                        default:
                            break;
                    }

                    
                }


                
                double resRes = resD + resL + resW;
                //Console.WriteLine(resRes);
                resRes = 1*resW / num ;
               // Console.WriteLine(resRes);
                resRes = resRes * 100;
                // Console.WriteLine(resRes);

                
                Console.WriteLine($"{name} has won {resW*3 + resD} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {resW}");
                Console.WriteLine($"## D: {resD}");
                Console.WriteLine($"## L: {resL}");
                Console.WriteLine($"Win rate: {(resW/num)*100:f2}%");
                //Console.WriteLine(resW/num);
                //Console.WriteLine(resW);
                //Console.WriteLine(  num);
                //double d = resW / num;
                //Console.WriteLine(d);

            }



            




        }
    }
}
