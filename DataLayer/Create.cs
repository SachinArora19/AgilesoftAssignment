using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;

namespace DataLayer
{
    public class Create:ICreate
    {
        void ICreate.addBook(List<books> book, List<categories> categories)
        {
            books bookVal = new books();
            Console.WriteLine("Kindly Enter the book name");
            bookVal.bookName = Console.ReadLine();
            bookVal.bookName = char.ToUpper(bookVal.bookName[0]) + bookVal.bookName.Substring(1).ToLower();
            if (book.Find(x => x.bookName == bookVal.bookName && x.Active == true) != null)
            {
                Console.WriteLine("Sorry book already exist. You cannot add the same book");
            }
            else
            {
                Console.WriteLine("Kindly Enter the book category");
                string categoryTemp = Console.ReadLine();
                categoryTemp = char.ToUpper(categoryTemp[0]) + categoryTemp.Substring(1).ToLower();
                while (categories.Find(x => x.categoryName == categoryTemp && x.Active == true) == null)
                {
                    Console.WriteLine("Kindly Enter the correct category");
                    categoryTemp = Console.ReadLine();
                    categoryTemp = char.ToUpper(categoryTemp[0]) + categoryTemp.Substring(1).ToLower();
                }
                if (categories.Find(x => x.categoryName == categoryTemp && x.Active == true) != null)
                {
                    bookVal.bookCategoryId = categories.Find(x => x.categoryName == categoryTemp && x.Active == true).categoryId;
                    categories.Find(x => x.categoryName == categoryTemp && x.Active == true).cntOfTaggedBooks++;
                }
                bookVal.bookId = book.Max(x => x.bookId) + 1;
                bookVal.Active = true;
                book.Add(bookVal);
                Console.WriteLine("Book added successfully");
            }
        }
        void ICreate.addCategory(List<categories> categories)
        {
            categories categoriesVal = new categories();
            Console.WriteLine("Kindly Enter the category name");
            categoriesVal.categoryName = Console.ReadLine();
            categoriesVal.categoryName = char.ToUpper(categoriesVal.categoryName[0]) + categoriesVal.categoryName.Substring(1).ToLower();
            if (categories.Find(x => x.categoryName == categoriesVal.categoryName && x.Active == true) != null)
            {
                Console.WriteLine("Sorry category already exist. You cannot add the same category");
            }
            else
            { 
                categoriesVal.Active = true;
                categoriesVal.cntOfTaggedBooks = 0;
                categoriesVal.categoryId = categories.Max(x => x.categoryId) + 1;
                categories.Add(categoriesVal);
                Console.WriteLine("Category added successfully");
            }
        }
    }
}
