using Microsoft.VisualBasic;
using System.Collections;

namespace Lab8_OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 5 objects of Employee
            Employee employee1 = new Employee(1001,"Erik","Male",9065);
            Employee employee2 = new Employee(1002, "John", "Male", 7965);
            Employee employee3 = new Employee(1003, "Anna", "Female", 42965);
            Employee employee4 = new Employee(1004, "Sara", "Female", 79965);
            Employee employee5 = new Employee(1005, "Siaa", "Female", 62965);

            //creating a stack
            Stack<Employee> stack = new Stack<Employee>();
            //adding the employe objects in stack.
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            //using foreach to print out all the elements in stack
            foreach (Employee i in stack)
            {
                Console.WriteLine(i);
                //printing out the amount of items thar are left after every itretation 
                Console.WriteLine($"Items left in the stack: {stack.Count()}");
            }

            //Divider
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Retrive using pop method");

            //varför inte foreach?

            //using a while loop to print out the elements.
            while (stack.Count > 0)
            {
                //storing the elements in a variable after taking them out from the stack.
                var popEmployes = stack.Pop();
                //printing out the elements that are in the variable
                Console.WriteLine(popEmployes);
                //printing out the amount of items thar are left after every itretation 
                Console.WriteLine($"Items left in the stack: {stack.Count()}");
            }
            //adding the employe objects back in the stack.
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            //divider
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Retrive using peek method");

            //printing out the elements with peek. using a for loop that iterates 2 times for printing out t objects.
            for (int i = 0; i < 2; i++)
            {
                var peek = stack.Peek();
                Console.WriteLine(peek);
                Console.WriteLine($"Items left in the stack: {stack.Count()}");
            }

            //var peek = stack.Peek();
            //Console.WriteLine(peek);
            //Console.WriteLine($"Items left in the stack: {stack.Count()}");
            //Console.WriteLine(peek);
            //Console.WriteLine($"Items left in the stack: {stack.Count()}");

            //divider
            Console.WriteLine("----------------------------------------------");

            //Checking if stack contains a employee3 the returning answer
            if (stack.Contains(employee3))
            {
                Console.WriteLine($"employee3 is in the stock.");
            }
            else
            {
                Console.WriteLine($"employee3 is in not the stock.");
            }

            //divider
            Console.WriteLine("----------------------------------------------");


            //creating a list type Employee
            List<Employee> ListEmployee = new List<Employee>();

            //Adding the objects in the list.
            ListEmployee.Add(employee1);
            ListEmployee.Add(employee2);
            ListEmployee.Add(employee3);
            ListEmployee.Add(employee4);
            ListEmployee.Add(employee5);

            //checking if the list contins employee2 and printing the answer with the contain method.
            if (ListEmployee.Contains(employee2))
            {
                Console.WriteLine($"employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine($"employee2 object does not exists in the list");
            }

            //divider
            Console.WriteLine("----------------------------------------------");

            //using find method to find the first "Male" on the list. putting it in a variable then printing it out.
            Employee found = ListEmployee.Find(find => find.Gender == "Male");
            Console.WriteLine(found);

            Console.WriteLine("----------------------------------------------");

            //using findAll method to find all "Male" on the list. putting it in a list because it contains several elements.
            List<Employee> alla = ListEmployee.FindAll(find => find.Gender == "Male");

            //printing it out all the found elements with a foreachloop
            foreach (Employee employee in alla)
            {
                Console.WriteLine(employee);
            }
        }         
    }
}