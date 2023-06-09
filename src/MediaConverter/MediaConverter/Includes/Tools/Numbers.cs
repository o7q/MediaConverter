using System;

namespace MediaConverter.Tools
{
    public static class Numbers
    {
        public static string GenerateID(int length)
        {
            // creates a random string of the specified length
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[length];
            var random = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];

            var finalString = new string(stringChars);

            return finalString;
        }
    }
}