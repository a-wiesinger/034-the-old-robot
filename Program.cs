using _034_the_old_robot;

Robot robot = new Robot();

// Start collecting input to power up the robot
Console.WriteLine("Would you like to power on the robot? ");
Console.Write("Acceptable inputs - 'on' or 'off': ");
PowerOnOrOffRobot();

void PowerOnOrOffRobot()
{
    while (true)
    {
        string? userInput = Console.ReadLine();

        if (userInput == "on")
        {
            robot.Commands[0] = new OnCommand();
            Console.WriteLine("Robot powered ON.");
            break;
        } 
        else if (userInput == "off")
        {
            robot.Commands[0] = new OffCommand();
            Console.WriteLine("Robot powered OFF.");
            break;
        }
        else
        {
            Console.WriteLine("Please enter 'on' or 'off'.");
        }
    }
}

// Please enter cardinal direction in which to move the robot
Console.WriteLine("In which 2 directions would you like to move the robot?");
for (int i = 0; i < 2; i++) // Run twice
{
    MoveRobot(i);
}

void MoveRobot(int i)
{
    bool isValidSelection = false;
    
    while (!isValidSelection)
    {
        Console.Write("Acceptable inputs - 'north', 'south', 'east', 'west': ");
        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "north":
                NorthCommand northCommand = new NorthCommand();
                northCommand.Run(robot);
                robot.Commands[i + 1] = northCommand; 
                isValidSelection = true;
                break;
            case "south":
                SouthCommand southCommand = new SouthCommand();
                southCommand.Run(robot);
                robot.Commands[i + 1] = southCommand;
                isValidSelection = true;
                break;
            case "east":
                EastCommand eastCommand = new EastCommand();
                eastCommand.Run(robot);
                robot.Commands[i + 1] = eastCommand;
                isValidSelection = true;
                break;
            case "west":
                WestCommand westCommand = new WestCommand();
                westCommand.Run(robot);
                robot.Commands[i + 1] = westCommand;
                isValidSelection = true;
                break;
            default:
                Console.Write("Please enter a valid selection: ");
                break;
        }
    }
    
    
}

robot.Run();