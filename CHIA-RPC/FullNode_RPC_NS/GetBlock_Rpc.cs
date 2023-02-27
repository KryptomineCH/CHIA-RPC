using CHIA_RPC.Objects_NS;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// used by the server to return a specific block
    /// </summary>
    public class GetBlock_Response
    {
        /// <summary>
        /// the block which is returned
        /// </summary>
        public Block block { get; set; }
        /// <summary>
        /// indicates wether the server accepted the request
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// if the server refused the request, it will add an error here
        /// </summary>
        public string error { get; set; }
    }
}
