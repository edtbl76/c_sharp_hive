using System;

namespace CaesarCipher
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // storage
            var alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            


            // Get Input from User
            Console.Write("Enter Message To Be Encoded: ");
            var secretMessage = Console.ReadLine();
            
            /*
             * Good Practices => readable code
             * Using negative conditionals allows fast exit in failure conditions
             * This also reduces nesting = hard to read. 
             */
            if (secretMessage == null) return;
            
            var encryptedMessage = new char[secretMessage.Length];
            for (var i = 0; i < secretMessage.Length; i++)
            {
                var thisChar = secretMessage[i];
                    
                /*
                     * Get the index of this character in the alphabet array
                     * add three (Rules: Ceaser Cipher)
                     * modulo it for the alphabet array so we don't fall off the edge
                     */
                var index = (Array.IndexOf(alphabet, thisChar) + 3) % alphabet.Length;
                    
                // Set new message character equal to the letter at the adjusted index
                encryptedMessage[i] = alphabet[index];
            }
            Console.WriteLine(String.Join("", encryptedMessage));



        }
    }
}