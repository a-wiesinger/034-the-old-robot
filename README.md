# Level 34 - "The Old Robot"
Following along with the C# Player's Guide by RB Whitaker
## Criteria:
1. Copy starter code from The Old Robot challenge
2. Define a "RobotCommand" class with an public abstract void Run(Robot robot)
   1. Copied code from book should compile after this
3. Create "OnCommand" and "OffCommand" classes that inherit from "RobotCommand" and turn the robot on or off by overriding the Run method
4. Create NorthCommand, SouthCommand, WestCommand, EastCommand classes that move the robot (respectively) 1 unit +Y, 1 unit -Y, 1 unit -X, 1 unit +X. These moves will only function if the IsPowered property = true.
5. The main method must be able to able to capture 3 commands from the console window. Generate new RobotCommand objects based on these commands. The Robot's Run method will then execute the commands
   1. e.g.
      1. (command 1) on
      2. (command 2) north
      3. (command 3) west