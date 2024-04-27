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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(252, 248, 239);
            linkLabel1.Location = new Point(957, 627);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Términos y condiciones";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(394, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(409, 340);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(394, 353);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(409, 97);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "Bienvenido!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbEmailInicio
            // 
            txbEmailInicio.Location = new Point(440, 453);
            txbEmailInicio.Name = "txbEmailInicio";
            txbEmailInicio.PlaceholderText = "Email";
            txbEmailInicio.Size = new Size(316, 23);
            txbEmailInicio.TabIndex = 4;
            txbEmailInicio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPassInicio
            // 
            txtbPassInicio.Location = new Point(440, 505);
            txtbPassInicio.Name = "txtbPassInicio";
            txtbPassInicio.PlaceholderText = "Contraseña";
            txtbPassInicio.Size = new Size(316, 23);
            txtbPassInicio.TabIndex = 4;
            txtbPassInicio.TextAlign = HorizontalAlignment.Center;
            txtbPassInicio.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(487, 567);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(224, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1183, 745);
            Controls.Add(btnLogin);
            Controls.Add(txtbPassInicio);
            Controls.Add(txbEmailInicio);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Landing";
            Text = "GuitarMatch";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Label lblBienvenida;
        private TextBox txbEmailInicio;
        private TextBox txtbPassInicio;
        private Button btnLogin;
    }
}
