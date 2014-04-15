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
                _view.SizeChanged += _view_SizeChanged;
            }
        }

        [Ninject.Inject]
        public ComplexPlane complexPlane { get; set; }

        #region view events
        // Handle view events is setting model property
        void _view_SizeChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
