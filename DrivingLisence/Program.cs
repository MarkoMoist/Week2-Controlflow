using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm kontrollib kasutaja sünniaastat
            //Program teavitab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Mis on Teie sünniaasta");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18) 
            {
                Console.WriteLine("oled piisavalt vana");
            }
            if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor");
            }
            else
            {
                Console.WriteLine("oled piisavalt vana");
            }
            Console.WriteLine("Kena päeva");
        }
    }
}
