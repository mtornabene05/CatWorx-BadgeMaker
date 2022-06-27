using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    internal class NewBaseType
    {
        static List<Employee> GetEmployees()
        {
            //I will return a list of strings
            List<Employee> employees = new List<Employee>();
            //Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter first name: (leave empty to exit) ");
                //Get a name from the console and assign it to a variable
                string firstName = Console.ReadLine();
                //Break if the user hits ENTER without typing a name
                if (firstName == "")
                {
                    break;
                }

                //add a Console.ReadLine() for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }

            return employees;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);

        }
    }
}