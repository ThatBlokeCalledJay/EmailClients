namespace ThatBlokeCalledJay.EmailClients.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailMessageAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="name"></param>
        public EmailMessageAddress(string emailAddress, string name)
        {
            EmailAddress = emailAddress;
            Name = name;
        }
    }
}