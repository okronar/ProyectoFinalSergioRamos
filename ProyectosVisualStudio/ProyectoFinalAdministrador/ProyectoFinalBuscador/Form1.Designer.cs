namespace ProyectoFinalBuscador
{
    partial class Administrador
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
            btnBorrar = new Button();
            txboxModeloBorrar = new TextBox();
            UpdateGuit = new TabPage();
            txbURLActu = new TextBox();
            txbPastActu = new TextBox();
            txbFijaActu = new TextBox();
            txbPuenteActu = new TextBox();
            txbMDiapActu = new TextBox();
            txbMMastActu = new TextBox();
            txbMarcaActu = new TextBox();
            txbCuerpoActu = new TextBox();
            txbYearActu = new TextBox();
            txbEscalaActu = new TextBox();
            txbMCuerActu = new TextBox();
            txbModeloAct = new TextBox();
            btnActualizar = new Button();
            picmuestraAct = new PictureBox();
            cargImgAct = new Button();
            tabControlElegir = new TabControl();
            ElegirGuit = new TabPage();
            ElegirUsuario = new TabPage();
            btnBorrarEmail = new Button();
            txboxUsuarioBorrar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picmuestra).BeginInit();
            tabControlGuitar.SuspendLayout();
            InsertarGuit.SuspendLayout();
            BorrarGuit.SuspendLayout();
            UpdateGuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picmuestraAct).BeginInit();
            tabControlElegir.SuspendLayout();
            ElegirGuit.SuspendLayout();
            ElegirUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // CargarIMG
            // 
            CargarIMG.AutoSize = true;
            CargarIMG.Location = new Point(1598, 574);
            CargarIMG.Name = "CargarIMG";
            CargarIMG.Size = new Size(135, 37);
            CargarIMG.TabIndex = 0;
            CargarIMG.Text = "Cargar Imagen ";
            CargarIMG.UseVisualStyleBackColor = true;
            CargarIMG.Click += CargarIMG_Click;
            // 
            // picmuestra
            // 
            picmuestra.Location = new Point(1573, 22);
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
            tabControlGuitar.Location = new Point(6, 6);
            tabControlGuitar.Name = "tabControlGuitar";
            tabControlGuitar.SelectedIndex = 0;
            tabControlGuitar.Size = new Size(2080, 871);
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
            InsertarGuit.Size = new Size(2072, 843);
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
            btnInsertar.Location = new Point(1474, 679);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(383, 108);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // BorrarGuit
            // 
            BorrarGuit.Controls.Add(btnBorrar);
            BorrarGuit.Controls.Add(txboxModeloBorrar);
            BorrarGuit.Location = new Point(4, 24);
            BorrarGuit.Name = "BorrarGuit";
            BorrarGuit.Padding = new Padding(3);
            BorrarGuit.Size = new Size(2072, 843);
            BorrarGuit.TabIndex = 1;
            BorrarGuit.Text = "Borrar";
            BorrarGuit.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(824, 356);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(383, 108);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txboxModeloBorrar
            // 
            txboxModeloBorrar.Location = new Point(847, 240);
            txboxModeloBorrar.Name = "txboxModeloBorrar";
            txboxModeloBorrar.PlaceholderText = "Modelo";
            txboxModeloBorrar.Size = new Size(343, 23);
            txboxModeloBorrar.TabIndex = 4;
            txboxModeloBorrar.TextAlign = HorizontalAlignment.Center;
            // 
            // UpdateGuit
            // 
            UpdateGuit.Controls.Add(txbURLActu);
            UpdateGuit.Controls.Add(txbPastActu);
            UpdateGuit.Controls.Add(txbFijaActu);
            UpdateGuit.Controls.Add(txbPuenteActu);
            UpdateGuit.Controls.Add(txbMDiapActu);
            UpdateGuit.Controls.Add(txbMMastActu);
            UpdateGuit.Controls.Add(txbMarcaActu);
            UpdateGuit.Controls.Add(txbCuerpoActu);
            UpdateGuit.Controls.Add(txbYearActu);
            UpdateGuit.Controls.Add(txbEscalaActu);
            UpdateGuit.Controls.Add(txbMCuerActu);
            UpdateGuit.Controls.Add(txbModeloAct);
            UpdateGuit.Controls.Add(btnActualizar);
            UpdateGuit.Controls.Add(picmuestraAct);
            UpdateGuit.Controls.Add(cargImgAct);
            UpdateGuit.Location = new Point(4, 24);
            UpdateGuit.Name = "UpdateGuit";
            UpdateGuit.Padding = new Padding(3);
            UpdateGuit.Size = new Size(2072, 843);
            UpdateGuit.TabIndex = 2;
            UpdateGuit.Text = "Actualizar";
            UpdateGuit.UseVisualStyleBackColor = true;
            // 
            // txbURLActu
            // 
            txbURLActu.Location = new Point(521, 172);
            txbURLActu.Name = "txbURLActu";
            txbURLActu.PlaceholderText = "URL Tienda ";
            txbURLActu.Size = new Size(343, 23);
            txbURLActu.TabIndex = 22;
            txbURLActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPastActu
            // 
            txbPastActu.Location = new Point(521, 118);
            txbPastActu.Name = "txbPastActu";
            txbPastActu.PlaceholderText = "Pastillas";
            txbPastActu.Size = new Size(343, 23);
            txbPastActu.TabIndex = 23;
            txbPastActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbFijaActu
            // 
            txbFijaActu.Location = new Point(521, 63);
            txbFijaActu.Name = "txbFijaActu";
            txbFijaActu.PlaceholderText = "Fijación";
            txbFijaActu.Size = new Size(343, 23);
            txbFijaActu.TabIndex = 24;
            txbFijaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPuenteActu
            // 
            txbPuenteActu.Location = new Point(57, 553);
            txbPuenteActu.Name = "txbPuenteActu";
            txbPuenteActu.PlaceholderText = "Puente";
            txbPuenteActu.Size = new Size(343, 23);
            txbPuenteActu.TabIndex = 21;
            txbPuenteActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMDiapActu
            // 
            txbMDiapActu.Location = new Point(57, 427);
            txbMDiapActu.Name = "txbMDiapActu";
            txbMDiapActu.PlaceholderText = "Madera del Diapasón";
            txbMDiapActu.Size = new Size(343, 23);
            txbMDiapActu.TabIndex = 20;
            txbMDiapActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMMastActu
            // 
            txbMMastActu.Location = new Point(57, 488);
            txbMMastActu.Name = "txbMMastActu";
            txbMMastActu.PlaceholderText = "Madera del Mástil";
            txbMMastActu.Size = new Size(343, 23);
            txbMMastActu.TabIndex = 19;
            txbMMastActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMarcaActu
            // 
            txbMarcaActu.Location = new Point(57, 118);
            txbMarcaActu.Name = "txbMarcaActu";
            txbMarcaActu.PlaceholderText = "Marca";
            txbMarcaActu.Size = new Size(343, 23);
            txbMarcaActu.TabIndex = 18;
            txbMarcaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbCuerpoActu
            // 
            txbCuerpoActu.Location = new Point(57, 172);
            txbCuerpoActu.Name = "txbCuerpoActu";
            txbCuerpoActu.PlaceholderText = "Cuerpo";
            txbCuerpoActu.Size = new Size(343, 23);
            txbCuerpoActu.TabIndex = 17;
            txbCuerpoActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbYearActu
            // 
            txbYearActu.Location = new Point(57, 242);
            txbYearActu.Name = "txbYearActu";
            txbYearActu.PlaceholderText = "Año";
            txbYearActu.Size = new Size(343, 23);
            txbYearActu.TabIndex = 16;
            txbYearActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbEscalaActu
            // 
            txbEscalaActu.Location = new Point(57, 301);
            txbEscalaActu.Name = "txbEscalaActu";
            txbEscalaActu.PlaceholderText = "Escala";
            txbEscalaActu.Size = new Size(343, 23);
            txbEscalaActu.TabIndex = 15;
            txbEscalaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMCuerActu
            // 
            txbMCuerActu.Location = new Point(57, 364);
            txbMCuerActu.Name = "txbMCuerActu";
            txbMCuerActu.PlaceholderText = "Madera del Cuerpo";
            txbMCuerActu.Size = new Size(343, 23);
            txbMCuerActu.TabIndex = 14;
            txbMCuerActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbModeloAct
            // 
            txbModeloAct.Location = new Point(57, 63);
            txbModeloAct.Name = "txbModeloAct";
            txbModeloAct.PlaceholderText = "Modelo";
            txbModeloAct.Size = new Size(343, 23);
            txbModeloAct.TabIndex = 13;
            txbModeloAct.TextAlign = HorizontalAlignment.Center;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1382, 655);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(289, 114);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // picmuestraAct
            // 
            picmuestraAct.Location = new Point(1432, 30);
            picmuestraAct.Name = "picmuestraAct";
            picmuestraAct.Size = new Size(187, 520);
            picmuestraAct.TabIndex = 3;
            picmuestraAct.TabStop = false;
            // 
            // cargImgAct
            // 
            cargImgAct.AutoSize = true;
            cargImgAct.Location = new Point(1457, 581);
            cargImgAct.Name = "cargImgAct";
            cargImgAct.Size = new Size(135, 37);
            cargImgAct.TabIndex = 2;
            cargImgAct.Text = "Cargar Imagen ";
            cargImgAct.UseVisualStyleBackColor = true;
            cargImgAct.Click += cargImgAct_Click;
            // 
            // tabControlElegir
            // 
            tabControlElegir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlElegir.Controls.Add(ElegirGuit);
            tabControlElegir.Controls.Add(ElegirUsuario);
            tabControlElegir.Location = new Point(1, 12);
            tabControlElegir.Name = "tabControlElegir";
            tabControlElegir.SelectedIndex = 0;
            tabControlElegir.Size = new Size(2101, 908);
            tabControlElegir.TabIndex = 3;
            // 
            // ElegirGuit
            // 
            ElegirGuit.Controls.Add(tabControlGuitar);
            ElegirGuit.Location = new Point(4, 24);
            ElegirGuit.Name = "ElegirGuit";
            ElegirGuit.Padding = new Padding(3);
            ElegirGuit.Size = new Size(2093, 880);
            ElegirGuit.TabIndex = 0;
            ElegirGuit.Text = "Guitarras";
            ElegirGuit.UseVisualStyleBackColor = true;
            // 
            // ElegirUsuario
            // 
            ElegirUsuario.Controls.Add(btnBorrarEmail);
            ElegirUsuario.Controls.Add(txboxUsuarioBorrar);
            ElegirUsuario.Location = new Point(4, 24);
            ElegirUsuario.Name = "ElegirUsuario";
            ElegirUsuario.Padding = new Padding(3);
            ElegirUsuario.Size = new Size(2093, 880);
            ElegirUsuario.TabIndex = 1;
            ElegirUsuario.Text = "Usuario";
            ElegirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmail
            // 
            btnBorrarEmail.Location = new Point(857, 446);
            btnBorrarEmail.Name = "btnBorrarEmail";
            btnBorrarEmail.Size = new Size(383, 108);
            btnBorrarEmail.TabIndex = 7;
            btnBorrarEmail.Text = "Borrar";
            btnBorrarEmail.UseVisualStyleBackColor = true;
            btnBorrarEmail.Click += btnBorrarEmail_Click;
            // 
            // txboxUsuarioBorrar
            // 
            txboxUsuarioBorrar.Location = new Point(877, 295);
            txboxUsuarioBorrar.Name = "txboxUsuarioBorrar";
            txboxUsuarioBorrar.PlaceholderText = "Email del usuario a borrar";
            txboxUsuarioBorrar.Size = new Size(343, 23);
            txboxUsuarioBorrar.TabIndex = 6;
            txboxUsuarioBorrar.TextAlign = HorizontalAlignment.Center;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2103, 921);
            Controls.Add(tabControlElegir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Administrador";
            Text = "Administrador";
            TransparencyKey = Color.Lime;
            ((System.ComponentModel.ISupportInitialize)picmuestra).EndInit();
            tabControlGuitar.ResumeLayout(false);
            InsertarGuit.ResumeLayout(false);
            InsertarGuit.PerformLayout();
            BorrarGuit.ResumeLayout(false);
            BorrarGuit.PerformLayout();
            UpdateGuit.ResumeLayout(false);
            UpdateGuit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picmuestraAct).EndInit();
            tabControlElegir.ResumeLayout(false);
            ElegirGuit.ResumeLayout(false);
            ElegirUsuario.ResumeLayout(false);
            ElegirUsuario.PerformLayout();
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
        private TextBox txboxModeloBorrar;
        private Button btnBorrar;
        private PictureBox picmuestraAct;
        private Button cargImgAct;
        private Button btnActualizar;
        private Button btnBorrarEmail;
        private TextBox txboxUsuarioBorrar;
        private TextBox txbURLActu;
        private TextBox txbPastActu;
        private TextBox txbFijaActu;
        private TextBox txbPuenteActu;
        private TextBox txbMDiapActu;
        private TextBox txbMMastActu;
        private TextBox txbMarcaActu;
        private TextBox txbCuerpoActu;
        private TextBox txbYearActu;
        private TextBox txbEscalaActu;
        private TextBox txbMCuerActu;
        private TextBox txbModeloAct;
    }
}
