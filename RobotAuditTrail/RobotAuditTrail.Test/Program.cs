var robot = new Robot();

robot.Move(5, 3, 2);
robot.Move(-2, 4, 0);
robot.Move(0, 0, -1);

Console.WriteLine("Movement complete.");

class Robot(int x = 0, int y = 0, int z = 0)
{
    public void Move(int deltaX, int deltaY, int deltaZ)
    {
        x += deltaX;
        y += deltaY;
        z += deltaZ;
        Console.WriteLine($"Robot moved to position (x: {x}, y: {y}, z: {z})");
    }
}