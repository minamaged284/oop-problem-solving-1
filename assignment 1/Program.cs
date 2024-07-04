using System.ComponentModel;
using System.Drawing;
using static assignment_1.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_1
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region problem 1

            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


            foreach (WeekDays day in Enum.GetValues<WeekDays>())
            {
                Console.WriteLine(day);
            }
            #endregion

            #region problem 2

            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            Person[] persons = new Person[3];
            for (int i = 0; i<persons.Length; i++)
            {
                int pAge = 0;
        persons[i] = new Person();

        Console.WriteLine($"enter the person = {i+1}  name");
                string? pName = Console.ReadLine();
                do
                {
                    Console.WriteLine($"enter the person = {i+1} age");

                } while (!int.TryParse(Console.ReadLine(), out pAge));
                persons[i].name = pName;
                persons[i].age = pAge;
            }

                foreach (Person person in persons)
                {
                    Console.WriteLine(person);
                }

                #endregion

#region problem 3


//Create an enum called "Season" with the four Seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

Seasons season = new Seasons();
            do
            {
                Console.WriteLine("write the required season");

            } while (!Seasons.TryParse(Console.ReadLine().ToLower(), out season));
            {
                switch (season)
                {
                    case Seasons.winter:
                        Console.WriteLine("December");
                        Console.WriteLine("January");
                        Console.WriteLine("February");

                        break;
                    case Seasons.spring:
                        Console.WriteLine("March");
                        Console.WriteLine("April");
                        Console.WriteLine("May");
                        break;
                    case Seasons.summer:
                        Console.WriteLine("June");
                        Console.WriteLine("July");
                        Console.WriteLine("August");
                        break;
                    case Seasons.automn:
                        Console.WriteLine("September");
                        Console.WriteLine("October");
                        Console.WriteLine("November");
                        break;
                    default:
                        Console.WriteLine("enter a valid season ");
                        break;
                }

            }




            #endregion

            #region problem 4

            //            Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            Permissions addOrRemove1 = new Permissions();
            Permissions addOrRemove2 = new Permissions();
            Permissions check3 = new Permissions();

            do
            {
                Console.WriteLine("enter the required permission to add or delete from (Read, write, Delete, Execute)");

            } while (!Permissions.TryParse(Console.ReadLine().ToLower(), out addOrRemove1));


            do
            {
                Console.WriteLine("enter the required permission to add or delete from (Read, write, Delete, Execute)");

            } while (!Permissions.TryParse(Console.ReadLine().ToLower(), out addOrRemove2));


            Permissions empPermission = new Permissions();
            empPermission |= addOrRemove1;
            empPermission |= addOrRemove2;
            Console.WriteLine($"the Permissions assigned are {empPermission}");

            do
            {
                Console.WriteLine("write a permission to check from (Read, write, Delete, Execute)");


            } while (!Permissions.TryParse(Console.ReadLine().ToLower(), out check3));
            ;
            if ((empPermission & check3) == check3)
            {
                Console.WriteLine($"{check3} exists");
            }
            else
            {
                Console.WriteLine($"{check3} does not exist");
            }
            #endregion

            #region problem 5

            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            BasicColors allColors = (BasicColors)7;
            Console.WriteLine("enter a color");
            string colorString = Console.ReadLine().ToLower();

            BasicColors.TryParse(colorString, out BasicColors color);
            if ((allColors & color) == color && (allColors & color) != 0)
            {
                Console.WriteLine($"color {colorString} is a basic color");
            }
            else
            {
                Console.WriteLine($"color {colorString} is not a basic color");
            }


            #endregion

            #region problem 6

            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            double x1;
            double x2;
            double y1;
            double y2;
            Point p1 = new Point();
            Point p2 = new Point();
            do
            {
                Console.WriteLine("enter the x coordinates of the first point");

            } while (!double.TryParse(Console.ReadLine(), out x1));
            do
            {
                Console.WriteLine("enter the y coordinates of the first point");

            } while (!double.TryParse(Console.ReadLine(), out y1));


            do
            {
                Console.WriteLine("enter the x coordinates of the second point");

            } while (!double.TryParse(Console.ReadLine(), out x2));
            do
            {
                Console.WriteLine("enter the y coordinates of the second point");

            } while (!double.TryParse(Console.ReadLine(), out y2));
            p1.x = x1;
            p1.y = y1;
            p2.x = x2;
            p2.y = y2;

            double distance = Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
            Console.WriteLine(distance);




            #endregion


            #region problem 7

            Person[] persons7 = new Person[3];
            int maxAge=0;
            int indexOldest=0;
            for (int i = 0; i < persons7.Length; i++)
            {
                int pAge7;
                persons7[i] = new Person();

                Console.WriteLine($"enter the person = {i + 1}  name");
                string? pName7 = Console.ReadLine();
                do
                {
                    Console.WriteLine($"enter the person = {i + 1} age");

                } while (!int.TryParse(Console.ReadLine(), out pAge7));
                persons7[i].name = pName7;
                persons7[i].age = pAge7;

                if (persons7[i].age > maxAge)
                {
                    maxAge = persons7[i].age;
                    indexOldest = i;
                }


            }



            #endregion

        }
    }
}
