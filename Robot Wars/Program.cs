using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotUnitTests RobotWarsUnitTests = new RobotUnitTests();

            RobotWarsUnitTests.Scenario1();
            RobotWarsUnitTests.Scenario2();
            RobotWarsUnitTests.Scenario3();
            RobotWarsUnitTests.Scenario4();

            /*
            Robot robot = new Robot(0, 2, 'E');
            Map map = new Map(5, 5);

            string MovementInstructions = "MLMRMMMRMMRR";

            foreach(char move in MovementInstructions)
            {
                robot.RobotMove(robot, move, map);
            }

            Console.WriteLine("Final position: " + robot.CoordinateX + ", " + robot.CoordinateY + ", " + robot.Direction + Environment.NewLine + "Penalties: " + robot.PenaltiesCount);
            */

            Console.ReadLine();
        }


    }
}
