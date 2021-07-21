using System;
using System.Collections.Generic;
using MarsRoverNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]

    //  Open RoverTests.cs and write the following tests.
    //  Write the code to make them pass in Rover.cs.
    //  Remember to use the given phrase as the test method name. 
    public class RoverTests
    {


        //      Refer to the Rover Class description above for the default value.
        [TestMethod] //Test 8       “ConstructorSetsDefaultPosition”
        public void ConstructorSetsDefaultPosition()
        {
            Rover rover1 = new Rover(5);
            Assert.AreEqual(5, rover1.Position);
        }

        [TestMethod] //Test 9       “ConstructorSetsDefaultMode”
        public void ConstructorSetsDefaultMode()
        {
            Rover rover1 = new Rover(5);
            Assert.AreEqual("NORMAL", rover1.Mode);
        }

        [TestMethod] //Test 10      “ConstructorSetsDefaultGeneratorWatts”
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover rover1 = new Rover(5);
            Assert.AreEqual(100, rover1.GeneratorWatts);
        }

        [TestMethod] //Test 11      “RespondsCorrectlyToModeChangeCommand”
        
        // a.   The test should check that when a rover object receives a message that
        //      contains a “MODE_CHANGE” command, that rover’s Mode field is updated.
        //
        // b.   The rover has two modes that can be passed as values to a
        //      mode change command, “LOW_POWER” and “NORMAL”.
        public void RespondsCorrectlytoModeChangeCommand()
        {
            Command[] commands =
            {
                new Command("MODE_CHANGE", "LOW_POWER")
  
            };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual("LOW_POWER", newRover.Mode);
            // RecieveMessage should iterate over an array of Commands
            // Pull out each Position and set Rover.Position to its value
            // I can handle that by .....
        }

        [TestMethod] //Test 12      “DoesNotMoveInLowPower”

        // a.   The test confirms that the rover position does not change
        //      when sent a “MOVE” command in “LOW_POWER” mode.
        //
        // b.   Use the Rover Modes table for guidance on how to
        //      handle move commands in different modes.
        public void DoesNotMoveInLowPower()
        {
            Command[] commands =
            {
                new Command("MODE_CHANGE", "LOW_POWER"), // 0
                
                new Command("MOVE", 6000), // 1
            };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(98382, newRover.Position);
        }

        [TestMethod] //Test 13      “PositionChangesFromMoveCommand”

        // a.   A MOVE command will update the rover’s position with
        //      the position value in the command.
        //      * The rover does not move while in "LOW_POWER" mode.
        public void PositionChangesFromMoveCommand()
        {
            Command[] commands =
            {
                new Command("MODE_CHANGE", "NORMAL"),
                
                new Command("MOVE", 6000), // 1
            };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(6000, newRover.Position);
        }
    }
}


/*
 *                                      --- From Mr. Campbell's Q&A --- 
RoverTest.cs
 [TestMethod]  // Test 11
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = {
                new Command("MOVE", 5000), // 0
                new Command("MOVE", 6000), // 1
                new Command("MOVE", 10000) // 2
            };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Position, commands[2].NewPosition);
            // RecieveMessage should iterate over an array of Commands
                // Pull out each Position and set Rover.Position to its value
                // I can handle that by .....
        }
*
*/
