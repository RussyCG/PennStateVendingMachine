using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFramework.Exceptions
{
    public class InvalidRequestFormatException : Exception
    {
        public InvalidRequestFormatException()
        {
        }

        public InvalidRequestFormatException(string message) : base(message)
        {
        }

        public InvalidRequestFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidRequestFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
