namespace ScalingCalculator
{
    partial class MainForm
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
            this.txt100 = new System.Windows.Forms.TextBox();
            this.lbl100 = new System.Windows.Forms.Label();
            this.txt125 = new System.Windows.Forms.TextBox();
            this.lbl125 = new System.Windows.Forms.Label();
            this.txt150 = new System.Windows.Forms.TextBox();
            this.lbl150 = new System.Windows.Forms.Label();
            this.txt175 = new System.Windows.Forms.TextBox();
            this.lbl175 = new System.Windows.Forms.Label();
            this.txt200 = new System.Windows.Forms.TextBox();
            this.lbl200 = new System.Windows.Forms.Label();
            this.pnlTextBoxes = new System.Windows.Forms.Panel();
            this.pnlTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt100
            // 
            this.txt100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt100.Location = new System.Drawing.Point(0, 0);
            this.txt100.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(201, 30);
            this.txt100.TabIndex = 1;
            this.txt100.Text = "16";
            this.txt100.TextChanged += new System.EventHandler(this.UpdateScaling);
            // 
            // lbl100
            // 
            this.lbl100.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(17, 22);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(57, 25);
            this.lbl100.TabIndex = 0;
            this.lbl100.Text = "100%";
            this.lbl100.UseMnemonic = false;
            // 
            // txt125
            // 
            this.txt125.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt125.Location = new System.Drawing.Point(0, 38);
            this.txt125.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt125.Name = "txt125";
            this.txt125.Size = new System.Drawing.Size(201, 30);
            this.txt125.TabIndex = 2;
            this.txt125.TextChanged += new System.EventHandler(this.UpdateScaling);
            // 
            // lbl125
            // 
            this.lbl125.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl125.AutoSize = true;
            this.lbl125.Location = new System.Drawing.Point(17, 60);
            this.lbl125.Name = "lbl125";
            this.lbl125.Size = new System.Drawing.Size(57, 25);
            this.lbl125.TabIndex = 0;
            this.lbl125.Text = "125%";
            this.lbl125.UseMnemonic = false;
            // 
            // txt150
            // 
            this.txt150.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt150.Location = new System.Drawing.Point(0, 76);
            this.txt150.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt150.Name = "txt150";
            this.txt150.Size = new System.Drawing.Size(201, 30);
            this.txt150.TabIndex = 3;
            this.txt150.TextChanged += new System.EventHandler(this.UpdateScaling);
            // 
            // lbl150
            // 
            this.lbl150.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl150.AutoSize = true;
            this.lbl150.Location = new System.Drawing.Point(17, 98);
            this.lbl150.Name = "lbl150";
            this.lbl150.Size = new System.Drawing.Size(57, 25);
            this.lbl150.TabIndex = 0;
            this.lbl150.Text = "150%";
            this.lbl150.UseMnemonic = false;
            // 
            // txt175
            // 
            this.txt175.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt175.Location = new System.Drawing.Point(0, 114);
            this.txt175.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt175.Name = "txt175";
            this.txt175.Size = new System.Drawing.Size(201, 30);
            this.txt175.TabIndex = 4;
            this.txt175.TextChanged += new System.EventHandler(this.UpdateScaling);
            // 
            // lbl175
            // 
            this.lbl175.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl175.AutoSize = true;
            this.lbl175.Location = new System.Drawing.Point(17, 136);
            this.lbl175.Name = "lbl175";
            this.lbl175.Size = new System.Drawing.Size(57, 25);
            this.lbl175.TabIndex = 0;
            this.lbl175.Text = "175%";
            this.lbl175.UseMnemonic = false;
            // 
            // txt200
            // 
            this.txt200.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt200.Location = new System.Drawing.Point(0, 152);
            this.txt200.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(201, 30);
            this.txt200.TabIndex = 5;
            this.txt200.TextChanged += new System.EventHandler(this.UpdateScaling);
            // 
            // lbl200
            // 
            this.lbl200.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl200.AutoSize = true;
            this.lbl200.Location = new System.Drawing.Point(17, 174);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(57, 25);
            this.lbl200.TabIndex = 0;
            this.lbl200.Text = "200%";
            this.lbl200.UseMnemonic = false;
            // 
            // pnlTextBoxes
            // 
            this.pnlTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextBoxes.Controls.Add(this.txt100);
            this.pnlTextBoxes.Controls.Add(this.txt125);
            this.pnlTextBoxes.Controls.Add(this.txt150);
            this.pnlTextBoxes.Controls.Add(this.txt175);
            this.pnlTextBoxes.Controls.Add(this.txt200);
            this.pnlTextBoxes.Location = new System.Drawing.Point(80, 19);
            this.pnlTextBoxes.Name = "pnlTextBoxes";
            this.pnlTextBoxes.Size = new System.Drawing.Size(201, 182);
            this.pnlTextBoxes.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(306, 217);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lbl175);
            this.Controls.Add(this.lbl150);
            this.Controls.Add(this.lbl125);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.pnlTextBoxes);
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScalingCalculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTextBoxes.ResumeLayout(false);
            this.pnlTextBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.TextBox txt125;
        private System.Windows.Forms.Label lbl125;
        private System.Windows.Forms.TextBox txt150;
        private System.Windows.Forms.Label lbl150;
        private System.Windows.Forms.TextBox txt175;
        private System.Windows.Forms.Label lbl175;
        private System.Windows.Forms.TextBox txt200;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Panel pnlTextBoxes;
    }
}

