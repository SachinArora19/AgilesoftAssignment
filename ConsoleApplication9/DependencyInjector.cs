﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using Unity.Extension;
namespace agilesoftAssignment
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();
        public static void Register<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }
        public static void InjectStub<I>(I instance)
        {
            UnityContainer.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        }
        public static void AddExtension<T>() where T : UnityContainerExtension
        {
            UnityContainer.AddNewExtension<T>();
        }
        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }
    }
}
