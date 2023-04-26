// See https://aka.ms/new-console-template for more information

using System;

namespace TextOutput1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // First String variable
            const string firstSentence = "Inigo Montoya stood before Count Rugen";
            
            // Second String variable
            const string firstSpeech = "He said, \"My name is Inigo Montoya. You killed my father. Prepare to die.\"";
            
            // Print 'em Out
            Console.WriteLine(firstSentence + "\n" + firstSpeech);
        }
    }
}