using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObjects;
namespace BusinessLayer
{
    public interface IReadBusiness
    {
        void findBook(List<books> book, List<categories> categories);
    }
}
