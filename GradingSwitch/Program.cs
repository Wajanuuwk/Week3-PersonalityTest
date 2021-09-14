using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne");
            int UserGrade = Convert.ToInt32(Console.ReadLine());

            switch (UserGrade)
            {
                case 5:
                    Console.WriteLine("Suurepärane");
                    break;
                case 4:
                    Console.WriteLine("väga hea");
                    break;
                case 3:
                    Console.WriteLine("Hea");
                    break;
                case 2:
                    Console.WriteLine("Rahuldav");
                    break;
                case 1:
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }
        }  
    }
}
