using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// creates a new datastore
    /// </summary>
    /// <remarks>
    /// can be validated with chia wallets show
    /// </remarks>
    public class CreateDataStore_Response : ResponseTemplate<CreateDataStore_Response>
    {
        /// <summary>
        /// The created Data Store ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// the transactions for the datastore creation
        /// </summary>
        public Transaction[] txs { get; set; }
    }
    /// <summary>
    /// Create a data store. Triggers a Chia transaction
    /// </summary>
    public class CreateDataStore_RPC : RPCTemplate<CreateDataStore_RPC>
    {
        /// <summary>
        /// the optional fee of the blockchain
        /// </summary>
        /// <remarks>defaults to 1000000000</remarks>
        public ulong? fee { get; set; }
    }
}
