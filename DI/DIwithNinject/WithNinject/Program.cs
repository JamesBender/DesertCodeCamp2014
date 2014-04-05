using System;
using Common;
using Ninject.Core;
using NinjectModule;

namespace WithNinject
{
    class Program
    {
        static void Main()
        {
            SimpleBusinessEngine simpleEngine;
            IKernel kernel;

            #region Example 1

            //kernel = new StandardKernel(new DistributedLoggingModule());

            //simpleEngine = kernel.Get<SimpleBusinessEngine>();
            //simpleEngine.RunProcess();

            #endregion

            #region Example 2

            //var connectedKernel =
            //    new StandardKernel(new ConditionalLoggingModule(true));
            //var disconnectedKernel = 
            //    new StandardKernel(new ConditionalLoggingModule(false));

            //simpleEngine = connectedKernel.Get<SimpleBusinessEngine>();
            //simpleEngine.RunProcess();
            //simpleEngine = disconnectedKernel.Get<SimpleBusinessEngine>();
            //simpleEngine.RunProcess();

            #endregion

            #region Example 3

            kernel = new StandardKernel(new DuplexLoggingModule());

            simpleEngine = kernel.Get<DoubleLoggingEngine>();
            simpleEngine.RunProcess();

            #endregion

            Console.ReadKey();
        }
    }
}
