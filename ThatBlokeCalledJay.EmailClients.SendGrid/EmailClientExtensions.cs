using System.Net;

namespace ThatBlokeCalledJay.EmailClients.SendGrid
{
    internal static class EmailClientExtensions
    {
        internal static bool IsSuccessStatusCode(this HttpStatusCode statusCode)
        {
            return ((int)statusCode >= 200 & (int)statusCode <= 300);
        }
    }
}