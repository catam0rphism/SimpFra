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
            ibIter.TextChanged += (s, ea) =>
                {
                    EventHandler temp = IterationChanged;
                    if (temp != null)
                    {
                        temp(s, ea);
                    }
                };
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
                return ibIter.ValueInt;
            }
            set
            {
                ibIter.ValueInt = value;
                EventHandler temp = IterationChanged;
                if (temp != null)
                {
                    temp(this,EventArgs.Empty);
                }
            }
        }
        public event EventHandler IterationChanged;

        public event EventHandler RenderClicked;
    }
}
