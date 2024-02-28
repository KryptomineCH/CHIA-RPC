using System.Security.Cryptography;

namespace CHIA_RPC.HelperFunctions_NS
{
    public readonly struct HexBytes
    {
        public string Hex { get; init; } = string.Empty;
        public byte[] Bytes { get; init; } = Array.Empty<byte>();
        public bool IsEmpty => string.IsNullOrWhiteSpace(Hex);

        public HexBytes(string hex, byte[] bytes)
        {
            Hex = hex ?? string.Empty;
            Bytes = bytes ?? Array.Empty<byte>();
        }

        public HexBytes Sha256()
        {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Bytes);
            var hexHash = ToHexString(hash);

            return new HexBytes(hexHash, hash);
        }

        public override bool Equals(object? obj)
        {
            return obj is HexBytes other && Hex.Equals(other.Hex, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hex);
        }

        public override string ToString()
        {
            return Hex.ToLowerInvariant();
        }

        public static HexBytes operator +(HexBytes a, HexBytes b)
        {
            var concatHex = string.Concat(a.Hex, b.Hex);
            var concatBytes = a.Bytes.Concat(b.Bytes).ToArray();

            return new HexBytes(concatHex, concatBytes);
        }

        public static HexBytes operator +(HexBytes a, byte[] b)
        {
            var bs = ToHexString(b);
            var concatHex = string.Concat(a.Hex, bs);
            var concatBytes = a.Bytes.Concat(b).ToArray();

            return new HexBytes(concatHex, concatBytes);
        }

        public static HexBytes operator +(HexBytes a, string b)
        {
            var bb = FromHexString(b);
            var concatHex = string.Concat(a.Hex, b);
            var concatBytes = a.Bytes.Concat(bb).ToArray();

            return new HexBytes(concatHex, concatBytes);
        }

        public static bool operator ==(HexBytes a, HexBytes b) => a.Equals(b);
        public static bool operator !=(HexBytes a, HexBytes b) => !a.Equals(b);

        public static HexBytes FromHex(string hex)
        {
            var cleanHex = hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? hex[2..] : hex;
            var bytes = FromHexString(cleanHex);

            return new HexBytes(cleanHex, bytes);
        }

        public static bool TryFromHex(string hex, out HexBytes result)
        {
            try
            {
                result = FromHex(hex);
                return true;
            }
            catch
            {
                result = Empty;
                return false;
            }
        }

        public static HexBytes FromBytes(byte[] bytes)
        {
            var hex = ToHexString(bytes);
            return new HexBytes(hex, bytes);
        }

        public static HexBytes Empty => new(string.Empty, Array.Empty<byte>());

        private static string ToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
        }

        private static byte[] FromHexString(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
