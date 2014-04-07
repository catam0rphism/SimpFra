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
            IKernel appLKernel = new StandardKernel();

            appLKernel.Bind<IComplexFractalConfigureView>().To<FractalConfigureView>().InSingletonScope();
            appLKernel.Bind<IComplexPlaneConfigureView>().To<ComplexPlaneConfigureView>().InSingletonScope();
            appLKernel.Bind<IComplexFractal>().To<MandelbrotFractal>();

            FractalConfigurePresenter presenter = appLKernel.Get<FractalConfigurePresenter>();

            Application.Run(presenter.view as Form);
        }
    }
}
