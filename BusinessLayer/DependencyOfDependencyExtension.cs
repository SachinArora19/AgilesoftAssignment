using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Unity;
using Unity.Extension;
namespace BusinessLayer
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IRead, Read>();
            Container.RegisterType<ICreate, Create>();
            Container.RegisterType<IUpdate, Update>();
            Container.RegisterType<IDelete, Delete>();
        }
    }
}
