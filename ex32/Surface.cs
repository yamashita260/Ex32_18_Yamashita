using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Surface
    {
        abstract public float GetSurface();
        abstract public float GetCircumference();
        abstract public void GetBounds(out float beside, out float vertical);
    }
}