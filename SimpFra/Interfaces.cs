using HRUC.Math;
using System;
using System.Drawing;
using System.Numerics;
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
        int Generate(Complex c);
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