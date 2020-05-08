using System;
using System.Linq;
using MarsRover.Enum;
using MarsRover.Model;
using MarsRover.Resource;
using Microsoft.VisualBasic;

namespace MarsRover
{
    public class Program
    {
        private static Coordinate _area = new Coordinate();
        public static void Main(string[] args)
        {
            EnterArea();

            var robot1 = CreateRobot(1);
            var robot2 = CreateRobot(2);

            Console.WriteLine(robot1.X + " " + robot1.Y + " " + robot1.DirectionCode);
            Console.WriteLine(robot2.X + " " + robot2.Y + " " + robot2.DirectionCode);

            Console.WriteLine(Messages.PressLogOutKey); Console.ReadKey();
        }

        private static void EnterArea()
        {
            Console.WriteLine(Messages.EnterTheAreaSize);
            var maxArea = Console.ReadLine()?.Trim().Split(' ').Select(int.Parse).ToList();

            if (maxArea == null || maxArea.Count != 2)
            {
                Console.WriteLine(Messages.LocationInformationNonStandart);
                maxArea?.Clear();
                EnterArea();
            }
            else
            {
                _area.X = maxArea[0];
                _area.Y = maxArea[1];
            }
        }

        private static Robot CreateRobot(int robotNumber)
        {
            var startPosition = EnterRobotLocation();

            var direction = EnterDirection();

            var robot = new Robot()
            {
                X = Convert.ToInt32(startPosition[0]),
                Y = Convert.ToInt32(startPosition[1]),
                DirectionCode = (Direction)System.Enum.Parse(typeof(Direction), startPosition[2].ToUpper()),
                RobotNumber = robotNumber
            };

            return DirectionControl(robot, direction);
        }

        private static string[] EnterRobotLocation()
        {
            Console.WriteLine(Messages.EnterTheRobotLocation);
            var startPosition = Console.ReadLine()?.Trim().Split(' ');

            if (startPosition != null &&
                startPosition.Length == 3 &&
                Information.IsNumeric(startPosition[0]) &&
                Information.IsNumeric(startPosition[1]) &&
                System.Enum.TryParse(startPosition[2].ToUpper(), out Direction _)) return startPosition;
            Console.WriteLine(Messages.LocationInformationNonStandart);
            
            return EnterRobotLocation();
        }

        private static string EnterDirection()
        {
            Console.WriteLine(Messages.EnterTheDirectionInformation);
            var direction = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(direction)) return direction;
            Console.WriteLine(Messages.DirectionInformationCannotBeEmpty);

            return EnterDirection();
        }

        private static Robot DirectionControl(Robot robot, string directionList)
        {
            return directionList.Aggregate(robot, (current, direction) => direction switch
            {
                'M' => Movement(current),
                'L' => LeftRotate(current),
                'R' => RightRotate(current),
                _ => current
            });
        }

        private static Robot LeftRotate(Robot robot)
        {
            robot.DirectionCode = robot.DirectionCode switch
            {
                Direction.N => Direction.W,
                Direction.S => Direction.E,
                Direction.E => Direction.N,
                Direction.W => Direction.S,
                _ => robot.DirectionCode
            };

            return robot;
        }

        private static Robot RightRotate(Robot robot)
        {
            robot.DirectionCode = robot.DirectionCode switch
            {
                Direction.N => Direction.E,
                Direction.S => Direction.W,
                Direction.E => Direction.S,
                Direction.W => Direction.N,
                _ => robot.DirectionCode
            };

            return robot;
        }

        private static Robot Movement(Robot robot)
        {
            switch (robot.DirectionCode)
            {
                case Direction.N:
                    if (robot.Y + 1 > _area.Y)
                    {
                        Console.WriteLine(Messages.SpaceError);
                        break;
                    }

                    robot.Y += 1;
                    break;
                case Direction.S:
                    if (robot.Y - 1 < 0)
                    {
                        Console.WriteLine(Messages.SpaceError);
                        break;
                    }

                    robot.Y -= 1;
                    break;
                case Direction.E:
                    if (robot.X + 1 > _area.X)
                    {
                        Console.WriteLine(Messages.SpaceError);
                        break;
                    }

                    robot.X += 1;
                    break;
                case Direction.W:
                    if (robot.X - 1 < 0)
                    {
                        Console.WriteLine(Messages.SpaceError);
                        break;
                    }

                    robot.X -= 1;
                    break;
            }

            return robot;
        }
    }
}
