using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringReversal5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "the cat    ran   uphill";

            char[] chars = input.ToCharArray();

            char[] interim = reverse(chars, 0, input.Length);

            for (int i = 0; i < input.Length; ++i)
            {
                int start = i;
                int len = input.Length;
                while (char.IsWhiteSpace(interim[i]) == false && i < len - 1)
                {
                    ++i;
                }
                int end;
                if (i == input.Length - 1)
                    end = i + 1; //On final swap, add 1 to reset end to the original input.Length
                else
                    end = i;
                if (start < input.Length - 1)
                    reverse(interim, start, end);
            }

            Console.WriteLine(interim);

            Console.ReadLine();

        }

        private static char[] reverse(char[] input, int start, int end)

        {

            int mid = start + ((end - start) / 2);

            int len = input.Length - 1;

            for (int i = start; i < mid; ++i)
            {

                char temp = input[i];

                input[i] = input[end - 1];

                input[end - 1] = temp;
                end--; //After the swap, this shifts the last index down each iteration until the midpoint is reached
            }

            return input;

        }
    }
}