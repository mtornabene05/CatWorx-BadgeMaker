using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    internal class NewBaseType
    {     
        public static void Main(string[] args)
        {
            //List<Employee> employees = PeopleFetcher.GetEmployees();

            //employees = PeopleFetcher.GetEmployees();

            List<Employee> employees = PeopleFetcher.GetFromApi();

            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}