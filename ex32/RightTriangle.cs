﻿using System;

using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class RightTriangle : Surface
    {
        readonly public float width;
        readonly public float height;
        public RightTriangle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public override float GetSurface()
        {
            return width / 2 * height;
        }
        public override float GetCircumference()
        {
            return width + height + MathF.Sqrt(width * width + height * height);
        }
        public override void GetBounds(out float beside, out float vertical)
        {
            beside = this.width;
            vertical = this.height;
        }
    }
}