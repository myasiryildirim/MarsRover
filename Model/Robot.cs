using MarsRover.Enum;

namespace MarsRover.Model
{
    public class Robot : Coordinate
    {
        public int RobotNumber { get; set; }
        public Direction DirectionCode { get; set; }
    }
}