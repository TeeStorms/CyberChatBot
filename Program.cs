using System;
using System.Media;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text;
using System.Data.SqlTypes;

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

            // Display an instruction for the user to maximize the window
            Console.WriteLine("\n====================================================");
            Console.WriteLine("|    For the best experience, please maximize your  |");
            Console.WriteLine("|    window before continuing the application.      |");
            Console.WriteLine("====================================================");
            Console.ResetColor();

            // Prompt user to press a key before proceeding
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue...");
            Console.ResetColor();
            Console.ReadKey(true); // Waits for user input

            // Display welcome message
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n==================================================");
            Console.WriteLine("|          WELCOME TO YOUR CYBERSECURITY ASSISTANT! |");
            Console.WriteLine("==================================================");
            Console.ResetColor();

            // Display ASCII art related to cybersecurity
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
           Fight Bugs                      |     |
                                \\_V_//
                                \/=|=\/
                                 [=v=]
                               __\___/_____
                              /..[  _____  ]
                             /_  [ [  M /] ]
                            /../.[ [ M /@] ]
                           <-->[_[ [M /@/] ]
                          /../ [.[ [ /@/ ] ]
     _________________]\ /__/  [_[ [/@/ C] ]
    <_________________>>0---]  [=\ \@/ C / /   
       ___      ___   ]/000o   /__\ \ C / /    
          \    /              /....\ \_/ /     
       ....\||/....           [___/=\___/     
      .    .  .    .          [...] [...]    
     .      ..      .         [___/ \___]     
     .    0 .. 0    .         <---> <--->    
  /\/\.    .  .    ./\/\      [..]   [..]    
 / / / .../|  |\... \ \ \    _[__]   [__]_   
/ / /       \/       \ \ \  [____>   <____]                                                     
            ");
            Console.ResetColor();

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