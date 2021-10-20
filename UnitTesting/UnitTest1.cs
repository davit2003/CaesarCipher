using CaesarCipher;
using System;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void EncryptionTest()
        {
            Assert.Equal("QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD", CaesarCipher.CaesarCipher.Encrypt("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG".ToCharArray()));
        }
        [Fact]
        public void DecryptionTest()
        {
            Assert.Equal("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", CaesarCipher.CaesarCipher.Decrypt("QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD".ToCharArray()));
        }
    }
}
