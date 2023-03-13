using System.ComponentModel.DataAnnotations;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class GetCoinRecordsByNames_Response : ResponseTemplate<GetCoinRecordsByNames_Response>
    {
        public CoinRecord[] coin_records { get; set; }
    }

    public class GetCoinRecordsByNames_RPC : RPCTemplate<GetCoinRecordsByNames_RPC>
    {
        /// <summary>
        /// A list of coin names from which to retrieve records
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string[] names { get; set; }
        /// <summary>
        /// The block height at which to start the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_height { get; set; }
        /// <summary>
        /// The block height at which to end the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? end_height { get; set; }
        /// <summary>
        /// Include spent coins in the result[Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? include_spent_coins { get; set; }
    }
}
