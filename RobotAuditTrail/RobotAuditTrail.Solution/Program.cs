var robot = new Robot();

robot.Move(5, 3, 2);
robot.Move(-2, 4, 0);
robot.Move(0, 0, -1);

Console.WriteLine("Movement complete.");

robot.PrintPositionHistory();

class Robot(int x = 0, int y = 0, int z = 0)
{
    private List<(int x, int y, int z)> positionHistory = new() { (x, y, z) };

    public void Move(int deltaX, int deltaY, int deltaZ)
    {
        x += deltaX;
        y += deltaY;
        z += deltaZ;
        positionHistory.Add((x, y, z));
        Console.WriteLine($"Robot moved to position (x: {x}, y: {y}, z: {z})");
    }

    public void PrintPositionHistory()
    {
        Console.WriteLine("Position History:");
        foreach (var position in positionHistory)
        {
            Console.WriteLine($"(x: {position.x}, y: {position.y}, z: {position.z})");
        }
    }

}

