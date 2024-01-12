

ElevatorState state = new ElevatorStateStopped(0); // Skapa hissen


while (true)
{
    state = state.Move(); // Slå på strömmen...
}
