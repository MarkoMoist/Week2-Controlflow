using System;

namespace When_were_you_born
{
    class Program
    {
        static void Main(string[] args)
        {  
            //programm küsib kasutaja sünniaasta
            //programm arvutab kasutaja vanuse
            //programm küsib kasutaja vanust

            Console.WriteLine("küsin kasutaja sünniaastat");
            int sünniaasta = Convert.ToInt32(Console.ReadLine());

            int vanus = 2021 - sünniaasta;

            Console.WriteLine($"Sa oled aastat vana");
        }
    }
}
