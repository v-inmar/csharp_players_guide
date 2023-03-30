namespace RoboticInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 commands (on, off, west, north, east, south)");
            int count = 3;

            Robot robot = new();
            for (int i = 0; i < count; i++)
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

/*
 * Question
 * Do you feel this is an improvement over using an abstract base class? Why or why not?
 * 
 * Answer
 * For this particular program, at its current state, I feel like it is not needed and there is no improvements.
 * This is because I feel that with abstract base class with can have fields (or data) in the future such as int timesUsed or something that
 * adds to the character of the command, which the interface cannot have (although each class can create their own field when implementing the interface).
 * This is not to say that abstract class are far better than interfaces. I am merely speculating and conveying my feeling about them for
 * this particular scenario. I am sure, as mentioned in the book, interfaces can be a better fit when it comes to other examples.
 */