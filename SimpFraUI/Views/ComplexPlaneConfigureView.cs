// Допилить, пока сойдет так
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpFraUI.Interfaces;
using System.Numerics;

namespace SimpFraUI.Views
{
    public partial class ComplexPlaneConfigureView : UserControl, IComplexPlaneConfigureView
    {
        public ComplexPlaneConfigureView()
        {
            InitializeComponent();
        }

        #region IComplexPlaneConfigureView
        public event EventHandler CenterChanged;
        public event EventHandler DifferenceChanged;
        public event EventHandler WidthChanged;
        public event EventHandler HeightChanged;
        
        public Complex? Center
        {
            get
            {
                double real = ibCRe.ValueDouble;
                double imag = ibCIm.ValueDouble;

                return new Complex(real, imag);
            }
            set
            {
                ibCRe.ValueDouble = value.Value.Real;
                ibCIm.ValueDouble = value.Value.Imaginary;

                EventHandler temp = CenterChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }
        public Complex? Difference
        {
            get
            {
                double real = ibDRe.ValueDouble;
                double imag = ibDIm.ValueDouble;

                return new Complex(real, imag);
            }
            set
            {
                ibDRe.ValueDouble = value.Value.Real;
                ibDIm.ValueDouble = value.Value.Imaginary;

                EventHandler temp = DifferenceChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }

        public new int? Width
        {
            get
            {
                return ibW.ValueInt;
            }
            set
            {
                ibW.ValueInt = value;
                EventHandler temp = WidthChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }
        public new int? Height
        {
            get
            {
                return ibH.ValueInt;
            }
            set
            {
                ibH.ValueInt = value;
                EventHandler temp = HeightChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }
        #endregion
    }
}
