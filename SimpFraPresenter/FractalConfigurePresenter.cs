using SimpFra;
using SimpFraUI.Interfaces;
using System;

namespace SimpFraPresenter
{
    public class FractalConfigurePresenter
    {
        private IComplexFractalConfigureView _view = null;

        [Ninject.Inject]
        public IComplexFractal fract { get; set; }
        [Ninject.Inject]
        public ComplexPlaneConfigurePresenter complexPlaneConfigurePresenter { get; set; }
        [Ninject.Inject]
        public FractalPanelPresenter fractalPanelPresenter { get; set; }

        [Ninject.Inject]
        public IComplexFractalConfigureView view
        {
            get
            {
                return _view;                
            }
            set
            {
                _view = value;
                _view.IterationChanged += view_IterationChanged;
                _view.RenderClicked += view_RenderClicked;
            }
        }

        void view_RenderClicked(object sender, EventArgs e)
        {
            var cp = complexPlaneConfigurePresenter.complexPlane;
            fract.complexPlane = cp;

            fractalPanelPresenter.Fractal = fract;
            fractalPanelPresenter.Render();
        }
        void view_IterationChanged(object sender, EventArgs e)
        {
            if(view.Iteration.HasValue && view.Iteration>0) fract.Iteration = view.Iteration.Value;
        }
    }
}
