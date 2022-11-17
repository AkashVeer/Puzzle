using NUnit.Framework;

namespace Assignment.Tests;

public class ConsoleRunnerTests
{
    [Test]
    public void ConsoleRunner_ReturnsPlcCountWithRunState_ShouldBeSuccessful()
    {
        //Arrange
        var numberOfEmployeesAndPlc = 1100;
        
        //Act
        var result = ConsoleRunner.Run(numberOfEmployeesAndPlc);
        
        //Assert
        Assert.AreEqual(33, result);
    }
}