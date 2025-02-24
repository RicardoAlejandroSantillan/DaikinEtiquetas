namespace Etiquetas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBackground = new Panel();
            daikinPartN_tbl = new DataGridView();
            lblSupplierPartNumber = new Label();
            btnSearch = new Button();
            lnSupplierP_N = new Panel();
            txtSupplierP_N = new TextBox();
            pictureBox1 = new PictureBox();
            pnlTop = new Panel();
            lblTitle = new Label();
            pcbPichonKun = new PictureBox();
            minimizeLbl = new Label();
            CloseLbl = new Label();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daikinPartN_tbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPichonKun).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(45, 45, 45);
            pnlBackground.Controls.Add(daikinPartN_tbl);
            pnlBackground.Controls.Add(lblSupplierPartNumber);
            pnlBackground.Controls.Add(btnSearch);
            pnlBackground.Controls.Add(lnSupplierP_N);
            pnlBackground.Controls.Add(txtSupplierP_N);
            pnlBackground.Controls.Add(pictureBox1);
            pnlBackground.Controls.Add(pnlTop);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Margin = new Padding(3, 4, 3, 4);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1235, 841);
            pnlBackground.TabIndex = 0;
            // 
            // daikinPartN_tbl
            // 
            daikinPartN_tbl.AllowUserToAddRows = false;
            daikinPartN_tbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            daikinPartN_tbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daikinPartN_tbl.BackgroundColor = SystemColors.ControlDarkDark;
            daikinPartN_tbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daikinPartN_tbl.Location = new Point(213, 550);
            daikinPartN_tbl.Name = "daikinPartN_tbl";
            daikinPartN_tbl.ReadOnly = true;
            daikinPartN_tbl.RowHeadersWidth = 51;
            daikinPartN_tbl.Size = new Size(812, 188);
            daikinPartN_tbl.TabIndex = 9;
            daikinPartN_tbl.CellClick += daikinPartN_tbl_CellClick;
            // 
            // lblSupplierPartNumber
            // 
            lblSupplierPartNumber.AutoSize = true;
            lblSupplierPartNumber.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSupplierPartNumber.ForeColor = Color.FromArgb(150, 150, 150);
            lblSupplierPartNumber.Location = new Point(359, 360);
            lblSupplierPartNumber.Name = "lblSupplierPartNumber";
            lblSupplierPartNumber.Size = new Size(215, 24);
            lblSupplierPartNumber.TabIndex = 7;
            lblSupplierPartNumber.Text = "Supplier Part Number";
            lblSupplierPartNumber.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(581, 475);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 37);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lnSupplierP_N
            // 
            lnSupplierP_N.BackColor = Color.White;
            lnSupplierP_N.Location = new Point(354, 435);
            lnSupplierP_N.Margin = new Padding(3, 4, 3, 4);
            lnSupplierP_N.Name = "lnSupplierP_N";
            lnSupplierP_N.Size = new Size(544, 4);
            lnSupplierP_N.TabIndex = 4;
            // 
            // txtSupplierP_N
            // 
            txtSupplierP_N.BackColor = Color.FromArgb(45, 45, 45);
            txtSupplierP_N.BorderStyle = BorderStyle.None;
            txtSupplierP_N.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSupplierP_N.ForeColor = Color.FromArgb(150, 150, 150);
            txtSupplierP_N.Location = new Point(354, 400);
            txtSupplierP_N.Margin = new Padding(3, 4, 3, 4);
            txtSupplierP_N.Multiline = true;
            txtSupplierP_N.Name = "txtSupplierP_N";
            txtSupplierP_N.Size = new Size(543, 44);
            txtSupplierP_N.TabIndex = 2;
            txtSupplierP_N.Text = "Supplier Part Number";
            txtSupplierP_N.MouseClick += txtSupplierP_N_MouseClick;
            txtSupplierP_N.TextChanged += txtSupplierP_N_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Daikin_logo;
            pictureBox1.Location = new Point(354, 95);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(30, 30, 30);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(pcbPichonKun);
            pnlTop.Controls.Add(minimizeLbl);
            pnlTop.Controls.Add(CloseLbl);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1235, 61);
            pnlTop.TabIndex = 0;
            pnlTop.MouseMove += pnlTop_MouseMove;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(85, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 35);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Etiquetas";
            lblTitle.MouseMove += lblTitle_MouseMove;
            // 
            // pcbPichonKun
            // 
            pcbPichonKun.Image = Properties.Resources.pichonkun;
            pcbPichonKun.Location = new Point(25, 1);
            pcbPichonKun.Margin = new Padding(3, 4, 3, 4);
            pcbPichonKun.Name = "pcbPichonKun";
            pcbPichonKun.Size = new Size(37, 53);
            pcbPichonKun.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPichonKun.TabIndex = 9;
            pcbPichonKun.TabStop = false;
            pcbPichonKun.MouseMove += lblTitle_MouseMove;
            // 
            // minimizeLbl
            // 
            minimizeLbl.AutoSize = true;
            minimizeLbl.Cursor = Cursors.Hand;
            minimizeLbl.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimizeLbl.ForeColor = Color.White;
            minimizeLbl.Location = new Point(1146, 0);
            minimizeLbl.Name = "minimizeLbl";
            minimizeLbl.Size = new Size(41, 45);
            minimizeLbl.TabIndex = 8;
            minimizeLbl.Text = "_";
            minimizeLbl.MouseClick += minimizeLbl_MouseClick;
            minimizeLbl.MouseLeave += minimizeLbl_MouseLeave;
            minimizeLbl.MouseHover += minimizeLbl_MouseHover;
            // 
            // CloseLbl
            // 
            CloseLbl.AutoSize = true;
            CloseLbl.BackColor = Color.Transparent;
            CloseLbl.Cursor = Cursors.Hand;
            CloseLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseLbl.ForeColor = Color.White;
            CloseLbl.Location = new Point(1190, 8);
            CloseLbl.Name = "CloseLbl";
            CloseLbl.Size = new Size(36, 41);
            CloseLbl.TabIndex = 0;
            CloseLbl.Text = "X";
            CloseLbl.MouseClick += CloseLbl_MouseClick;
            CloseLbl.MouseLeave += CloseLbl_MouseLeave;
            CloseLbl.MouseHover += CloseLbl_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 841);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiquetas";
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daikinPartN_tbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPichonKun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackground;
        private Panel pnlTop;
        private PictureBox pictureBox1;
        private Label CloseLbl;
        private TextBox txtSupplierP_N;
        private Panel lnSupplierP_N;
        private Button btnSearch;
        private Label minimizeLbl;
        private PictureBox pcbPichonKun;
        private Label lblTitle;
        private Label lblSupplierPartNumber;
        private TableLayoutPanel delete;
        private DataGridView daikinPartN_tbl;
    }
}
