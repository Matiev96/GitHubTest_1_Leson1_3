using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace GitHubTest_1_Leson1_3
{
    /// <summary>
    /// Start point of app.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Start of app.
        /// </summary>
        /// <param name="args">args added via console.</param>
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == null)
            {
                return;
            }

            int n = int.Parse(input);

            List<char> list = new List<char>();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray();

            int[] abc = new int[n];

            int oddCount = 0;

            int evenCount = 0;

            Random randet = new Random();

            for (int i = 0; i < abc.Length; i++)
            {
                abc[i] = randet.Next(1, 26);
                if (abc[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int fA = 0;

            int sA = 0;

            int[] firstArray = new int[evenCount];

            int[] secondArray = new int[oddCount];

            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] % 2 == 1)
                {
                    secondArray[sA] = abc[i];
                    sA++;
                }
                else
                {
                    firstArray[fA] = abc[i];
                    fA++;
                }
            }

            char[] evenLetters = new char[evenCount];

            char[] oddLetters = new char[oddCount];

            char[] capitalLetters = { 'a', 'e', 'i', 'd', 'h', 'j' };

            int counterEven = 0;

            int counterOdd = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                evenLetters[i] = alphabet[firstArray[i]];
                if (evenLetters[i] == capitalLetters[0])
                {
                    evenLetters[i] = 'A';

                    counterEven++;
                }
                else if (evenLetters[i] == capitalLetters[1])
                {
                    evenLetters[i] = 'E';

                    counterEven++;
                }
                else if (evenLetters[i] == capitalLetters[2])
                {
                    evenLetters[i] = 'I';

                    counterEven++;
                }
                else if (evenLetters[i] == capitalLetters[3])
                {
                    evenLetters[i] = 'D';

                    counterEven++;
                }
                else if (evenLetters[i] == capitalLetters[4])
                {
                    evenLetters[i] = 'H';

                    counterEven++;
                }
                else if (evenLetters[i] == capitalLetters[5])
                {
                    evenLetters[i] = 'J';

                    counterEven++;
                }
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                oddLetters[i] = alphabet[secondArray[i]];
                if (oddLetters[i] == capitalLetters[0])
                {
                    oddLetters[i] = 'A';

                    counterOdd++;
                }
                else if (oddLetters[i] == capitalLetters[1])
                {
                    oddLetters[i] = 'E';

                    counterOdd++;
                }
                else if (oddLetters[i] == capitalLetters[2])
                {
                    oddLetters[i] = 'I';

                    counterOdd++;
                }
                else if (oddLetters[i] == capitalLetters[3])
                {
                    oddLetters[i] = 'D';

                    counterOdd++;
                }
                else if (oddLetters[i] == capitalLetters[4])
                {
                    oddLetters[i] = 'H';

                    counterOdd++;
                }
                else if (oddLetters[i] == capitalLetters[5])
                {
                    oddLetters[i] = 'J';

                    counterOdd++;
                }
            }

            if (counterEven > counterOdd)
            {
                Console.WriteLine("Even Letters > Odd Letters");
            }
            else
            {
                Console.WriteLine("Odd Letters > Even Letters");
            }

            for (int i = 0; i < evenLetters.Length; i++)
            {
                Console.Write(evenLetters[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < oddLetters.Length; i++)
            {
                Console.Write(oddLetters[i] + " ");
            }
        }
    }
}