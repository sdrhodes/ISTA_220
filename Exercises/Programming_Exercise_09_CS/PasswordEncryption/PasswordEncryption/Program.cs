using System;
using System.Security.Cryptography;
using System.Text;


//Altered from https://stackoverflow.com/questions/9031537/really-simple-encryption-with-c-sharp-and-symmetricalgorithm
//Credit to Sam Greenhalgh

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a string");
        string expected = Console.ReadLine();
        string a = expected.Crypt();
        Console.WriteLine(a);
        string actual = a.Decrypt();
        Console.WriteLine(actual);
    }
}

public static class StringUtil
{
    private static byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private static byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

    public static string Crypt(this string text)
    {
        SymmetricAlgorithm algorithm = DES.Create();
        ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
        byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
        byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
        return Convert.ToBase64String(outputBuffer);
    }

    public static string Decrypt(this string text)
    {
        SymmetricAlgorithm algorithm = DES.Create();
        ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
        byte[] inputbuffer = Convert.FromBase64String(text);
        byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
        return Encoding.Unicode.GetString(outputBuffer);
    }
}
