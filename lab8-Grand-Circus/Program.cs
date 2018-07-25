using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStudentInformation
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nWelcome to our C# class. Which student would you like to learn more about? (enter a number 1-20)");

                int inputNumber = int.Parse(Console.ReadLine());

                try
                {
                    string homeTown = "hometown";

                    string favoriteFood = "favorite food";

           


                    Console.Write($"\nStudent {inputNumber} is {GetStudentName(inputNumber)}. What would you like to know about {GetStudentName(inputNumber)}? ( Choose a  hometown or favorite food):", GetStudentName(inputNumber));

                    var inputOption = Console.ReadLine();

                    bool repeat = true;

                    while (repeat)
                    {
                        if (Equals(inputOption, homeTown))
                        {
                            Console.WriteLine($"\n{GetStudentName(inputNumber)} is from {GetHomeTown(inputNumber)}. Would you like to know more ? ( Yes or No):");

                            var inputAgain = Console.ReadLine();
                        }
                        else if (Equals(inputOption, favoriteFood))
                        {
                            Console.WriteLine($"\n{GetStudentName(inputNumber)} favorite food is {GetFavoriteFood(inputNumber)}. Would you like to know more ? (Yes or No):");

                            var inputAgain = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("That does not exist. Please try again. (enter or hometown or favorite food");
                        }

                    };


                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20)", ex);
                }

                if (!toContinue())
                {
                    break;
                }
                    

            } while (true);

            Console.WriteLine("\nSee You Later!\n");

            Console.ReadKey();
        }




        /*** End of Main *********/



        // students
        public static string GetStudentName(int num)
        {

            string[] students = new string[20];

            students = new string[]
            {
                "Tommy", "John", "David", "Adam", "Chris A", "Sean A", "Bo", "", "", "Ron",

                "Kim", "Ricky B", "Sarah", "Justin", "Donna W", "Kevin W","Peggy ","Mike", "Hem G", "Susan", "Aron R"
            };

            return students[num];
        }

        // favorite foods
        public static string GetFavoriteFood(int number)
        {
            string[] favoriteFood = new string[20];

            favoriteFood = new string[]
            {
                "Banana", "Ice Cream", "Rice", "Apple", "Subway", "Sereal", "Popcorn", "Ham Burger", "Mac Chicken", "Taco",

                "Bread", "Rice", "Sandwhich", "Pie", "Bean soup","Meat ball","Rice", "Tea", "Hot Coffee", "Mosrum"
            };

            return favoriteFood[number];
        }

        //student hometown
        public static string GetHomeTown(int number)
        {
            string[] homeTown = new string[20];

            homeTown = new string[]
            {" Lansing,Michigan ", "Grand Rapids, MI", "Kentwood, MI", "Grand Rapid MI", "Kentwood, MI", "Grand Rapids, MI",

                "Detroit, MI", "Detroit, MI", "Florida,Fort.Luderdale", "Grand Rapids, MI", "Grand Rapids, MI", "Grand Rapids, MI","Holland, MI","Battle Greek, MI", "Wyoming, MI", "Kentwood, MI", "Grand Rapids, MI"
            };

            return homeTown[number];
        }

        // continue yes or no
        private static bool toContinue()
        {
            do
            {
                Console.Write("\nContinue? (y/n) ?");

                var toContinue = char.ToLower(Console.ReadKey().KeyChar);

                if (toContinue != 'y' && toContinue != 'n')
                {
                    continue;
                }

                return toContinue == 'y';

            } while (true);
        }

    }

}
