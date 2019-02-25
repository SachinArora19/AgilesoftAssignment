using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace BusinessLayer
{
    public interface IUpdateBusiness
    {
        void updateBookCategory(List<books> book, List<categories> categories);
    }
}
