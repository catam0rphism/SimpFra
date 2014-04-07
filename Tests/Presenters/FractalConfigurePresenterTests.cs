using FluentAssertions;
using Ninject;
using NSubstitute;
using NUnit.Core;
using NUnit.Framework;
using SimpFra;
using SimpFraPresenter;
using SimpFraUI.Interfaces;
using System;

namespace Tests.Presenters
{
    [TestFixture]
    class FractalConfigurePresenterTests
    {
        IComplexPlaneConfigureView cpcView = Substitute.For<IComplexPlaneConfigureView>();
        IComplexFractalConfigureView view = Substitute.For<IComplexFractalConfigureView>();

        FractalConfigurePresenter presenter = null;

        [SetUp]
        public void Init()
        {
            var fract = Substitute.For<IComplexFractal>();
            // Заменить на конструктор
            fract.Iteration = 1;

            IKernel appKernel = new StandardKernel();

            appKernel.Bind<IComplexPlaneConfigureView>().ToConstant(cpcView);
            appKernel.Bind<IComplexFractalConfigureView>().ToConstant(view);
            appKernel.Bind<IComplexFractal>().ToConstant(fract);

            presenter = appKernel.Get<FractalConfigurePresenter>();
        }

        [Test]
        public void sync_iteration_with_valid_view_value()
        {
            // Arrange
            view.Iteration = 42;
            
            // Act
            view.IterationChanged += Raise.EventWith(EventArgs.Empty);


            // Assert
            Assert.AreEqual(42, presenter.fract.Iteration);
        }

        [Test]
        public void not_sync_iteration_with_null_view_value()
        {
            // Arrange
            presenter.fract.Iteration = 44;
            view.Iteration = null;

            // Act
            view.IterationChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(null, presenter.fract.Iteration);
        }

        [Test]
        public void not_sync_iteration_with_negative_view_value()
        {
            // Arrange
            view.Iteration = -123;

            // Act
            view.IterationChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(-123, presenter.fract.Iteration);
        }

        [Test]
        public void not_sync_iteration_with_zero_view_value()
        {
            // Arrange
            view.Iteration = 0;

            // Act
            view.IterationChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            presenter.fract.Iteration.Should().NotBe(0);
        }
    }
}
