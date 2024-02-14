namespace Count_Chars_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            string input = Console.ReadLine();

            foreach (char character in input)
                if (character != ' ')
                {
                    if (charCount.ContainsKey(character))
                    {
                        charCount[character]++;
                    }
                    else
                    {
                        charCount.Add(character, 1);
                    }
                }

            foreach (var character in charCount)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}