﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Retrieves an estimate of the netspace, which is the total plotted space of all farmers, in bytes.
    /// </summary>
    public class GetNetworkSpace_Response : ResponseTemplate<GetNetworkSpace_Response>
    {
        /// <summary>
        /// the network space in bytes
        /// </summary>
        public ulong space { get; set; }
        /// <summary>
        /// the netspace, calculated in petabytes
        /// <remarks>calculated on demand with binary prefix (/1024^5)</remarks>
        /// </summary>
        public decimal space_pb { get
            {
                return space / 1099511627776m;
            }
        }
        /// <summary>
        /// the netspace, calculated in exobytes
        /// <remarks>calculated on demand with binary prefix (/1024^6)</remarks>
        /// </summary>
        public decimal space_eb
        {
            get
            {
                return space / 1152921504606846976m;
            }
        }
        /// <summary>
        /// the netspace, calculated in zettabytes
        /// <remarks>calculated on demand with binary prefix (/1024^7)</remarks>
        /// </summary>
        public decimal space_zb
        {
            get
            {
                return space / 1152921504606846976000m;
            }
        }
        /// <summary>
        /// the netspace, calculated in yottabytes
        /// <remarks>calculated on demand with binary prefix (/1024^8)</remarks>
        /// </summary>
        public decimal space_yb
        {
            get
            {
                return space / 1152921504606846976000000m;
            }
        }

        /// <summary>
        /// the netspace, calculated in brontobytes
        /// <remarks>calculated on demand with binary prefix (/1024^9)</remarks>
        /// </summary>
        public decimal space_bb
        {
            get
            {
                return space / 1152921504606846976000000000m;
            }
        }
    }
    /// <summary>
    /// Retrieves the info about the net space (total space allocated by farmers)
    /// </summary>
    public class GetNetworkSpace_Rpc : RPCTemplate<GetNetworkSpace_Rpc>
    {
        /// <summary>
        /// the start header hash
        /// </summary>
        public string older_block_header_hash { get; set; }
        /// <summary>
        /// the end header hash
        /// </summary>
        public string newer_block_header_hash { get; set; }
    }
}