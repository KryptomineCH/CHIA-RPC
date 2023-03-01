using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CHIA_RPC.General
{
    public class HeaderHash_RPC : RPCTemplate<HeaderHash_RPC>
    {
        /// <summary>
        /// The header hash of the block to look up
        /// </summary>
        [JsonPropertyName("header_hash")]
        [Required]
        public string header_hash { get; set; }
    }
}
