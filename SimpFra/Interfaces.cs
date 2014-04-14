using HRUC.Math;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace SimpFra
{
    public interface IFractal
    {
        Size FractalSize { get; set; }
        Bitmap Render();
    }
    public interface IComplexFractal
        :IFractalAsync
    {
        int Iteration { get; set; }
        ComplexPlane complexPlane { get; set; }
        Func<System.Numerics.Complex, int> GeneratingFunc { get; set; }
    }
    public interface IColorizedFractal<T>
    {
        Color Colorize(T i);
    }
    public interface IFractalAsync
        : IFractal
    {
        Task<Bitmap> RenderAsync();
    }
}