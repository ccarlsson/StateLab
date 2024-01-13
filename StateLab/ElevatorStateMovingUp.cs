namespace StateLab;

public sealed class ElevatorStateMovingUp(int floor, int targetFloor) : ElevatorState(floor, targetFloor)
{ 
    public override ElevatorState Move()
    {
        if (Floor < TargetFloor)
        {
            Thread.Sleep(200);
            _floor++;
            return this;
        }
        else
        {
            return new ElevatorStateStopped(Floor);
        }
    }
}