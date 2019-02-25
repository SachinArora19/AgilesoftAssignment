using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
using DataLayer;

namespace BusinessLayer
{
    public class updateBusiness: IUpdateBusiness
    {
        IUpdate _dataUpdate;
        public updateBusiness(IUpdate Update)
        {
            _dataUpdate = Update;
        }
        void IUpdateBusiness.updateBookCategory(List<books> book, List<categories> categories)
        {
            _dataUpdate.updateBookCategory(book, categories);
        }
    }
}
