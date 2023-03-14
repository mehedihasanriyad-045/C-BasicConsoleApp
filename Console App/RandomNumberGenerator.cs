using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal static class RandomNumberGenerator
    {
        private static readonly Random random = new Random();

        public static int Generate()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt32(buffer, 0) ^ random.Next();
        }
    }
}
