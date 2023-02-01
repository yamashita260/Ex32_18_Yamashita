using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return radius * radius * (float)Math.PI;
        }
        public override float GetCircumference()
        {
            return radius * 2 * (float)Math.PI;
        }
        public override void GetBounds(out float beside, out float vertical)
        {
            beside = radius * 2;
            vertical = radius * 2;
        }
    }
}