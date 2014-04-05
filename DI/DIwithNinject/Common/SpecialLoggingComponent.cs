using System;

namespace Common
{
    public class SpecialLoggingComponent : IComponent
    {
        public string Execute()
        {
            return "special log";
        }
    }
}