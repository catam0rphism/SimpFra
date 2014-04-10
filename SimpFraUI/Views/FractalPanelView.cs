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
using SimpFra;

namespace SimpFraUI.Views
{
    public partial class FractalPanelView : PictureBox, IFractalPanelView
    {
        
        public FractalPanelView()
        {
            InitializeComponent();
        }

        private Point center;
        private Size area;
        private Rectangle prevRect;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // TODO: implement Moved and CenterSetted events
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.Right:
                    break;
                default:                    
                    break;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {

            base.OnMouseUp(e);
        }

        public Bitmap FractalImage
        {
            get
            {
                return new Bitmap(base.Image);
            }
            set
            {
                Image = value;
            }
        }
        public TimeSpan RenderTime
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

        public event EventHandler<FractalMovingEventArgs> Moved;
        public event EventHandler<FractalMovingEventArgs> CenterSetted;
    }
}
