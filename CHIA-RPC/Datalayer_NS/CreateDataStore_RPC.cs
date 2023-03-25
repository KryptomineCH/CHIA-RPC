using CHIA_RPC.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// creates a new datastore
    /// </summary>
    /// <remarks>
    /// request requires a <see cref="CreateDataStore_RPC"/><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/>
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
        public Datalayer_Transaction[] txs { get; set; }
    }
    /// <summary>
    /// Create a data store. Triggers a Chia transaction
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/></remarks>
    /// <returns><see cref="CreateDataStore_Response"/></returns>
    public class CreateDataStore_RPC : RPCTemplate<CreateDataStore_RPC>
    {
        /// <summary>
        /// the optional fee of the blockchain
        /// </summary>
        /// <remarks>defaults to 1000000000</remarks>
        [JsonConverter(typeof(StringToUlongNullableConverter))]
        public ulong? fee { get; set; }
    }
}
