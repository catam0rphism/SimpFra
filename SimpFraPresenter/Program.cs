using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpFraUI.Interfaces;
using SimpFraUI.Views;
using Ninject;
using SimpFraPresenter;
using SimpFra.Fractals;

namespace SimpFra
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel appKernel = new StandardKernel();

            FractalConfigureView mainView = new FractalConfigureView();

            MandelbrotFractal mfr = new MandelbrotFractal();

            appKernel.Bind<IComplexFractal>().ToConstant(mfr);
            appKernel.Bind<IComplexFractalConfigureView>().ToConstant(mainView);
            appKernel.Bind<IComplexPlaneConfigureView>().ToConstant(mainView.complexPlaneConfigureView);
            appKernel.Bind<IFractalPanelView>().ToConstant(mainView.fractalPanelView);

            FractalConfigurePresenter presenter = appKernel.Get<FractalConfigurePresenter>();

            Application.Run(presenter.view as Form);
        }
    }
}
