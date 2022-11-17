using Assignment.Models;
using Assignment.Models.Enums;

namespace Assignment.DataService;

public class EmployeeDataService
{
    private static Dictionary<Operations, Employee> employeeData = new Dictionary<Operations, Employee>();

    public static Employee GetEmployee(Operations operation){
        if (employeeData.ContainsKey(operation))
            return employeeData[operation];
        var employee = new Employee(operation);
        employeeData.Add(operation, employee);
        return employeeData[operation];
    }
}