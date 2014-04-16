namespace SimpFraUI.Views
{
    partial class ComplexPlaneConfigureView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ibCIm = new HRUC.Components.InputBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibCRe = new HRUC.Components.InputBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibDRe = new HRUC.Components.InputBox();
            this.ibDIm = new HRUC.Components.InputBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibW = new HRUC.Components.InputBox();
            this.ibH = new HRUC.Components.InputBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibCIm
            // 
            this.ibCIm.LabelText = "Center imag:";
            this.ibCIm.Location = new System.Drawing.Point(3, 29);
            this.ibCIm.Name = "ibCIm";
            this.ibCIm.Size = new System.Drawing.Size(194, 20);
            this.ibCIm.TabIndex = 1;
            this.ibCIm.TextBoxWidth = 100;
            this.ibCIm.ValueDouble = double.NaN;
            this.ibCIm.ValueInt = null;
            this.ibCIm.ValueString = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ibCRe);
            this.panel1.Controls.Add(this.ibCIm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 4;
            // 
            // ibCRe
            // 
            this.ibCRe.LabelText = "Center real:";
            this.ibCRe.Location = new System.Drawing.Point(3, 3);
            this.ibCRe.Name = "ibCRe";
            this.ibCRe.Size = new System.Drawing.Size(194, 20);
            this.ibCRe.TabIndex = 0;
            this.ibCRe.TextBoxWidth = 100;
            this.ibCRe.ValueDouble = double.NaN;
            this.ibCRe.ValueInt = null;
            this.ibCRe.ValueString = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ibDRe);
            this.panel2.Controls.Add(this.ibDIm);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 55);
            this.panel2.TabIndex = 5;
            // 
            // ibDRe
            // 
            this.ibDRe.LabelText = "Difference real:";
            this.ibDRe.Location = new System.Drawing.Point(3, 3);
            this.ibDRe.Name = "ibDRe";
            this.ibDRe.Size = new System.Drawing.Size(194, 20);
            this.ibDRe.TabIndex = 2;
            this.ibDRe.TextBoxWidth = 100;
            this.ibDRe.ValueDouble = double.NaN;
            this.ibDRe.ValueInt = null;
            this.ibDRe.ValueString = "";
            // 
            // ibDIm
            // 
            this.ibDIm.LabelText = "Difference imag:";
            this.ibDIm.Location = new System.Drawing.Point(3, 29);
            this.ibDIm.Name = "ibDIm";
            this.ibDIm.Size = new System.Drawing.Size(194, 20);
            this.ibDIm.TabIndex = 3;
            this.ibDIm.TextBoxWidth = 100;
            this.ibDIm.ValueDouble = double.NaN;
            this.ibDIm.ValueInt = null;
            this.ibDIm.ValueString = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ibW);
            this.panel3.Controls.Add(this.ibH);
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 6;
            // 
            // ibW
            // 
            this.ibW.LabelText = "Width:";
            this.ibW.Location = new System.Drawing.Point(3, 3);
            this.ibW.Name = "ibW";
            this.ibW.Size = new System.Drawing.Size(194, 20);
            this.ibW.TabIndex = 4;
            this.ibW.TextBoxWidth = 140;
            this.ibW.ValueDouble = double.NaN;
            this.ibW.ValueInt = null;
            this.ibW.ValueString = "";
            // 
            // ibH
            // 
            this.ibH.LabelText = "Height:";
            this.ibH.Location = new System.Drawing.Point(3, 29);
            this.ibH.Name = "ibH";
            this.ibH.Size = new System.Drawing.Size(194, 20);
            this.ibH.TabIndex = 5;
            this.ibH.TextBoxWidth = 140;
            this.ibH.ValueDouble = double.NaN;
            this.ibH.ValueInt = null;
            this.ibH.ValueString = "";
            // 
            // ComplexPlaneConfigureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ComplexPlaneConfigureView";
            this.Size = new System.Drawing.Size(200, 176);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HRUC.Components.InputBox ibCIm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private HRUC.Components.InputBox ibDRe;
        private HRUC.Components.InputBox ibDIm;
        private System.Windows.Forms.Panel panel3;
        private HRUC.Components.InputBox ibW;
        private HRUC.Components.InputBox ibH;
        private HRUC.Components.InputBox ibCRe;







    }
}
