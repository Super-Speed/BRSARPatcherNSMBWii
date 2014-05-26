using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

// From http://code.lummie.co.uk/hex-string-to-byte-array-converter/

namespace BRSARFilePatcher
{
    static class HexStringConverter
    {
        public static byte[] ToByteArray(String HexString)
        {

            if (HexString.Length % 2 != 0)
            {
                //throw new ArgumentException("Hex string is of odd length");
                HexString = "0" + HexString;
            }

            Regex re = new Regex(@"[^0-9A-Fa-f]");

            if (re.IsMatch(HexString))
            {
                throw new ArgumentException("Hex string contains invalid characters");
            }

            //return Encoding.ASCII.GetBytes(HexString);

            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];

            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }

            return bytes;

        }
    }
}


