using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObjects
{
    public sealed class bookAndCategoriesData
    {
        private static List<books> bookList = new List<books>();
        private static List<categories> categoriesList = new List<categories>();
        private bookAndCategoriesData() { }
        public static List<books> retBooks()
        {
            return bookList;
        }
        public static List<categories> retcategories()
        {
            return categoriesList;
        }

        public static string searchElement { get; set; }
    }
}
