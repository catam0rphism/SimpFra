﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpFra.Fractals
{
    public class MandelbrotFractal
        :IComplexFractal,IColorizedFractal<int>
    {
        public MandelbrotFractal()
        {
            Func<Complex, int> gFunc = c =>
            {
                int i = 0;
                Complex z = Complex.Zero;
                while (true)
                {
                    if (i == Iteration - 1 || Complex.Abs(z) >= 4)
                        return i;

                    i++;
                    z = mFunc(z, c);
                }
            };
        }

        public int Iteration { get; set; }
        public HRUC.Math.ComplexPlane complexPlane { get; set; }

        private Func<Complex,Complex, Complex> mFunc = (z, c) => z * z + c;
        private Func<Complex, int> gFunc = null;
        public Func<Complex, int> GeneratingFunc
        {
            get
            {
                return gFunc;
            }
            set
            {
                gFunc = value;
            }
        }

        public Size FractalSize
        {
            get
            {
                return complexPlane.Size;
            }
            set
            {
                complexPlane = complexPlane.Resize(value.Width, value.Height);
            }
        }

        public Bitmap Render()
        {
            HRUC.Images.SpeedBitmap sImg = new HRUC.Images.SpeedBitmap(FractalSize);
            sImg.LockBitmap();

            for (int i = 0; i < complexPlane.Width; i++)
            {
                for (int j = 0; j < complexPlane.Height; j++)
                {
                    sImg.SetPixel(i, j,
                        ColorizeFunc(GeneratingFunc(complexPlane[i, j])));
                }
            }

            sImg.UnlockBitmap();
            return sImg.Image;
        }

        public Func<int, Color> ColorizeFunc
        {
            get
            {
                return i => Color.FromArgb(2 * i % 255, 4 * i % 255, 8 % i % 255);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}