using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFramework.Exceptions
{
    public class InvalidSessionException : Exception
    {
        public InvalidSessionException()
        {
        }

        public InvalidSessionException(string message) : base(message)
        {
        }

        public InvalidSessionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSessionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
