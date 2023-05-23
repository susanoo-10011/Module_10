using System;

namespace Task_2
{
    public class IncorrectDataException : Exception
    {
        public IncorrectDataException(string meccage) : base(meccage)
        {
        
        }
    }
}
