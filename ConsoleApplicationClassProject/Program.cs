using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationClassProject
{

  class Program
    { 
        static void Main(string[] args)
        {

            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favColor;
            int numberofSiblings;
            int retirementAge;
            int bankMoney;
            string location, ride;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age % 2 == 0)
            {
                //Console.WriteLine("You will retire at age 60!");
                retirementAge = 60;
            }
            else
            {
                //Console.WriteLine("You will retire at age 50!");
                retirementAge = 50;
            }

            Console.WriteLine("Enter your birthmonth number (1-12)");
            birthMonth = int.Parse(Console.ReadLine());


            if (birthMonth >= 1 && birthMonth <= 4)
            {
                //Console.WriteLine("You have $100 in the bank");
                bankMoney = 100;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                //Console.WriteLine("You have $200 in the bank");
                bankMoney = 200;
            }
            else if (birthMonth >= 6 && birthMonth <= 12)
            {
                //Console.WriteLine("You have $300 in the bank");
                bankMoney = 300;
            }
            else if (birthMonth <= 0 && birthMonth > 12)
            {
                //Console.WriteLine("You have $0 in the bank");
                bankMoney = 0;
            }
            else
                bankMoney = 0;

            Console.WriteLine("Enter your favorite ROYGBIV color  (Red, Orange, Yellow, Green, Blue, Indigo, Violet)?");
            favColor = Console.ReadLine();
            switch (favColor)
            {
                case "red":
                   // Console.WriteLine("You drive a car");
                    ride = "car";
                    break;
                case "orange":
                    //Console.WriteLine(" You dive a Horse");
                    ride = "Horse";
                    break;
                case "yellow":
                    // Console.WriteLine("You drive a boat");
                    ride = "boat";
                    break;
                case "green":
                    //Console.WriteLine("You drive a segway");
                    ride = "segway";
                    
                    break;
                case "blue":
                    //Console.WriteLine("You drive a scooter");
                    ride = "scooter";
                    break;
                case "indigo":
                    //Console.WriteLine("You drive a mini van");


                    ride = "van";
                    break;
                case "voilet":
                    //Console.WriteLine("You ride a bike");
                    ride = "Bike";
                    break;

                default:
                //    Console.WriteLine("You walk");
                    ride = "walk";
                    break;

            }

            Console.WriteLine("Enter your  number of siblings ");
            numberofSiblings = int.Parse(Console.ReadLine());
            {
                if (numberofSiblings == 0)
                {//
                    //Console.WriteLine("Your vacation home is in Cleveland");
                    location = "Cleveland";
                }
                else if (numberofSiblings == 1)
                {
                   // Console.WriteLine("Your vacation home is in Bedford");
                    location = "Bedford";
                }
                else if (numberofSiblings == 2)
                {
                    //Console.WriteLine("Your vacation home is in Maple Heights");
                    location = "Maple Heights";
                }
                else if (numberofSiblings == 3)
                {
                   // Console.WriteLine("Your vacation home is in Solon");
                    location = "Solon";
                }
                else if (numberofSiblings <= 4)
                {
                   // Console.WriteLine("Your vacation home is in Garfield");
                    location = "Garfield";
                }
                else
                {
                   // Console.WriteLine("You have a bad location");
                    location = "Bad Location";
                }


                Console.WriteLine( "" + firstName+ " " + lastName + " will retire in " + retirementAge + " years" + " with $" + bankMoney+ " in the bank, a vacation home in " + location + " and a " + ride + ".");
            }
        }
    }
}









