using FluentAssertions;
using HRUC.Math;
using Ninject;
using NSubstitute;
using NUnit.Core;
using NUnit.Framework;
using SimpFraPresenter;
using SimpFraUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Tests.Presenters
{
    [TestFixture]
    public class ComplexPlaneConfigurePresenterTests
    {
        ComplexPlaneConfigurePresenter presenter;

        IComplexPlaneConfigureView view = NSubstitute.Substitute.For<IComplexPlaneConfigureView>();
        ComplexPlane cp = new ComplexPlane(0.003,333,999,Complex.Zero);
        // ComplexPlane cp = Substitute.For<ComplexPlane>();

        [SetUp]
        public void Init()
        {
            IKernel appKernel = new StandardKernel();

            appKernel.Bind<IComplexPlaneConfigureView>().ToConstant(view);
            appKernel.Bind<ComplexPlane>().ToConstant(cp).InSingletonScope();

            presenter = appKernel.Get<ComplexPlaneConfigurePresenter>();
        }

        #region Center tests
        [Test]
        public void sync_center_with_valid_view_value()
        {
            // Arrange
            Complex otherComplex = new Complex(42, 24);
            view.Center = otherComplex;

            // Act
            view.CenterChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreEqual(otherComplex, presenter.complexPlane.Center);
        }
        [Test]
        public void not_sync_center_with_null_view_value()
        {
            // Arrange
            view.Center = null;

            // Act
            view.CenterChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(null, presenter.complexPlane.Center);
        }
        [TestCaseSource("GetInvalidComplexValue")]
        public void not_sync_center_with_invalid_view_value(Complex invalidValue)
        {
            // Arrange
            view.Center = invalidValue;

            // Act
            view.CenterChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(invalidValue, presenter.complexPlane.Center);
        }
        #endregion
        #region difference tests
        [Test]
        public void sync_difference_with_valid_view_value()
        {
            // Arrange
            view.Difference = new Complex(2, 4);

            // Act
            view.DifferenceChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            presenter.complexPlane.Diff.Real.Should().BeGreaterOrEqualTo(2);
            presenter.complexPlane.Diff.Imaginary.Should().BeGreaterOrEqualTo(4);    
        }
        [TestCaseSource("GetInvalidComplexValue")]
        public void not_sync_difference_with_invalid_view_value(Complex invalidValue)
        {
            // Arrange
            view.Difference = invalidValue;

            // Act
            view.DifferenceChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(invalidValue, presenter.complexPlane.Diff);
        }
        [Test]
        public void not_sync_difference_with_null_view_value()
        { 
            // Arrange
            view.Difference = null;

            // Act
            view.DifferenceChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(null, presenter.complexPlane.Diff);
        }
        #endregion
        #region size tests
        [TestCaseSource("GetValidSizeValue")]
        public void sync_size_with_valid_view_value(Size valid_size)
        {
            // Arrange
            view.Size = valid_size;

            // Act
            view.SizeChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            presenter.complexPlane.Width.Should().Be(valid_size.Width);
            presenter.complexPlane.Height.Should().Be(valid_size.Height);
        }
        [TestCaseSource("GetInvalidSizeValue")]
        public void not_sync_size_with_invalid_view_value(Size invalid_size)
        {
            // Arrange
            view.Size = invalid_size;

            // Act
            view.SizeChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            presenter.complexPlane.Width.Should().NotBe(invalid_size.Width);
            presenter.complexPlane.Height.Should().NotBe(invalid_size.Height);
            
        }
        [Test]
        public void not_sync_size_with_null_view_value()
        {
            // Arrange
            view.Size = null;
            presenter.complexPlane = presenter.complexPlane.Resize(42, 84);
            // Act
            view.SizeChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            presenter.complexPlane.Width.Should().Be(42);
            presenter.complexPlane.Height.Should().Be(84);
        }
        #endregion

        IEnumerable<TestCaseData> GetInvalidComplexValue()
        {
            yield return new TestCaseData(new Complex(double.NaN, double.NaN));
            yield return new TestCaseData(new Complex(double.NaN, double.PositiveInfinity));
            yield return new TestCaseData(new Complex(double.NaN, double.NegativeInfinity));

            yield return new TestCaseData(new Complex(double.PositiveInfinity, double.PositiveInfinity));
            yield return new TestCaseData(new Complex(double.PositiveInfinity, double.NegativeInfinity));
            yield return new TestCaseData(new Complex(double.PositiveInfinity, double.NaN));

            yield return new TestCaseData(new Complex(double.NegativeInfinity, double.NaN));
            yield return new TestCaseData(new Complex(double.NegativeInfinity, double.PositiveInfinity));
            yield return new TestCaseData(new Complex(double.NegativeInfinity, double.NegativeInfinity));
            
            yield return new TestCaseData(new Complex(42, double.NaN));
            yield return new TestCaseData(new Complex(42, double.PositiveInfinity));
            yield return new TestCaseData(new Complex(42, double.NegativeInfinity));

            yield return new TestCaseData(new Complex(double.NaN,42));
            yield return new TestCaseData(new Complex(double.PositiveInfinity,42));
            yield return new TestCaseData(new Complex(double.NegativeInfinity,24));

            //yield return new TestCaseData(null);
        }
        IEnumerable<Size> GetValidSizeValue()
        {
            yield return new Size(10, 10);
            yield return new Size(42, 84);
            yield return new Size(84, 42);
            yield return new Size(1024, 768);
            yield return new Size(1600, 1200);
        }
        IEnumerable<Size> GetInvalidSizeValue()
        {
            yield return new Size(0, 0);
            yield return new Size(-42, -84);
            yield return new Size(84, -42);
            yield return new Size(-1024, 768);
            yield return new Size(-1600, 0);
        }
    }
}
