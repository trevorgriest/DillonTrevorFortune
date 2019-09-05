using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTellerD_T
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string userAge;
            string userBirthMonth;
            string userFavColor;
            string userSiblingCount;

            Console.WriteLine("What is your first name?");

            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");

            userAge = Console.ReadLine();

            Console.WriteLine("What is your birth month (use 1-12 to specifiy month)?");

            userBirthMonth = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");

            userSiblingCount = Console.ReadLine();

            Console.WriteLine("What is your favorite ROYGBIV color? Type HELP for a list of ROYGBIV colors");
            userFavColor = Console.ReadLine();
            while (userFavColor.ToLower() != "red" &&
                  userFavColor.ToLower() != "orange" &&
                  userFavColor.ToLower() != "yellow" &&
                  userFavColor.ToLower() != "green" &&
                  userFavColor.ToLower() != "blue" &&
                  userFavColor.ToLower() != "indigo" &&
                  userFavColor.ToLower() != "violet"
                  )
            {
                Console.WriteLine("What is your favorite ROYGBIV color? Type HELP for a list of ROYGBIV colors");
                userFavColor = Console.ReadLine();
                if (userFavColor.ToLower() == "help")
                {
                    Console.WriteLine("Colors to choose from");
                    Console.WriteLine();
                    Console.WriteLine("Red");
                    Console.WriteLine("Yellow");
                    Console.WriteLine("Orange");
                    Console.WriteLine("Green");
                    Console.WriteLine("Blue");
                    Console.WriteLine("Indigo");
                    Console.WriteLine("Violet");
                }
            }
            //What Job People will have
            string jobFortune = null;
            int ageInt = Convert.ToInt32(userAge);
            if (ageInt < 0) jobFortune = "Unborn";
            if (ageInt >= 0 && ageInt <= 15) jobFortune = "Highschool Student";
            if (ageInt >= 16 && ageInt <= 30) jobFortune = "Lifeguard";
            if (ageInt >= 31 && ageInt <= 45) jobFortune = "Underwater Basket Weaver";
            if (ageInt >= 46 && ageInt <= 64) jobFortune = "Pro NBA Player";
            if (ageInt >= 65) jobFortune = "Old People Things";

            //Will you have kids or gerbils
            string colorFortune = null;
            if (userFavColor.ToLower() == "red") colorFortune = "7 gerbils";
            if (userFavColor.ToLower() == "orange") colorFortune = "17 gerbils";
            if (userFavColor.ToLower() == "blue") colorFortune = "2 kids";
            if (userFavColor.ToLower() == "yellow") colorFortune = "8 kids";
            if (userFavColor.ToLower() == "indigo") colorFortune = "26 gerbils";
            if (userFavColor.ToLower() == "violet") colorFortune = "30 gerbils";
            if (userFavColor.ToLower() == "green") colorFortune = "24 kids";

            //Info
            Console.WriteLine("You are " + firstName + " " + lastName);
            Console.WriteLine("You're age is " + ageInt);
            Console.WriteLine("Your birth month is " + userBirthMonth);
            Console.WriteLine("Your favorite color is " + userFavColor);
            Console.WriteLine("You have " + userSiblingCount);
            Console.WriteLine("Based on my cosmic awesomesauce powers, the following fortunes pertain to your future!");
            //Fortunes
            Console.WriteLine("Based on your age your job is " + jobFortune);
            Console.WriteLine("You will have " + colorFortune);
            Console.ReadLine();
        }
    }
}
