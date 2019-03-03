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
        public void Read()
        {
            _businessClass.findBook();
        }
        public void addBook()
        {
            _createBusiness.addBook();
        }
        public void addCategory()
        {
            _createBusiness.addCategory();
        }
        public void updateBookCategory()
        {
            _updateBusiness.updateBookCategory();
        }
        public void deleteBook()
        {
            _deleteBusiness.deleteBook();
        }
        public void deleteCategory()
        {
            _deleteBusiness.deleteCategory();
        }
    }
}
