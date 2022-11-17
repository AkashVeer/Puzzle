using System.Collections.Generic;
using Assignment.Controller;
using Assignment.Models;
using Assignment.Models.Enums;
using NUnit.Framework;

namespace Assignment.Tests.Controller;

public class AssemblyLineModeratorTests
{
    [Test]
    public void UpdateState_UpdatesPlcStateList_ShouldBeSuccessful()
    {
        //Arrange
        var employeeList = new List<Employee>()
        {
            new(Operations.SET_RUN)
        };

        var PlcList = new List<BasicPLC>()
        {
            new(State.PROGRAM)
        };
        
        //Act
        AssemblyLineModerator.UpdateState(employeeList, PlcList);
        
        //Assert
        Assert.AreEqual(State.RUN, PlcList[0].GetState());
    }
}