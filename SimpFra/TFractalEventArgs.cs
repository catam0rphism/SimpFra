using System;
using System.Drawing;
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
