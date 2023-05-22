namespace VowelCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            var userInput = Console.ReadLine();

            Console.WriteLine(VowelService.GetVowelCount(userInput));
        }
    }
}