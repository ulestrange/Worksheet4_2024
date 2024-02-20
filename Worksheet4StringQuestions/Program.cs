using System.ComponentModel;

namespace Worksheet4StringQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintEveryThirdCharacter("abcdefghij123456789");
            PrintEveryThirdCharacter("");
            PrintEveryThirdCharacter("ab");

            Console.WriteLine(AddDashes("123456789"));
            Console.WriteLine(AddDashes("123"));
            Console.WriteLine(AddDashes("1"));
            Console.WriteLine(AddDashes(""));
        }

        //static void PrintCharacters (string input)
        //{
        //    for (int i = 0; i < input.Length; i++) {
        //        Console.WriteLine(input[i]);
        //}


        static void PrintCharacters(string input)
        {
            foreach (char c in input)
            { Console.WriteLine(c); }
        }

        static void PrintEveryThirdCharacter(string input)
        {
            for (int i = 2; i < input.Length; i += 3)
            {
                Console.WriteLine(input[i]);
            }
        }

        static int CountxoryInString (string input)
        {
            int count = 0;

            for (int i=0; i < input.Length; i++)
            {
                if (input[i] =='x' || input[i] == 'y')
                {
                    count++;
                }

            }
            return count;
        }

        static string EveryThirdCharacter (string input)
        {
            string answer = "";
            for (int i = 2; i < input.Length; i += 3)
            {
                answer += input[i];
            }

            return answer;

            // note this is not the most efficent way of doing this.
            // if you are working with long string then you should use a
            // string builder rather than appending to a string each time.
        }

        static bool HasNummericFirstCharacter(string input)
        {
            return (input.Length > 0 && input[0] >= '0' && input[0] <= '9');
        }


        static string AddDashes(string input)
        {
            string answer = "";
            for (int i = 0; i < input.Length; i ++)
            {
                answer += input[i];

                if ((i+1) % 3 == 0 && (i+1) != input.Length )
                {
                    answer += '-';
                }
            }

            return answer;

            // note this is not the most efficent way of doing this.
            // if you are working with long string then you should use a
            // string builder rather than appending to a string each time.
        }
    }
}