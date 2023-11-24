namespace CHIA_RPC.HelperFunctions_NS
{
    /// <summary>
    /// contains efficient functions to compare hashes
    /// </summary>
    public class HashCompare
    {
        /// <summary>
        /// compares if two hashes are equal.<br/>
        /// 1. checks if both hashes are null or empty<br/>
        /// 2. checks if both hashes are of equal length<br/>
        /// 3. foregoes a backwards char by char comparison, as prefixes are often equal and the suffix is more likely to differ
        /// </summary>
        /// <remarks>
        /// WARNING: 0xhash != hash<br/>
        /// do not use this for normal string comparisons. no edgecases such as format, invariance, and capitalization are checked for
        /// </remarks>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool AreHashesEqual(string? str1, string? str2)
        {
            // check if both strings are null or empty or if the content needs to be compared
            bool isNullOrEmpty = string.IsNullOrEmpty(str1);
            if (isNullOrEmpty != string.IsNullOrEmpty(str2))
            {
                return false;
            }
            if (isNullOrEmpty)
            {
                return true;
            }

            // arbitrary length comparison
            if ( str1!.Length != str2!.Length)
                return false;

            // compare backwards, 
            for (int i = str1.Length-1; i >=0; i--)
            {
                if (str1[i] != str2[i])
                    return false;
            }

            // strings are equal
            return true;
        }
    }
}
