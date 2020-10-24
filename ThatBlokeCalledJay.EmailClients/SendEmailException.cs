using System;
using System.Runtime.Serialization;

namespace ThatBlokeCalledJay.EmailClients
{
    /// <summary>
    /// Email Exception
    /// </summary>
    public class SendEmailException : Exception
    {
        /// <inheritdoc />
        public SendEmailException()
        { }

        /// <inheritdoc />
        public SendEmailException(string message)
            : base(message)
        { }

        /// <inheritdoc />
        public SendEmailException(string message, Exception innerException)
            : base(message, innerException)
        { }

        /// <inheritdoc />
        protected SendEmailException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}