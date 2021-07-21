using System;
//namespace MarsRover
namespace MarsRoverNS
{
    // Message: A Message object has a Name field and can contain several Command objects.
    // Message is responsible for bundling the commands from mission control and delivering them to the rover.
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }
        public Message(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Name is required.");
            }
            this.Name = name;
        }
        public Message(Command[] commands)
        {
            this.Commands = commands;
        }
        public Message(string name, Command[] commands)
        {
            this.Name = name;
            this.Commands = commands;
        }
    }
}


/*
 *                                      --- From Mr. Campbell's Q&A ---
Message.cs
using System;
namespace MarsRoverNS
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }
        public Message(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Name is required.");
            }
            this.Name = name;
        }
        public Message(Command[] commands)
        {
            this.Commands = commands;
        }
        public Message(string name, Command[] commands)
        {
            this.Name = name;
            this.Commands = commands;
        }
    }
}
*
*/
