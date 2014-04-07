using SimpFra;
using SimpFraUI.Interfaces;
using System;

namespace SimpFraPresenter
{
    public class FractalConfigurePresenter
    {
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
            }
        }
        private IComplexFractalConfigureView _view = null;

        [Ninject.Inject]
        public IComplexFractal fract { get; set; }

        [Ninject.Inject]
        public ComplexPlaneConfigurePresenter complexPlaneConfigurePresenter { get; set; }

        public FractalConfigurePresenter() { }

        void view_IterationChanged(object sender, EventArgs e)
        {
            if(view.Iteration.HasValue && view.Iteration>0) fract.Iteration = view.Iteration.Value;
        }
    }
}
