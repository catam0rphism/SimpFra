using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUC.Math;
using SimpFraUI.Interfaces;
using System.Drawing;

namespace SimpFraPresenter
{
    public class FractalPanelPresenter
    {
        IFractalPanelView _view;
        IFractalPanelView view
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
            }
        }

        public async void Render(Task<Bitmap> RenderTask)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            view.FractalImage = await RenderTask;
            sw.Stop();

            _view.RenderTime = sw.Elapsed;
        }
    }
}
