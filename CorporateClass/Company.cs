using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    
    class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> employees  { get; set; }


    // Create a private property for holding a collection of current employees


    // Create a method that allows a caller to add an employee
    //public void AddEmployee() 
    //{
    //    foreach (var employee in CurrentEmployees)
    //    CurrentEmployees.Add(employee);

    //}       



    // Create a method that allows a caller to remove an employee
    //public void RemoveEmployee()
    //{
    //    var employee = Console.ReadLine();
    //    //currentEmployees.Remove(employee);
    //}


    //// Create a method that allows a caller to retrieve the list of employees
    //public void ShowEmployees()
    //{
    //    foreach (var employee in CurrentEmployees)
    //    {
    //        Console.WriteLine(employee);
    //    }
    //}


    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
    }
    
}
