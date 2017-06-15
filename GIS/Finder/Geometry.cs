using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIS.Finder
{
    public class MousePoint
    {
        public double X;
        public double Y;
        
        public MousePoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static int SearchRightPoint(List<MousePoint> p)
        {
            MousePoint right = p[0];
            int num = 0;
            for (int i = 1; i < p.Count; i++)
                if (p[i].X > right.X)
                {
                    right = p[i];
                    num = i;
                }
            return num;
        }
    }

    public static class Geometry
    {

        public static int checkIntersection(MousePoint a1, MousePoint a2, MousePoint b1, MousePoint b2)
        {
            double eps = 0.000001;
            double d = (a1.X - a2.X) * (b2.Y - b1.Y) - (a1.Y - a2.Y) * (b2.X - b1.X);
            double da = (a1.X - b1.X) * (b2.Y - b1.Y) - (a1.Y - b1.Y) * (b2.X - b1.X);
            double db = (a1.X - a2.X) * (a1.Y - b1.Y) - (a1.Y - a2.Y) * (a1.X - b1.X);

            if (Math.Abs(d) < eps)
                return 0;
            else
            {
                double ta = da / d;
                double tb = db / d;
                if ((Math.Abs(ta) < eps) && ((0 <= tb) && (tb <= 1)))
                    return 2;
                else
                if ((0 <= ta) && (0 <= tb) && (tb <= 1))
                    return 1;
                else return -1;
            }
        }


        public static bool IsInside(MousePoint a, List<MousePoint> plg)
        {
            MousePoint ax = new MousePoint(a.X + plg[MousePoint.SearchRightPoint(plg)].X, a.Y);
            int k = 0;
            int i1;
            int i2;
            int r;
            for (int i = 0; i < plg.Count; i++)
            {
                i1 = i;
                i2 = i + 1;
                if (i == plg.Count - 1) i2 = 0;

                r = checkIntersection(a, ax, plg[i1], plg[i2]);
                if (r == 2)
                {
                    return false;
                }
                if (r == 1)
                    k = 1 - k;
            }
            if (k == 0)
                return false;
            else
                return true;
        }
    }
}
