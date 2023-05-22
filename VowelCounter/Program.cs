namespace VowelCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("No text provided. Re-run the program!");
                return;
            }

            Console.WriteLine(VowelService.GetVowelCount(userInput));
        }
    }
}