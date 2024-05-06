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
            SuspendLayout();
            // 
            // txbEmailReg
            // 
            txbEmailReg.Location = new Point(665, 301);
            txbEmailReg.Name = "txbEmailReg";
            txbEmailReg.PlaceholderText = "Introduzca su email";
            txbEmailReg.Size = new Size(321, 23);
            txbEmailReg.TabIndex = 0;
            txbEmailReg.TextAlign = HorizontalAlignment.Center;
            // 
            // txboxPassReg
            // 
            txboxPassReg.Location = new Point(665, 350);
            txboxPassReg.Name = "txboxPassReg";
            txboxPassReg.PlaceholderText = "Introduzca su contraseña";
            txboxPassReg.Size = new Size(321, 23);
            txboxPassReg.TabIndex = 0;
            txboxPassReg.TextAlign = HorizontalAlignment.Center;
            txboxPassReg.UseSystemPasswordChar = true;
            // 
            // txbPassRepReg
            // 
            txbPassRepReg.Location = new Point(665, 401);
            txbPassRepReg.Name = "txbPassRepReg";
            txbPassRepReg.PlaceholderText = "Repita la contraseña";
            txbPassRepReg.Size = new Size(321, 23);
            txbPassRepReg.TabIndex = 0;
            txbPassRepReg.TextAlign = HorizontalAlignment.Center;
            txbPassRepReg.UseSystemPasswordChar = true;
            // 
            // lblReg
            // 
            lblReg.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReg.Location = new Point(629, 128);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(409, 97);
            lblReg.TabIndex = 4;
            lblReg.Text = "Regístrese aquí";
            lblReg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnvolreg
            // 
            btnvolreg.Location = new Point(1500, 757);
            btnvolreg.Name = "btnvolreg";
            btnvolreg.Size = new Size(102, 23);
            btnvolreg.TabIndex = 5;
            btnvolreg.Text = "Volver";
            btnvolreg.UseVisualStyleBackColor = true;
            btnvolreg.Click += btnvolreg_Click;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(753, 456);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(127, 23);
            btnReg.TabIndex = 5;
            btnReg.Text = "Registrar";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // lblInfor
            // 
            lblInfor.Font = new Font("Segoe UI", 9F);
            lblInfor.Location = new Point(702, 575);
            lblInfor.Name = "lblInfor";
            lblInfor.Size = new Size(237, 49);
            lblInfor.TabIndex = 6;
            lblInfor.Text = "Al registrarse, usted acepta los términos y condiciones que puede revisar en la página principal";
            lblInfor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            ClientSize = new Size(1650, 814);
            Controls.Add(lblInfor);
            Controls.Add(btnReg);
            Controls.Add(btnvolreg);
            Controls.Add(lblReg);
            Controls.Add(txbPassRepReg);
            Controls.Add(txboxPassReg);
            Controls.Add(txbEmailReg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbEmailReg;
        private TextBox txboxPassReg;
        private TextBox txbPassRepReg;
        private Label lblReg;
        private Button btnvolreg;
        private Button btnReg;
        private Label lblInfor;
    }
}