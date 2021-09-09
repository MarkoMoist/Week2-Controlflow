using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust
            //Kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //Kui kasutaja on noorme kui 18. siis konsoolis kuvatakse "oled liiga noor"
            //Kui kasutaja on 18, siis programmis kuvatakse "oled 18"

            Console.WriteLine("kui vana sa oled?");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age  > 18)
            {
                Console.WriteLine("Oled piisavalt vana");
            }
            else if (Age < 18)
            {
                Console.WriteLine("oled liiga noor");
            }
            else
            {
                Console.WriteLine("Oledki 18");
            }

            Console.WriteLine("Kena päeva");






        }
    }
}
