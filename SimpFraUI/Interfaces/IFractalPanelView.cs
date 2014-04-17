using SimpFra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpFraUI.Interfaces
{
    public interface IFractalPanelView
        :IView<SimpFra.IComplexFractal>
    {
        Size ImageSize { get; set; }
        Bitmap FractalImage { get; set; }
        TimeSpan RenderTime { set; }

        // TODO: Fractal moving events
        
        //event EventHandler<FractalMovingEventArgs> Moved;
        //event EventHandler<FractalMovingEventArgs> CenterSetted;
        //event EventHandler<FractalMovingEventArgs> ZomeIn;
        //event EventHandler<FractalMovingEventArgs> ZomeOut;

    }
}
