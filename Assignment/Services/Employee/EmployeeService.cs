using Assignment.DataService;
using Assignment.Models;
using Assignment.Models.Enums;

namespace Assignment.Services.Employee;

public static class EmployeeService
{
    public static List<Models.Employee> GenerateListOfEmployees(int numberOfEmployees) {
        var employeesList = new List<Models.Employee>();
        for (int i = 0; i < numberOfEmployees; i++) {
            employeesList.Add(BuildEmployee(i));
        }
        return employeesList;
    }

    private static Models.Employee BuildEmployee(int employeeIndex) {
        switch (employeeIndex) {
            case 0:
                return EmployeeDataService.GetEmployee(Operations.SET_RUN);
            case 1:
                return EmployeeDataService.GetEmployee(Operations.SET_PROGRAM);
            default:
                return EmployeeDataService.GetEmployee(Operations.SET_RUN_OR_PROGRAM);
        }
    }
}