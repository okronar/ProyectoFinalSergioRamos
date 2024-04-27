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
            tabBusquedas.SuspendLayout();
            SuspendLayout();
            // 
            // tabBusquedas
            // 
            tabBusquedas.Controls.Add(MasPopular);
            tabBusquedas.Controls.Add(PopularMarca);
            tabBusquedas.Controls.Add(Menos_Popular);
            tabBusquedas.Location = new Point(12, 12);
            tabBusquedas.Name = "tabBusquedas";
            tabBusquedas.SelectedIndex = 0;
            tabBusquedas.Size = new Size(1154, 921);
            tabBusquedas.TabIndex = 0;
            // 
            // MasPopular
            // 
            MasPopular.Location = new Point(4, 24);
            MasPopular.Name = "MasPopular";
            MasPopular.Padding = new Padding(3);
            MasPopular.Size = new Size(1146, 893);
            MasPopular.TabIndex = 0;
            MasPopular.Text = "MasPopular";
            MasPopular.UseVisualStyleBackColor = true;
            // 
            // PopularMarca
            // 
            PopularMarca.Location = new Point(4, 24);
            PopularMarca.Name = "PopularMarca";
            PopularMarca.Padding = new Padding(3);
            PopularMarca.Size = new Size(1146, 893);
            PopularMarca.TabIndex = 1;
            PopularMarca.Text = "PopularMarca";
            PopularMarca.UseVisualStyleBackColor = true;
            // 
            // Menos_Popular
            // 
            Menos_Popular.Location = new Point(4, 24);
            Menos_Popular.Name = "Menos_Popular";
            Menos_Popular.Padding = new Padding(3);
            Menos_Popular.Size = new Size(1146, 893);
            Menos_Popular.TabIndex = 2;
            Menos_Popular.Text = "MenosPopular";
            Menos_Popular.UseVisualStyleBackColor = true;
            // 
            // Marketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 945);
            Controls.Add(tabBusquedas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Marketing";
            Text = "Marketing Area";
            tabBusquedas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabBusquedas;
        private TabPage MasPopular;
        private TabPage PopularMarca;
        private TabPage Menos_Popular;
    }
}
