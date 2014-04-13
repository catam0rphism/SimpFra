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

        public Size Shift
        {
            get
            {
                return shift;
            }
        }
        public Point Center
        {
            get
            {
                return center;
            }
        }
    }
}
