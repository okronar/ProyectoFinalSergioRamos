namespace proyectoFinalPublico
{
    partial class BuscadorComparador
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
            picGuitarra1 = new PictureBox();
            picGuitarra2 = new PictureBox();
            tableGuit1 = new TableLayoutPanel();
            tableGuit2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picGuitarra1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuitarra2).BeginInit();
            tableGuit1.SuspendLayout();
            tableGuit2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // picGuitarra1
            // 
            picGuitarra1.Anchor = AnchorStyles.Right;
            picGuitarra1.Location = new Point(349, 3);
            picGuitarra1.Name = "picGuitarra1";
            picGuitarra1.Size = new Size(187, 291);
            picGuitarra1.TabIndex = 0;
            picGuitarra1.TabStop = false;
            // 
            // picGuitarra2
            // 
            picGuitarra2.Anchor = AnchorStyles.Left;
            picGuitarra2.Location = new Point(3, 3);
            picGuitarra2.Name = "picGuitarra2";
            picGuitarra2.Size = new Size(187, 291);
            picGuitarra2.TabIndex = 0;
            picGuitarra2.TabStop = false;
            // 
            // tableGuit1
            // 
            tableGuit1.ColumnCount = 1;
            tableGuit1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGuit1.Controls.Add(picGuitarra1, 0, 0);
            tableGuit1.Location = new Point(3, 3);
            tableGuit1.Name = "tableGuit1";
            tableGuit1.RowCount = 1;
            tableGuit1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableGuit1.Size = new Size(539, 297);
            tableGuit1.TabIndex = 1;
            // 
            // tableGuit2
            // 
            tableGuit2.ColumnCount = 1;
            tableGuit2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGuit2.Controls.Add(picGuitarra2, 0, 0);
            tableGuit2.Location = new Point(784, 3);
            tableGuit2.Name = "tableGuit2";
            tableGuit2.RowCount = 1;
            tableGuit2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableGuit2.Size = new Size(555, 297);
            tableGuit2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableGuit1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableGuit2, 1, 0);
            tableLayoutPanel1.Location = new Point(119, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1563, 606);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BuscadorComparador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 239);
            ClientSize = new Size(1694, 912);
            Controls.Add(tableLayoutPanel1);
            Name = "BuscadorComparador";
            Text = "BuscadorComparador";
            ((System.ComponentModel.ISupportInitialize)picGuitarra1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuitarra2).EndInit();
            tableGuit1.ResumeLayout(false);
            tableGuit2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGuitarra1;
        private PictureBox picGuitarra2;
        private TableLayoutPanel tableGuit1;
        private TableLayoutPanel tableGuit2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}