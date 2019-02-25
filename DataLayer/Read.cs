using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;

namespace DataLayer
{
    public class Read:IRead
    {
        public void findBook(List<books> book, List<categories> categories)
        {
            Console.WriteLine("Kindly enter the book or category name");
            string searchInput = Console.ReadLine();
            searchInput = char.ToUpper(searchInput[0]) + searchInput.Substring(1).ToLower();
            if (categories.Any(x => x.categoryName == searchInput && x.Active==true))
            {
                if (categories.Any(x => x.categoryName == searchInput && x.cntOfTaggedBooks != 0))
                {
                    int categoryIdTemp=categories.Find(x => x.categoryName == searchInput).categoryId;
                    if (book.Any(x => x.bookCategoryId == categoryIdTemp && x.Active==true))
                    {
                        Console.WriteLine("bookId       bookName");
                        foreach (var x in book.Where(x => x.bookCategoryId == categoryIdTemp && x.Active == true))
                        {
                            Console.WriteLine(x.bookId+ "       "+x.bookName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry no book exist");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry no book exist under the given category");
                }
            }
            else
            {
                if (book.Any(x => x.bookName == searchInput && x.Active==true))
                {
                    Console.WriteLine("bookId       bookName");
                    foreach (var x in book.Where(x => x.bookName == searchInput))
                    {
                        Console.WriteLine(x.bookId + "       " + x.bookName);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry no such book or category exist or database is empty");
                }
            }
        }
    }
}
