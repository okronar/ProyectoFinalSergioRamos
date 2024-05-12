namespace proyectoFinalPublico
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            lblBienvenida = new Label();
            txbEmailInicio = new TextBox();
            txtbPassInicio = new TextBox();
            btnLogin = new Button();
            btnReg = new Button();
            lblregistrar = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(252, 248, 239);
            linkLabel1.Location = new Point(149, 286);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Términos y condiciones";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(397, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(388, 366);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(97, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(194, 87);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "Bienvenido!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbEmailInicio
            // 
            txbEmailInicio.Anchor = AnchorStyles.None;
            txbEmailInicio.Location = new Point(97, 104);
            txbEmailInicio.Name = "txbEmailInicio";
            txbEmailInicio.PlaceholderText = "Email";
            txbEmailInicio.Size = new Size(194, 23);
            txbEmailInicio.TabIndex = 4;
            txbEmailInicio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPassInicio
            // 
            txtbPassInicio.Anchor = AnchorStyles.None;
            txtbPassInicio.Location = new Point(97, 167);
            txtbPassInicio.Name = "txtbPassInicio";
            txtbPassInicio.PlaceholderText = "Contraseña";
            txtbPassInicio.Size = new Size(194, 23);
            txtbPassInicio.TabIndex = 4;
            txtbPassInicio.TextAlign = HorizontalAlignment.Center;
            txtbPassInicio.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(78, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.None;
            btnReg.Location = new Point(36, 329);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(316, 23);
            btnReg.TabIndex = 6;
            btnReg.Text = "Crear nueva cuenta";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // lblregistrar
            // 
            lblregistrar.Anchor = AnchorStyles.None;
            lblregistrar.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblregistrar.Location = new Point(43, 276);
            lblregistrar.Name = "lblregistrar";
            lblregistrar.Size = new Size(302, 30);
            lblregistrar.TabIndex = 7;
            lblregistrar.Text = "No tiene cuenta? regístrese aquí";
            lblregistrar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1183, 745);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblBienvenida, 0, 0);
            tableLayoutPanel2.Controls.Add(txbEmailInicio, 0, 1);
            tableLayoutPanel2.Controls.Add(txtbPassInicio, 0, 2);
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 3);
            tableLayoutPanel2.Controls.Add(btnReg, 0, 5);
            tableLayoutPanel2.Controls.Add(lblregistrar, 0, 4);
            tableLayoutPanel2.Location = new Point(397, 375);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel2.Size = new Size(388, 367);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.Controls.Add(linkLabel1, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(791, 375);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tableLayoutPanel3.Size = new Size(389, 367);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1183, 745);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Landing";
            Text = "GuitarMatch";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Label lblBienvenida;
        private TextBox txbEmailInicio;
        private TextBox txtbPassInicio;
        private Button btnLogin;
        private Button btnReg;
        private Label lblregistrar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
