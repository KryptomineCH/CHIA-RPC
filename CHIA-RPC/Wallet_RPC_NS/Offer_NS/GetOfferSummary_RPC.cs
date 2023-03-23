using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Represents the response for a get_offer_summary server request.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/offer-rpc#get_offer_summary"/><br/><br/>
    /// Using:<br/> <see cref="GetOfferSummary_RPC"/>
    /// </remarks>
    public class GetOfferSummary_Response : ResponseTemplate<GetOfferSummary_Response>
    {
        public string id { get; set; }

        public Summary summary { get; set; }

        public class Summary
        {
            public ulong fees { get; set; }

            public Info[] infos { get; set; }

            public Offered offered { get; set; }

            public Requested requested { get; set; }

            public class Info
            {
                public string launcher_id { get; set; }

                public string launcher_ph { get; set; }

                public string type { get; set; }

                public Also also { get; set; }

                public class Also
                {
                    public string type { get; set; }

                    public string metadata { get; set; }

                    public string updater_hash { get; set; }

                    public Ownership ownership { get; set; }

                    public class Ownership
                    {
                        public string type { get; set; }

                        public string owner { get; set; }

                        public TransferProgram transfer_program { get; set; }

                        public class TransferProgram
                        {
                            public string launcher_id { get; set; }

                            public string royalty_address { get; set; }

                            public string royalty_percentage { get; set; }

                            public string type { get; set; }
                        }
                    }
                }
            }

            public class Offered
            {
                public ulong xch { get; set; }
            }

            public class Requested
            {
                public ulong b4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16 { get; set; }
            }
        }
    }
    /// <summary>
    /// Returns the summary of a specific offer. Works for offers in any state.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#get_offer_summary"/></remarks>
    /// <returns><see cref="GetOfferSummary_Response"/></returns>
    public class GetOfferSummary_RPC : RPCTemplate<GetOfferSummary_RPC>
    {
        /// <summary>
        /// The offer to summarize.
        /// </summary>
        public string offer { get; set; }
    }

}
