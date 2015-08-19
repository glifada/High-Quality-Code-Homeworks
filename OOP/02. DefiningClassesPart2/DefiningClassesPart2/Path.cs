using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Path
    {
        private List<Point3D> points;
        public Path()
        {
            this.Points = new List<Point3D>();
        }
        public Path(List<Point3D> points) : this()
        {
            this.Points = points;
        }

        public List<Point3D> Points { get; set; }

        public void AddPoint (Point3D point)
        {
            this.Points.Add(point);
        }

        public Point3D this[int index]
        {
            get
            {
                return this.Points[index];
            }
            set
            {
                this.Points[index] = value;
            }
        }
    }
}
