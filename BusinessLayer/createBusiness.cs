using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;
namespace BusinessLayer
{
    public class createBusiness:ICreateBusiness
    {
        ICreate _dataCreate;
        public createBusiness(ICreate Create)
        {
            _dataCreate = Create;
        }
        void ICreateBusiness.addBook(List<books> book, List<categories> categories)
        {
            _dataCreate.addBook(book, categories);
        }
        void ICreateBusiness.addCategory(List<categories> categories)
        {
            _dataCreate.addCategory(categories);
        }
    }
}
