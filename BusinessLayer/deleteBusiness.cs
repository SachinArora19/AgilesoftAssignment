using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;
namespace BusinessLayer
{
    public class deleteBusiness: IDeleteBusiness
    {
        IDelete _dataDelete;
        public deleteBusiness(IDelete Delete)
        {
            _dataDelete = Delete;
        }
        void IDeleteBusiness.deleteBook(List<books> book, List<categories> categories)
        {
            _dataDelete.deleteBook(book, categories);
        }
        void IDeleteBusiness.deleteCategory(List<categories> categories)
        {
            _dataDelete.deleteCategory(categories);
        }
    }
}
