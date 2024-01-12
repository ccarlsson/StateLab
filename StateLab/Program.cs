

ElevatorState state = new ElevatorStateStopped(0); // Skapa hissen


while (true)
{
    state = state.Move(); // Slå på strömmen...
}




public abstract class ElevatorState(int floor, int targetFloor)
{
    protected int _floor = floor;
    public int Floor { get { return _floor; } }
    public int TargetFloor { get; set; } = targetFloor;
    public abstract ElevatorState Move();
}


public class ElevatorStateMovingUp(int floor, int targetFloor) : ElevatorState(floor, targetFloor)
{

    public override ElevatorState Move()
    {
        if (Floor < TargetFloor)
        {
            _floor++;
            Console.WriteLine($"Moving up... {Floor}");
           Thread.Sleep(200);
            return this;
        }
        else
        {
            return new ElevatorStateStopped(Floor);
        }
    }
}


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


public class ElevatorStateStopped(int floor) : ElevatorState(floor, floor)
{
    public override ElevatorState Move()
    {
        Console.WriteLine($"Elevator is stopped at floor {Floor}");
        Console.WriteLine("Enter target floor:");
        int targetFloor = int.Parse(Console.ReadLine());
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