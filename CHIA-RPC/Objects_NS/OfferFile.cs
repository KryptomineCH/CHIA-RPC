using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
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
        /// <summary>
        /// Implicitly converts a OfferFile object to a CheckOfferValidity_RPC object.
        /// </summary>
        /// <param name="offer">The OfferFile object to convert.</param>
        /// <returns>A new CheckOfferValidity_RPC object initialized with the offer.</returns>
        public static implicit operator CheckOfferValidity_RPC(OfferFile offer)
        {
            return new CheckOfferValidity_RPC(offer);
        }

    }
    public class OfferFiles : ObjectTemplate<OfferFiles>
    {
        public string[] offers { get; set; }
        public TradeRecord[] trade_records { get; set; }

        public bool success { get; set; }
        public string? error { get; set; }
        /// <summary>
        /// exports the offer as offer file which can be uploaded to exchanges
        /// </summary>
        /// <param name="path"></param>
        public void Export(string path)
        {
            for(int i = 0; i < offers.Length; i++)
            {
                string tempPath = path + i.ToString();
                if (!tempPath.EndsWith(".offer"))
                {
                    tempPath += ".offer";
                }
                Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
                File.WriteAllText(tempPath, offers[i], utf8WithoutBom);
            }
            
        }
    }
}
