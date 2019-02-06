using System;
using System.Windows.Forms;

namespace ScalingCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateScaling(txt100);
            this.ActiveControl = txt100;
        }

        private TextBox txtSender;
        private TextBox txt;
        private byte scale;
        private byte t_scale;
        private double val;
        private bool updating;

        private void UpdateScaling(object sender, EventArgs e = null)
        {
            if(!updating)
            {
                updating = true;
                try
                {
                    txtSender = (sender as TextBox);
                    scale = byte.Parse(txtSender.Name.Substring(3));
                    val = double.Parse(txtSender.Text);

                    foreach (Control c in pnlTextBoxes.Controls)
                    {
                        txt = (c as TextBox);
                        if (txt.Name != txtSender.Name)
                        {
                            t_scale = byte.Parse(txt.Name.Substring(3));
                            txt.Text = Math.Round(val / scale * t_scale, 2).ToString();
                        }
                    }
                }
                catch { }
                updating = false;
            }
        }
    }
}
