using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;

namespace BusinessLayer
{
    public class readBusiness:IReadBusiness
    {
        IRead _dataRead;
        public readBusiness(IRead Read)
        {
            _dataRead = Read;
        }
        void IReadBusiness.findBook()
        {

            _dataRead.findBook();
            if (bookAndCategoriesData.retcategories().Any(x => x.categoryName == bookAndCategoriesData.searchElement && x.Active == true))
            {
                if (bookAndCategoriesData.retcategories().Any(x => x.categoryName == bookAndCategoriesData.searchElement && x.cntOfTaggedBooks != 0))
                {
                    int categoryIdTemp = bookAndCategoriesData.retcategories().Find(x => x.categoryName == bookAndCategoriesData.searchElement).categoryId;
                    if (bookAndCategoriesData.retBooks().Any(x => x.bookCategoryId == categoryIdTemp && x.Active == true))
                    {
                        Console.WriteLine("bookId       bookName");
                        foreach (var x in bookAndCategoriesData.retBooks().Where(x => x.bookCategoryId == categoryIdTemp && x.Active == true))
                        {
                            Console.WriteLine(x.bookId + "       " + x.bookName);
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
                if (bookAndCategoriesData.retBooks().Any(x => x.bookName == bookAndCategoriesData.searchElement && x.Active == true))
                {
                    Console.WriteLine("bookId       bookName");
                    foreach (var x in bookAndCategoriesData.retBooks().Where(x => x.bookName == bookAndCategoriesData.searchElement))
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
