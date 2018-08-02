using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petronas.Exceptions
{
    public class ExConnectionError : Exception
    {
        public ExConnectionError (String pMessage) : base(pMessage)
        {

        }
    }
}
