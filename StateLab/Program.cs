 using StateLab;

ElevatorState state = new ElevatorStateStopped(0); // Skapa hissen

while (true)
{
    state = state.Move(); // Flytta hissen
    switch(state)
    {
        case ElevatorStateStopped s:
            Console.WriteLine($"Elevator is stopped at floor {s.Floor}");
            Console.WriteLine("Enter target floor: ");
            int.TryParse(Console.ReadLine(), out int targetFloor);
            state.TargetFloor = targetFloor;
            break;
        case ElevatorStateMovingUp u:
            Console.WriteLine($"Elevator is moving up... {u.Floor}");
            break;
        case ElevatorStateMovingDown d:
            Console.WriteLine($"Elevator is moving down... {d.Floor}");
            break;
    }
}
