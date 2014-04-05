using Common;
using Ninject.Core;

namespace NinjectModule
{
    public class DistributedLoggingModule : StandardModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<IComponent>().To<Logger>();
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }    
}
