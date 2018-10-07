using System;

namespace Chimerical.Conversions.Api.Converters
{
    public static class GuidConverter
    {
        private const int EncodedGuidLength = 22;

        public static string EncodeGuid(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }

            return Convert.ToBase64String(guid.ToByteArray())
                .Substring(0, EncodedGuidLength)
                .Replace("/", "_")
                .Replace("+", "-");
        }

        public static Guid DecodeGuid(string encodedGuid)
        {
            if (string.IsNullOrEmpty(encodedGuid))
            {
                throw new ArgumentNullException(nameof(encodedGuid));
            }

            if (encodedGuid.Length != EncodedGuidLength)
            {
                throw new FormatException($"Encoded GUID was not the correct length ({EncodedGuidLength})");
            }

            return new Guid(Convert.FromBase64String(encodedGuid.Replace("_", "/").Replace("-", "+") + "=="));
        }
    }
}
