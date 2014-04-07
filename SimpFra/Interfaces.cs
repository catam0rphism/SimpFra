using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUC.Math;

namespace SimpFra
{
    public interface IFractal
    {
        Size FractalSize { get; set; }
        Bitmap Render();
    }
    public interface IComplexFractal
        :IFractal
    {
        int Iteration { get; set; }
        ComplexPlane complexPlane { get; set; }
        Func<System.Numerics.Complex, int> GeneratingFunc { get; set; }
    }
    public interface IColorizedFractal<T>
    {
        Func<T, Color> ColorizeFunc { get; set; }
    }
    public interface IFractalAsync
        : IFractal
    {
        Task<Bitmap> RenderAsync();
    }
}