using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using CommonObjects;
namespace agilesoftAssignment
{
    public class Initiator
    {
        IReadBusiness _businessClass;
        ICreateBusiness _createBusiness;
        IUpdateBusiness _updateBusiness;
        IDeleteBusiness _deleteBusiness;
        public Initiator(IReadBusiness ReadBusiness, ICreateBusiness createBusiness,IUpdateBusiness updateBusiness, IDeleteBusiness deleteBusiness)
        {
            _businessClass = ReadBusiness;
            _createBusiness = createBusiness;
            _updateBusiness = updateBusiness;
            _deleteBusiness = deleteBusiness;
        }
        public void Read(List<books> book, List<categories> categories)
        {
            _businessClass.findBook(book, categories);
        }
        public void addBook(List<books> book, List<categories> categories)
        {
            _createBusiness.addBook(book, categories);
        }
        public void addCategory(List<categories> categories)
        {
            _createBusiness.addCategory(categories);
        }
        public void updateBookCategory(List<books> book, List<categories> categories)
        {
            _updateBusiness.updateBookCategory(book, categories);
        }
        public void deleteBook(List<books> book, List<categories> categories)
        {
            _deleteBusiness.deleteBook(book, categories);
        }
        public void deleteCategory(List<categories> categories)
        {
            _deleteBusiness.deleteCategory(categories);
        }
    }
}
