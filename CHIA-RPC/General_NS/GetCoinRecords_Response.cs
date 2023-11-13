
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// This response contains Conrecords. it is uset by several EndPoints in WalletNode and FullNode
    /// </summary>
    /// <remarks>
    /// used by:<br/>
    /// <see cref="GetCoinRecordsByNames_RPC"/> <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_names"/><br/>
    /// <see cref="FullNode_NS.GetCoinRecordsByParentIDs_RPC"/> <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_parent_ids"/><br/>
    /// <see cref="FullNode_NS.GetCoinRecordsByHint_RPC"/> <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_hint"/><br/>
    /// <see cref="FullNode_NS.GetCoinRecordsByPuzzleHash_RPC"/> <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_puzzle_hash"/><br/>
    /// <see cref="FullNode_NS.GetCoinRecordsByPuzzleHashes_RPC"/> <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_puzzle_hashes"/>
    /// </remarks>
    public class GetCoinRecords_Response : ResponseTemplate<GetCoinRecords_Response>
    {
        /// <summary>
        /// It provides key information about coins, including if it has been spent, when it was confirmed, and when it was spent.
        /// </summary>
        public CoinRecord[]? coin_records { get; set; }
    }
}
