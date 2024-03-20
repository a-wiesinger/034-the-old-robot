namespace _034_the_old_robot;

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered == true)
        {
            robot.Y++;
        }
    }
}