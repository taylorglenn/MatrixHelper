namespace MatrixHelperGUI
{
    partial class LinearMatrixGUI
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpMatrixControls = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSwapRows = new System.Windows.Forms.Button();
            this.btnMultiplyRow = new System.Windows.Forms.Button();
            this.btnAddRows = new System.Windows.Forms.Button();
            this.libLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.grpMatrixOperands = new System.Windows.Forms.GroupBox();
            this.chkAddMultiple = new System.Windows.Forms.CheckBox();
            this.txtFactor = new System.Windows.Forms.TextBox();
            this.cboResultantRow = new System.Windows.Forms.ComboBox();
            this.cboRow2 = new System.Windows.Forms.ComboBox();
            this.cboRow1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatrixDisplay = new System.Windows.Forms.Label();
            this.lblOriginalMatrix = new System.Windows.Forms.Label();
            this.lblOriginalMatrixDisplay = new System.Windows.Forms.Label();
            this.lblUpdateMatrix = new System.Windows.Forms.Label();
            this.grpMatrixControls.SuspendLayout();
            this.grpMatrixOperands.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(491, 58);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New Matrix";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpMatrixControls
            // 
            this.grpMatrixControls.Controls.Add(this.btnUndo);
            this.grpMatrixControls.Controls.Add(this.btnSwapRows);
            this.grpMatrixControls.Controls.Add(this.btnMultiplyRow);
            this.grpMatrixControls.Controls.Add(this.btnAddRows);
            this.grpMatrixControls.Location = new System.Drawing.Point(12, 76);
            this.grpMatrixControls.Name = "grpMatrixControls";
            this.grpMatrixControls.Size = new System.Drawing.Size(156, 188);
            this.grpMatrixControls.TabIndex = 6;
            this.grpMatrixControls.TabStop = false;
            this.grpMatrixControls.Text = "Matrix Controls";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(8, 147);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(142, 35);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo Last Action";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSwapRows
            // 
            this.btnSwapRows.Location = new System.Drawing.Point(8, 107);
            this.btnSwapRows.Name = "btnSwapRows";
            this.btnSwapRows.Size = new System.Drawing.Size(142, 35);
            this.btnSwapRows.TabIndex = 0;
            this.btnSwapRows.Text = "Swap Rows";
            this.btnSwapRows.UseVisualStyleBackColor = true;
            this.btnSwapRows.Click += new System.EventHandler(this.btnSwapRows_Click);
            // 
            // btnMultiplyRow
            // 
            this.btnMultiplyRow.Location = new System.Drawing.Point(8, 66);
            this.btnMultiplyRow.Name = "btnMultiplyRow";
            this.btnMultiplyRow.Size = new System.Drawing.Size(142, 35);
            this.btnMultiplyRow.TabIndex = 0;
            this.btnMultiplyRow.Text = "Multiply Row";
            this.btnMultiplyRow.UseVisualStyleBackColor = true;
            this.btnMultiplyRow.Click += new System.EventHandler(this.btnMultiplyRow_Click);
            // 
            // btnAddRows
            // 
            this.btnAddRows.Location = new System.Drawing.Point(8, 25);
            this.btnAddRows.Name = "btnAddRows";
            this.btnAddRows.Size = new System.Drawing.Size(142, 35);
            this.btnAddRows.TabIndex = 0;
            this.btnAddRows.Text = "Add Rows";
            this.btnAddRows.UseVisualStyleBackColor = true;
            this.btnAddRows.Click += new System.EventHandler(this.btnAddRows_Click);
            // 
            // libLog
            // 
            this.libLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libLog.FormattingEnabled = true;
            this.libLog.ItemHeight = 25;
            this.libLog.Location = new System.Drawing.Point(698, 29);
            this.libLog.Name = "libLog";
            this.libLog.Size = new System.Drawing.Size(297, 229);
            this.libLog.TabIndex = 8;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(698, 6);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 20);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Log";
            // 
            // grpMatrixOperands
            // 
            this.grpMatrixOperands.Controls.Add(this.chkAddMultiple);
            this.grpMatrixOperands.Controls.Add(this.txtFactor);
            this.grpMatrixOperands.Controls.Add(this.cboResultantRow);
            this.grpMatrixOperands.Controls.Add(this.cboRow2);
            this.grpMatrixOperands.Controls.Add(this.cboRow1);
            this.grpMatrixOperands.Controls.Add(this.label3);
            this.grpMatrixOperands.Controls.Add(this.label2);
            this.grpMatrixOperands.Controls.Add(this.label4);
            this.grpMatrixOperands.Controls.Add(this.label1);
            this.grpMatrixOperands.Location = new System.Drawing.Point(178, 76);
            this.grpMatrixOperands.Name = "grpMatrixOperands";
            this.grpMatrixOperands.Size = new System.Drawing.Size(325, 188);
            this.grpMatrixOperands.TabIndex = 10;
            this.grpMatrixOperands.TabStop = false;
            this.grpMatrixOperands.Text = "Matrix Operands";
            // 
            // chkAddMultiple
            // 
            this.chkAddMultiple.AutoSize = true;
            this.chkAddMultiple.Location = new System.Drawing.Point(6, 29);
            this.chkAddMultiple.Name = "chkAddMultiple";
            this.chkAddMultiple.Size = new System.Drawing.Size(122, 24);
            this.chkAddMultiple.TabIndex = 5;
            this.chkAddMultiple.Text = "Add Multiple";
            this.chkAddMultiple.UseVisualStyleBackColor = true;
            this.chkAddMultiple.CheckedChanged += new System.EventHandler(this.chkAddMultiple_CheckedChanged);
            // 
            // txtFactor
            // 
            this.txtFactor.Enabled = false;
            this.txtFactor.Location = new System.Drawing.Point(206, 58);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(100, 26);
            this.txtFactor.TabIndex = 4;
            this.txtFactor.Text = "1";
            // 
            // cboResultantRow
            // 
            this.cboResultantRow.FormattingEnabled = true;
            this.cboResultantRow.Location = new System.Drawing.Point(126, 134);
            this.cboResultantRow.Name = "cboResultantRow";
            this.cboResultantRow.Size = new System.Drawing.Size(74, 28);
            this.cboResultantRow.TabIndex = 3;
            this.cboResultantRow.Text = "1";
            // 
            // cboRow2
            // 
            this.cboRow2.FormattingEnabled = true;
            this.cboRow2.Location = new System.Drawing.Point(66, 98);
            this.cboRow2.Name = "cboRow2";
            this.cboRow2.Size = new System.Drawing.Size(134, 28);
            this.cboRow2.TabIndex = 3;
            this.cboRow2.Text = "1";
            this.cboRow2.SelectedIndexChanged += new System.EventHandler(this.cboRow2_SelectedIndexChanged);
            // 
            // cboRow1
            // 
            this.cboRow1.FormattingEnabled = true;
            this.cboRow1.Location = new System.Drawing.Point(66, 58);
            this.cboRow1.Name = "cboRow1";
            this.cboRow1.Size = new System.Drawing.Size(134, 28);
            this.cboRow1.TabIndex = 2;
            this.cboRow1.Text = "1";
            this.cboRow1.SelectedIndexChanged += new System.EventHandler(this.cboRow1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultant Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Row 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Multiply by...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Row 1";
            // 
            // lblMatrixDisplay
            // 
            this.lblMatrixDisplay.AutoSize = true;
            this.lblMatrixDisplay.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrixDisplay.Location = new System.Drawing.Point(12, 318);
            this.lblMatrixDisplay.Name = "lblMatrixDisplay";
            this.lblMatrixDisplay.Size = new System.Drawing.Size(305, 37);
            this.lblMatrixDisplay.TabIndex = 11;
            this.lblMatrixDisplay.Text = "lblMatrixDisplay";
            // 
            // lblOriginalMatrix
            // 
            this.lblOriginalMatrix.AutoSize = true;
            this.lblOriginalMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalMatrix.Location = new System.Drawing.Point(509, 12);
            this.lblOriginalMatrix.Name = "lblOriginalMatrix";
            this.lblOriginalMatrix.Size = new System.Drawing.Size(148, 20);
            this.lblOriginalMatrix.TabIndex = 12;
            this.lblOriginalMatrix.Text = "Original Matrix          ";
            this.lblOriginalMatrix.Visible = false;
            // 
            // lblOriginalMatrixDisplay
            // 
            this.lblOriginalMatrixDisplay.AutoSize = true;
            this.lblOriginalMatrixDisplay.Location = new System.Drawing.Point(509, 38);
            this.lblOriginalMatrixDisplay.Name = "lblOriginalMatrixDisplay";
            this.lblOriginalMatrixDisplay.Size = new System.Drawing.Size(170, 20);
            this.lblOriginalMatrixDisplay.TabIndex = 12;
            this.lblOriginalMatrixDisplay.Text = "lblOriginalMatrixDisplay";
            this.lblOriginalMatrixDisplay.Visible = false;
            // 
            // lblUpdateMatrix
            // 
            this.lblUpdateMatrix.AutoSize = true;
            this.lblUpdateMatrix.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMatrix.Location = new System.Drawing.Point(12, 269);
            this.lblUpdateMatrix.Name = "lblUpdateMatrix";
            this.lblUpdateMatrix.Size = new System.Drawing.Size(413, 37);
            this.lblUpdateMatrix.TabIndex = 11;
            this.lblUpdateMatrix.Text = "UpdateMatrix          ";
            this.lblUpdateMatrix.Visible = false;
            // 
            // LinearMatrixGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 579);
            this.Controls.Add(this.lblOriginalMatrixDisplay);
            this.Controls.Add(this.lblOriginalMatrix);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblUpdateMatrix);
            this.Controls.Add(this.lblMatrixDisplay);
            this.Controls.Add(this.grpMatrixOperands);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.libLog);
            this.Controls.Add(this.grpMatrixControls);
            this.Name = "LinearMatrixGUI";
            this.Text = "LinearMatrixGUI";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.LinearMatrixGUI_Load);
            this.grpMatrixControls.ResumeLayout(false);
            this.grpMatrixOperands.ResumeLayout(false);
            this.grpMatrixOperands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpMatrixControls;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSwapRows;
        private System.Windows.Forms.Button btnAddRows;
        private System.Windows.Forms.ListBox libLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.GroupBox grpMatrixOperands;
        private System.Windows.Forms.TextBox txtFactor;
        private System.Windows.Forms.ComboBox cboResultantRow;
        private System.Windows.Forms.ComboBox cboRow2;
        private System.Windows.Forms.ComboBox cboRow1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatrixDisplay;
        private System.Windows.Forms.CheckBox chkAddMultiple;
        private System.Windows.Forms.Label lblOriginalMatrix;
        private System.Windows.Forms.Label lblOriginalMatrixDisplay;
        private System.Windows.Forms.Label lblUpdateMatrix;
        private System.Windows.Forms.Button btnMultiplyRow;
    }
}