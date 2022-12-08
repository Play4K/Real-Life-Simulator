using System.Drawing;

namespace Real_Life_Simulator
{
    public class PointCoordinate
    {
        public string Name { get; set; }
        public Point Point { get; set; }

        public PointCoordinate() { }

        public PointCoordinate(string name, Point point)
        {
            this.Name = name;
            this.Point = point;
        }

    }
}
