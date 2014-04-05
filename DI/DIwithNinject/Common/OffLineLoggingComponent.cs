using System;

namespace Common
{
    public class OffLineLoggingComponent : IComponent
    {
        public string Execute()
        {
            return "logged off line.";
        }
    }
}