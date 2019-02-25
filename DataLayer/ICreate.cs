using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace DataLayer
{
    public interface ICreate
    {
        void addBook(List<books> book, List<categories> categories);
        void addCategory(List<categories> categories);
    }
}
