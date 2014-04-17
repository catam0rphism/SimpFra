using FluentAssertions;
using HRUC.Math;
using Ninject;
using NSubstitute;
using NUnit.Core;
using NUnit.Framework;
using SimpFra;
using SimpFraPresenter;
using SimpFraUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Tests.Presenters
{
    [TestFixture]
    class FractalPanelPresenterTests
    {
        IComplexFractalConfigureView cfcview = Substitute.For<IComplexFractalConfigureView>();
        IFractalPanelView view = Substitute.For<IFractalPanelView>();
        IComplexFractal fract = Substitute.For<IComplexFractal>();

        FractalPanelPresenter presenter = null;

        [SetUp]
        public void Init()
        {


            IKernel kernel = new StandardKernel();

            kernel.Bind<IFractalPanelView>().ToConstant(view);
            kernel.Bind<IComplexFractalConfigureView>().ToConstant(cfcview);
            kernel.Bind<IComplexFractal>().ToConstant(fract);

            presenter = kernel.Get<FractalPanelPresenter>();
        }

        [Test]
        public void Change_view_image_when_render_called()
        {
            // Arrange
            fract.Render().Returns(new System.Drawing.Bitmap(190, 310));
            presenter.Fractal.Render().Returns(new System.Drawing.Bitmap(190, 310));
            
            // Act
            presenter.Render();

            // Assert
            view.FractalImage.Width.Should().Be(190);
            view.FractalImage.Height.Should().Be(310);
        }
    }
}
