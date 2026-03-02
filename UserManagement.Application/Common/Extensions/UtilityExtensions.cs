using System.Security.Cryptography;
using System.Text;

namespace Core.Application.Common.Extensions
{
    public static class UtilityExtensions
    {
        public static string ComputeSha1Hash(this string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static string ComputeSha256Hash(this string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] bytes = sha256Hash.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
