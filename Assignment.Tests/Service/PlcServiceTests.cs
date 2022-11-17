using System.Collections.Generic;
using Assignment.Models;
using Assignment.Models.Enums;
using Assignment.Services.PLC;
using NUnit.Framework;

namespace Assignment.Tests.Service;

public class PlcServiceTests
{
    [Test]
    public void GetListOfBasicPLCs_ReturnsListOfPlc_When_NumberofPlcPassed_ShouldBeSuccessful()
    {
        //Arrange
        var PlcCount = 110;
        
        //Act
        var result = PlcService.GetListOfBasicPLCs(PlcCount);
        
        //Assert
        Assert.IsNotEmpty(result);
    }
    
    [Test]
    public void CountPlcState_When_StateIsPassed_ReturnsCount_ShouldBeSuccessful()
    {
        //Arrange
        var PlcList = new List<BasicPLC>()
        {
            new (State.RUN),
            new (State.RUN),
            new (State.PROGRAM)
        };
        
        //Act
        var result = PlcService.CountState(PlcList, State.RUN);
        
        //Assert
        Assert.AreEqual(2, result);
    }
}