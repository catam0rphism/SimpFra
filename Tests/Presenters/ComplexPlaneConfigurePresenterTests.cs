using HRUC.Math;
using NSubstitute;
using NUnit.Core;
using NUnit.Framework;
using SimpFraPresenter;
using SimpFraUI.Interfaces;
using SimpFraUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class ComplexPlaneConfigurePresenterTests
    {
        ComplexPlaneConfigurePresenter presenter;

        IComplexPlaneConfigureView view = NSubstitute.Substitute.For<IComplexPlaneConfigureView>();

        [SetUp]
        public void Init()
        {
            presenter = new ComplexPlaneConfigurePresenter(
                view,
                new ComplexPlane(new Complex(1,1), 100, 100, Complex.Zero));
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
            Assert.LessOrEqual(2, presenter.complexPlane.Diff.Real);
            Assert.LessOrEqual(4, presenter.complexPlane.Diff.Imaginary);
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
        #region width tests
        [Test]
        public void sync_width_with_valid_view_value()
        {
            // Arrange
            view.Width = 42;

            // Act
            view.WidthChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreEqual(42, presenter.complexPlane.Width);
        }
        [Test]
        public void not_sync_width_with_negative_view_value()
        {
            // Arrange
            view.Width = -42;

            // Act
            view.WidthChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(-42, presenter.complexPlane.Width);
        }
        [Test]
        public void not_sync_width_with_zero_view_value()
        {
            // Arrange
            view.Width = 0;

            // Act
            view.WidthChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(0, presenter.complexPlane.Width);
        }
        [Test]
        public void not_sync_width_with_null_view_value()
        {
            // Arrange
            view.Width = null;

            // Act
            view.WidthChanged += Raise.EventWith(EventArgs.Empty);
            
            // Assert
            Assert.AreNotEqual(null, presenter.complexPlane.Width);
        }
        #endregion
        #region height tests
        [Test]
        public void sync_height_with_valid_view_value()
        {
            // Arrange
            view.Height = 42;

            // Act
            view.HeightChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreEqual(42, presenter.complexPlane.Height);
        }
        [Test]
        public void not_sync_height_with_negative_view_value()
        {
            // Arrange
            view.Height = -42;

            // Act
            view.HeightChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(-42, presenter.complexPlane.Height);
        }
        [Test]
        public void not_sync_height_with_zero_view_value()
        {
            // Arrange
            view.Height = 0;

            // Act
            view.HeightChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(0, presenter.complexPlane.Height);
        }
        [Test]
        public void not_sync_height_with_null_view_value()
        {
            // Arrange
            view.Height = null;

            // Act
            view.HeightChanged += Raise.EventWith(EventArgs.Empty);

            // Assert
            Assert.AreNotEqual(null, presenter.complexPlane.Height);
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
    }
}
