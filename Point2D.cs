using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point2Dand3D
{
    public class Point2D
    {
        private float x;
        private float y;

        public Point2D()
        {

        }
        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public string Tostring(float x, float y)
        {
         return "point: "+ x + y;
        }
    }
    public class Point3D : Point2D
    {
        private float Z;

        public Point3D()
        {

        }
        public Point3D(float x, float y, float z) : base(x,y)
        {
            this.Z = z;
        }
        public float z { get => z; set => z = value; }
        public string Tostring(float x, float y, float z)
        {
           return "point: " + x + y + z;
        }
    }
}
