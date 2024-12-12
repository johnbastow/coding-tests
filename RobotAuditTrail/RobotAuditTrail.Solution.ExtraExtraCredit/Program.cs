var robot = new Robot(new PositionHistoryMemoryProvider());

robot.Move(5, 3, 2);
robot.Move(-2, 4, 0);
robot.Move(0, 0, -1);

robot.PrintPositionHistory();

Console.WriteLine("Movement complete.");

class Robot
{
    public IPositionHistoryProvider PositionHistory { get; }
    public int X { get; private set; } = 0;
    public int Y { get; private set; } = 0;
    public int Z { get; private set; } = 0;

    public Robot(IPositionHistoryProvider positionHistory, int x = 0, int y = 0, int z = 0)
    {
        PositionHistory = positionHistory;
        X = x;
        Y = y;
        Z = z;

        PositionHistory.AddPosition(X, Y, Z);
    }

    public void Move(int deltaX, int deltaY, int deltaZ)
    {
        X += deltaX;
        Y += deltaY;
        Z += deltaZ;
        PositionHistory.AddPosition(X, Y, Z);
        Console.WriteLine($"Robot moved to position (x: {X}, y: {Y}, z: {Z})");
    }

    public void PrintPositionHistory()
    {
        PositionHistory.Print();
    }

}

interface IPositionHistoryProvider
{
    public void AddPosition(int x, int y, int z);
    public void Print();
}

class PositionHistoryMemoryProvider: IPositionHistoryProvider
{
    private List<(int x, int y, int z)> history = new();

    public void AddPosition(int x, int y, int z)
    {
        history.Add((x, y, z));
    }

    public void Print()
    {
        Console.WriteLine("Position History:");
        foreach (var position in history)
        {
            Console.WriteLine($"(x: {position.x}, y: {position.y}, z: {position.z})");
        }
    }

}

