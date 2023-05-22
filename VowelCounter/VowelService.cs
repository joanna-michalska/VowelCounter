namespace VowelCounter
{
    internal class VowelService
    {
        public static int GetVowelCount(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"No text provided for {nameof(inputString)}. Re-run the program!");
            }

            int vowelCount = 0;
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };

            foreach (char c in inputString)
            {
                if (vowels.Contains(c.ToString()))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
