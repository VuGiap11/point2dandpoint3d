using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace point2Dand3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p2 = new Point2D(1,2);
            Console.WriteLine(p2);
            Point3D p3 = new Point3D(1,2,3);
            Console.WriteLine(p3);
        }
    }
}
