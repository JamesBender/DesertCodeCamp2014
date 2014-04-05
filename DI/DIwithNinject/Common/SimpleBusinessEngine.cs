using System;

namespace Common
{
    public interface IBusinessEngine
    {
        string RunProcess();
    }

    public class SimpleBusinessEngine : IBusinessEngine
    {
        private readonly IComponent _component;

        public SimpleBusinessEngine(IComponent component)
        {
            _component = component;
        }

        public virtual string RunProcess()
        {
            var returnValue = string.Format("Transaction run, {0}", _component.Execute());
            Console.WriteLine(returnValue);
            return returnValue;
        }
    }    
}
