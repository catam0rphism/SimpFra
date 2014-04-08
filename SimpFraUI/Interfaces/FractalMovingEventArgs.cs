using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimpFra
{
    class FractalMovingEventArgs: EventArgs
    {
        public SizeF Shift { get; }
    }
}
