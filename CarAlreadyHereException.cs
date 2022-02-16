﻿using System.Runtime.Serialization;

namespace EXceptionHW
{
    [Serializable]
    internal class CarAlreadyHereException : Exception
    {
        public CarAlreadyHereException()
        {
        }

        public CarAlreadyHereException(string? message) : base(message)
        {
        }

        public CarAlreadyHereException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}