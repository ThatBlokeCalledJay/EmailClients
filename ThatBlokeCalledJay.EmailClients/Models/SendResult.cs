namespace ThatBlokeCalledJay.EmailClients.Models
{
    /// <summary></summary>
    public class SendResult
    {
        /// <summary>
        /// Indicates whether the operation was successful or not.
        /// </summary>
        public bool Success { get; }

        /// <summary>
        /// Result message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Instantiate a new instance of <see cref="SendResult"/>.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public SendResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}