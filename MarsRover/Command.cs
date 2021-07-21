using System;
//namespace MarsRover
namespace MarsRoverNS
{
    // Command: A type of object containing a CommandType field.
    // CommandType is one of the given strings in the table below.
    //
    //                                          R O V E R    C O M M A N D    T Y P E S
    //
    //  Command         Value sent with command                                         Updates to Rover object
    //  MOVE            Number representing the position the rover should move to.      Position
    //  MODE_CHANGE     String representing rover mode(see modes)                       Mode
    //                  * NOTE: The rover does not move while in "LOW_POWER" mode.
    //
    //                                          R O V E R    M O D E S 
    //  Mode            Restrictions
    //  LOW-POWER       Can't be moved in this state
    //  NORMAL          None
    //
    //
    // Some CommandTypes are coupled with a NewPosition property and
    // some are coupled with a NewMode property.
    // Every Command object is a single instruction to be delivered to the rover.
    public class Command
    {
        public string CommandType { get; set; }
        // CommandType is a string that represents the type of command.
        // A command type will be one of the following: 'MODE_CHANGE' or 'MOVE'.

        public int NewPosition { get; set; }
        // NewPosition is an int value provided in conjunction with a “MOVE” command type.

        public string NewMode { get; set; }
        // NewMode is a string value provided in conjunction with a “MODE_CHANGE” command type.

        public Command() { }

        public Command(string commandType)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
        }

        public Command(string commandType, int value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            // NewPosition = value;
            this.NewPosition = value;
        }

        public Command(string commandType, string value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            NewMode = value;
        }

        public Command(string commandType, int value, string setMode)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            NewPosition = value;
            NewMode = setMode;
        }

    }
}


/*
 *                                      --- From Mr. Campbell's Q&A ---
Comand.cs
using System;
namespace MarsRoverNS
{
    public class Command
    {
        public string CommandType { get; set; }
        public int NewPosition { get; set; }
        public string NewMode { get; set; }
        public Command() { }
        public Command(string commandType)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
        }
        public Command(string commandType, int value)
        {
            this.CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            this.NewPosition = value;
        }
        public Command(string commandType, string value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            NewMode = value;
        }
    }
}
*
*/
