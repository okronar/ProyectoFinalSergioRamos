namespace ProyectoFinalBuscador
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
            CargarIMG = new Button();
            picmuestra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picmuestra).BeginInit();
            SuspendLayout();
            // 
            // CargarIMG
            // 
            CargarIMG.AutoSize = true;
            CargarIMG.Location = new Point(754, 536);
            CargarIMG.Name = "CargarIMG";
            CargarIMG.Size = new Size(135, 37);
            CargarIMG.TabIndex = 0;
            CargarIMG.Text = "Cargar Imagen ";
            CargarIMG.UseVisualStyleBackColor = true;
            CargarIMG.Click += CargarIMG_Click;
            // 
            // picmuestra
            // 
            picmuestra.Location = new Point(721, 10);
            picmuestra.Name = "picmuestra";
            picmuestra.Size = new Size(187, 520);
            picmuestra.TabIndex = 1;
            picmuestra.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 680);
            Controls.Add(picmuestra);
            Controls.Add(CargarIMG);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picmuestra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CargarIMG;
        private PictureBox picmuestra;
    }
}
