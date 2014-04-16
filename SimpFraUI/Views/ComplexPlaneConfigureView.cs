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
            #region Invoke events

            Func<EventHandler,EventHandler> textChanged = eh =>
                {
                    return (s, ea) =>
                    {
                        EventHandler temp = eh;
                        if (temp != null)
                        {
                            temp(s, ea);
                        }
                    };
                };

            // CenterChanged
            ibCIm.TextChanged += textChanged(CenterChanged);
            ibCRe.TextChanged += textChanged(CenterChanged);
            // DifferenceChanged
            ibDIm.TextChanged += textChanged(DifferenceChanged);
            ibDRe.TextChanged += textChanged(DifferenceChanged);
            // SizeChanged
            ibW.TextChanged += textChanged(SizeChanged);
            ibH.TextChanged += textChanged(SizeChanged);
            #endregion
        }

        #region IComplexPlaneConfigureView
        public event EventHandler CenterChanged;
        public event EventHandler DifferenceChanged;
        public event EventHandler SizeChanged;
        
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
        Size? IComplexPlaneConfigureView.Size
        {
            get
            {
                int w = ibW.ValueInt ?? 0,
                    h = ibH.ValueInt ?? 0;

                if (w > 0 && h > 0)
                    return new Size(w, h);
                else return null;
            }
            set
            {
                if (value != null)
                {
                    ibW.ValueInt = value.Value.Width;
                    ibH.ValueInt = value.Value.Height;
                }

                EventHandler temp = SizeChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }
        #endregion
    }
}
