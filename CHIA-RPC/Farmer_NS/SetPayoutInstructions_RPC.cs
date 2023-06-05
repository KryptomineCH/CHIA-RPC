using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Set the payout instructions parameter for your pool configuration.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#set_payout_instructions"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class SetPayoutInstructions_RPC : RPCTemplate<SetPayoutInstructions_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SetPayoutInstructions_RPC() { /* for serialisation */ }
        /// <summary>
        /// Set the payout instructions parameter for your pool configuration.
        /// </summary>
        /// <param name="launcher_id">The launcher_id from your pool, obtainable from the get_pool_state RPC.</param>
        /// <param name="payout_instructions">The puzzle hash to be used as the new payout_instructions.</param>
        public SetPayoutInstructions_RPC(string launcher_id, string payout_instructions)
        {
            this.launcher_id = launcher_id;
            this.payout_instructions = payout_instructions;
        }

        /// <summary>
        /// The launcher_id from your pool, obtainable from the get_pool_state RPC.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string launcher_id { get; set; }

        /// <summary>
        /// The puzzle hash to be used as the new payout_instructions.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string payout_instructions { get; set; }
    }
}
