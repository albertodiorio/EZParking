using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.Validations
{
    public sealed class ValidationDomain(string error) : Exception(error)
    {
        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new ValidationDomain(error);
        }
    }
}
