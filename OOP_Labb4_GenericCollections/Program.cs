using System;
using System.Collections.Generic;

namespace OOP_Labb4_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar fem olika objekt av klassen "Employee"
            Employee claes = new Employee(101, "Claes", "Male", 11998);
            Employee shaoupa = new Employee(102, "Shaoupa", "Female", 70000);
            Employee krille = new Employee(103, "Krille", "Male", 31586);
            Employee linus = new Employee(104, "Linus", "Male", 23589);
            Employee alex = new Employee(105, "Alex", "Female", 203);

            //Skapar en stack och lägger in alla objekt i stacken med hjälp av "push" metoden
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(claes);
            employeeStack.Push(shaoupa);
            employeeStack.Push(krille);
            employeeStack.Push(linus);
            employeeStack.Push(alex);


            //Skriver ut alla objekt i stacken med en foreachloop
            Console.Write("\n\tRetriveing from stack\n\t");
            foreach (Employee employee in employeeStack)
            {
                Console.Write($"\n\tItems left in stack {employeeStack.Count}" +
                    $"\n\t------------------------------" +
                    $"\n\tid: {employee._id} - {employee._name} - {employee._gender} - {employee._salary}" +
                    $"\n\t------------------------------\n\t");
            }
            Console.ReadLine();
            Console.Clear();


            //Skriver ut alla objekt med hjälp av "Pop" metoden
            //Dessa objekt försvinner också från stacken då "Pop" tar ut dom
            Console.Write("\n\tRetriveing from stack using pop method\n\t");
            while (employeeStack.Count > 0)
            {
                Console.Write($"\n\tItems left in stack {employeeStack.Count}" +
                    $"\n\t------------------------------" +
                    $"\n\t{employeeStack.Pop()}" +
                    $"\n\t------------------------------\n\t");
            }
            Console.ReadLine();
            Console.Clear();


            //Lägger in objekten i stacken igen
            employeeStack.Push(claes);
            employeeStack.Push(shaoupa);
            employeeStack.Push(krille);
            employeeStack.Push(linus);
            employeeStack.Push(alex);

            //Skriver ut det översta objektet i stacken två gånger
            //då "Peek" metoden bara kan skriva ut det översta objektet i stacken
            //Kollar även om id nummer 3 ligger i stacken
            Console.Write("\n\tRetriveing from stack using peek method\n\t");
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    if (employeeStack.Contains(krille) == true)
                    {
                        Console.Write("\n\tid nummer 3 ligger i stacken");
                        continue;
                    }
                    else
                    {
                        Console.Write("\n\tid nummer 3 ligger inte i stacken");
                        continue;
                    }
                }
                Console.Write($"\n\tItems left in stack {employeeStack.Count}" +
                    $"\n\t------------------------------" +
                    $"\n\t{employeeStack.Peek()}" +
                    $"\n\t------------------------------\n\t");
            }
            Console.ReadLine();
            Console.Clear();


            //Skapar en lista av "Employee" och lägger alla objekt i listan 
            //med hjälp av "Add" metoden
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(claes);
            employeeList.Add(shaoupa);
            employeeList.Add(krille);
            employeeList.Add(linus);
            employeeList.Add(alex);

            //Kollar om id 2 ligger i listan
            if (employeeList.Contains(shaoupa) == true)
            {
                Console.Write($"\n\tid nummer 2 ligger i stacken");
            }
            else
            {
                Console.Write($"\n\tid nummer 2 ligger inte i stacken");
            }
            Console.ReadLine();
            Console.Clear();


            //Skriver ut första användaren som är "Male"
            Console.Write($"\n\tDen första användaren i listan som är 'Male' är " +
                $"{employeeList.Find(item => item._gender == "Male")._name} han har id " +
                $"{employeeList.Find(item => item._gender == "Male")._id}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();


            //Skriver ut alla objekt som är "Male"
            Console.Write($"\n\tAnvändarna som är 'Male' är ");
            foreach (Employee employee in employeeList.FindAll(item => item._gender == "Male"))
            {
                Console.Write($"\n\t{employee._name}, id {employee._id}");
            }
            Console.ReadLine();
        }
    }
}
