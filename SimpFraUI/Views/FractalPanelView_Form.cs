using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpFraUI.Interfaces;

namespace SimpFraUI.Views
{
    public partial class FractalPanelView_Form : Form, IFractalPanelView
    {
        public FractalPanelView_Form()
        {
            InitializeComponent();
        }
        #region IFractalPanelView
        Size IFractalPanelView.ImageSize
        {
            get
            {
                return pictureBox1.Size;
            }
            set
            {
                pictureBox1.Size = value;
            }
        }

        Bitmap IFractalPanelView.FractalImage
        {
            get { return pictureBox1.Image as Bitmap; }
            set { pictureBox1.Image = value; }
        }

        TimeSpan IFractalPanelView.RenderTime
        {
            set
            {
                toolStripStatusLabel1.Text = 
                    String.Format("Render completed | {0}ms", value.TotalMilliseconds);
            }
        }
        #endregion
    }
}
