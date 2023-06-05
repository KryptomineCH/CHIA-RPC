using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Represents the response for the Set Auto Farming RPC API.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#set_auto_farming"/><br/><br/>
    /// Uses:<br/>
    /// <see cref="SetAutoFarming_RPC"/><br/>
    /// GetAutoFarming
    /// </remarks>
    public class AutoFarming_Response : ResponseTemplate<AutoFarming_Response>
    {
        /// <summary>
        /// Boolean indicating whether auto farming is enabled.
        /// </summary>
        public bool auto_farm_enabled { get; set; }
    }

    /// <summary>
    /// Represents the RPC request for the Set Auto Farming API.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/simulator-rpc#set_auto_farming"/></remarks>
    /// <returns><see cref="AutoFarming_Response"/></returns>
    public class SetAutoFarming_RPC : RPCTemplate<SetAutoFarming_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SetAutoFarming_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents the RPC request for the Set Auto Farming API.
        /// </summary>
        /// <param name="auto_farm">Boolean to enable or disable auto farming.</param>
        public SetAutoFarming_RPC(bool auto_farm)
        {
            this.auto_farm = auto_farm;
        }

        /// <summary>
        /// Boolean to enable or disable auto farming.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public bool auto_farm { get; set; }
    }

}
