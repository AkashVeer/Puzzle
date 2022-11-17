using Assignment.Models.Enums;

namespace Assignment.Models;

public class Employee
{
    private Operations _operations;

    public Employee(Operations operations){
        this._operations = operations;
    }

    public Operations getEmployeeOperations() {
        return this._operations;
    }
}