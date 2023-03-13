using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents a response from the "get_mirrors" API endpoint.
    /// </summary>
    /// <remarks>Request requires an ID_RPC</remarks>
    public class GetMirrors_Response : ResponseTemplate<GetMirrors_Response>
    {
        /// <summary>
        /// Gets or sets the mirrors.
        /// </summary>
        public Mirror[] mirrors { get; set; }  
    }
}
