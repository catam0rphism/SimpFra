using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRUC.Math;
using SimpFraUI.Interfaces;
using System.Drawing;
using SimpFra;

namespace SimpFraPresenter
{
    public class FractalPanelPresenter
    {
        public IFractalAsync Fractal { get; set; }

        IFractalPanelView _view;
        [Ninject.Inject]
        public IFractalPanelView view
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

        public async void RenderAsync()
        {
#warning Check timer!
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            view.FractalImage = await Fractal.RenderAsync();
            sw.Stop();
            _view.RenderTime = sw.Elapsed;
        }

        public void Render()
        {
            view.FractalImage = Fractal.Render();
        }
    }
}
