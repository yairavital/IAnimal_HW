using System.Runtime.Serialization;

namespace EXceptionHW
{
    [Serializable]
    internal class WrongGargeException : Exception
    {
        public WrongGargeException()
        {
        }

        public WrongGargeException(string? message) : base(message)
        {
        }

        public WrongGargeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WrongGargeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}