using CHIA_RPC.HelperFunctions_NS;
using System.Text;

namespace CHIA_RPC.Objects_NS
{
	public class OfferFile : ObjectTemplate<OfferFile>
    {
		public string offer { get; set; }
		public TradeRecord trade_record { get; set;}
	
		public bool success { get; set; }
		public string? error { get; set; }
        /// <summary>
        /// exports the offer as offer file which can be uploaded to exchanges
        /// </summary>
        /// <param name="path"></param>
        public void Export(string path)
        {
            if (!path.EndsWith(".offer"))
            {
                path += ".offer";
            }
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, offer, utf8WithoutBom);
        }
    }
}
