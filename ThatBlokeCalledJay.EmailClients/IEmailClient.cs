using System.Threading;
using System.Threading.Tasks;
using ThatBlokeCalledJay.EmailClients.Models;

namespace ThatBlokeCalledJay.EmailClients
{
    /// <summary>
    ///
    /// </summary>
    public interface IEmailClient
    {
        /// <summary>
        /// Send email message asynchronously.
        /// </summary>
        /// <param name="emailMessage"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SendResult> SendEmailAsync(EmailMessage emailMessage, CancellationToken cancellationToken = default);
    }
}