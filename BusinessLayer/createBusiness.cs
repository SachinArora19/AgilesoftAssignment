using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;
namespace BusinessLayer
{
    public class createBusiness:ICreateBusiness
    {
        ICreate _dataCreate;
        public createBusiness(ICreate Create)
        {
            _dataCreate = Create;
        }
        void ICreateBusiness.addBook()
        {
            _dataCreate.addBook();
            books bookVal = new books();
            Console.WriteLine("Kindly Enter the book name");
            bookVal.bookName = Console.ReadLine();
            bookVal.bookName = char.ToUpper(bookVal.bookName[0]) + bookVal.bookName.Substring(1).ToLower();
            if (bookAndCategoriesData.retBooks().Find(x => x.bookName == bookVal.bookName && x.Active == true) != null)
            {
                Console.WriteLine("Sorry book already exist. You cannot add the same book");
            }
            else
            {
                Console.WriteLine("Kindly Enter the book category");
                string categoryTemp = Console.ReadLine();
                categoryTemp = char.ToUpper(categoryTemp[0]) + categoryTemp.Substring(1).ToLower();
                while (bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryTemp && x.Active == true) == null)
                {
                    Console.WriteLine("Kindly Enter the correct category");
                    categoryTemp = Console.ReadLine();
                    categoryTemp = char.ToUpper(categoryTemp[0]) + categoryTemp.Substring(1).ToLower();
                }
                if (bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryTemp && x.Active == true) != null)
                {
                    bookVal.bookCategoryId = bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryTemp && x.Active == true).categoryId;
                    bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryTemp && x.Active == true).cntOfTaggedBooks++;
                }
                bookVal.bookId = bookAndCategoriesData.retBooks().Max(x => x.bookId) + 1;
                bookVal.Active = true;
                bookAndCategoriesData.retBooks().Add(bookVal);
                Console.WriteLine("Book added successfully");
            }
        }
        void ICreateBusiness.addCategory()
        {
            _dataCreate.addCategory();
            categories categoriesVal = new categories();
            Console.WriteLine("Kindly Enter the category name");
            categoriesVal.categoryName = Console.ReadLine();
            categoriesVal.categoryName = char.ToUpper(categoriesVal.categoryName[0]) + categoriesVal.categoryName.Substring(1).ToLower();
            if (bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoriesVal.categoryName && x.Active == true) != null)
            {
                Console.WriteLine("Sorry category already exist. You cannot add the same category");
            }
            else
            {
                categoriesVal.Active = true;
                categoriesVal.cntOfTaggedBooks = 0;
                categoriesVal.categoryId = bookAndCategoriesData.retcategories().Max(x => x.categoryId) + 1;
                bookAndCategoriesData.retcategories().Add(categoriesVal);
                Console.WriteLine("Category added successfully");
            }
        }
    }
}
