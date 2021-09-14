using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajat sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõver",
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik";

            Console.WriteLine("Mis on su lemmikvärv");
            string UserColor = Console.ReadLine().ToLower();

            if (UserColor == "punane")
            {
                Console.WriteLine("oled romantiline");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if (UserColor == "roheline") 
            {
                Console.WriteLine("oled looduse sõber");
            }
            else
            {
                Console.WriteLine("oled ükssarvik");
            }
        }
    }
}
