using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    
    static class Utils
    {
        
        public static int CalculerDistance(Point a, Point b) 
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        
        }

    }
}
