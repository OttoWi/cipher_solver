using System;

namespace BasicCipherTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Cipher Tool");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1: Caesar Cipher Encryption");
            Console.WriteLine("2: Caesar Cipher Decryption");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.WriteLine("Enter the text to encrypt:");
                string plainText = Console.ReadLine();
                Console.WriteLine("Enter the shift value (1-25):");
                int shift = int.Parse(Console.ReadLine());

                string encryptedText = CaesarEncrypt(plainText, shift);
                Console.WriteLine($"Encrypted text: {encryptedText}");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the text to decrypt:");
                string cipherText = Console.ReadLine();
                Console.WriteLine("Enter the shift value (1-25):");
                int shift = int.Parse(Console.ReadLine());

                string decryptedText = CaesarDecrypt(cipherText, shift);
                Console.WriteLine($"Decrypted text: {decryptedText}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
        
        static string CaesarEncrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((letter - offset + shift) % 26 + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        
        static string CaesarDecrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((letter - offset - shift + 26) % 26 + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}