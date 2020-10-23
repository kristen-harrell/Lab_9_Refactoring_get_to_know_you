using System;
using System.Collections.Generic;

namespace Lab_9_get_to_know
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> classmates = new List<string>
            {
                "Kristen", "Kevin", "Keira", "Lois", "Harry", "Jenny", "Diego", "Annie", "Brian", "Riley"
            };

            List<string> favoriteFoods = new List<string>
            {
                "macaroni and cheese", "boneless wings", "shawarma", "spaghetti noodles", "tuna", "carrots", "chicken", "ice cream", "chicken wings", "bananas"
            };

            List<string> hometowns = new List<string>
            {
                "jacksonville", "Mount Clemens", "Clinton Township", "Clinton Township", "Clinton Township", "San Juan, PR", "San Juan, PR", "Warren, MI", "Warren, MI", "Warren, MI"
            };

            List<string> favoriteColor = new List<string>
            {
                "green", "red", "blue", "blue", "pink", "purple", "green", "teal", "blue", "purple"
            };

            Console.WriteLine("Welcome to our class!!");
            Console.WriteLine();

            bool runStudentInfo = true;
            bool roundTwo = true;
            while (roundTwo)
            {
                Display(classmates);
                Console.WriteLine( );
                int studentSelection = ValidateInteger("Enter the number of the student you want to learn about: ");
                Console.WriteLine($"What would you like to learn about {classmates[studentSelection - 1]}?");
                while (runStudentInfo)
                {
                    string studentInfoType = ValidateText("You can enter hometown, favorite food, or favorite color: ");
                    if (studentInfoType == "hometown")
                    {
                        Console.WriteLine($"{classmates[studentSelection - 1]}'s {studentInfoType} is {hometowns[studentSelection - 1]}");
                        break;
                    }

                    else if (studentInfoType == "favorite food")
                    {
                        Console.WriteLine($"{classmates[studentSelection - 1]}'s {studentInfoType} is {favoriteFoods[studentSelection - 1]}");
                        break;
                    }

                    else if (studentInfoType == "favorite color")
                    {
                        Console.WriteLine($"{classmates[studentSelection - 1]}'s {studentInfoType} is {favoriteColor[studentSelection - 1]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is not a valid selection");
                        
                    }
                }
                int learnMore = ValidateInteger("Enter 1 to learn about another student, or 2 to add a new student.  Enter 3 if you wish to exit: ");
                if (learnMore == 1)
                {
                    roundTwo = true;
                }
                else if (learnMore == 2)
                {
                    string newStudent = ValidateText("Tell me the name of the student you would like to add: ");
                    classmates.Add(newStudent);
                    Console.WriteLine();
                    string newHometown = ValidateText("What is their hometown: ");
                    hometowns.Add(newHometown);
                    Console.WriteLine();
                    string newFavoriteFood = ValidateText("What is their favorite food: ");
                    favoriteFoods.Add(newFavoriteFood);
                    Console.WriteLine();
                    string newFavoritecolor = ValidateText("What is their favorite color: ");
                    favoriteColor.Add(newFavoritecolor);
                    Console.WriteLine();
                    Console.WriteLine("Ok great! I've added them to the class");

                    int startOver = ValidateInteger("Enter 1 to start over and learn about the students, or 2 to exit ");
                    if (startOver == 1)
                    {
                        roundTwo = true;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (learnMore == 3)
                {
                    Console.WriteLine("Ok, goodbye!");
                    break;
                }
                }

            }

            public static void Display(List<string> nameOfList)
            {
                for (int i = 0; i < nameOfList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\t {nameOfList[i]}");
                }
            }

            public static string GetUserInput(string message)
            {
                Console.Write($"{message}");
                string response = Console.ReadLine();
                return response;
            }

            public static int ValidateInteger(string message)
            {
                while (true)
                {
                    string input = GetUserInput(message);
                    if (int.TryParse(input, out int validInteger))
                    {
                        return validInteger;
                    }
                    else
                    {
                        Console.WriteLine("That didn't work. Let's try again");
                    }
                }
            }

            public static string ValidateText(string incomingText)
            {
                while (true)
                {
                    string validText = GetUserInput(incomingText);
                    if (incomingText.ToLower() != incomingText != null)
                    {
                        return validText;
                    }
                    else
                    {
                        Console.WriteLine("That didn't work. Let's try again");
                    }
                }
            }
        }
    }
