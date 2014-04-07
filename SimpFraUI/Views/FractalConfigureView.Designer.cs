namespace SimpFraUI.Views
{
    partial class FractalConfigureView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalConfigureView));
            this.button1 = new System.Windows.Forms.Button();
            this.complexPlaneConfigureView1 = new SimpFraUI.Views.ComplexPlaneConfigureView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibIter = new HRUC.Components.InputBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // complexPlaneConfigureView1
            // 
            this.complexPlaneConfigureView1.Center = ((System.Nullable<System.Numerics.Complex>)(resources.GetObject("complexPlaneConfigureView1.Center")));
            this.complexPlaneConfigureView1.Difference = ((System.Nullable<System.Numerics.Complex>)(resources.GetObject("complexPlaneConfigureView1.Difference")));
            this.complexPlaneConfigureView1.Height = null;
            this.complexPlaneConfigureView1.Location = new System.Drawing.Point(12, 12);
            this.complexPlaneConfigureView1.Name = "complexPlaneConfigureView1";
            this.complexPlaneConfigureView1.Size = new System.Drawing.Size(200, 176);
            this.complexPlaneConfigureView1.TabIndex = 2;
            this.complexPlaneConfigureView1.Width = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ibIter);
            this.panel1.Location = new System.Drawing.Point(13, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 29);
            this.panel1.TabIndex = 3;
            // 
            // inputBox1
            // 
            this.ibIter.LabelText = "Iteration";
            this.ibIter.Location = new System.Drawing.Point(3, 3);
            this.ibIter.Name = "inputBox1";
            this.ibIter.Size = new System.Drawing.Size(191, 20);
            this.ibIter.TabIndex = 0;
            this.ibIter.TextBoxWidth = 140;
            this.ibIter.ValueDouble = double.NaN;
            this.ibIter.ValueInt = null;
            this.ibIter.ValueString = "";
            // 
            // FractalConfigureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.complexPlaneConfigureView1);
            this.Controls.Add(this.button1);
            this.Name = "FractalConfigureView";
            this.Text = "FractalConfigureForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ComplexPlaneConfigureView complexPlaneConfigureView1;
        private System.Windows.Forms.Panel panel1;
        private HRUC.Components.InputBox ibIter;
    }
}