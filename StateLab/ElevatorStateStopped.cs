public class ElevatorStateStopped(int floor) : ElevatorState(floor, floor)
{
    public override ElevatorState Move()
    {
        Console.WriteLine($"Elevator is stopped at floor {Floor}");
        Console.WriteLine("Enter target floor:");
        int targetFloor = int.TryParse(Console.ReadLine(), out targetFloor) ? targetFloor : Floor;
        TargetFloor = targetFloor;
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