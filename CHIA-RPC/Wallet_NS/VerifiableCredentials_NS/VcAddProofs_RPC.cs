using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Security.Cryptography;
using System.Text;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{

    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents a request to add a set of proofs to the DB that can be used when spending a VC.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/wallet-rpc#vc_add_proofs"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Serves as an extension of the RPCTemplate class, specifically for the functionality of adding proofs for VCs.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `proofs`: A dictionary of key/value pairs to be added as proofs. Type: <see cref="Dictionary{string, string}"/>.
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="Success_Response"/> indicating the result of the RPC request.
    /// </returns>
    public class VcAddProofs_RPC : RPCTemplate<VcAddProofs_RPC>
    {
        /// <summary>
        /// A dictionary of key/value pairs to be added as proofs.
        /// </summary>
        public Dictionary<string, string> proofs { get; set; }
        /// <summary>
        /// WARNING: UNTESTED<br/>
        /// Calculates the root hash for the given proofs.
        /// <br/>
        /// <list type="bullet">
        /// <item>
        /// <term>Sort the proofs</term>
        /// <description>Sorts proofs in reverse alphabetical order by key</description>
        /// </item>
        /// <item>
        /// <term>Binary Tree</term>
        /// <description>Transforms the sorted key-value pairs into a binary tree</description>
        /// </item>
        /// <item>
        /// <term>Root Hash</term>
        /// <description>Recursively traverses the tree, hashing the leaves to compute the root hash</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="proofs">The proofs for which to calculate the root hash.</param>
        /// <returns>The calculated root hash.</returns>
        public string CalculateRootHash()
        {
            const string CHIA_TREE_HASH_ATOM_PREFIX = "01";
            const string CHIA_TREE_HASH_PAIR_PREFIX = "02";

            string Sha256Hash(string input)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                    return BitConverter.ToString(bytes).Replace("-", "").ToLower();
                }
            }

            List<KeyValuePair<string, string>> SortPairs(Dictionary<string, string> pairs)
            {
                return pairs.OrderByDescending(x => x.Key).ToList();
            }

            object ListToBinaryTree(List<KeyValuePair<string, string>> objects)
            {
                if (objects.Count == 1) return objects[0];
                int mid = objects.Count / 2;
                var firstHalf = objects.GetRange(0, mid);
                var secondHalf = objects.GetRange(mid, objects.Count - mid);
                return new[] { ListToBinaryTree(firstHalf), ListToBinaryTree(secondHalf) };
            }

            string TreeHash(object node)
            {
                if (node is Array arr && arr.Length == 2)
                {
                    string leftHash = TreeHash(arr.GetValue(0));
                    string rightHash = TreeHash(arr.GetValue(1));
                    return Sha256Hash($"{CHIA_TREE_HASH_PAIR_PREFIX}{leftHash}{rightHash}");
                }
                else if (node is KeyValuePair<string, string> pair)
                {
                    return Sha256Hash($"{CHIA_TREE_HASH_ATOM_PREFIX}{pair.Value}");
                }
                throw new ArgumentException("Unsupported type passed to hash function.");
            }

            var sorted = SortPairs(this.proofs);
            var binaryTree = ListToBinaryTree(sorted);
            return TreeHash(binaryTree);
        }
    }
}
