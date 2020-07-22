using System;
using System.Text;

namespace CAD.CD.Search.TestFramework.Utils
{
    public class TestDataGenerator
    {
        public static String charsAndDigitsString(int length)
        {
            Char[] chars = "0123456789ABCDEFGRHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char c = chars[random.Next(chars.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static String notAllowedCharsString(int length)
        {
            Char[] chars = "\"`&()|!<>\\".ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char c = chars[random.Next(chars.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static String digitsString(int length)
        {
            Char[] chars = "123456789".ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                char c = chars[random.Next(chars.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
