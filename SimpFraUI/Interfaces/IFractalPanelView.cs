using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpFraUI.Interfaces
{
    interface IFractalPanelView
        :IView<SimpFra.IComplexFractal>
    {
        Bitmap FractalImage { get; set; }
        TimeSpan RenderTime { get; set; }
        
        // TODO: Fractal moving events
    }
}
