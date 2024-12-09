using System.Xml.Linq;

namespace SwitchPoints
{
    internal class Program
    {
        static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Ange en siffra mellan 1 och 9: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int points) && points >= 1 && points <= 9)
            {
                int bonus = points;
                switch (points)
                {
                    case 1:
                    case 2:
                    case 3:
                        bonus *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        bonus *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        bonus *= 1000;
                        break;
                }

                Console.WriteLine($"Det nya värdet med bonus är: {bonus}");
            }
            else
            {
                Console.WriteLine("Fel: Ange en siffra mellan 1 och 9.");
            }


            Console.WriteLine("----------------------------------------------");

            for (int floor = 0; floor <= 4; floor++)
            {
                Console.Write($"Våning {floor}: ");
                switch (floor)
                {
                    case 0:
                        Console.WriteLine("Entréplan");
                        break;
                    case 1:
                        Console.WriteLine("Säljavdelningen");
                        break;
                    case 2:
                        Console.WriteLine("IT-avdelningen");
                        break;
                    case 3:
                        Console.WriteLine("Projektledningen");
                        break;
                    case 4:
                        Console.WriteLine("Chefen");
                        break;
                }

                // Vänta en sekund för att simulera hissens rörelse
                Thread.Sleep(1000);
            }

            Console.WriteLine("Hissen har nått högsta våningen.");



            Console.WriteLine("--------------------------------");

            
                SayHello();
                SayGoodbye();
            

            static void SayHello()
            {
                Console.Write("Ange ditt namn: ");
                name = Console.ReadLine();
                Console.WriteLine($"Hej, {name}! Välkommen!");
            }

            static void SayGoodbye()
            {
                Console.WriteLine($"Hej då, {name} ! Ha en bra dag!");
            }
        }
    }
}
        
    

