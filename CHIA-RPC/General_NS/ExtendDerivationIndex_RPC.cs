using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class Index_Response : ResponseTemplate<Index_Response>
    {
        public ulong index { get; set; }
    }
    public class Index_RPC : RPCTemplate<Index_RPC>
    {
        [Required]
        public ulong index { get; set; }
    }
}
