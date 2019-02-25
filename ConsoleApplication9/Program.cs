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
            List<books> book = new List<books>();
            List<categories> categories = new List<categories>();
            // Predefined data for validation added --Start
            books Temp = new books();
            Temp.bookId = 1;
            Temp.bookName = "A";
            Temp.bookCategoryId = 1;
            Temp.Active = true;
            book.Add(Temp);

            books Temp1 = new books();
            Temp1.bookId = 2;
            Temp1.bookName = "B";
            Temp1.bookCategoryId = 1;
            Temp1.Active = true;
            book.Add(Temp1);

            books Temp2 = new books();
            Temp2.bookId = 3;
            Temp2.bookName = "C";
            Temp2.bookCategoryId = 2;
            Temp2.Active = true;
            book.Add(Temp2);

            categories Temp3 = new categories();
            Temp3.categoryId = 1;
            Temp3.categoryName = "Fiction";
            Temp3.cntOfTaggedBooks = 2;
            Temp3.Active = true;
            categories.Add(Temp3);

            categories Temp4 = new categories();
            Temp4.categoryId = 2;
            Temp4.categoryName = "Nonfiction";
            Temp4.cntOfTaggedBooks = 1;
            Temp4.Active = true;
            categories.Add(Temp4);
            // Predefined data for validation added --End

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
                { Initiator.Read(book, categories); }
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
                    { Initiator.addBook(book, categories); }
                    else if ((tempAdd == "c"))
                    { Initiator.addCategory(categories); }
                }
                else if (inputVal == "3")
                { Initiator.updateBookCategory(book, categories); }
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
                    { Initiator.deleteBook(book, categories); }
                    else if ((tempDel == "c"))
                    { Initiator.deleteCategory(categories); }
                }
            }
            while (inputVal.ToLower() !="e");
            //Console Menu --End
        }
    }
}
