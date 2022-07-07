using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    internal class NewBaseType
    {     
        public static void Main(string[] args)
        {
            List<Employee> employees = PeopleFetcher.GetFromApi();
            //List<Employee> employees = PeopleFetcher.GetEmployees();
            //employees = PeopleFetcher.GetEmployees();

            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}