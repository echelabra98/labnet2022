using System;

namespace TpN4.EF.Logic
{
    public class LogicException : Exception
    {
        public LogicException(string message) : base(message)
        {
        }
    }
}
