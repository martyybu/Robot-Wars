using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    [TestFixture]
    class RobotUnitTests
    {
        [Test]
        public void Scenario1()
        {
            // Creating the robot and map
            Robot robot = new Robot(0, 2, 'E');
            Map map = new Map(4, 4);

            // Setting up the movement instructions
            string MovementInstructions = "MLMRMMMRMMRR";

            // Dealing with robot movement
            foreach (char move in MovementInstructions)
            {
                robot.RobotMove(robot, move, map);
            }

            Console.WriteLine("Final position: " + robot.CoordinateX + ", " + robot.CoordinateY + ", " + robot.Direction + Environment.NewLine + "Penalties: " + robot.PenaltiesCount);

            // Expected final positions and penalties
            int expectedX = 4;
            int expectedY = 1;
            char expectedDirection = 'N';
            int expectedPenalties = 0;

            Assert.AreEqual(expectedX, robot.CoordinateX);
            Assert.AreEqual(expectedY, robot.CoordinateY);
            Assert.AreEqual(expectedDirection, robot.Direction);
            Assert.AreEqual(expectedPenalties, robot.PenaltiesCount);
        }

        [Test]
        public void Scenario2()
        {
            Robot robot = new Robot(4, 4, 'S');
            Map map = new Map(4, 4);

            string MovementInstructions = "LMLLMMLMMMRMM";

            foreach (char move in MovementInstructions)
            {
                robot.RobotMove(robot, move, map);
            }

            Console.WriteLine("Final position: " + robot.CoordinateX + ", " + robot.CoordinateY + ", " + robot.Direction + Environment.NewLine + "Penalties: " + robot.PenaltiesCount);

            // Expected final positions and penalties
            int expectedX = 0;
            int expectedY = 1;
            char expectedDirection = 'W';
            int expectedPenalties = 1;

            Assert.AreEqual(expectedX, robot.CoordinateX);
            Assert.AreEqual(expectedY, robot.CoordinateY);
            Assert.AreEqual(expectedDirection, robot.Direction);
            Assert.AreEqual(expectedPenalties, robot.PenaltiesCount);
        }

        [Test]
        public void Scenario3()
        {
            Robot robot = new Robot(2, 2, 'W');
            Map map = new Map(4, 4);

            string MovementInstructions = "MLMLMLM RMRMRMRM";

            foreach (char move in MovementInstructions)
            {
                robot.RobotMove(robot, move, map);
            }

            Console.WriteLine("Final position: " + robot.CoordinateX + ", " + robot.CoordinateY + ", " + robot.Direction + Environment.NewLine + "Penalties: " + robot.PenaltiesCount);

            // Expected final positions and penalties
            int expectedX = 2;
            int expectedY = 2;
            char expectedDirection = 'N';
            int expectedPenalties = 0;

            Assert.AreEqual(expectedX, robot.CoordinateX);
            Assert.AreEqual(expectedY, robot.CoordinateY);
            Assert.AreEqual(expectedDirection, robot.Direction);
            Assert.AreEqual(expectedPenalties, robot.PenaltiesCount);
        }

        [Test]
        public void Scenario4()
        {
            Robot robot = new Robot(1, 3, 'N');
            Map map = new Map(4, 4);

            string MovementInstructions = "MMLMMLMMMMM";

            foreach (char move in MovementInstructions)
            {
                robot.RobotMove(robot, move, map);
            }

            Console.WriteLine("Final position: " + robot.CoordinateX + ", " + robot.CoordinateY + ", " + robot.Direction + Environment.NewLine + "Penalties: " + robot.PenaltiesCount);

            // Expected final positions and penalties
            int expectedX = 0;
            int expectedY = 0;
            char expectedDirection = 'S';
            int expectedPenalties = 3;

            Assert.AreEqual(expectedX, robot.CoordinateX);
            Assert.AreEqual(expectedY, robot.CoordinateY);
            Assert.AreEqual(expectedDirection, robot.Direction);
            Assert.AreEqual(expectedPenalties, robot.PenaltiesCount);
        }
    }
}
