using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixHelper;

namespace MatrixHelperGUI
{
    public partial class CreateMatrixGUI : Form
    {
        public LinearMatrix createMatrixFormMatrix { get; set; }
        public int rows { get; set; }
        public int columns { get; set; }

        public CreateMatrixGUI()
        {
            InitializeComponent();
        }
        private void CreateMatrixGUI_Load(object sender, EventArgs e)
        {
            InitializeCreateMatrixComboBoxes();
        }
        private void InitializeCreateMatrixComboBoxes()
        {
            for (int i = 1; i < 10; i++)
            {
                cboColumns.Items.Add(i.ToString());
                cboRows.Items.Add(i.ToString());
            }
        }
        private void ShowMatrixInForm()
        {
            foreach (Control cont in this.Controls)
            {
                if (cont.GetType() == typeof(TextBox))
                {
                    cont.Visible = false;
                }
            }
            int rows;
            int columns;
            bool parseRows = Int32.TryParse(cboRows.Text.ToString(), out rows);
            bool parseCols = Int32.TryParse(cboColumns.Text.ToString(), out columns);
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    TextBox tb = this.Controls.Find("tb" + r.ToString() + c.ToString(), true).FirstOrDefault() as TextBox;
                    if (tb != null)
                    {
                        tb.Visible = true;
                        if (tb.Text == "") //This way it won't overwrite any values if you just want to resize
                        {
                            tb.Text = "0";
                        }
                    }
                }
            }
        }
        private void cboRows_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowMatrixInForm();
        }
        private void cboColumns_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowMatrixInForm();
        }
        private LinearMatrix CreateLinearMatrix(int rows, int columns)
        {
            LinearMatrix output = new LinearMatrix(rows, columns);
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    string textBoxName = "tb" + r.ToString() + c.ToString();
                    TextBox tb = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                    output.SetElement(r - 1, c - 1, double.Parse(tb.Text));
                }
            }
            return output;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            createMatrixFormMatrix = CreateLinearMatrix(int.Parse(cboRows.Text), int.Parse(cboColumns.Text));
            rows = Convert.ToInt32(cboRows.Text);
            columns = Convert.ToInt32(cboColumns.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
