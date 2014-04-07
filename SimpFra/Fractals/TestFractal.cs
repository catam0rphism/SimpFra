using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpFra.Fractals
{
    public class TestFractal
        : IFractalAsync
    {
        public Bitmap Render()
        {
            Bitmap img = new Bitmap(FractalSize.Width, FractalSize.Height);
            using (Graphics g = Graphics.FromImage(img))
            {
                Action<int, int, int, int> drawRects = (x, y, w, h) =>
                    {
                        // Рисуем пирамидку (вид сверху)
                        while (true)
                        {
                            g.DrawRectangle(Pens.Black, x, y, w, h);
                            x += 2;
                            y += 2;
                            w -= 4;
                            h -= 4;

                            if (w <= 0 || h <= 0) break;
                        }
                    };
                drawRects(0, 0, FractalSize.Width, FractalSize.Height);
            }
            return img;
        }

        private Size fractalSize;
        public Size FractalSize
        {
            get { return fractalSize; }
            set
            {
                fractalSize = value;
                EventHandler<FractalEventArgs> temp = StateChanged;
                if (temp != null)
                {
                    temp(this, new FractalEventArgs() { Fractal = this, RenderTask = RenderAsync() });
                }
            }
        }

        public event EventHandler<FractalEventArgs> StateChanged;
        public async Task<Bitmap> RenderAsync()
        {
            return await Task.Run<Bitmap>(new Func<Bitmap>(Render));
        }
    }
}