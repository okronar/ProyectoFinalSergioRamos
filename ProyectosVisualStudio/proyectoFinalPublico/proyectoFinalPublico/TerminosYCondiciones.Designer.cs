namespace proyectoFinalPublico
{
    partial class TerminosYCondiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminosYCondiciones));
            btnVolvTer = new Button();
            lblTerminos = new Label();
            SuspendLayout();
            // 
            // btnVolvTer
            // 
            btnVolvTer.Location = new Point(1285, 736);
            btnVolvTer.Name = "btnVolvTer";
            btnVolvTer.Size = new Size(137, 42);
            btnVolvTer.TabIndex = 0;
            btnVolvTer.Text = "Volver";
            btnVolvTer.UseVisualStyleBackColor = true;
            btnVolvTer.Click += btnVolvTer_Click;
            // 
            // lblTerminos
            // 
            lblTerminos.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTerminos.ForeColor = SystemColors.MenuHighlight;
            lblTerminos.Location = new Point(217, 101);
            lblTerminos.Name = "lblTerminos";
            lblTerminos.Size = new Size(954, 529);
            lblTerminos.TabIndex = 1;
            lblTerminos.Text = resources.GetString("lblTerminos.Text");
            lblTerminos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TerminosYCondiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            ClientSize = new Size(1424, 780);
            Controls.Add(lblTerminos);
            Controls.Add(btnVolvTer);
            Name = "TerminosYCondiciones";
            Text = "TérminosYCondiciones";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolvTer;
        private Label lblTerminos;
    }
}