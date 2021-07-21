using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverNS;
using System;

namespace MarsRoverTests

{
    [TestClass]

    //  To begin, open and examine MarsRoverTests/CommandTests.cs.
    //  Two tests have been created for you.
    //  When a user creates a new Command object from the class,
    //  we want to make sure they pass a command type as the first argument.

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
    public class CommandTests
    {

        [TestMethod] // Test 1      “ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty”

        // a.   Look at the constructors in Command.cs.
        //      In each, a null or empty commandType argument results in an exception thrown.
        //
        // b.   Use the “Tests” tab in Visual Studio to run the Command unit tests.
        //      Verify that the tests pass.
        //
        // c.   Next, change the first assertion in CommandTests.cs to expect message: 'Oops'.
        //      Run the tests again to verify that the test fails
        //      (the error message did not match "Command type required.").
        //
        // d.   Restore the Assert method’s expected argument to be "Command type required.".
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
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

        [TestMethod] //Test 2       “ConstructorSetsCommandType”

        // a.   Without editing, Command.cs contains the correct code.
        //      Click “Run” to verify that the first and second tests both pass.
        //
        // b.   You do not need to catch an exception in this test.
        //
        // c.   You may not need to know the specific types of commands to write this test.
        //      In fact, you can change the commandType input to any string value and run the test.
        //      Does it still pass?
        public void ConstructorSetsCommandType()
        {
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
            //Assert.AreEqual(newCommand.CommandType, "any string"); //test failed Expected: MOVE Actual: any string
        }

        [TestMethod] // Test 3      “ConstructorSetsInitialNewPositionValue”

        // a.   You may not need to know a proper NewPosition value in order to write this test.      
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPosition, 20);
        }

        [TestMethod] // Test 4      “ConstructorSetsInitialNewModeValue”

        // a.   Write the test to check that a Command constructor that is passed a
        //      second string value will set that string value to NewMode.
        //
        // b.   Run the test suite. This new test will initially fail.
        //
        // c.   Add an additional constructor to Command that sets the NewMode field when passed a string value.
        //
        // d.   Re-run the tests. Your new test should pass now.
        public void ConstructorSetsInitialNewModeValue()
        {
            Command newCommand = new Command("MOVE", 20, "NORMAL");
            Assert.AreEqual(newCommand.NewMode, "NORMAL");
        }

    }
}
