﻿using System;
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
    public partial class LinearMatrixGUI : Form
    {
        LinearMatrix _matrix;
        public LinearMatrixGUI()
        {
            InitializeComponent();
        }
        private void LinearMatrixGUI_Load(object sender, EventArgs e)
        {
            lblMatrixDisplay.Text = "To create a matrix, \nplease click on \nthe \"Create Matrix\" button";
            grpMatrixControls.Enabled = false;
            grpMatrixOperands.Enabled = false;
        }
        private void UpdateMatrixOperandsComboBoxes()
        {
            cboRow1.Items.Clear();
            cboRow2.Items.Clear();
            for(int i = 1; i <= _matrix.ReturnNumberOfRows(); i++)
            {
                cboRow1.Items.Add(i.ToString());
                cboRow2.Items.Add(i.ToString());
            }
            cboRow1.Text = cboRow1.Items[0].ToString();
            cboRow2.Text = cboRow2.Items[0].ToString();
        }
        private void UpdateResultantRowComboBox()
        {
            cboResultantRow.Items.Clear();
            cboResultantRow.Items.Add(cboRow1.Text);
            cboResultantRow.Items.Add(cboRow2.Text);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var createMatrixForm = new CreateMatrixGUI())
            {
                var result = createMatrixForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    _matrix = createMatrixForm.createMatrixFormMatrix;
                    UpdateMatrixOperandsComboBoxes();
                    PrintMatrixToLabel(_matrix, lblMatrixDisplay);
                    grpMatrixOperands.Enabled = true;
                    grpMatrixControls.Enabled = true;
                    ShowOriginalMatrix(_matrix);
                    UpdateLog("Created new matrix." + _matrix._rows.ToString() + " x " + _matrix._columns.ToString());
                }
            } 
        }
        private void UpdateLog(string logMessage)
        {
            libLog.Items.Add(logMessage + "\n");
            //The below two lines make the list box autoscroll
            libLog.SelectedIndex = libLog.Items.Count - 1;
            libLog.SelectedIndex = -1;
        }
        private void PrintMatrixToLabel(LinearMatrix matrix, Label lbl)
        {
            lbl.Text = "";
            for(int r = 0; r < matrix.ReturnNumberOfRows(); r++)
            {
                for(int c = 0; c < matrix.ReturnNumberOfColumns(); c++)
                {
                    lbl.Text += matrix.GetElement(r, c).ToString() + "   ";
                }
                lbl.Text += "\n";
            }
        }
        private void ShowOriginalMatrix(LinearMatrix matrix)
        {
            PrintMatrixToLabel(_matrix, lblOriginalMatrixDisplay);
            lblOriginalMatrix.Visible = true;
            lblOriginalMatrixDisplay.Visible = true;
            lblUpdateMatrix.Visible = true;
        }
        private void btnAddRows_Click(object sender, EventArgs e)
        {
            //These are -1 because the SumRows function of LinearMatrix is 0 based.
            int rowIndex1 = Convert.ToInt32(cboRow1.Text) - 1;
            int rowIndex2 = Convert.ToInt32(cboRow2.Text) - 1;
            int rowReplace = Convert.ToInt32(cboResultantRow.Text) - 1;
            if (chkAddMultiple.Checked)
            {
                _matrix.SumRows(rowIndex1, rowIndex2, rowReplace, Convert.ToDouble(txtFactor.Text));
                UpdateLog("R" + cboResultantRow.Text + ": " + txtFactor.Text + "R" + cboRow1.Text + " + R" + cboRow2.Text);
            } else
            {
                _matrix.SumRows(rowIndex1, rowIndex2, rowReplace);
                UpdateLog("R" + cboResultantRow.Text + ": R" + cboRow1.Text + " + R" + cboRow2.Text);
            }
            PrintMatrixToLabel(_matrix, lblMatrixDisplay);
        }
        private void btnMultiplyRow_Click(object sender, EventArgs e)
        {
            _matrix.MultiplyRow(Convert.ToInt32(cboRow1.Text), Convert.ToDouble(txtFactor.Text));
            UpdateLog("R" + cboRow1.Text + ": " + txtFactor.Text + cboRow1.Text);
            PrintMatrixToLabel(_matrix, lblMatrixDisplay);
        }
        private void cboRow1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultantRowComboBox();
        }
        private void cboRow2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultantRowComboBox();
        }
        private void btnMultiplyRows_Click(object sender, EventArgs e)
        {
            double factor;
            string factorText = txtFactor.Text.Replace('\\', '/'); //Just in case the wrong slash is used
            if (factorText.Contains("/"))
            {
                double n = Convert.ToDouble(factorText.Substring(0, factorText.IndexOf('/')));
                double d = Convert.ToDouble(factorText.Substring(factorText.IndexOf('/') + 1));
                factor = n / d;
            } else
            {
                factor = Convert.ToDouble(factorText);
            }
            _matrix.MultiplyRow(Convert.ToInt32(cboRow1.Text) - 1, factor);
            PrintMatrixToLabel(_matrix, lblMatrixDisplay);
            UpdateLog("R" + cboRow1.Text + ": " + factorText + "R" + cboRow1.Text);
        }
        private void btnSwapRows_Click(object sender, EventArgs e)
        {
            _matrix.SwitchRows(Convert.ToInt32(cboRow1.Text) - 1, Convert.ToInt32(cboRow2.Text) - 1);
            PrintMatrixToLabel(_matrix, lblMatrixDisplay);
            UpdateLog("R" + cboRow1.Text + " <---> R" + cboRow2.Text);
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            _matrix.Undo();
            PrintMatrixToLabel(_matrix, lblMatrixDisplay);
            UpdateLog("Undo last action.");
        }
    }
}
