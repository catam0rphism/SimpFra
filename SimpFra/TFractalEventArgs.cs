using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpFra.Fractals
{
    public class FractalEventArgs
        :EventArgs
    {
        public IFractal Fractal { get; set; }
        public Task<Bitmap> RenderTask { get; set; }
    }
}
