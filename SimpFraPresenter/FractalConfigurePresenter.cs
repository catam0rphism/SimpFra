using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpFraUI.Interfaces;
using HRUC.Math;
using SimpFra;

namespace SimpFraPresenter
{
    public class FractalConfigurePresenter
    {
        [Ninject.Inject]
        public IComplexFractalConfigureView view { get; set; }

        public IComplexFractal fract { get; set; }

        public ComplexPlaneConfigurePresenter complexPlaneConfigurePresenter { get; set; }

        public FractalConfigurePresenter(
            IComplexFractalConfigureView view,
            IComplexFractal fract,
            ComplexPlaneConfigurePresenter complexPlaneConfigurePresenter)
        {
            this.view = view;
            this.fract = fract;
            this.complexPlaneConfigurePresenter = complexPlaneConfigurePresenter;

            view.IterationChanged += view_IterationChanged;
        }

        void view_IterationChanged(object sender, EventArgs e)
        {
            if(view.Iteration.HasValue && view.Iteration>0) fract.Iteration = view.Iteration.Value;
        }
    }
}
