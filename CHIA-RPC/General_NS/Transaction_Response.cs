using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Represents the response to a transaction server request in the Chia ecosystem.
    /// This class holds the information of a specific transaction, including the transaction details and its unique ID.
    /// </summary>
    /// <remarks>
    /// A 'Transaction_Response' is returned from the server when a request is made to retrieve details about a specific transaction.
    /// The transaction details are stored in a 'Transaction_DictMemos' object and the transaction's unique identifier is represented by a string.
    /// The transaction ID is a unique identifier that can be used to look up and verify the transaction in the Chia network.
    /// </remarks>
    public class Transaction_Response : ResponseTemplate<Transaction_Response>
    {
        /// <summary>
        /// The 'Transaction_DictMemos' object that contains the details of the transaction.
        /// This includes information such as the inputs, outputs, and other details of the transaction.
        /// 'Transaction_DictMemos' is a dictionary that maps transaction details to their respective memo data.
        /// </summary>
        public Transaction_DictMemos? transaction { get; set; }

        /// <summary>
        /// The unique identifier of the transaction.
        /// This is a string that is generated when the transaction is created and is used to uniquely identify the transaction in the Chia network.
        /// It can be used to look up the transaction, verify its existence, and check its status.
        /// </summary>
        public string? transaction_id { get; set; }
    }

}
