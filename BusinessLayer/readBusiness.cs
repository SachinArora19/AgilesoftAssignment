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
        public void findBook(List<books> book, List<categories> categories)
        {
            _dataRead.findBook(book,categories);
        }
    }
}
