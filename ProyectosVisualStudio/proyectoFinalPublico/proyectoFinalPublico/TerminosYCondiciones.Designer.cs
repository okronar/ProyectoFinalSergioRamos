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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolvTer
            // 
            btnVolvTer.Anchor = AnchorStyles.None;
            btnVolvTer.Location = new Point(1290, 720);
            btnVolvTer.Name = "btnVolvTer";
            btnVolvTer.Size = new Size(115, 34);
            btnVolvTer.TabIndex = 0;
            btnVolvTer.Text = "Volver";
            btnVolvTer.UseVisualStyleBackColor = true;
            btnVolvTer.Click += btnVolvTer_Click;
            // 
            // lblTerminos
            // 
            lblTerminos.Anchor = AnchorStyles.None;
            lblTerminos.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTerminos.ForeColor = SystemColors.MenuHighlight;
            lblTerminos.Location = new Point(62, 50);
            lblTerminos.Name = "lblTerminos";
            lblTerminos.Size = new Size(1207, 644);
            lblTerminos.TabIndex = 1;
            lblTerminos.Text = resources.GetString("lblTerminos.Text");
            lblTerminos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1213F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Controls.Add(lblTerminos, 1, 1);
            tableLayoutPanel1.Controls.Add(btnVolvTer, 2, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.27802038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.72198F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Size = new Size(1424, 780);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // TerminosYCondiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            ClientSize = new Size(1424, 780);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TerminosYCondiciones";
            Text = "TérminosYCondiciones";
            FormClosed += TerminosYCondiciones_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolvTer;
        private Label lblTerminos;
        private TableLayoutPanel tableLayoutPanel1;
    }
}