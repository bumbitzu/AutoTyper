using System.Security.Cryptography;

namespace RRandom
{
    internal class Rdm
    {
        public static void Random_(ref int num)
        {
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            rand.GetBytes(randomNumber);
            num = (randomNumber[0] % 16);
        }
    }
}
