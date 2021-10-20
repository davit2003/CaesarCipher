using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public static string Encrypt(char[] Text)
        {
            for(int i = 0; i < Text.Length; i++)
                if (Text[i] != ' ')
                    Text[i] = (char)(65 + ((short)Text[i] - 42) % 26);

            return new string(Text);
        }
        public static string Decrypt(char[] Text)
        {
            for (int i = 0; i < Text.Length; i++)
                if (Text[i] != ' ')
                    Text[i] = (char)(65 + ((short)Text[i] - 62) % 26);

            return new string(Text);
        }
    }
}
