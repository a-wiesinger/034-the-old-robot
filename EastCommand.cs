namespace _034_the_old_robot;

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.X++;
        }
    }
}

