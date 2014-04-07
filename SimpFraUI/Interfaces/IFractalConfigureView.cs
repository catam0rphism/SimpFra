using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpFraUI.Interfaces
{
    public interface IComplexFractalConfigureView
        :IView<SimpFra.IComplexFractal>
    {
        int? Iteration{get;set;}
        
        event EventHandler IterationChanged;
        event EventHandler RenderClicked;
    }
}
