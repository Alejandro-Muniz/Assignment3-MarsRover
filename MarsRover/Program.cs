using System;

//namespace MarsRover
namespace MarsRoverNS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Rover myRover = new Rover(20);
            // Console.WriteLine(myRover.ToString());
            Command command1 = new Command("MOVE", 5000);
            Command command2 = new Command("MOVE", 5000);
            Command[] commands =
            {
                new Command("MOVE", 5000),
                new Command("MOVE", 6000),
                new Command("MOVE", 10000)
            };
            string[] names = { "Marvin", "TheMartian" };  // why do I have an array of names?
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);    // Passes 98382 as the rover's position.
            Console.WriteLine(newRover.ToString());
            newRover.ReceiveMessage(newMessage);
            Console.WriteLine(newRover.ToString());
        }
    }
}


/*
 *                                      --- From Mr. Campbell's Q&A ---
 // Program.cs
using System;
namespace MarsRoverNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Command command1 = new Command("MOVE", 5000);
            Command command2 = new Command("MOVE", 5000);
            Command[] commands = {
                new Command("MOVE", 5000),
                new Command("MOVE", 6000),
                new Command("MOVE", 10000)
        };
            string[] names = { "Roger", "Doc" };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);    // Passes 98382 as the rover's position.
            Console.WriteLine(newRover.ToString());
            newRover.ReceiveMessage(newMessage);
            Console.WriteLine(newRover.ToString());
        }
    }
}
*
*/