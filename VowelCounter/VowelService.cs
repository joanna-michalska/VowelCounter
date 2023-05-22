namespace VowelCounter
{
    internal class VowelService
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            foreach (char c in str)
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
