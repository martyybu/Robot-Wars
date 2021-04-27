using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    class Robot
    {
        public int CoordinateX;
        public int CoordinateY;
        public char Direction;
        public int PenaltiesCount;

        /// <summary>
        /// Creates a robot object with X, Y coordinates and selected direction (must be one character)
        /// </summary>
        /// <param name="CoordinateX">X coordinate of the robot</param>
        /// <param name="CoordinateY">Y coordinate of the robot</param>
        /// <param name="Direction">Robot direction</param>
        public Robot(int CoordinateX, int CoordinateY, char Direction)
        {
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.Direction = Direction;
        }

        /// <summary>
        /// A function that deals with robot movement
        /// </summary>
        /// <param name="robot">Robot to process movement for</param>
        /// <param name="moveDirection">Direction the robot should move in</param>
        /// <param name="map">Currently selected map</param>
        public void RobotMove(Robot robot, char moveDirection, Map map)
        {
            if (moveDirection == 'L' || moveDirection == 'R')
            {
                CalculateNewDirection(robot, moveDirection);
            }
            else if (moveDirection == 'M')
            {
                CalculateRobotNewLocation(robot, map);
            }
        }

        /// <summary>
        /// Calculates location for the robot, depending on its direction
        /// </summary>
        /// <param name="robot">Robot to process movement for</param>
        /// <param name="map">Currently selected map</param>
        private void CalculateRobotNewLocation(Robot robot, Map map)
        {
            switch (robot.Direction)
            {
                case 'N':
                    // If robot direction is North and the map is wide enough for the robot move up,
                    // process the movement otherwise add a penalty for hitting the border of the map
                    if (robot.CoordinateY < map.Height)
                    {
                        robot.CoordinateY++;
                    }
                    else
                    {
                        robot.PenaltiesCount++;
                    }
                    break;
                case 'W':
                    if (robot.CoordinateX > 0)
                    {
                        robot.CoordinateX--;
                    }
                    else
                    {
                        robot.PenaltiesCount++;
                    }
                    break;
                case 'S':
                    if (robot.CoordinateY > 0)
                    {
                        robot.CoordinateY--;
                    }
                    else
                    {
                        robot.PenaltiesCount++;
                    }
                    break;
                case 'E':
                    if (robot.CoordinateX < map.Width)
                    {
                        robot.CoordinateX++;
                    }
                    else
                    {
                        robot.PenaltiesCount++;
                    }
                    break;
            }
        }

        private void CalculateNewDirection(Robot robot, char moveDirection)
        {
            switch (moveDirection)
            {
                case 'L':
                    // If the robot direction is North and it has to turn left,
                    // Set the robot direction to West
                    if (robot.Direction == 'N')
                    {
                        robot.Direction = 'W';
                    }
                    else if (robot.Direction == 'W')
                    {
                        robot.Direction = 'S';
                    }
                    else if (robot.Direction == 'S')
                    {
                        robot.Direction = 'E';
                    }
                    else
                    {
                        robot.Direction = 'N';
                    }
                    break;
                case 'R':
                    if (robot.Direction == 'N')
                    {
                        robot.Direction = 'E';
                    }
                    else if (robot.Direction == 'W')
                    {
                        robot.Direction = 'N';
                    }
                    else if (robot.Direction == 'S')
                    {
                        robot.Direction = 'W';
                    }
                    else
                    {
                        robot.Direction = 'S';
                    }
                    break;
            }
        }
    }
}
