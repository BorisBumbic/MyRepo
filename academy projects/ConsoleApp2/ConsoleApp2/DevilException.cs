using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DevilException : Exception
    {
        public DevilException()
        {
           
        }

        public DevilException(int e)
            
        {
            if (e == 666)
                throw this;
        }

        public DevilException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    
}
