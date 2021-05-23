using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message="Object not found!") : base(message)
        {

        }
    }
}
