﻿namespace proyectoFinalPublico
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
            ((System.ComponentModel.ISupportInitialize)picGuitarra1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuitarra2).BeginInit();
            tableGuit1.SuspendLayout();
            tableGuit2.SuspendLayout();
            SuspendLayout();
            // 
            // picGuitarra1
            // 
            picGuitarra1.Anchor = AnchorStyles.Right;
            picGuitarra1.Location = new Point(349, 4);
            picGuitarra1.Name = "picGuitarra1";
            picGuitarra1.Size = new Size(187, 515);
            picGuitarra1.TabIndex = 0;
            picGuitarra1.TabStop = false;
            // 
            // picGuitarra2
            // 
            picGuitarra2.Anchor = AnchorStyles.Left;
            picGuitarra2.Location = new Point(3, 3);
            picGuitarra2.Name = "picGuitarra2";
            picGuitarra2.Size = new Size(187, 518);
            picGuitarra2.TabIndex = 0;
            picGuitarra2.TabStop = false;
            // 
            // tableGuit1
            // 
            tableGuit1.ColumnCount = 1;
            tableGuit1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGuit1.Controls.Add(picGuitarra1, 0, 0);
            tableGuit1.Location = new Point(211, 246);
            tableGuit1.Name = "tableGuit1";
            tableGuit1.RowCount = 1;
            tableGuit1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableGuit1.Size = new Size(539, 524);
            tableGuit1.TabIndex = 1;
            // 
            // tableGuit2
            // 
            tableGuit2.ColumnCount = 1;
            tableGuit2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGuit2.Controls.Add(picGuitarra2, 0, 0);
            tableGuit2.Location = new Point(950, 243);
            tableGuit2.Name = "tableGuit2";
            tableGuit2.RowCount = 1;
            tableGuit2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableGuit2.Size = new Size(539, 524);
            tableGuit2.TabIndex = 1;
            // 
            // BuscadorComparador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 912);
            Controls.Add(tableGuit2);
            Controls.Add(tableGuit1);
            Name = "BuscadorComparador";
            Text = "BuscadorComparador";
            ((System.ComponentModel.ISupportInitialize)picGuitarra1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuitarra2).EndInit();
            tableGuit1.ResumeLayout(false);
            tableGuit2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGuitarra1;
        private PictureBox picGuitarra2;
        private TableLayoutPanel tableGuit1;
        private TableLayoutPanel tableGuit2;
    }
}