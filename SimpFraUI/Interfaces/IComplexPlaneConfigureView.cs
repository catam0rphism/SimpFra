using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUC.Math;
using System.Numerics;
using System.Drawing;

namespace SimpFraUI.Interfaces
{
    public interface IComplexPlaneConfigureView
        :IView<ComplexPlane>
    {
        Complex? Center { get; set; }
        Complex? Difference { get; set; }
        Size? Size { get; set; }
        
        event EventHandler CenterChanged;
        event EventHandler DifferenceChanged;
        event EventHandler SizeChanged;
    }
}
