﻿using CHIA_RPC.FullNode_NS;
using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// the headerhash is beeing used for a variety of lookup tasks
    /// </summary>
    public class HeaderHash_RPC : RPCTemplate<HeaderHash_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public HeaderHash_RPC() { /* for serialisation */ }
        /// <summary>
        /// the headerhash is beeing used for a variety of lookup tasks
        /// </summary>
        /// <param name="header_hash">The header hash of the block to look up</param>
        public HeaderHash_RPC(string header_hash)
        {
            this.header_hash = header_hash;
        }

        /// <summary>
        /// The header hash of the block to look up
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? header_hash { get; set; }
        /// <summary>
        /// implicit conversion from BlockRecord to HeaderHash_RPC
        /// </summary>
        /// <param name="record"></param>
        public static implicit operator HeaderHash_RPC(BlockRecord record)
        {
            return new HeaderHash_RPC(record.header_hash);
        }
        /// <summary>
        /// implicit conversion from GetBlockRecord_Response to HeaderHash_RPC
        /// </summary>
        /// <param name="record"></param>
        public static implicit operator HeaderHash_RPC(GetBlockRecord_Response record)
        {
            return new HeaderHash_RPC(record.block_record.header_hash);
        }
    }
}
