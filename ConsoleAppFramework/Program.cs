using ConsoleAppFramework.Controller;
using System;

namespace ConsoleAppFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.GetAll\n2.Created\n3.Edit4.Delete\n5.Filter");
            Console.Write("Enter number :");
            int number = int.Parse(Console.ReadLine());
            EmployeeController emp = new EmployeeController();
            switch (number)
            {
                case 1:
                    emp.GetAll();
                    break;
                case 2:
                    Console.Write("Enter fullname: ");
                    string fullname = Console.ReadLine();
                    emp.Created(fullname);
                    break;
                case 3:
                    Console.Write("Enter fullname: ");
                    string fullName = Console.ReadLine();
                    Console.Write("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    emp.Edit(id, fullName);
                    break;
                case 4:
                    Console.Write("Enter ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    emp.Delete(ID);
                    break;
                case 5:
                    Console.Write("Enter search: ");
                    string search = Console.ReadLine();
                    emp.Filter(search);
                    break;
                default:
                    Console.WriteLine("Duzgun regem daxil edin");
                    break;
            }


        }
    }
}
