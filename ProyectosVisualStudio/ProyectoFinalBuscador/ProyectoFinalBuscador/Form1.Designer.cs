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
            tabControlGuitar = new TabControl();
            InsertarGuit = new TabPage();
            txtbUrl = new TextBox();
            yxybPastillas = new TextBox();
            txtbFijac = new TextBox();
            txtbPuente = new TextBox();
            txtbMaderaDiapa = new TextBox();
            txtbMaderaMastil = new TextBox();
            txtbMarca = new TextBox();
            txtbCuerpo = new TextBox();
            txtbYear = new TextBox();
            txtBEscala = new TextBox();
            txtbMaderaCuer = new TextBox();
            txtbModelo = new TextBox();
            btnInsertar = new Button();
            BorrarGuit = new TabPage();
            UpdateGuit = new TabPage();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tabControlElegir = new TabControl();
            ElegirGuit = new TabPage();
            ElegirUsuario = new TabPage();
            ((System.ComponentModel.ISupportInitialize)picmuestra).BeginInit();
            tabControlGuitar.SuspendLayout();
            InsertarGuit.SuspendLayout();
            UpdateGuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlElegir.SuspendLayout();
            ElegirGuit.SuspendLayout();
            SuspendLayout();
            // 
            // CargarIMG
            // 
            CargarIMG.AutoSize = true;
            CargarIMG.Location = new Point(1416, 575);
            CargarIMG.Name = "CargarIMG";
            CargarIMG.Size = new Size(135, 37);
            CargarIMG.TabIndex = 0;
            CargarIMG.Text = "Cargar Imagen ";
            CargarIMG.UseVisualStyleBackColor = true;
            CargarIMG.Click += CargarIMG_Click;
            // 
            // picmuestra
            // 
            picmuestra.Location = new Point(1391, 23);
            picmuestra.Name = "picmuestra";
            picmuestra.Size = new Size(187, 520);
            picmuestra.TabIndex = 1;
            picmuestra.TabStop = false;
            // 
            // tabControlGuitar
            // 
            tabControlGuitar.Controls.Add(InsertarGuit);
            tabControlGuitar.Controls.Add(BorrarGuit);
            tabControlGuitar.Controls.Add(UpdateGuit);
            tabControlGuitar.Location = new Point(3, 6);
            tabControlGuitar.Name = "tabControlGuitar";
            tabControlGuitar.SelectedIndex = 0;
            tabControlGuitar.Size = new Size(1764, 848);
            tabControlGuitar.TabIndex = 2;
            // 
            // InsertarGuit
            // 
            InsertarGuit.Controls.Add(txtbUrl);
            InsertarGuit.Controls.Add(yxybPastillas);
            InsertarGuit.Controls.Add(txtbFijac);
            InsertarGuit.Controls.Add(txtbPuente);
            InsertarGuit.Controls.Add(txtbMaderaDiapa);
            InsertarGuit.Controls.Add(txtbMaderaMastil);
            InsertarGuit.Controls.Add(txtbMarca);
            InsertarGuit.Controls.Add(txtbCuerpo);
            InsertarGuit.Controls.Add(txtbYear);
            InsertarGuit.Controls.Add(txtBEscala);
            InsertarGuit.Controls.Add(txtbMaderaCuer);
            InsertarGuit.Controls.Add(txtbModelo);
            InsertarGuit.Controls.Add(btnInsertar);
            InsertarGuit.Controls.Add(picmuestra);
            InsertarGuit.Controls.Add(CargarIMG);
            InsertarGuit.Location = new Point(4, 24);
            InsertarGuit.Name = "InsertarGuit";
            InsertarGuit.Padding = new Padding(3);
            InsertarGuit.Size = new Size(1756, 820);
            InsertarGuit.TabIndex = 0;
            InsertarGuit.Text = "Insertar";
            InsertarGuit.ToolTipText = "Insertar guitarras";
            InsertarGuit.UseVisualStyleBackColor = true;
            // 
            // txtbUrl
            // 
            txtbUrl.Location = new Point(527, 167);
            txtbUrl.Name = "txtbUrl";
            txtbUrl.PlaceholderText = "URL Tienda ";
            txtbUrl.Size = new Size(343, 23);
            txtbUrl.TabIndex = 12;
            txtbUrl.TextAlign = HorizontalAlignment.Center;
            // 
            // yxybPastillas
            // 
            yxybPastillas.Location = new Point(527, 113);
            yxybPastillas.Name = "yxybPastillas";
            yxybPastillas.PlaceholderText = "Pastillas";
            yxybPastillas.Size = new Size(343, 23);
            yxybPastillas.TabIndex = 12;
            yxybPastillas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbFijac
            // 
            txtbFijac.Location = new Point(527, 58);
            txtbFijac.Name = "txtbFijac";
            txtbFijac.PlaceholderText = "Fijación";
            txtbFijac.Size = new Size(343, 23);
            txtbFijac.TabIndex = 12;
            txtbFijac.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPuente
            // 
            txtbPuente.Location = new Point(63, 548);
            txtbPuente.Name = "txtbPuente";
            txtbPuente.PlaceholderText = "Puente";
            txtbPuente.Size = new Size(343, 23);
            txtbPuente.TabIndex = 11;
            txtbPuente.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMaderaDiapa
            // 
            txtbMaderaDiapa.Location = new Point(63, 422);
            txtbMaderaDiapa.Name = "txtbMaderaDiapa";
            txtbMaderaDiapa.PlaceholderText = "Madera del Diapasón";
            txtbMaderaDiapa.Size = new Size(343, 23);
            txtbMaderaDiapa.TabIndex = 10;
            txtbMaderaDiapa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMaderaMastil
            // 
            txtbMaderaMastil.Location = new Point(63, 483);
            txtbMaderaMastil.Name = "txtbMaderaMastil";
            txtbMaderaMastil.PlaceholderText = "Madera del Mástil";
            txtbMaderaMastil.Size = new Size(343, 23);
            txtbMaderaMastil.TabIndex = 9;
            txtbMaderaMastil.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMarca
            // 
            txtbMarca.Location = new Point(63, 113);
            txtbMarca.Name = "txtbMarca";
            txtbMarca.PlaceholderText = "Marca";
            txtbMarca.Size = new Size(343, 23);
            txtbMarca.TabIndex = 8;
            txtbMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbCuerpo
            // 
            txtbCuerpo.Location = new Point(63, 167);
            txtbCuerpo.Name = "txtbCuerpo";
            txtbCuerpo.PlaceholderText = "Cuerpo";
            txtbCuerpo.Size = new Size(343, 23);
            txtbCuerpo.TabIndex = 7;
            txtbCuerpo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbYear
            // 
            txtbYear.Location = new Point(63, 237);
            txtbYear.Name = "txtbYear";
            txtbYear.PlaceholderText = "Año";
            txtbYear.Size = new Size(343, 23);
            txtbYear.TabIndex = 6;
            txtbYear.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBEscala
            // 
            txtBEscala.Location = new Point(63, 296);
            txtBEscala.Name = "txtBEscala";
            txtBEscala.PlaceholderText = "Escala";
            txtBEscala.Size = new Size(343, 23);
            txtBEscala.TabIndex = 5;
            txtBEscala.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMaderaCuer
            // 
            txtbMaderaCuer.Location = new Point(63, 359);
            txtbMaderaCuer.Name = "txtbMaderaCuer";
            txtbMaderaCuer.PlaceholderText = "Madera del Cuerpo";
            txtbMaderaCuer.Size = new Size(343, 23);
            txtbMaderaCuer.TabIndex = 4;
            txtbMaderaCuer.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbModelo
            // 
            txtbModelo.Location = new Point(63, 58);
            txtbModelo.Name = "txtbModelo";
            txtbModelo.PlaceholderText = "Modelo";
            txtbModelo.Size = new Size(343, 23);
            txtbModelo.TabIndex = 3;
            txtbModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1292, 680);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(383, 108);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // BorrarGuit
            // 
            BorrarGuit.Location = new Point(4, 24);
            BorrarGuit.Name = "BorrarGuit";
            BorrarGuit.Padding = new Padding(3);
            BorrarGuit.Size = new Size(1756, 820);
            BorrarGuit.TabIndex = 1;
            BorrarGuit.Text = "Borrar";
            BorrarGuit.UseVisualStyleBackColor = true;
            // 
            // UpdateGuit
            // 
            UpdateGuit.Controls.Add(pictureBox1);
            UpdateGuit.Controls.Add(button1);
            UpdateGuit.Location = new Point(4, 24);
            UpdateGuit.Name = "UpdateGuit";
            UpdateGuit.Padding = new Padding(3);
            UpdateGuit.Size = new Size(1756, 820);
            UpdateGuit.TabIndex = 2;
            UpdateGuit.Text = "Actualizar";
            UpdateGuit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1306, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 520);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(1336, 631);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 2;
            button1.Text = "Cargar Imagen ";
            button1.UseVisualStyleBackColor = true;
           
            // 
            // tabControlElegir
            // 
            tabControlElegir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlElegir.Controls.Add(ElegirGuit);
            tabControlElegir.Controls.Add(ElegirUsuario);
            tabControlElegir.Location = new Point(2, 12);
            tabControlElegir.Name = "tabControlElegir";
            tabControlElegir.SelectedIndex = 0;
            tabControlElegir.Size = new Size(1783, 888);
            tabControlElegir.TabIndex = 3;
            // 
            // ElegirGuit
            // 
            ElegirGuit.Controls.Add(tabControlGuitar);
            ElegirGuit.Location = new Point(4, 24);
            ElegirGuit.Name = "ElegirGuit";
            ElegirGuit.Padding = new Padding(3);
            ElegirGuit.Size = new Size(1775, 860);
            ElegirGuit.TabIndex = 0;
            ElegirGuit.Text = "Guitarras";
            ElegirGuit.UseVisualStyleBackColor = true;
            // 
            // ElegirUsuario
            // 
            ElegirUsuario.Location = new Point(4, 24);
            ElegirUsuario.Name = "ElegirUsuario";
            ElegirUsuario.Padding = new Padding(3);
            ElegirUsuario.Size = new Size(1775, 860);
            ElegirUsuario.TabIndex = 1;
            ElegirUsuario.Text = "Usuario";
            ElegirUsuario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 903);
            Controls.Add(tabControlElegir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picmuestra).EndInit();
            tabControlGuitar.ResumeLayout(false);
            InsertarGuit.ResumeLayout(false);
            InsertarGuit.PerformLayout();
            UpdateGuit.ResumeLayout(false);
            UpdateGuit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlElegir.ResumeLayout(false);
            ElegirGuit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CargarIMG;
        private PictureBox picmuestra;
        private TabControl tabControlGuitar;
        private TabPage InsertarGuit;
        private TabPage BorrarGuit;
        private TabPage UpdateGuit;
        private TabControl tabControlElegir;
        private TabPage ElegirGuit;
        private TabPage ElegirUsuario;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnInsertar;
        private TextBox txtbMaderaDiapa;
        private TextBox txtbMaderaMastil;
        private TextBox txtbMarca;
        private TextBox txtbCuerpo;
        private TextBox txtbYear;
        private TextBox txtBEscala;
        private TextBox txtbMaderaCuer;
        private TextBox txtbModelo;
        private TextBox txtbUrl;
        private TextBox yxybPastillas;
        private TextBox txtbFijac;
        private TextBox txtbPuente;
    }
}
