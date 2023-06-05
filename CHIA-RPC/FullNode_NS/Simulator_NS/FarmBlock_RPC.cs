using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Response for the 'farm_block' RPC API call.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#farm_block"/><br/><br/>
    /// Uses:<br/><see cref="FarmBlock_RPC"/>
    /// </remarks>
    public class FarmBlock_Response : ResponseTemplate<FarmBlock_Response>
    {
        /// <summary>
        /// The new peak height after farming.
        /// </summary>
        public ulong new_peak_height { get; set; }
    }

    /// <summary>
    /// Class representing a JSON RPC request for the farm_block functionality.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/simulator-rpc#farm_block"/></remarks>
    /// <returns><see cref="FarmBlock_Response"/></returns>
    public class FarmBlock_RPC : RPCTemplate<FarmBlock_RPC>
    {
        /// <summary>
        /// for serializer
        /// </summary>
        public FarmBlock_RPC() { /* for serialisation */ }
        /// <summary>
        /// Class representing a JSON RPC request for the farm_block functionality.
        /// </summary>
        /// <param name="address">The address to use to farm the block.</param>
        /// <param name="guarantee_tx_block">Set to True to farm a transaction block (i.e., farm new blocks until a tx block is farmed);</param>
        /// <param name="blocks">Number of blocks to farm. If guarantee_tx_block is True, then each block will be a transaction block (Default: 1).</param>
        public FarmBlock_RPC(string address, bool? guarantee_tx_block = null, ulong? blocks = null)
        {
            this.address = address;
            this.guarantee_tx_block = guarantee_tx_block;
            this.blocks = blocks;
        }

        /// <summary>
        /// The address to use to farm the block.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string address { get; set; }

        /// <summary>
        /// Set to True to farm a transaction block (i.e., farm new blocks until a tx block is farmed);
        /// set to False to farm the next block, which could also be a transaction block, but is not guaranteed (Default: False).
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? guarantee_tx_block { get; set; }

        /// <summary>
        /// Number of blocks to farm. If guarantee_tx_block is True, then each block will be a transaction block (Default: 1).
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? blocks { get; set; }
    }
}
