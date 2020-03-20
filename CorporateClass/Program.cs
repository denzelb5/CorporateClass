using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {

        
    static void Main(string[] args)
        {
            List<Employee> CurrentEmployees = new List<Employee>();

           var TacoTown = new Company("Taco Town", new DateTime(1999, 1, 1));


            var mikeSmith = new Employee();
            mikeSmith.FirstName = "Michael";
            mikeSmith.LastName = "Smith";
            mikeSmith.JobTitle = "Assistant Manager";
            mikeSmith.StartedOn = new DateTime(2005, 4, 20);

            CurrentEmployees.Add(mikeSmith);


            CurrentEmployees.Add(
                new Employee()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    JobTitle = "Manager",
                    StartedOn = new DateTime(2009, 10, 22)
                });

            CurrentEmployees.Add(
                new Employee()
                {
                    FirstName = "Kristy",
                    LastName = "Seefer",
                    JobTitle = "Grunt",
                    StartedOn = new DateTime(1994, 9, 4)
                });

            TacoTown.employees = CurrentEmployees;

            CurrentEmployees.Add(
                new Employee()
                {
                    FirstName = "Alex",
                    LastName = "Johnson",
                    JobTitle = "Minion",
                    StartedOn = new DateTime(2018, 4, 12)
                });

                
            

            foreach (var employee in CurrentEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", " + employee.JobTitle);
            }


            CurrentEmployees.Remove(mikeSmith);

            foreach (var employee in CurrentEmployees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", " + employee.JobTitle);
            }


        }
    }
}
