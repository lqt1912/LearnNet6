using System.Globalization;

namespace LearnNet6.Utilities
{
    public static class StringHelper
    {
        public static string RandomString(int length, string[] lines)
        {
            var maxValue = lines.Length - 1;
            var result = "";
            while (result.Length < length)
            {
                result = result + lines[new Random().Next(1, maxValue)] + ' ';
            }
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return textInfo.ToTitleCase(result);
        }
    }
}
