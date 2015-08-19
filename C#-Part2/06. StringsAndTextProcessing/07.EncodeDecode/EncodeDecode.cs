using System;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Please enter a string to encode/decode: ");
        string str = Console.ReadLine();
        Console.Write("Please enter a encryption key: ");
        string cipher = Console.ReadLine();
        Console.WriteLine("The encoded string is {0}", Encode(str, cipher));
        Console.WriteLine("The decoded string is {0}", Decode(str, cipher));
    }

    static string Encode (string str, string cipher)
    {
        string encodedStr = string.Empty;
        for (int i = 0, j = 0; i < str.Length; i++, j++)
        {
            encodedStr += (char)(str[i] ^ cipher[j]);
            if (j == cipher.Length - 1)
            {
                j = -1;
            }
        }
        return encodedStr;
    }

    static string Decode (string str, string cipher)
    {
        string decodedStr = Encode(Encode(str, cipher), cipher);
        return decodedStr;
    }
}