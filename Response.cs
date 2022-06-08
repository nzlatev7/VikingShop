using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VikingShop
{
    public class Response
    {
        public Response(bool isValid, string error)
        {
            IsValid = isValid;
            Error = error;
        }

        public bool IsValid { get; set; }

        public string Error { get; set; }
    }
}
