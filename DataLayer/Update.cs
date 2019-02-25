using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace DataLayer
{
    public class Update: IUpdate
    {
        void IUpdate.updateBookCategory(List<books> book, List<categories> categories)
        {
            Console.WriteLine("Kindly Enter the book name");
            string bookName = Console.ReadLine();
            bookName = char.ToUpper(bookName[0]) + bookName.Substring(1).ToLower();
            if (book.Find(x => x.bookName == bookName && x.Active == true) != null)
            {
                Console.WriteLine("Kindly Enter the book category");
                string tempNewCategory = Console.ReadLine();
                tempNewCategory = char.ToUpper(tempNewCategory[0]) + tempNewCategory.Substring(1).ToLower();
                int tempBookOlderCategoryId = book.Find(x => x.bookName == bookName && x.Active == true).bookCategoryId;
                if (categories.Find(x => x.categoryName == tempNewCategory && x.Active == true) != null)
                {
                    categories.Find(x => x.categoryId == tempBookOlderCategoryId && x.Active == true).cntOfTaggedBooks--;
                    categories.Find(x => x.categoryName == tempNewCategory && x.Active == true).cntOfTaggedBooks++;
                    book.Find(x => x.bookName == bookName && x.Active == true).bookCategoryId = categories.Find(x => x.categoryName == tempNewCategory && x.Active == true).categoryId;
                    Console.WriteLine("Book updated successfully");
                }
                else
                {
                    Console.WriteLine("Sorry no such category exist");
                }
            }
            else
            {
                Console.WriteLine("Sorry no such book exist");
            }
        }
    }
}
