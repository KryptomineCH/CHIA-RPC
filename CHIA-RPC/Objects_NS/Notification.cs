using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// A Notification object is used to convey information from the application to the user. 
    /// This information could be related to updates on the state of the application, or critical notifications, like alerts about transactions.
    /// </summary>
    /// <remarks>
    /// For example, a notification could be generated when a transaction occurs, and it could contain information like the transaction amount, the involved parties, and the time of the transaction. 
    /// The notification system can help users keep track of important events or changes in the state of their applications.
    /// </remarks>
    public class Notification : ObjectTemplate<Notification>
    {
        /// <summary>
        /// The amount value associated with this notification, denoted in mojos. 
        /// Mojos are the smallest unit in the Chia network where 1 chia (XCH) is equal to 1,000,000,000,000 mojos. 
        /// This can represent things like transaction amount in a payment notification.
        /// </summary>
        public ulong? amount { get; set; }

        /// <summary>
        /// The amount value associated with this notification, denoted in XCH (Chia's native currency).
        /// </summary>
        /// <remarks>
        /// This value is derived from the mojos amount and provides a more user-friendly representation of the amount. 
        /// It's not included in the JSON representation of the object as it's derived from the mojos amount.
        /// </remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// Unique identifier for this notification. This could be used for managing and tracking notifications.
        /// </summary>
        public string? id { get; set; }

        /// <summary>
        /// The main content of the notification. This could contain any message that needs to be conveyed to the user.
        /// </summary>
        public string? message { get; set; }
    }

}
