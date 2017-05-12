using System;

namespace Treehouse
{
    class Program
    {
        public static void Main()
        {
            while(true)
            {
                Console.WriteLine("Welcome to the Morse Code Translator");
                Console.Write("Enter text to translate or press ENTER to exit: ");
                string input = Console.ReadLine().Trim();

                if(string.IsNullOrEmpty(input))
                {
                    break;
                }

                string output;

                if(input[0] == '.' || input[0] == '-')
                {
                    output = MorseCodeTranslator.ToText(input);
                }
                else
                {
                    output = MorseCodeTranslator.ToMorse(input);
                }

                Console.WriteLine(output);
            }
        }
    }
}