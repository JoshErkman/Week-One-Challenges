using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeeklyChallenges
{
    [TestClass]
    public class WeekOneChallenges
    {
        [TestMethod]
        public void ChallengeOne()
        {
            string firstName = "Josh";
            string lastName = "Erkman";
            int age = 31;

            Console.WriteLine(firstName + " " + lastName + " " + age);

        }

        [TestMethod]
        public void ChallengeTwo()
        {
            string[] movieArray = { "Forest Gump", "Step Brothers", "Fight Club", "Avengers" };

            Console.WriteLine(movieArray);
            
        }

        [TestMethod]
        public void ChallengeThree()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            listOfDates.Add(DateTime.Now);

            Console.WriteLine(listOfDates);
                
        }
        [TestMethod]
        public void ChallengeFour()
        {
            int age = 31;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

            // Or

            int ageSum = age + 7;
            int ageDiff = age - 7;
            int ageProd = age * 7;
            int ageQuot = age / 7;
            int ageMod = age % 7;

            Console.WriteLine(ageSum);
            Console.WriteLine(ageDiff);
            Console.WriteLine(ageProd);
            Console.WriteLine(ageQuot);
            Console.WriteLine(ageMod);
        }

        [TestMethod]
        public void ChallengeFive()
        {
            int hoursOfSleep = 8;

            if (hoursOfSleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursOfSleep >= 8 && hoursOfSleep < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (hoursOfSleep >= 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }



        }

        [TestMethod]
        public void ChallengeSix()
        {
            Console.WriteLine("How's you're day going?");
            /*string userDay = Console.ReadLine();*/
            string userDay = "Bad";

            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Well I am glad to hear that");
                    break;
                case "Good":
                    Console.WriteLine("Well I am glad to hear that");
                    break;
                case "Okay":
                    Console.WriteLine("Just okay huh?");
                    break;
                case "Bad":
                    Console.WriteLine("Man that sucks.");
                    break;
            }

        }
    }
}
