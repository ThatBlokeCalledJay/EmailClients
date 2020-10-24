namespace ThatBlokeCalledJay.EmailClients.Models
{
    /// <summary>
    ///
    /// </summary>
    public class EmailMessage
    {
        /// <summary>
        /// Recipient details.
        /// </summary>
        public EmailMessageAddress To { get; }

        /// <summary>
        /// Senders details.
        /// </summary>
        public EmailMessageAddress From { get; }

        /// <summary>
        /// Message Subject
        /// </summary>
        public string Subject { get; }

        /// <summary>Message plain text body content.</summary>
        public string PlainTextContent { get; }

        /// <summary>Message HTML body content.</summary>
        public string HtmlContent { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fromAddress"></param>
        /// <param name="fromName"></param>
        /// <param name="toAddress"></param>
        /// <param name="toName"></param>
        /// <param name="subject"></param>
        /// <param name="htmlContent"></param>
        /// <param name="plainTextContent"></param>
        public EmailMessage(string fromAddress, string fromName, string toAddress, string toName, string subject, string htmlContent, string plainTextContent)
        {
            Subject = subject;
            HtmlContent = htmlContent;
            PlainTextContent = plainTextContent;
            From = new EmailMessageAddress(fromAddress, fromName);
            To = new EmailMessageAddress(toAddress, toName);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="htmlContent"></param>
        /// <param name="plainTextContent"></param>
        public EmailMessage(EmailMessageAddress from, EmailMessageAddress to, string subject, string htmlContent, string plainTextContent)
        {
            Subject = subject;
            HtmlContent = htmlContent;
            PlainTextContent = plainTextContent;
            From = from;
            To = to;
        }
    }
}