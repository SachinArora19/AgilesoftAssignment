using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;

namespace BusinessLayer
{
    public class updateBusiness: IUpdateBusiness
    {
        IUpdate _dataUpdate;
        public updateBusiness(IUpdate Update)
        {
            _dataUpdate = Update;
        }
        void IUpdateBusiness.updateBookCategory()
        {
            _dataUpdate.updateBookCategory();
            Console.WriteLine("Kindly Enter the book name");
            string bookName = Console.ReadLine();
            bookName = char.ToUpper(bookName[0]) + bookName.Substring(1).ToLower();
            if (bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true) != null)
            {
                Console.WriteLine("Kindly Enter the book category");
                string tempNewCategory = Console.ReadLine();
                tempNewCategory = char.ToUpper(tempNewCategory[0]) + tempNewCategory.Substring(1).ToLower();
                int tempBookOlderCategoryId = bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true).bookCategoryId;
                if (bookAndCategoriesData.retcategories().Find(x => x.categoryName == tempNewCategory && x.Active == true) != null)
                {
                    bookAndCategoriesData.retcategories().Find(x => x.categoryId == tempBookOlderCategoryId && x.Active == true).cntOfTaggedBooks--;
                    bookAndCategoriesData.retcategories().Find(x => x.categoryName == tempNewCategory && x.Active == true).cntOfTaggedBooks++;
                    bookAndCategoriesData.retBooks().Find(x => x.bookName == bookName && x.Active == true).bookCategoryId = bookAndCategoriesData.retcategories().Find(x => x.categoryName == tempNewCategory && x.Active == true).categoryId;
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
