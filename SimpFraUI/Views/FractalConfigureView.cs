using SimpFraUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpFraUI.Views
{
    public partial class FractalConfigureView : Form, IComplexFractalConfigureView
    {
        public FractalConfigureView()
        {
            InitializeComponent();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            EventHandler temp = RenderClicked;
            if (temp != null)
            {
                temp(this,EventArgs.Empty);
            }
        }

        public int? Iteration
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public event EventHandler IterationChanged;

        public event EventHandler RenderClicked;
    }
}
