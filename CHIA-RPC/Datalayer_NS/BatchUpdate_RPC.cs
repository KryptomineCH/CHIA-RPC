using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// update a data store by adding or removing a value. Triggers a Chia transaction
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item>The entire list must be formatted as a JSON array</item>
    ///     <item>There are two actions allowed: insert and delete</item>
    ///     <item>insert requires key and value flags</item>
    ///     <item>delete requires a key flag only</item>
    ///     <item>Keys and values must be written in hex format. Values can be derived from text or binary.</item>
    ///     <item>Multiple inserts and deletes are allowed</item>
    ///     <item>an existing key cannot be overridden. it needs to be removed and then added with new value</item>
    ///     <item>The size of a single value flag is limited to 100 MiB. However, adding anything close to that size has not been tested and could produce unexpected results</item>
    /// </list><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc#batch_update"/>
    /// </remarks>
    /// <returns><see cref="General_NS.TxID_Response"/></returns>
    public class BatchUpdate_RPC : RPCTemplate<BatchUpdate_RPC>
    {
        /// <summary>
        /// The hexadecimal store ID
        /// </summary>
        public string id { set; get; }
        /// <summary>
        /// the changes which should be applied to the datastore
        /// </summary>
        public DataStoreChange[] changelist { get; set; }
        /// <summary>
        /// Set the fee for the transaction, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }
}
