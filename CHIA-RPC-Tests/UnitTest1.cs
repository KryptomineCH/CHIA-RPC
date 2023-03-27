using CHIA_RPC.Wallet_NS.NFT_NS;

namespace CHIA_RPC_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void NftMintNft_SaveLoadRPC()
        {
            NftMintNFT_RPC rpc = new NftMintNFT_RPC(
                walletID: 8,
                nftLinks: new[]
                {
                    "https://nft.kryptomine.ch/Kryptomine_Basecollection/KryptoMine_Logo.png",
                    "https://bafybeicwmyirgdb7cul5jy66rls73ww4fhyb5y7y6qfjjz54qtvepfausu.ipfs.nftstorage.link/"
                },
                metadataLinks: new[]
                {
                    "https://bafkreifvwkzpf7unauzpcnydnmfu2jwhuhj3kyhgliyps44oipw3ebbqpm.ipfs.nftstorage.link/",
                    "https://nft.kryptomine.ch/kryptomine_testcollection/metadata/god_under_the_shower.json"
                },
                licenseLinks: new[]
                {
                    "https://nft.kryptomine.ch/Kryptomine_Basecollection/KryptoMine_Logo_License.txt",
                    "https://bafkreigj4vrboii67oj2ygmgrjzz4bmig5vfnzlxwfzbkxajhumk7qro2q.ipfs.nftstorage.link/"
                },
                royaltyFee: 1234567890,
                royaltyAddress: "xch1e426jf55z7npqnw7ae7h9ap0gez7wrljvqqeskx97p928jshfapq2w7p5l",
                targetAddress: "xch1e426jf55z7npqnw7ae7h9ap0gez7wrljvqqeskx97p928jshfapq2w7p5l",
                mintingFee_Mojos: 2441556
                );
            rpc.SaveRpcToFile("NftMintNft_SaveLoadRPC");
            NftMintNFT_RPC loadedRpc = NftMintNFT_RPC.LoadRpcFromFile("NftMintNft_SaveLoadRPC");
            if (rpc.wallet_id != loadedRpc.wallet_id)
            {
                throw new System.Exception("Wallet Ids do not match!");
            }
            if (rpc.uris[0] != loadedRpc.uris[0] || rpc.uris[1] != loadedRpc.uris[1] ||
                rpc.meta_uris[0] != loadedRpc.meta_uris[0] || rpc.meta_uris[1] != loadedRpc.meta_uris[1] ||
                rpc.license_uris[0] != loadedRpc.license_uris[0] || rpc.license_uris[1] != loadedRpc.license_uris[1])
            {
                throw new System.Exception("uris dont match!");
            }
            if (rpc.hash != loadedRpc.hash || rpc.meta_hash != loadedRpc.meta_hash || rpc.license_hash != loadedRpc.license_hash)
            {
                throw new System.Exception("uris dont match!");
            }
            if (rpc.royalty_address != loadedRpc.royalty_address || rpc.target_address != loadedRpc.target_address)
            {
                throw new System.Exception("addresses dont match!");
            }
            if (rpc.edition_number != loadedRpc.edition_number || rpc.edition_total != loadedRpc.edition_total)
            {
                throw new System.Exception("edition numbers do not match!");
            }
            if (rpc.fee != loadedRpc.fee || rpc.royalty_percentage != loadedRpc.royalty_percentage)
            {
                throw new System.Exception("fees dont match!");
            }
        }
    }
}