using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents a response from the "get_mirrors" API endpoint.
    /// </summary>
    /// <remarks>
    /// Request requires an <see cref="General_NS.ID_RPC"/><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_mirrors"/>
    /// </remarks>
    public class GetMirrors_Response : ResponseTemplate<GetMirrors_Response>
    {
        /// <summary>
        /// Gets or sets the mirrors.
        /// </summary>
        public Mirror[] mirrors { get; set; }  
    }
}
