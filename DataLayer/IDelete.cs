using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace DataLayer
{
    public interface IDelete
    {
        void deleteBook(List<books> book, List<categories> categories);
        void deleteCategory(List<categories> categories);
    }
}
