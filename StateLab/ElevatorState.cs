namespace StateLab;

public abstract class ElevatorState(int floor, int targetFloor)
{
    protected int _floor = floor;
    public int Floor { get { return _floor; } }
    public int TargetFloor { get; set; } = targetFloor;
    public abstract ElevatorState Move();
}