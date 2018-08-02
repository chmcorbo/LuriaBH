using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clBasePOO.Exceptions
{
    public class ExMatriculaRepetida : Exception
    {
        public ExMatriculaRepetida(String pMessagem) : base(pMessagem)
        {

        }
    }
}
