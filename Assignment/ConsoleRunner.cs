using Assignment.Controller;
using Assignment.Models;
using Assignment.Models.Enums;
using Assignment.Services.Employee;
using Assignment.Services.PLC;

namespace Assignment;

public class ConsoleRunner
{
    public static long Run(int numberOfEmployeesAndPLC){
        var employeesList = EmployeeService.GenerateListOfEmployees(numberOfEmployeesAndPLC);
        var basicPLCList = PlcService.GetListOfBasicPLCs(numberOfEmployeesAndPLC);

        AssemblyLineModerator.UpdateState(employeesList, basicPLCList);

        var count = PlcService.CountState(basicPLCList, State.RUN);

        return count;
    }
}