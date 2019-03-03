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
        public bool loadFirstFlag=false;
        public void predefinedDataLoad()
        {
            // Predefined Data -- Think of it like it is coming from DB Start
            books Temp = new books();
            Temp.bookId = 1;
            Temp.bookName = "A";
            Temp.bookCategoryId = 1;
            Temp.Active = true;

            bookAndCategoriesData.retBooks().Add(Temp);

            books Temp1 = new books();
            Temp1.bookId = 2;
            Temp1.bookName = "B";
            Temp1.bookCategoryId = 1;
            Temp1.Active = true;
            bookAndCategoriesData.retBooks().Add(Temp1);

            books Temp2 = new books();
            Temp2.bookId = 3;
            Temp2.bookName = "C";
            Temp2.bookCategoryId = 2;
            Temp2.Active = true;
            bookAndCategoriesData.retBooks().Add(Temp2);

            categories Temp3 = new categories();
            Temp3.categoryId = 1;
            Temp3.categoryName = "Fiction";
            Temp3.cntOfTaggedBooks = 2;
            Temp3.Active = true;
            bookAndCategoriesData.retcategories().Add(Temp3);

            categories Temp4 = new categories();
            Temp4.categoryId = 2;
            Temp4.categoryName = "Nonfiction";
            Temp4.cntOfTaggedBooks = 1;
            Temp4.Active = true;
            bookAndCategoriesData.retcategories().Add(Temp4);
            // Predefined Data -- Think of it like it is coming from DB End
        }
        public void findBook()
        {

            Console.WriteLine("Kindly enter the book or category name");
            string searchInput = Console.ReadLine();
            searchInput = char.ToUpper(searchInput[0]) + searchInput.Substring(1).ToLower();
            if (!this.loadFirstFlag)
            {
                predefinedDataLoad();
                this.loadFirstFlag = true;
            }
            bookAndCategoriesData.searchElement = searchInput;
        }
    }
}
