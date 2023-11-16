using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using System.Text;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents an offer file in the Chia trading system. This is used to encapsulate an offer for a trade which can be uploaded to exchanges for trading.
    /// </summary>
    /// <remarks>
    /// The OfferFile class is a key part of the Chia trading system. It includes the offer itself, a record of the trade, and status and error information about the offer.
    /// The Export function allows this offer to be exported as a .offer file which can be used on trading platforms that support it.
    /// </remarks>
    public class OfferFile : ObjectTemplate<OfferFile>
    {
        /// <summary>
        /// The offer for the trade. This string contains all the information necessary for the trade to be executed on a Chia trading platform.
        /// </summary>
        public string? offer { get; set; }

        /// <summary>
        /// A record of the trade. This object contains a historical record of the trade including assets involved, parties, quantities, and timestamps.
        /// </summary>
        public TradeRecord? trade_record { get; set; }

        /// <summary>
        /// Indicates the success status of the offer. This boolean flag indicates if the offer has been successfully created and is ready for trading.
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// Contains error message if the offer creation failed. This string will contain detailed error information if the offer creation process encountered any errors.
        /// </summary>
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
    /// <summary>
    /// Represents a collection of offer files in the Chia trading system. This is used to encapsulate multiple offers for trades which can be uploaded to exchanges for trading.
    /// </summary>
    /// <remarks>
    /// The OfferFiles class is a collection of OfferFile objects. It includes multiple offers, records of the trades, and status and error information about each offer.
    /// The Export function allows these offers to be exported as .offer files which can be used on trading platforms that support it.
    /// </remarks>
    public class OfferFiles : ObjectTemplate<OfferFiles>
    {
        /// <summary>
        /// An array of offers for the trades. These strings contain all the information necessary for the trades to be executed on a Chia trading platform.
        /// </summary>
        public string[]? offers { get; set; }

        /// <summary>
        /// A collection of records for the trades. These objects contain historical records of the trades including assets involved, parties, quantities, and timestamps.
        /// </summary>
        public TradeRecord[]? trade_records { get; set; }

        /// <summary>
        /// Indicates the success status of the offers. This boolean flag indicates if the offers have been successfully created and are ready for trading.
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// Contains error message if the offers creation failed. This string will contain detailed error information if the offers creation process encountered any errors.
        /// </summary>
        public string? error { get; set; }
        /// <summary>
        /// exports the offer as offer file which can be uploaded to exchanges
        /// </summary>
        /// <param name="path"></param>
        public void Export(string path)
        {
            if (offers == null)
            {
                throw new NullReferenceException(nameof(offers));
            }
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
