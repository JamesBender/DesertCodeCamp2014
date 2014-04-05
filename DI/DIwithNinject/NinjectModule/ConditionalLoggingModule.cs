using Common;
using Ninject.Core;
using Ninject.Core.Activation;
using Ninject.Core.Creation;

namespace NinjectModule
{
    public class ConditionalLoggingModule : StandardModule
    {
        private readonly bool _isConnected;

        public ConditionalLoggingModule(bool isConnected)
        {
            _isConnected = isConnected;
        }

        public override void Load()
        {
            Bind<ILoggingSink>().To<NormalLoggingSync>();
            
            if (_isConnected)
            {
                Bind<IComponent>().To<Logger>();
            }
            else
            {
                Bind<IComponent>().ToProvider<OfflineLoggingCompoentProvider>();
            }
            
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }

    public class OfflineLoggingCompoentProvider : SimpleProvider<OffLineLoggingComponent>
    {
        protected override OffLineLoggingComponent CreateInstance(IContext context)
        {
            return new OffLineLoggingComponent();
        }
    }
}