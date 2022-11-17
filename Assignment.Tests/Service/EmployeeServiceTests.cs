using Assignment.Services.Employee;
using NUnit.Framework;

namespace Assignment.Tests.Service;

public class EmployeeServiceTests
{
    [Test]
    public void GenerateListOfEmployees_ReturnsEmployeeList_WhenNumberOfEmployeePassed_ShouldBeSuccessFul()
    {
        //Arrange
        var employeeCount = 1100;
        
        //Act
        var result = EmployeeService.GenerateListOfEmployees(employeeCount);
        
        //Assert
        Assert.IsNotEmpty(result);
    }
}