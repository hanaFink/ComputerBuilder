using System;
using System.Runtime.Serialization;

namespace BuildComp
{
    [Serializable]
    internal class CompDidNotDoneYet : Exception
    {
        public CompDidNotDoneYet()
        {
        }

        public CompDidNotDoneYet(string message) : base(message)
        {
        }

        public CompDidNotDoneYet(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CompDidNotDoneYet(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}