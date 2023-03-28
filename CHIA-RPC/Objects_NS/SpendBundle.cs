using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;
namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// used by full node and wallet node
    /// </summary>
    public class SpendBundle : ObjectTemplate<SpendBundle>
    {
        public string aggregated_signature { get; set; }
        public CoinSpend[] coin_spends { get; set; }
        public CoinSpend[] coin_solutions { get; set; }
        public override string ToString()
        {
            string json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}
