using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    // TODO: Xunit Test
    /// <summary>
    ///Returns the additional data used for AGG_SIG conditions for the current network
    /// </summary>
    /// <remarks>
    /// get_aggsig_additional_data <see href="https://docs.chia.net/full-node-rpc/#get_aggsig_additional_data"/>
    /// </remarks>
    public class GetAggsigAdditionalData_Response : ResponseTemplate<GetAggsigAdditionalData_Response>
    {
        /// <summary>
        /// the data string
        /// </summary>
        public string additional_data { get; set; }
    }
}
