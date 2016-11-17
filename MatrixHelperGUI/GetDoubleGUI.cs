using System;
using System.Windows.Forms;

namespace MatrixHelperGUI
{
    public partial class GetDoubleGUI : Form
    {
        public double factor;
        public GetDoubleGUI()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            double n = 1;
            double d = 1;
            bool error = false;
            string factorText = txtNumber.Text.Replace('\\', '/'); //Just in case the wrong slash is used
            if (factorText.Contains("/"))
            {
                error = Double.TryParse(factorText.Substring(0, factorText.IndexOf('/')), out n) ? false : true;
                error = Double.TryParse(factorText.Substring(factorText.IndexOf('/') + 1), out d) ? false : true;
            }
            else
            {
                error = Double.TryParse(factorText, out n) ? false : true;
            }
            if (!error)
            {
                factor = n / d;
                this.DialogResult = DialogResult.OK;
                Close();
            } 
            else
            {
                lblError.Visible = true;
            } 
        }
    }
}
