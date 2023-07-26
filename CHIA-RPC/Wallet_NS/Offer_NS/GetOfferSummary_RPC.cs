using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using static CHIA_RPC.Wallet_NS.Offer_NS.GetOfferSummary_Response.Summary.Info;

namespace CHIA_RPC.Wallet_NS.Offer_NS
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
        /// <summary>
        /// The unique identifier for the offer summary.
        /// </summary>
        public string? id { get; set; }

        /// <summary>
        /// Contains summary information of the offer.
        /// </summary>
        public Summary? summary { get; set; }

        /// <summary>
        /// summary for an nft offer
        /// </summary>
        public class Summary
        {
            /// <summary>
            /// Fees associated with the offer.
            /// </summary>
            public ulong? fees { get; set; }

            /// <summary>
            /// Array of Info objects representing detailed information about the offer.
            /// </summary>
            public Info[]? infos { get; set; }

            /// <summary>
            /// Represents what is offered.
            /// </summary>
            public Offered? offered { get; set; }

            /// <summary>
            /// Represents what is requested.
            /// </summary>
            public Requested? requested { get; set; }

            /// <summary>
            /// info about the nft
            /// </summary>
            public class Info
            {
                /// <summary>
                /// The launcher identifier.
                /// </summary>
                public string? launcher_id { get; set; }

                /// <summary>
                /// The launcher public hash.
                /// </summary>
                public string? launcher_ph { get; set; }

                /// <summary>
                /// The type of the information.
                /// </summary>
                public string? type { get; set; }

                /// <summary>
                /// Additional information about the offer.
                /// </summary>
                public Also? also { get; set; }

                /// <summary>
                /// contains further information such as iwnership etc
                /// </summary>
                public class Also
                {
                    /// <summary>
                    /// The type of the additional information.
                    /// </summary>
                    public string? type { get; set; }

                    /// <summary>
                    /// Metadata associated with the additional information.
                    /// </summary>
                    public string? metadata { get; set; }

                    /// <summary>
                    /// Hash of the updater for the offer.
                    /// </summary>
                    public string? updater_hash { get; set; }

                    /// <summary>
                    /// Information about the ownership of the offer.
                    /// </summary>
                    public Ownership? ownership { get; set; }

                    /// <summary>
                    /// the ownership of the nft
                    /// </summary>
                    public class Ownership
                    {
                        /// <summary>
                        /// The type of the ownership.
                        /// </summary>
                        public string? type { get; set; }

                        /// <summary>
                        /// The owner of the offer.
                        /// </summary>
                        public string? owner { get; set; }

                        /// <summary>
                        /// Program that handles the transfer of the offer.
                        /// </summary>
                        public TransferProgram? transfer_program { get; set; }

                        /// <summary>
                        /// the transfer conditions for an nft
                        /// </summary>
                        public class TransferProgram
                        {
                            /// <summary>
                            /// The launcher identifier for the transfer program.
                            /// </summary>
                            public string? launcher_id { get; set; }

                            /// <summary>
                            /// Address where royalties are sent.
                            /// </summary>
                            public string? royalty_address { get; set; }

                            /// <summary>
                            /// The percentage of royalties that are allocated to the royalty address.
                            /// </summary>
                            public string? royalty_percentage { get; set; }

                            /// <summary>
                            /// The type of the transfer program.
                            /// </summary>
                            public string? type { get; set; }
                        }
                    }
                }
                /// <summary>
                /// the amount of offered xch
                /// </summary>
                public class Offered
                {
                    /// <summary>
                    /// Amount of XCH (Chia cryptocurrency) offered.
                    /// </summary>
                    public ulong? xch { get; set; }
                }

                /// <summary>
                /// the amount of requested mojos
                /// </summary>
                public class Requested
                {
                    /// <summary>
                    /// Specific item requested in the offer identified by its unique hash.
                    /// </summary>
                    public ulong? b4158076fee6af25c9403b3b9d97a7c967a61c6b37c4614a1a16587345b2cb16 { get; set; }
                }
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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetOfferSummary_RPC() { /* for serialisation */ }
        /// <summary>
        /// Returns the summary of a specific offer. Works for offers in any state.
        /// </summary>
        /// <param name="offer">The offer to summarize.</param>
        public GetOfferSummary_RPC(string offer)
        {
            this.offer = offer;
        }
        /// <summary>
        /// Returns the summary of a specific offer. Works for offers in any state.
        /// </summary>
        /// <param name="offerFile">The offer to summarize.</param>
        public GetOfferSummary_RPC(OfferFile offerFile)
        {
            this.offer = offerFile.offer;
        }
        /// <summary>
        /// The offer to summarize.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? offer { get; set; }
    }

}
