using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverNS;

namespace MarsRoverTests
{
    [TestClass]

    //          Recall, the role of a message object is to bundle commands to send to the rover.
    //          Message Class
    //          This class builds an object with two properties:
    //          Message(string name, Command[] commands)
    //          Name        is a string that is the name of the message.
    //          Commands    is an array of Command objects.
    //          example:
    //          Command[] commands = {new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500)};
    //          Message newMessage = new Message("Test message with two commands", commands);
    //  Message Tests
    //  At the same level as CommandTests, open the test file MessageTests
    //  and write the unit tests for the Message class as described below.
    //  TIP:
    //      Inside this test file, you will have to create at least one commands array,
    //      fill it with some Command objects, and pass it into the Message constructors you are testing.
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };  //why do I have this line?




        //  It will look similar to the first test in the CommandTests file.
        //  Review the first test in CommandTests for an example of how to write this test.
        [TestMethod] // Test 5      “ArgumentNullExceptionThrownIfNameNotPassedToConstructor”
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
                //Assert.AreEqual("'Oops'", ex.Message);  //testing should return a fail.  Expected: 'Oops' Actual Command: Type required

            }
        }



        //  The test confirms that the constructor in the Message class
        //  correctly sets the Name property in a new message object.
        [TestMethod] //Test 6       “ConstructorSetsName”
        public void ConstructorSetsName()
        {
            Message message1 = new Message("test Message", commands);
            Assert.AreEqual("test Message", message1.Name);
        }

        [TestMethod] //Test 7       “ConstructorSetsCommandsField”

        //  This test confirms that the Commands property of a new message object
        //  contains the data passed in from the Message(name, commands) call.
        public void ConstructorSetsCommandsField()
        {
            Message message1 = new Message("test Message", commands);
            Assert.AreEqual(commands, message1.Commands);
        }
    }
}
