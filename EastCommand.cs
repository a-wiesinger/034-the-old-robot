namespace _034_the_old_robot;

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X++;
        }
    }
}

