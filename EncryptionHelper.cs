using static System.Array;
using static System.BitConverter;
using static System.Console;
using static System.Convert;
using static System.DateTime;
using static System.DateTimeKind;
using static System.Security.Cryptography.CipherMode;
using static System.Security.Cryptography.PaddingMode;
using static System.Security.Cryptography.RandomNumberGenerator;
using static System.Text.Encoding;

using static TinkeringApp.AESKeyGen;

namespace TinkeringApp;

using System.Security.Cryptography;

// Generate a 256-bit (32-byte) key
public static class AESKeyGen
{
    public static string GenerateKey()
    {
        // Generate a 256-bit (32-byte) key
        byte[] key = new byte[32];
        using var rng = Create();
        rng.GetBytes(key);
        // Convert the key to a string
        return UTF8.GetString(key);
    }
}

public static class EncryptionHelper
{
    private static readonly string _key = GenerateKey();
    public static string Encrypt(string input)
    {
        // Get the current date and time in UTC format
        DateTime now = UtcNow;

        // Add 2 seconds to get the expiry date and time
        DateTime expiry = now.AddSeconds(2);

        // Convert the expiry date and time to a byte array
        byte[] expiryBytes = GetBytes(expiry.Ticks);

        // Concatenate the input string with the expiry byte array
        byte[] inputBytes = UTF8.GetBytes(input);
        byte[] encryptedBytes = new byte[inputBytes.Length + expiryBytes.Length];
        inputBytes.CopyTo(encryptedBytes, 0);
        expiryBytes.CopyTo(encryptedBytes, inputBytes.Length);

        // Encrypt the concatenated byte array using the specified key
        byte[] key = UTF8.GetBytes(_key);
        //trim the key if it is more than 32 bytes
        if (key.Length > 32)
        {
            byte[] temp = new byte[32];
            Copy(key, temp, 32);
            key = temp;
        }
        
        using var aes = Aes.Create();
        aes.Key = key;
        aes.Mode = ECB;
        aes.Padding = PKCS7;
        using var encryptor = aes.CreateEncryptor();
        byte[] encryptedData = encryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

        // Convert the encrypted byte array to a Base64 string
        string encryptedString = ToBase64String(encryptedData);

        // Return the encrypted string
        return encryptedString;
    }

    public static string Decrypt(string input)
    {
        // Convert the input string from Base64 to a byte array
        byte[] encryptedData = FromBase64String(input);

        // Decrypt the encrypted byte array using the specified key
        byte[] key = UTF8.GetBytes(_key);
        if (key.Length > 32)
        {
            byte[] temp = new byte[32];
            Copy(key, temp, 32);
            key = temp;
        }
        
        using var aes = Aes.Create();
        aes.Key = key;
        aes.Mode = ECB;
        aes.Padding = PKCS7;
        using var decrypt = aes.CreateDecryptor();
        byte[] decryptedData = decrypt.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

        // Extract the input string and expiry date from the decrypted byte array
        const int expiryLength = sizeof(long);
        byte[] inputBytes = new byte[decryptedData.Length - expiryLength];
        Copy(decryptedData, inputBytes, inputBytes.Length);
        byte[] expiryBytes = new byte[expiryLength];
        Copy(decryptedData, inputBytes.Length, expiryBytes, 0, expiryLength);

        // Convert the expiry date byte array to a DateTime object
        long ticks = ToInt64(expiryBytes, 0);
        DateTime expiryDate = new(ticks, Utc);

        // Check if the expiry date is within the allowed range
        if (expiryDate < UtcNow)
        {
            WriteLine("Input has expired");
            return string.Empty;
        }

        // Convert the input byte array to a string and return it
        string inputString = UTF8.GetString(inputBytes);
        return inputString;
    }
}