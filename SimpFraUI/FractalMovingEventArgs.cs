using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimpFra
{
    public class FractalMovingEventArgs : EventArgs
    {
        Size shift;
        Point center;
        Size size;

        public Size Shift { get { return shift; } }
        public Point Center { get { return center; } }
        public Size Size { get { return size; } }
    }
}
