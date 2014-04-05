using System;
using Ninject.Core;

namespace Common
{
    public class DoubleLoggingEngine : SimpleBusinessEngine
    {
        public DoubleLoggingEngine(IComponent primaryLogger) : base(primaryLogger)
        {
        }

        [Inject, SpecialLogger]
        public IComponent SecondLogger { get; set; }

        public override string RunProcess()
        {
            base.RunProcess();
            var returnValue = 
                string.Format("Baking a | {0} | in the second oven.", SecondLogger.Execute());
            Console.WriteLine(returnValue);
            return returnValue;
        }
    }
}