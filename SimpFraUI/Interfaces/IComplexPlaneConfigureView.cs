using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUC.Math;
using System.Numerics;

namespace SimpFraUI.Interfaces
{
    public interface IComplexPlaneConfigureView
        :IView<ComplexPlane>
    {
        Complex? Center { get; set; }
        Complex? Difference { get; set; }
        int? Width { get; set; }
        int? Height { get; set; }
        
        event EventHandler CenterChanged;
        event EventHandler DifferenceChanged;
        event EventHandler SizeChanged;
    }
}
