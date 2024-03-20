namespace _034_the_old_robot;

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y++;
        }
    }
}