using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using CommonObjects;
using BusinessLayer;

namespace agilesoftAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependency Injection --start
            Bootstrapper.Init();
            Initiator Initiator = DependencyInjector.Retrieve<Initiator>();
            //Dependency Injection --End

            //Console Menu --Start
            string inputVal = "";
            Console.WriteLine("Welcome to Library --- An assignment for Agilesoft by Sachin Arora");
            do
            {
                Console.WriteLine("\nEnter 1 if you want to search book or category");
                Console.WriteLine("Enter 2 if you want to add a book or a category");
                Console.WriteLine("Enter 3 if you want to update a book or a category");
                Console.WriteLine("Enter 4 if you want to delete a book or a category");
                Console.WriteLine("Enter 'E' or 'e' to exit");
                inputVal = Console.ReadLine();
                if (inputVal == "1")
                {

                    Initiator.Read();
                }
                else if (inputVal == "2")
                {
                    Console.WriteLine("Kindly enter 'b' if you want to add a book or 'c' if you want to add category");
                    string tempAdd = Console.ReadLine();
                    while ((tempAdd != "b") && (tempAdd != "c"))
                    {
                        Console.WriteLine("Kindly enter 'b' if you want to add a book or 'c' if you want to add category");
                        tempAdd = Console.ReadLine();
                    }
                    if ((tempAdd == "b"))
                    { Initiator.addBook(); }
                    else if ((tempAdd == "c"))
                    { Initiator.addCategory(); }
                }
                else if (inputVal == "3")
                { Initiator.updateBookCategory(); }
                else if (inputVal == "4")
                {
                    Console.WriteLine("Kindly enter 'b' if you want to delete a book or 'c' if you want to delete a category");
                    string tempDel = Console.ReadLine();
                    while ((tempDel != "b") && (tempDel != "c"))
                    {
                        Console.WriteLine("Kindly enter 'b' if you want to delete a book or 'c' if you want to delete category");
                        tempDel = Console.ReadLine();
                    }
                    if ((tempDel == "b"))
                    { Initiator.deleteBook(); }
                    else if ((tempDel == "c"))
                    { Initiator.deleteCategory(); }
                }
            }
            while (inputVal.ToLower() !="e");
            //Console Menu --End
        }
    }
}
