using CHIA_RPC.HelperFunctions_NS;
using static System.Net.WebRequestMethods;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// used by fullnode and wallet node<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_names"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_parent_ids"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_hint"/>
    /// </remarks>
    public class CoinRecord : ObjectTemplate<CoinRecord>
    {
        public Coin coin { get; set; }
        public bool coinbase { get; set; }
        public ulong confirmed_block_index { get; set; }
        public bool spent { get; set; }
        public ulong spent_block_index { get; set; }
        public ulong timestamp { get; set; }
    }
}
