namespace Labb8MorganWestin
{
    using System;
    using System.Collections.Generic;

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Skapa en Stack och lägg till objekt
            Stack<Employee> employeeStack = new Stack<Employee>();

            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 50000 + i * 10000
                };

                employeeStack.Push(employee);
            }

            // Skriv ut alla objekt i stacken
            Console.WriteLine("Alla objekt i stacken:");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
            }

            // Hämta alla objekt med Pop-metoden
            Console.WriteLine("\nHämta alla objekt med Pop-metoden:");
            while (employeeStack.Count > 0)
            {
                Employee poppedEmployee = employeeStack.Pop();
                Console.WriteLine($"Popped: Id: {poppedEmployee.Id}, Name: {poppedEmployee.Name}, Gender: {poppedEmployee.Gender}, Salary: {poppedEmployee.Salary}");
                Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
            }

            // Lägg till alla objekt igen genom Push-metoden
            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 50000 + i * 10000
                };

                employeeStack.Push(employee);
            }

            // Hämta objekt med Peek-metoden
            Console.WriteLine("\nHämta två objekt med Peek-metoden:");
            for (int i = 0; i < 2; i++)
            {
                Employee peekedEmployee = employeeStack.Peek();
                Console.WriteLine($"Peeked: Id: {peekedEmployee.Id}, Name: {peekedEmployee.Name}, Gender: {peekedEmployee.Gender}, Salary: {peekedEmployee.Salary}");
                Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
                employeeStack.Pop(); // Pop för att gå vidare till nästa objekt
            }

            // Kolla om objekt nummer 3 finns i stacken
            Employee employeeToCheck = employeeStack.SingleOrDefault(e => e.Id == 3);
            if (employeeToCheck != null)
            {
                Console.WriteLine($"\nObjekt nummer 3 finns i stacken. Id: {employeeToCheck.Id}");
            }
            else
            {
                Console.WriteLine("\nObjekt nummer 3 finns inte i stacken.");
            }
        }
    }
}