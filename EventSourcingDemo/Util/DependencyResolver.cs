﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using EventSourcingDemo.Domain;
using EventSourcingDemo.Repository;
using EventSourcingDemo.Storage;

namespace EventSourcingDemo.Util
{
    public class DependencyResolver
    {
        private static IContainer Container { get; set; }

        public DependencyResolver()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            builder.RegisterType<InMemoryStorageProvider>().As<IEventStorageProvider>().SingleInstance();
            builder.RegisterType<Repository<Note>>().As<IRepository<Note>>().SingleInstance();
            Container = builder.Build();
        }

        public T ResolveDependecy<T>()
        {
                return Container.Resolve<T>();
        }
    }
}