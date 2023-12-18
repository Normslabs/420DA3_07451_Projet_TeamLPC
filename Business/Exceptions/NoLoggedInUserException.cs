using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Exceptions;
internal class NoLoggedInUserException : Exception {

    public NoLoggedInUserException(string message) : base(message) { }

}
