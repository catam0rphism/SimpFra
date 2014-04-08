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
    public partial class FractalPanelView : PictureBox, IFractalPanelView
    {
        
        public FractalPanelView()
        {
            InitializeComponent();
        }
    }
}
