using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    /// <summary>
/// Represents a transfer program in the Chia ecosystem.
/// This class contains the details of the transfer program that are required for transferring NFTs between different addresses.
/// </summary>
/// <remarks>
/// A transfer program in Chia is essentially a set of instructions that defines how an NFT is transferred.
/// This includes information about who the recipient will be (identified by their 'launcher_id'),
/// any royalties that are to be paid as part of the transfer, and the type of the program.
/// </remarks>
public class TransferProgram : ObjectTemplate<TransferProgram>
{
    /// <summary>
    /// The launcher id of the recipient.
    /// This is the unique identifier that represents the recipient in the Chia network.
    /// It is used to route the NFT to the correct address during the transfer process.
    /// </summary>
    public string? launcher_id { get; set; }

    /// <summary>
    /// The address where the royalty payment will be sent.
    /// This is the address of the party that will receive the royalties when the NFT is transferred.
    /// The royalties are a percentage of the transaction value that is paid to the original creator of the NFT.
    /// </summary>
    public string? royalty_address { get; set; }

    /// <summary>
    /// The percentage of the transaction value that will be paid as royalties.
    /// This value is expressed as a string but represents a decimal percentage.
    /// For example, a royalty percentage of "0.01" means that 1% of the transaction value will be paid as royalties.
    /// </summary>
    public string? royalty_percentage { get; set; }

    /// <summary>
    /// The type of the transfer program.
    /// This is a string that identifies the type of instructions contained in the program.
    /// It helps the Chia network understand how to execute the transfer process.
    /// </summary>
    public string? type { get; set; }
}

}
