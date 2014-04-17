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

namespace SimpFraUI.Views
{
    public partial class FractalPanelView : UserControl, IFractalPanelView
    {
        public FractalPanelView()
        {
            InitializeComponent();
        }

        public Bitmap FractalImage
        {
            set { pictureBox.Image = value.Clone() as Image; }
        }

        public TimeSpan RenderTime
        {
            set
            {
                toolStripStatusLabel.Text = "Render completed | " + value.Milliseconds + "ms";
            }
        }

        public Size ImageSize
        {
            get
            {
                return pictureBox.Size;
            }
            set
            {
                pictureBox.Size = value;
            }
        }
    }
}
