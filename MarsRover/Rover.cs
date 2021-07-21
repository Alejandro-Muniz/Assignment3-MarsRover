using System;
//namespace MarsRover
namespace MarsRoverNS
{
    // Rover: An object representing Curiosity, the mars rover.
    // This class contains information on the rover’s --'Position'--,
    // operating --'Mode'--, and --'GeneratorWatts'--.
    // It will also contain a method that you will write, --'ReceiveMessage'--.
    // This method will include conditional statements for each type of
    // command the rover receives and updates the rover’s properties.
    //

    // Rover receives a message object, updates its properties from the message, and returns the results
    // Rover Class:
    // This class builds a rover object with a few properties.
    // It will also contain a method called ReceiveMessage to handle updates to its properties.
    // 
    //  1.  public Rover(int position)
    //      a.  position is a number representing the rover’s position.
    //      b.  Sets Position to position
    //      c.  Sets Mode to 'NORMAL'
    //      d.  Sets default value for generatorWatts to 110
    //  2.  public void ReceiveMessage(Message message)
    //      a.  message is a Message object
    //      b.  This method does not return anything
    //      c.  It applies the contents of the Message sent to update certain properties of the rover object
    //          i.  Details about how to respond to different commands are in the Command Types table.
    //  example:
    //      input:
    //          Command[] commands = {new Command("MOVE", 5000)};
    //          Message newMessage = new Message("Test message with one command", commands);
    //          Rover newRover = new Rover(98382);    // Passes 98382 as the rover's position.
    //
    //          Console.WriteLine(newRover.ToString());
    //
    //          newRover.ReceiveMessage(newMessage);
    //          Console.WriteLine(newRover.ToString());
    //      output:
    //          Position: 98382 - Mode: NORMAL - GeneratorWatts: 110
    //          Position: 5000 - Mode: NORMAL - GeneratorWatts: 110

    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }



        public Rover(int position)
        {
            this.Position = position;
            this.Mode = "NORMAL";
            this.GeneratorWatts = 100;
        }

        // -- replacing code block below with code from Q&A
        // public override string ToString()           // what is this overiding?
        // {
        //     return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;   //?
        // }
        // --

        public void ReceiveMessage(Message message)  //changed Received to Receive. one of my many typos
        {
            // This method will include conditional statements for each type of
            // command the rover receives and updates the rover’s properties.
            //
            //
            // Command: A type of object containing a CommandType field.
            // CommandType is one of the given strings in the table below.
            // Some CommandTypes are coupled with a NewPosition property and
            // some are coupled with a NewMode property.
            // Every Command object is a single instruction to be delivered to the rover.
            //
            // CommandType is a string that represents the type of command.
            // A command type will be one of the following: 'MODE_CHANGE' or 'MOVE'.
            // * NOTE: The rover does not move while in "LOW_POWER" mode.

            foreach (Command command in message.Commands)
            {
                if (command.CommandType == "MODE_CHANGE")
                {
                    this.Mode = command.NewMode;
                }
                    // this.Mode = command.NewMode;
                if (this.Mode == "NORMAL")
                {
                    this.Position = command.NewPosition;
                }
                else if (this.Mode == "LOW_POWER")
                {
                    // Rover doesn't move while in "LOW_POWER" mode. stays in "this.Position"
                }

                
            }
        }
                     

        public override string ToString()
        {
            return $"Position: {this.Position} | Mode: {this.Mode} | GeneratorWatts: {this.GeneratorWatts}";
        }



        //bool IAmLost = true;
        //bool IAmgettingMoreLost = true;
        //if(IAmLost) do
        //    {
        //        //something || anything
        //    } while(IAmgettingMoreLost);
    }
}


/*
 *                                      --- From Mr. Campbell's Q&A ---
// Rover.cs
using System;
namespace MarsRoverNS
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }
        public Rover()
        { }
        public Rover(int position)
        {
            this.Position = position;
            this.Mode = "NORMAL";
            this.GeneratorWatts = 100;
        }
        public void ReceiveMessage(Message message)
        {
             foreach(Command command in message.Commands)
            {
                this.Position = command.NewPosition;
            }
        }
        public override string ToString()
        {
            return $"Position: {this.Position} | Mode: {this.Mode} | GeneratorWatts: {this.GeneratorWatts}";
        }
    }
}
*
*/
