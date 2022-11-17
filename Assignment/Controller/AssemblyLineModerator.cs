using Assignment.Models;
using Assignment.Models.Enums;

namespace Assignment.Controller;

public class AssemblyLineModerator
{
    public static void UpdateState(List<Employee> employeesList, List<BasicPLC> basicPLCList){
        for (int i = 0 ; i < employeesList.Count() ; i++){
            int plcIterator = i;
            var employee = employeesList[i];
            while (plcIterator < employeesList.Count()){
                var basicPLC = basicPLCList[plcIterator];
                SetPLCState(employee, basicPLC);

                plcIterator += i + 1;
            }
        }
    }

    private static void SetPLCState(Employee employee, BasicPLC basicPLC){
        switch (employee.getEmployeeOperations()){
            case Operations.SET_RUN:
                basicPLC.SetState(State.RUN);
                break;
            case Operations.SET_PROGRAM:
                basicPLC.SetState(State.PROGRAM);
                break;
            case Operations.SET_RUN_OR_PROGRAM:
                SetDefaultState(basicPLC);
                break;
            default: throw new Exception("Operation out of scope");
        }
    }

    private static void SetDefaultState(BasicPLC basicPLC){
        var plcState = basicPLC.GetState();
        switch (plcState) {
            case State.PROGRAM:
                basicPLC.SetState(State.RUN);
                break;
            case State.RUN:
                basicPLC.SetState(State.PROGRAM);
                break;
        }
    }
}