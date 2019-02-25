using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonObjects;
using DataLayer;
using System.Collections.Generic;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<books> book_ip = new List<books>();
            List<categories> categories_ip = new List<categories>();
            books Temp = new books();
            Temp.bookId = 1;
            Temp.bookName = "A";
            Temp.bookCategoryId = 1;
            Temp.Active = true;
            book_ip.Add(Temp);

            books Temp1 = new books();
            Temp1.bookId = 2;
            Temp1.bookName = "B";
            Temp1.bookCategoryId = 1;
            Temp1.Active = true;
            book_ip.Add(Temp1);

            books Temp2 = new books();
            Temp2.bookId = 3;
            Temp2.bookName = "C";
            Temp2.bookCategoryId = 2;
            Temp2.Active = true;
            book_ip.Add(Temp2);

            categories Temp3 = new categories();
            Temp3.categoryId = 1;
            Temp3.categoryName = "Fiction";
            Temp3.cntOfTaggedBooks = 2;
            Temp3.Active = true;
            categories_ip.Add(Temp3);

            categories Temp4 = new categories();
            Temp4.categoryId = 2;
            Temp4.categoryName = "Nonfiction";
            Temp4.cntOfTaggedBooks = 1;
            Temp4.Active = true;
            categories_ip.Add(Temp4);
            
            //Read.findBook(book_ip, categories_ip);
        }
    }
}
