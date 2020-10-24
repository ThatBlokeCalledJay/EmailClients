using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading;
using System.Threading.Tasks;
using ThatBlokeCalledJay.EmailClients.Models;

namespace ThatBlokeCalledJay.EmailClients.SendGrid
{
    /// <summary>
    ///
    /// </summary>
    public class SendGridEmailClient : IEmailClient
    {
        private readonly SendGridClient _sendGridClient;

        /// <summary>
        ///
        /// </summary>
        /// <param name="options"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendGridEmailClient(SendGridOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (string.IsNullOrWhiteSpace(options.ApiKey))
                throw new ArgumentNullException(nameof(options.ApiKey), "SendGrid ApiKey cannot be null or empty.");

            _sendGridClient = new SendGridClient(options.ApiKey);
        }

        /// <summary>
        /// Make a request to send an email through Twilio SendGrid asynchronously.
        /// </summary>
        /// <param name="emailMessage">A SendGridMessage object with the details for the request.</param>
        /// <param name="cancellationToken">Cancel the asynchronous call.</param>
        /// <returns>A Response object.</returns>
        public async Task<SendResult> SendEmailAsync(EmailMessage emailMessage, CancellationToken cancellationToken = default)
        {
            var subject = emailMessage.Subject;
            var from = new EmailAddress(emailMessage.From.EmailAddress, emailMessage.From.Name);
            var to = new EmailAddress(emailMessage.To.EmailAddress, emailMessage.To.Name);

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailMessage.PlainTextContent, emailMessage.HtmlContent);

            try
            {
                var response = await _sendGridClient.SendEmailAsync(sendGridMessage, cancellationToken);

                var success = response.StatusCode.IsSuccessStatusCode();

                var message = response.StatusCode.IsSuccessStatusCode()
                    ? "OK"
                    : $"SendGrid response indicates failure: {(int)response.StatusCode} {response.StatusCode}.";

                var result = new SendResult(success, message);

                return result;
            }
            catch (Exception e)
            {
                throw new SendEmailException("SendGrid SendEmail unexpected exception.", e);
            }
        }
    }
}