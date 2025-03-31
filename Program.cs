using System;
using System.Media;
using System.IO;

namespace CybersecurityChatBot
{
    class Program
    {
        static void Main()
        {
            // Clear console and set colors for better readability
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // Path to the audio file
            string audioFilePath = Path.Combine("audio.wav");

            // Check if the welcome audio file exists
            if (File.Exists(audioFilePath))
            {
                try
                {
                    // Play audio if the file is found
                    SoundPlayer player = new SoundPlayer(audioFilePath);
                    player.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing audio: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\nOops! Audio file not found.");
            }

            // Ask user for their name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("\n==================================================");

            Console.WriteLine($"\nHello {name}, chatbot functionalities have been removed.");
            Console.Beep();
        }
    }
}