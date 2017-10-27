using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    public class AracGiris
    {
        BusinessLayer.Otopark BsOtopark = new BusinessLayer.Otopark();
        public bool AracOtoparktaMi(string plaka)
        {
            if (BsOtopark.aracOtoparktaMi(plaka))
                return true;
            return false;
        }

        public System.Drawing.Rectangle boundingRectangle(List<Point> points)
        {
            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new System.Drawing.Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        


    }
}
