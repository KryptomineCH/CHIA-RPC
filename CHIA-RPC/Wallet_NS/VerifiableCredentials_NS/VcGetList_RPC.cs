using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS;
using System.Security.Cryptography;
using System.Text;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the response for the `vc_get_list` command in the Chia RPC API.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_get_list"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// This class is an extension of the ResponseTemplate class, serving as a response type for `vc_get_list` RPC calls in the Chia blockchain.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `proofs`: Dictionary of proofs to be returned. Type: <see cref="Dictionary{string, string}"/>.
    /// - `vc_records`: List of Verifiable Credential records. Type: <see cref="VcRecord"/>[].<br/>
    /// </remarks>
    ///
    /// <returns>
    /// <list type="bullet">
    /// <item><description>`proofs`: Dictionary of proofs.</description></item>
    /// <item><description>`vc_records`: List of Verifiable Credential records.</description></item>
    /// </list>
    /// </returns>
    public class VcGetList_Response : ResponseTemplate<VcGetList_Response>
    {
        /// <summary>
        /// Dictionary of proofs.
        /// </summary>
        public Dictionary<string, string> proofs { get; set; }

        /// <summary>
        /// List of Verifiable Credential records.
        /// </summary>
        public VcRecord[] vc_records { get; set; }
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
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Class representing the parameters for the 'vc_get_list' RPC call to get a list of Verifiable Credentials.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/wallet-rpc#vc_get_list"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Serves as a parameter set for the `vc_get_list` call.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `start`: The index to start the list at. Default is 0. Type: <see cref="ulong"/>?.
    /// - `count`: The maximum number of results to return. Default is 50. Type: <see cref="ulong"/>?.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="VcGetList_Response"/>
    /// </returns>
    public class VcGetList_RPC : RPCTemplate<VcGetList_RPC>
    {
        /// <summary>
        /// The index to start the list at. Default is 0.
        /// </summary>
        public ulong? start { get; set; }

        /// <summary>
        /// The maximum number of results to return. Default is 50.
        /// </summary>
        public ulong? count { get; set; }
    }
}
