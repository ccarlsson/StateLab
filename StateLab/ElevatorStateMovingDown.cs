



public class ElevatorStateMovingDown(int floor, int targetFloor) : ElevatorState(floor, targetFloor)
{

    public override ElevatorState Move()
    {
        if (Floor > TargetFloor)
        {
            _floor--;
            Console.WriteLine($"Moving down... {Floor}");
            Thread.Sleep(200);
            return this;
        }
        else
        {
            return new ElevatorStateStopped(Floor);
        }
    }
}
