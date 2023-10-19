using System.Reflection;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// provides Properties used throughout the application
    /// </summary>
    public static class GlobalVar
    {
        /// <summary>
        /// specifies the amount of mojos for 1 xch
        /// </summary>
        public const decimal OneChiaInMojos = 1000000000000;
        /// <summary>
        /// specifies the amount of mojos for 1 Cat Token
        /// </summary>
        public const decimal OneCatInMojos = 1000;
        /// <summary>
        /// returns the nuget version
        /// </summary>
        public static Version PackageVersion
        {
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Version version = assembly.GetName().Version;
                return version;
            }
        }
    }
}
