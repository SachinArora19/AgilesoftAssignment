using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;
namespace BusinessLayer
{
    public class deleteBusiness: IDeleteBusiness
    {
        IDelete _dataDelete;
        public deleteBusiness(IDelete Delete)
        {
            _dataDelete = Delete;
        }
        void IDeleteBusiness.deleteBook()
        {
            _dataDelete.deleteBook();
            Console.WriteLine("Kindly Enter the book name");
            string bookName = Console.ReadLine();
            bookName = char.ToUpper(bookName[0]) + bookName.Substring(1).ToLower();
            if (bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true) == null)
            {
                Console.WriteLine("Sorry book doesn't exist.");
            }
            else
            {
                int tempBookCategoryId = bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true).bookCategoryId;
                bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true).Active = false;
                bookAndCategoriesData.retcategories().Find(x => x.categoryId == tempBookCategoryId && x.Active == true).cntOfTaggedBooks--;
                Console.WriteLine("Book deleted successfully");
            }
        }
        void IDeleteBusiness.deleteCategory()
        {
            _dataDelete.deleteCategory();
            Console.WriteLine("Kindly Enter the category name");
            string categoryName = Console.ReadLine();
            categoryName = char.ToUpper(categoryName[0]) + categoryName.Substring(1).ToLower();
            if (bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryName && x.Active == true) == null)
            {
                Console.WriteLine("Sorry category doesn't exist.");
            }
            else
            {
                if (bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryName && x.Active == true && x.cntOfTaggedBooks != 0) != null)
                {
                    Console.WriteLine("Sorry category is tagged to few books and hence you can't delete the category.");
                }
                else
                {
                    bookAndCategoriesData.retcategories().Find(x => x.categoryName == categoryName && x.Active == true && x.cntOfTaggedBooks == 0).Active = false;
                    Console.WriteLine("Category deleted successfully");
                }
            }
        }
    }
}
