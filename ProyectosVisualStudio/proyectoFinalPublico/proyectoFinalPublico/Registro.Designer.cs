namespace proyectoFinalPublico
{
    partial class Registro
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
            txbEmailReg = new TextBox();
            txboxPassReg = new TextBox();
            txbPassRepReg = new TextBox();
            lblReg = new Label();
            btnvolreg = new Button();
            btnReg = new Button();
            lblInfor = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // txbEmailReg
            // 
            txbEmailReg.Anchor = AnchorStyles.None;
            txbEmailReg.Location = new Point(111, 297);
            txbEmailReg.Name = "txbEmailReg";
            txbEmailReg.PlaceholderText = "Introduzca su email";
            txbEmailReg.Size = new Size(321, 23);
            txbEmailReg.TabIndex = 0;
            txbEmailReg.TextAlign = HorizontalAlignment.Center;
            // 
            // txboxPassReg
            // 
            txboxPassReg.Anchor = AnchorStyles.None;
            txboxPassReg.Location = new Point(111, 418);
            txboxPassReg.Name = "txboxPassReg";
            txboxPassReg.PlaceholderText = "Introduzca su contraseña";
            txboxPassReg.Size = new Size(321, 23);
            txboxPassReg.TabIndex = 0;
            txboxPassReg.TextAlign = HorizontalAlignment.Center;
            txboxPassReg.UseSystemPasswordChar = true;
            // 
            // txbPassRepReg
            // 
            txbPassRepReg.Anchor = AnchorStyles.None;
            txbPassRepReg.Location = new Point(111, 521);
            txbPassRepReg.Name = "txbPassRepReg";
            txbPassRepReg.PlaceholderText = "Repita la contraseña";
            txbPassRepReg.Size = new Size(321, 23);
            txbPassRepReg.TabIndex = 0;
            txbPassRepReg.TextAlign = HorizontalAlignment.Center;
            txbPassRepReg.UseSystemPasswordChar = true;
            // 
            // lblReg
            // 
            lblReg.Anchor = AnchorStyles.None;
            lblReg.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReg.Location = new Point(67, 75);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(409, 97);
            lblReg.TabIndex = 4;
            lblReg.Text = "Regístrese aquí";
            lblReg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnvolreg
            // 
            btnvolreg.Anchor = AnchorStyles.None;
            btnvolreg.Location = new Point(222, 748);
            btnvolreg.Name = "btnvolreg";
            btnvolreg.Size = new Size(102, 23);
            btnvolreg.TabIndex = 5;
            btnvolreg.Text = "Volver";
            btnvolreg.UseVisualStyleBackColor = true;
            btnvolreg.Click += btnvolreg_Click;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.None;
            btnReg.Location = new Point(208, 602);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(127, 23);
            btnReg.TabIndex = 5;
            btnReg.Text = "Registrar";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // lblInfor
            // 
            lblInfor.Anchor = AnchorStyles.None;
            lblInfor.Font = new Font("Segoe UI", 9F);
            lblInfor.Location = new Point(153, 705);
            lblInfor.Name = "lblInfor";
            lblInfor.Size = new Size(237, 49);
            lblInfor.TabIndex = 6;
            lblInfor.Text = "Al registrarse, usted acepta los términos y condiciones que puede revisar en la página principal";
            lblInfor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblReg, 0, 0);
            tableLayoutPanel2.Controls.Add(lblInfor, 0, 5);
            tableLayoutPanel2.Controls.Add(txbEmailReg, 0, 1);
            tableLayoutPanel2.Controls.Add(btnReg, 0, 4);
            tableLayoutPanel2.Controls.Add(txboxPassReg, 0, 2);
            tableLayoutPanel2.Controls.Add(txbPassRepReg, 0, 3);
            tableLayoutPanel2.Location = new Point(552, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.92112F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.07888F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tableLayoutPanel2.Size = new Size(543, 808);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1650, 814);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnvolreg, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1101, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.12709F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.87291F));
            tableLayoutPanel3.Size = new Size(546, 808);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            ClientSize = new Size(1650, 814);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            Text = "Registro";
            FormClosing += Registro_FormClosing;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbEmailReg;
        private TextBox txboxPassReg;
        private TextBox txbPassRepReg;
        private Label lblReg;
        private Button btnvolreg;
        private Button btnReg;
        private Label lblInfor;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}