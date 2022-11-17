using Assignment.Models;
using Assignment.Models.Enums;

namespace Assignment.Services.PLC;

public class PlcService
{
    public static List<BasicPLC> GetListOfBasicPLCs(int numberOfPlc)
    {
        var basicPlcs = new List<BasicPLC>();
        var basicPlc = new BasicPLC();
        for (int i = 0 ; i < numberOfPlc ; i ++){
            basicPlcs.Add(basicPlc.GetPLC());
        }

        return basicPlcs;
    }
    
    public static long CountState(List<BasicPLC> simplePLCList, State state)
    {
        return simplePLCList.Count(x => x.GetState().Equals(state));
    }
}