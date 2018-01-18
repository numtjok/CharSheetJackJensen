using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            //Input Character information
            Console.WriteLine("Please enter the first name of your Character:");
            class1.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of your Character");
            class1.LastName = Console.ReadLine();
            Console.WriteLine("Please enther the age of you Character");
            class1.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your characters Alignment");
            class1.Alignment = Console.ReadLine();
            Console.WriteLine("Please enter you characters race");
            class1.Race = Console.ReadLine();
            Console.WriteLine("Please enter your characters Backstory");
            class1.Backstory = Console.ReadLine();
            
            Random rnd = new Random();
            //Instead of making a reroll i will just make sure that it is impossible to get 1's
            int Roll1 = rnd.Next(2, 7); 
            int Roll2 = rnd.Next(2, 7);
            int Roll3 = rnd.Next(2, 7);
            int stat1 = Roll1 + Roll2 + Roll3;

            int Roll4 = rnd.Next(2, 7);
            int Roll5 = rnd.Next(2, 7);
            int Roll6 = rnd.Next(2, 7);
            int stat2 = Roll4 + Roll5 + Roll6;

            int Roll7 = rnd.Next(2, 7);
            int Roll8 = rnd.Next(2, 7);
            int Roll9 = rnd.Next(2, 7);
            int stat3 = Roll7 + Roll8 + Roll9;

            int Roll10 = rnd.Next(2, 7);
            int Roll11 = rnd.Next(2, 7);
            int Roll12 = rnd.Next(2, 7);
            int stat4 = Roll10 + Roll11 + Roll12;

            int Roll13 = rnd.Next(2, 7);
            int Roll14 = rnd.Next(2, 7);
            int Roll15 = rnd.Next(2, 7);
            int stat5 = Roll13 + Roll14 + Roll15;

            int Roll16 = rnd.Next(2, 7);
            int Roll17 = rnd.Next(2, 7);
            int Roll18 = rnd.Next(2, 7);
            int stat6 = Roll16 + Roll17 + Roll18;

            Console.WriteLine("Here are your stat numbers " + stat1 + " " + stat2 + " " + stat3 + " " + stat4 + " " + stat5 + " " + stat6);

            int Strength;
            int Dexterity;
            int Constitution;
            int Intelligence;
            int Wisdom;
            int Charisma;



            int[] statArray = { stat1, stat2, stat3, stat4, stat5, stat6 };
            for (int i = 0; i < statArray.Length; i++)
            {
                Console.WriteLine("Which Stat would you like to assign this value? "+statArray[i]+" 1:Strength 2:Dexterity 3:Constitution 4:Intelligence 5:Wisdom 6:Charisma");
                int choiceNum = int.Parse(Console.ReadLine());
                if (choiceNum == 1) {
                    Strength = statArray[i];
                }
                if (choiceNum == 2)
                {
                    Dexterity = statArray[i];
                }
                if (choiceNum == 3)
                {
                    Constitution = statArray[i];
                }
                if (choiceNum == 4)
                {
                    Intelligence = statArray[i];
                }
                if (choiceNum == 5)
                {
                    Wisdom = statArray[i];
                }
                if (choiceNum == 6)
                {
                    Charisma = statArray[i];
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                    break;
                }

            }





            Console.ReadKey();


        }
    }
}
