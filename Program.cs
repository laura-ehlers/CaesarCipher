using System;
using System.Reflection.PortableExecutable;

namespace CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please enter your secret message: ");
            string messageInput = Console.ReadLine();
            char [] secretMessage = messageInput.ToCharArray();
            char[] encryptedMessage = new char [secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int position = (Array.IndexOf(alphabet,letter) + 3) % alphabet.Length;
                char encryptedLetter = alphabet[position];
                encryptedMessage[i] = encryptedLetter; 
                
            }

            string encodedString = String.Join("", encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}");
            
            
        }

    

    }
}