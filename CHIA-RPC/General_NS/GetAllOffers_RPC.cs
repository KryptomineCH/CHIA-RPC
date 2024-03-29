﻿using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Class to represent the request for the "get_all_offers" RPC method.
    /// </summary>
    /// <remarks>
    /// Technical Limitations:<br/>
    /// - accepted_at_time can only be filled if you accepted the offer<br/>
    /// - accepted_at_index cannot be filled at all currently<br/>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_all_offers"/>
    /// </remarks>
    /// <returns><see cref="OfferFiles"/></returns>
    public class GetAllOffers_RPC : RPCTemplate<GetAllOffers_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetAllOffers_RPC() { /* for serialisation */ }
        /// <summary>
        /// Class to represent the request for the "get_all_offers" RPC method.
        /// </summary>
        /// <param name="start">The sequence number of the first offer to show. Default: 0; Max: long.MaxValue -1</param>
        /// <param name="end">The sequence number of the last offer to show. Default: 10; Max: long.MaxValue</param>
        /// <param name="exclude_my_offers">Set to true to exclude offers you originated. Default: false</param>
        /// <param name="exclude_taken_offers">Set to true to exclude offers that have already been taken. Default: false</param>
        /// <param name="include_completed">Set to true to include offers that have been taken. Default: false</param>
        /// <param name="sort_key">Specify the key for sorting. Default: None</param>
        /// <param name="reverse">Set to true to sort the results in reverse order. Default: false<br/>
        /// true sets the default sorting key from oldest to newest, ideal to build a history.<br/>
        /// false lists from new to old, perfect to list the last X offers</param>
        /// <param name="file_contents">Set to true to display the contents of each offer. Default: false</param>
        public GetAllOffers_RPC(ulong start, ulong end, bool? exclude_my_offers = null, bool? exclude_taken_offers = null, bool? include_completed = null, GetTransactionSortKey? sort_key = null, bool? reverse = null, bool? file_contents = null)
        {
            this.start = start;
            this.end = end;
            this.exclude_my_offers = exclude_my_offers;
            this.exclude_taken_offers = exclude_taken_offers;
            this.include_completed = include_completed;
            this.sort_key = sort_key;
            this.reverse = reverse;
            this.file_contents = file_contents;
        }

        /// <summary>
        /// The sequence number of the first offer to show. Default: 0
        /// </summary>
        /// <remarks>Maximum is long.MaxValue -1!</remarks>
        public ulong start { get; set; } = 0;

        /// <summary>
        /// The sequence number of the last offer to show. Default: 10
        /// </summary>
        /// <remarks>Maximum is long.MaxValue!</remarks>
        public ulong end { get; set; } = 10;

        /// <summary>
        /// Set to true to exclude offers you originated. Default: false
        /// </summary>
        public bool? exclude_my_offers { get; set; }

        /// <summary>
        /// Set to true to exclude offers that have already been taken. Default: false
        /// </summary>
        public bool? exclude_taken_offers { get; set; }

        /// <summary>
        /// Set to true to include offers that have been taken. Default: false
        /// </summary>
        public bool? include_completed { get; set; }

        /// <summary>
        /// The key for sorting. Default: None.
        /// </summary>
        /// <remarks>Optional</remarks>
        [JsonConverter(typeof(StringToEnumConverter<GetTransactionSortKey>))]
        public GetTransactionSortKey? sort_key { get; set; }

        /// <summary>
        /// Set to true to sort the results in reverse order. Default: false
        /// </summary>
        /// <remarks>true sets the default sorting key from oldest to newest, ideal to build a history.<br/>
        /// false lists from new to old, perfect to list the last X offers</remarks>
        public bool? reverse { get; set; }

        /// <summary>
        /// Set to true to display the contents of each offer. Default: false
        /// </summary>
        public bool? file_contents { get; set; }
    }

}
