using System;
using Common;
using Ninject.Conditions;
using Ninject.Core;

namespace NinjectModule
{
    public class DuplexLoggingModule : StandardModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<DoubleLoggingEngine>().ToSelf();
            
            Bind<IComponent>().To<OffLineLoggingComponent>();

            Bind<IComponent>().To<SpecialLoggingComponent>().
                Only(When.Context.Target
                .HasAttribute<SpecialLogger>());
        }
    }
}