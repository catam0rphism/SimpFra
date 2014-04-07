using HRUC.Math;
using SimpFraUI.Interfaces;
using System;
using System.Numerics;

namespace SimpFraPresenter
{
    public class ComplexPlaneConfigurePresenter
    {

        IComplexPlaneConfigureView _view = null;        
        [Ninject.Inject]
        public IComplexPlaneConfigureView view
        {
            get { return _view; }
            set
            {
                _view = value;
                _view.CenterChanged += view_CenterChanged;
                _view.DifferenceChanged += view_DifferenceChanged;
                _view.WidthChanged += view_WidthChanged;
                _view.HeightChanged += view_HeightChanged;
            }
        }
        [Ninject.Inject]
        public ComplexPlane complexPlane { get; set; }
        public ComplexPlaneConfigurePresenter() { }

        #region view events
        // Handle view events is setting model property
        void view_HeightChanged(object sender, EventArgs e)
        {
            if (view.Height.HasValue && view.Height > 0) complexPlane = complexPlane.SetHeight(view.Height.Value);
        }
        void view_WidthChanged(object sender, EventArgs e)
        {
            if(view.Width.HasValue && view.Width > 0) complexPlane = complexPlane.SetWidth(view.Width.Value);
        }
        void view_DifferenceChanged(object sender, EventArgs e)
        {
            if (view.Difference.HasValue && isValidComplex(view.Difference.Value))
                complexPlane = complexPlane.SetDifference(view.Difference.Value);
        }
        void view_CenterChanged(object sender, EventArgs e)
        {
            if(view.Center.HasValue && isValidComplex(view.Center.Value)) 
                complexPlane = complexPlane.SetCenter(view.Center.Value);
        }

        private bool isValidComplex(Complex c)
        {
            double re = c.Real,
                im = c.Imaginary;
            return !(double.IsNaN(re) ||
                double.IsNaN(im) ||
                double.IsInfinity(re) ||
                double.IsInfinity(im));
        }
        #endregion        
    }
}
