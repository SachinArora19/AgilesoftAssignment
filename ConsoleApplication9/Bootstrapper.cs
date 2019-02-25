using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
namespace agilesoftAssignment
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IReadBusiness, readBusiness>();
            DependencyInjector.Register<ICreateBusiness, createBusiness>();
            DependencyInjector.Register<IUpdateBusiness, updateBusiness>();
            DependencyInjector.Register<IDeleteBusiness, deleteBusiness>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
