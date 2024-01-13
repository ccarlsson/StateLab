namespace StateLab;

public sealed class ElevatorStateStopped(int floor) : ElevatorState(floor, floor)
{
    public override ElevatorState Move()
    {
        if (Floor < TargetFloor)
        {
            return new ElevatorStateMovingUp(Floor, TargetFloor);
        }
        else if (Floor > TargetFloor)
        {
            return new ElevatorStateMovingDown(Floor, TargetFloor);
        }
        else
        {
            return this;
        }
    }
}