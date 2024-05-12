namespace ProyectoFinalMarketing
{
    partial class Marketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marketing));
            tabBusquedas = new TabControl();
            MasPopular = new TabPage();
            PopularMarca = new TabPage();
            Menos_Popular = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            gridMasPopu = new DataGridView();
            gridPopuMarca = new DataGridView();
            gridMenosPopu = new DataGridView();
            tabBusquedas.SuspendLayout();
            MasPopular.SuspendLayout();
            PopularMarca.SuspendLayout();
            Menos_Popular.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMasPopu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPopuMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMenosPopu).BeginInit();
            SuspendLayout();
            // 
            // tabBusquedas
            // 
            tabBusquedas.Controls.Add(MasPopular);
            tabBusquedas.Controls.Add(PopularMarca);
            tabBusquedas.Controls.Add(Menos_Popular);
            tabBusquedas.Dock = DockStyle.Fill;
            tabBusquedas.Location = new Point(0, 0);
            tabBusquedas.Name = "tabBusquedas";
            tabBusquedas.SelectedIndex = 0;
            tabBusquedas.Size = new Size(1184, 945);
            tabBusquedas.TabIndex = 0;
            // 
            // MasPopular
            // 
            MasPopular.Controls.Add(tableLayoutPanel1);
            MasPopular.Location = new Point(4, 24);
            MasPopular.Name = "MasPopular";
            MasPopular.Padding = new Padding(3);
            MasPopular.Size = new Size(1176, 917);
            MasPopular.TabIndex = 0;
            MasPopular.Text = "MasPopular";
            MasPopular.UseVisualStyleBackColor = true;
            // 
            // PopularMarca
            // 
            PopularMarca.Controls.Add(gridPopuMarca);
            PopularMarca.Location = new Point(4, 24);
            PopularMarca.Name = "PopularMarca";
            PopularMarca.Padding = new Padding(3);
            PopularMarca.Size = new Size(1176, 917);
            PopularMarca.TabIndex = 1;
            PopularMarca.Text = "PopularMarca";
            PopularMarca.UseVisualStyleBackColor = true;
            // 
            // Menos_Popular
            // 
            Menos_Popular.Controls.Add(gridMenosPopu);
            Menos_Popular.Location = new Point(4, 24);
            Menos_Popular.Name = "Menos_Popular";
            Menos_Popular.Padding = new Padding(3);
            Menos_Popular.Size = new Size(1176, 917);
            Menos_Popular.TabIndex = 2;
            Menos_Popular.Text = "MenosPopular";
            Menos_Popular.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gridMasPopu, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1170, 911);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gridMasPopu
            // 
            gridMasPopu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMasPopu.Dock = DockStyle.Fill;
            gridMasPopu.Location = new Point(3, 3);
            gridMasPopu.Name = "gridMasPopu";
            gridMasPopu.Size = new Size(1164, 905);
            gridMasPopu.TabIndex = 0;
            // 
            // gridPopuMarca
            // 
            gridPopuMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPopuMarca.Dock = DockStyle.Fill;
            gridPopuMarca.Location = new Point(3, 3);
            gridPopuMarca.Name = "gridPopuMarca";
            gridPopuMarca.Size = new Size(1170, 911);
            gridPopuMarca.TabIndex = 0;
            // 
            // gridMenosPopu
            // 
            gridMenosPopu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMenosPopu.Dock = DockStyle.Fill;
            gridMenosPopu.Location = new Point(3, 3);
            gridMenosPopu.Name = "gridMenosPopu";
            gridMenosPopu.Size = new Size(1170, 911);
            gridMenosPopu.TabIndex = 0;
            // 
            // Marketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 945);
            Controls.Add(tabBusquedas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Marketing";
            Text = "Marketing Area";
            tabBusquedas.ResumeLayout(false);
            MasPopular.ResumeLayout(false);
            PopularMarca.ResumeLayout(false);
            Menos_Popular.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMasPopu).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPopuMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMenosPopu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabBusquedas;
        private TabPage MasPopular;
        private TabPage PopularMarca;
        private TabPage Menos_Popular;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView gridMasPopu;
        private DataGridView gridPopuMarca;
        private DataGridView gridMenosPopu;
    }
}
