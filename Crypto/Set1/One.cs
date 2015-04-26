using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Set1
{
    public class One
    {
        public static void Solve()
        {
            string hex = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";

            string correct_answer = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

            string my_answer = HexToBase64(hex);

            if (my_answer == correct_answer)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");
            }
        }
        public static string HexToBase64(string hex)
        {
            string base64 = "";

            byte[] floatvals = HexDecode(hex);

            base64 = Convert.ToBase64String(floatvals);

            return base64;
        }
        public static byte[] HexDecode(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
        }
    }
}
