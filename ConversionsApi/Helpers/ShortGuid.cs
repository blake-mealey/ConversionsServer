using System;

namespace Chimerical.Conversions.Api.Helpers
{
    public class ShortGuid
    {
        private const int EncodedGuidLength = 22;

        public static ShortGuid Empty => FromGuid(Guid.Empty);

        private Guid _guid;

        private ShortGuid() { }

        public static ShortGuid NewShortGuid()
        {
            return FromGuid(Guid.NewGuid());
        }

        public static ShortGuid Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length != EncodedGuidLength)
            {
                throw new FormatException($"Encoded GUID was not the correct length ({EncodedGuidLength})");
            }

            return FromGuid(new Guid(Convert.FromBase64String(input.Replace("_", "/").Replace("-", "+") + "==")));
        }

        public static bool TryParse(string input, out ShortGuid result)
        {
            try
            {
                result = Parse(input);
                return true;
            }
            catch (Exception e) when(e is ArgumentNullException || e is FormatException)
            {
                result = null;
                return false;
            }
        }

        public static ShortGuid FromGuid(Guid guid)
        {
            return new ShortGuid
            {
                _guid = guid
            };
        }

        public Guid ToGuid()
        {
            return _guid;
        }

        public override string ToString()
        {
            return Convert.ToBase64String(_guid.ToByteArray())
                .Substring(0, EncodedGuidLength)
                .Replace("/", "_")
                .Replace("+", "-");
        }
    }
}
