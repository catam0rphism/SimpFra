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

            appKernel.Bind<IComplexFractalConfigureView>().To<FractalConfigureView>().InSingletonScope();
            appKernel.Bind<IComplexPlaneConfigureView>().To<ComplexPlaneConfigureView>().InSingletonScope();
            appKernel.Bind<IComplexFractal>().To<MandelbrotFractal>();

            FractalConfigurePresenter presenter = appKernel.Get<FractalConfigurePresenter>();

            Application.Run(presenter.view as Form);
        }
    }
}
