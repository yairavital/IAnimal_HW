﻿using System.Runtime.Serialization;

namespace EXceptionHW
{
    [Serializable]
    internal class CarNotInGarageException : Exception
    {
        public CarNotInGarageException()
        {
        }

        public CarNotInGarageException(string? message) : base(message)
        {
        }

        public CarNotInGarageException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}