namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// An enumeration of Chia wallet types.
    /// </summary>
    /// <remarks>
    /// More types may be added in the future. See <see href="https://github.com/Chia-Network/chia-blockchain/blob/main/chia/wallet/util/wallet_types.py"/> for an up-to-date list of valid types.
    /// </remarks>
    public enum WalletType
    {
        /// <summary>
        /// Represents a standard XCH wallet.
        /// </summary>
        STANDARD_WALLET = 0,

        /// <summary>
        /// Represents an unknown wallet type.
        /// </summary>
        RATE_LIMITED = 1,

        /// <summary>
        /// Represents an atomic swap wallet, used for cross-chain atomic swaps.
        /// </summary>
        ATOMIC_SWAP = 2,

        /// <summary>
        /// Represents an authorized payee wallet, used for transactions where specific payees are authorized.
        /// </summary>
        AUTHORIZED_PAYEE = 3,

        /// <summary>
        /// Represents a multi-signature wallet, requiring multiple signatories for transactions.
        /// </summary>
        MULTI_SIG = 4,

        /// <summary>
        /// Represents a custody wallet, used for custodial services.
        /// </summary>
        CUSTODY = 5,

        /// <summary>
        /// Represents a Chia Asset Token (CAT) wallet, used for handling custom tokens on the Chia network.
        /// </summary>
        CAT = 6,

        /// <summary>
        /// Represents a recoverable wallet, typically providing additional layers of security or recovery options.
        /// </summary>
        RECOVERABLE = 7,

        /// <summary>
        /// Represents a decentralized ID wallet, used for managing decentralized identifiers.
        /// </summary>
        DECENTRALIZED_ID = 8,

        /// <summary>
        /// Represents a pooling wallet, used for participation in Chia pooling protocols.
        /// </summary>
        POOLING_WALLET = 9,

        /// <summary>
        /// Represents a Non-Fungible Token (NFT) wallet, used for managing NFTs on the Chia network.
        /// </summary>
        NFT = 10,

        /// <summary>
        /// Represents a data layer wallet, used for data layer operations and applications.
        /// </summary>
        DATA_LAYER = 11,

        /// <summary>
        /// Represents a data layer offer wallet, used for making offers within data layer operations.
        /// </summary>
        DATA_LAYER_OFFER = 12,

        /// <summary>
        /// Represents a verifiable credential (VC) wallet, used for managing verifiable credentials.
        /// </summary>
        VC = 13
    }

}
