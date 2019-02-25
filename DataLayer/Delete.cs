using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace DataLayer
{
    public class Delete: IDelete
    {
        void IDelete.deleteBook(List<books> book, List<categories> categories)
        {
            Console.WriteLine("Kindly Enter the book name");
            string bookName = Console.ReadLine();
            bookName = char.ToUpper(bookName[0]) + bookName.Substring(1).ToLower();
            if (book.Find(x => x.bookName == bookName && x.Active == true) == null)
            {
                Console.WriteLine("Sorry book doesn't exist.");
            }
            else
            {
                int tempBookCategoryId = book.Find(x => x.bookName == bookName && x.Active == true).bookCategoryId;
                book.Find(x => x.bookName == bookName && x.Active == true).Active = false;
                categories.Find(x => x.categoryId == tempBookCategoryId && x.Active == true).cntOfTaggedBooks--;
                Console.WriteLine("Book deleted successfully");
            }
        }
        void IDelete.deleteCategory(List<categories> categories)
        {
            Console.WriteLine("Kindly Enter the category name");
            string categoryName = Console.ReadLine();
            categoryName = char.ToUpper(categoryName[0]) + categoryName.Substring(1).ToLower();
            if(categories.Find(x=>x.categoryName==categoryName && x.Active==true)==null)
            {
                Console.WriteLine("Sorry category doesn't exist.");
            }
            else
            {
                if (categories.Find(x => x.categoryName == categoryName && x.Active == true && x.cntOfTaggedBooks!=0) != null)
                {
                    Console.WriteLine("Sorry category is tagged to few books and hence you can't delete the category.");
                }
                else
                {
                    categories.Find(x => x.categoryName == categoryName && x.Active == true && x.cntOfTaggedBooks == 0).Active = false;
                    Console.WriteLine("Category deleted successfully");
                }
            }
        }
    }
}
