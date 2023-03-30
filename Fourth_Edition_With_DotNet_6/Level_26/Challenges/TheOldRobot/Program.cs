namespace TheOldRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 commands (on, off, west, north, east, south)");
            int count = 3;

            Robot robot = new();
            for(int i = 0; i < count; i++)
            {
                Console.Write("Command: ");
                // No null checking. You are in control
                string command = Console.ReadLine()!;

                // Populate the robot's Commands' array directly
                robot.Commands[i] = command.ToLower() switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "west" => new WestCommand(),
                    "north" => new NorthCommand(),
                    "east" => new EastCommand(),
                    "south" => new SouthCommand(),
                    _ => new OffCommand() // Catch all will issue an off command
                };
                
            }

            robot.Run();


        }
    }
}