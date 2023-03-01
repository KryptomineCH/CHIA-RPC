﻿using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents the response received from the `get_routes` endpoint.
    /// </summary>
    public class GetRoutes_Response : ResponseTemplate<GetRoutes_Response>
    {
        /// <summary>
        /// An array of strings representing the names of all the available RPC endpoints.
        /// </summary>
        public string[] routes { get; set; }
    }
}
