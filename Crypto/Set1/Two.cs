using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Set1
{
    public class Two
    {
        public static void Solve()
        {
            string hex1 = "1c0111001f010100061a024b53535009181c";
            string hex2 = "686974207468652062756c6c277320657965";

            byte[] decoded1 = One.hexDecode(hex1);
            byte[] decoded2 = One.hexDecode(hex2);

            string correct_answer = "746865206b696420646f6e277420706c6179";

            string my_answer = xor(decoded1, decoded2);


            if (my_answer == correct_answer)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");
            }

        }
        public static string xor(byte[] input1, byte[] input2)
        {
            string result = "";
            List<byte> xorResult = new List<byte>();

            for (int i = 0; i < input1.Length;i++ )
            {
                var xor = (byte)(input1[i] ^ input2[i]);
                xorResult.Add(xor);
            }
            result = Convert.ToBase64String(xorResult.ToArray());
            return result;
        }

    }
}
