using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class OffCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
}
