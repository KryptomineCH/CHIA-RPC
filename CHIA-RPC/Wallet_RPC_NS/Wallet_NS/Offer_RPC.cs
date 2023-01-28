using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class Offer_RPC
    {
        public Offer_RPC()
        {
            offer = new Dictionary<string, long>();
        }
        /// <summary>
        /// this dictionary contains your requested additions ans substractions, in mojos.<br/>
        /// if you wan to offer an nft for example, use the launcher id such as <br/>
        /// "1": 1000000000000 (offer for 1 xch) <br/>
        /// "cc4138f8debe4fbedf26ccae0f965be19c67a49d525f1416c0749c3c865dxxx", -1 <br/>
        /// 
        /// </summary>
        public Dictionary<string, long> offer { get; set; }

        public ulong? fee { get; set; }

        public bool? validate_only { get; set; }

        public dynamic? driver_dict { get; set; }

        public ulong? min_coin_amount { get; set; }

        public ulong? max_coin_amount { get; set; }

        public Dictionary<string, object>? solver { get; set; }
        /// <summary>
        /// saves the rpc as rpc-file (json) to the specified path
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".rpc"))
            {
                path += ".rpc";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// loads an rpc file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Offer_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            Offer_RPC rpc = JsonSerializer.Deserialize<Offer_RPC>(text);
            return rpc;
        }
        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string jsonString = JsonSerializer.Serialize(this, options: options);
            return jsonString;
        }
        public static Offer_RPC GenerateOffer_RPC(Nft[] sells, Nft[] buys, long mojoValue )
        {
        
            Offer_RPC offer_rpc = new Offer_RPC();
            foreach ( Nft sell in sells )
            {
                offer_rpc.offer.Add(sell.launcher_id, -1);
            }
            foreach ( Nft buy in buys )
            {
                offer_rpc.offer.Add(buy.launcher_id, 1);
            }
            offer_rpc.offer.Add("1", mojoValue);
            return offer_rpc;
        }
    } 
}
