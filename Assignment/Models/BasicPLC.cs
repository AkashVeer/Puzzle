using Assignment.Models.Enums;

namespace Assignment.Models;

public class BasicPLC
{
    private State _state;
    
    public BasicPLC(){
        this._state = State.UNKNOWN;
    }

    public BasicPLC(State state){
        this._state= state;
    }

    private BasicPLC(BasicPLC basicPLC){
        this._state = basicPLC.GetState();
    }

    public BasicPLC GetPLC(){
        return new BasicPLC(this);
    }

    public void SetState(State state) {
        this._state = state;
    }

    public State GetState(){
        return this._state;
    }
}