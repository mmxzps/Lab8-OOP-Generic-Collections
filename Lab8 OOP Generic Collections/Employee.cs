using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_OOP_Generic_Collections
{
    internal class Employee
    {
        //creating the properties 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        //creating a constructor with parameters 
        public Employee(int id, string name, string gender, double salary)
        {
            //initializing the parameters.
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        //Adding a override to be able to print out the data.
        public override string ToString()
        {
            return ($"Id: {Id} Name: {Name} Gender: {Gender} Salary: {Salary}");
        }

    }
}
