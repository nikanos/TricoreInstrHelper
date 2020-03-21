using System;
using System.Runtime.Serialization;

namespace TricoreInstrHelperLib
{
    [Serializable]
    public class InvalidOffsetException : Exception
    {
        public InvalidOffsetException()
        {
        }

        public InvalidOffsetException(string message) : base(message)
        {
        }

        public InvalidOffsetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOffsetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}