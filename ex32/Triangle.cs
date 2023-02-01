using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Triangle : Surface
    {
        readonly public float side_A;
        readonly public float side_B;
        readonly public float side_C;
        public Triangle(float A = 0, float B = 0, float C = 0)
        {
            this.side_A = A;
            this.side_B = B;
            this.side_C = C;
        }
        public override float GetSurface()
        {
            float s;
            s = (side_A + side_B + side_C) / 2;
            return MathF.Sqrt(s * (s - side_A) * (s - side_B) * (s - side_C));
        }
        public override float GetCircumference()
        {
            return side_A + side_B + side_C;
        }
        public override void GetBounds(out float beside, out float vertical)
        {
            beside = this.side_A;
            vertical = GetSurface() * 2 / side_A;
        }
    }
}
