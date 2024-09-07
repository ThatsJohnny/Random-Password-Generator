using System;
using System.Security.Cryptography;

namespace Random_Password_Generator
{
    public class Random // 100% Random using RNGCryptoServiceProvider
    {
        public int Next(int n)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            var randomInteger = BitConverter.ToUInt32(byteArray, 0);
            return (int)(randomInteger % n);
        }
    }
}
