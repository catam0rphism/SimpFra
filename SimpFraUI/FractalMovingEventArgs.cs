using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimpFra
{
    public class FractalMovingEventArgs : EventArgs
    {
        SizeF shift;
        PointF center;

        public SizeF Shift
        {
            get
            {
                return shift;
            }
        }
        public PointF Center
        {
            get
            {
                return center;
            }
        }
    }
}
