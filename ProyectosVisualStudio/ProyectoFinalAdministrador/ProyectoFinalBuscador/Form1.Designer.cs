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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtbModelo = new TextBox();
            txtbMarca = new TextBox();
            txtbCuerpo = new TextBox();
            txtbYear = new TextBox();
            txtBEscala = new TextBox();
            txtbMaderaDiapa = new TextBox();
            txtbMaderaCuer = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtbMaderaMastil = new TextBox();
            txtbPuente = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtbFijac = new TextBox();
            txtbUrl = new TextBox();
            txtbPastillas = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnInsertar = new Button();
            BorrarGuit = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnBorrarGuitarra = new Button();
            txboxIdBorrar = new TextBox();
            dataGridguitborrar = new DataGridView();
            UpdateGuit = new TabPage();
            tableLayoutPanel10 = new TableLayoutPanel();
            GridActualizarGuitarra = new DataGridView();
            tableLayoutPanel11 = new TableLayoutPanel();
            txbModeloAct = new TextBox();
            txbMarcaActu = new TextBox();
            txbCuerpoActu = new TextBox();
            txbYearActu = new TextBox();
            txbEscalaActu = new TextBox();
            txbPuenteActu = new TextBox();
            txbMCuerActu = new TextBox();
            txbMMastActu = new TextBox();
            txbMDiapActu = new TextBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            txbFijaActu = new TextBox();
            txbPastActu = new TextBox();
            txbIdActu = new TextBox();
            txbURLActu = new TextBox();
            btnActualizar = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            picmuestraAct = new PictureBox();
            cargImgAct = new Button();
            tabControlElegir = new TabControl();
            ElegirGuit = new TabPage();
            ElegirUsuario = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBorrarEmail = new Button();
            txboxUsuarioBorrar = new TextBox();
            tableUsuarios = new TableLayoutPanel();
            gridBorrarUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picmuestra).BeginInit();
            tabControlGuitar.SuspendLayout();
            InsertarGuit.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            BorrarGuit.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridguitborrar).BeginInit();
            UpdateGuit.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridActualizarGuitarra).BeginInit();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picmuestraAct).BeginInit();
            tabControlElegir.SuspendLayout();
            ElegirGuit.SuspendLayout();
            ElegirUsuario.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBorrarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // CargarIMG
            // 
            CargarIMG.AutoSize = true;
            CargarIMG.Location = new Point(3, 528);
            CargarIMG.Name = "CargarIMG";
            CargarIMG.Size = new Size(135, 37);
            CargarIMG.TabIndex = 0;
            CargarIMG.Text = "Cargar Imagen ";
            CargarIMG.UseVisualStyleBackColor = true;
            CargarIMG.Click += CargarIMG_Click;
            // 
            // picmuestra
            // 
            picmuestra.Anchor = AnchorStyles.None;
            picmuestra.Location = new Point(205, 3);
            picmuestra.Name = "picmuestra";
            picmuestra.Size = new Size(173, 519);
            picmuestra.TabIndex = 1;
            picmuestra.TabStop = false;
            // 
            // tabControlGuitar
            // 
            tabControlGuitar.Controls.Add(InsertarGuit);
            tabControlGuitar.Controls.Add(BorrarGuit);
            tabControlGuitar.Controls.Add(UpdateGuit);
            tabControlGuitar.Dock = DockStyle.Fill;
            tabControlGuitar.Location = new Point(3, 3);
            tabControlGuitar.Name = "tabControlGuitar";
            tabControlGuitar.SelectedIndex = 0;
            tabControlGuitar.Size = new Size(1504, 887);
            tabControlGuitar.TabIndex = 2;
            // 
            // InsertarGuit
            // 
            InsertarGuit.Controls.Add(tableLayoutPanel3);
            InsertarGuit.Location = new Point(4, 24);
            InsertarGuit.Name = "InsertarGuit";
            InsertarGuit.Padding = new Padding(3);
            InsertarGuit.Size = new Size(1496, 859);
            InsertarGuit.TabIndex = 0;
            InsertarGuit.Text = "Insertar";
            InsertarGuit.ToolTipText = "Insertar guitarras";
            InsertarGuit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5093155F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4906845F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 589F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 2, 0);
            tableLayoutPanel3.Controls.Add(btnInsertar, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.12544F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8745613F));
            tableLayoutPanel3.Size = new Size(1490, 853);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtbModelo, 0, 0);
            tableLayoutPanel5.Controls.Add(txtbMarca, 0, 1);
            tableLayoutPanel5.Controls.Add(txtbCuerpo, 0, 2);
            tableLayoutPanel5.Controls.Add(txtbYear, 0, 3);
            tableLayoutPanel5.Controls.Add(txtBEscala, 0, 4);
            tableLayoutPanel5.Controls.Add(txtbMaderaDiapa, 0, 6);
            tableLayoutPanel5.Controls.Add(txtbMaderaCuer, 0, 5);
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.Size = new Size(326, 686);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // txtbModelo
            // 
            txtbModelo.Location = new Point(3, 3);
            txtbModelo.Name = "txtbModelo";
            txtbModelo.PlaceholderText = "Modelo";
            txtbModelo.Size = new Size(320, 23);
            txtbModelo.TabIndex = 3;
            txtbModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMarca
            // 
            txtbMarca.Location = new Point(3, 101);
            txtbMarca.Name = "txtbMarca";
            txtbMarca.PlaceholderText = "Marca";
            txtbMarca.Size = new Size(320, 23);
            txtbMarca.TabIndex = 8;
            txtbMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbCuerpo
            // 
            txtbCuerpo.Location = new Point(3, 199);
            txtbCuerpo.Name = "txtbCuerpo";
            txtbCuerpo.PlaceholderText = "Cuerpo";
            txtbCuerpo.Size = new Size(320, 23);
            txtbCuerpo.TabIndex = 7;
            txtbCuerpo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbYear
            // 
            txtbYear.Location = new Point(3, 297);
            txtbYear.Name = "txtbYear";
            txtbYear.PlaceholderText = "Año";
            txtbYear.Size = new Size(320, 23);
            txtbYear.TabIndex = 6;
            txtbYear.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBEscala
            // 
            txtBEscala.Location = new Point(3, 395);
            txtBEscala.Name = "txtBEscala";
            txtBEscala.PlaceholderText = "Escala";
            txtBEscala.Size = new Size(320, 23);
            txtBEscala.TabIndex = 5;
            txtBEscala.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMaderaDiapa
            // 
            txtbMaderaDiapa.Location = new Point(3, 591);
            txtbMaderaDiapa.Name = "txtbMaderaDiapa";
            txtbMaderaDiapa.PlaceholderText = "Madera del Diapasón";
            txtbMaderaDiapa.Size = new Size(320, 23);
            txtbMaderaDiapa.TabIndex = 10;
            txtbMaderaDiapa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMaderaCuer
            // 
            txtbMaderaCuer.Location = new Point(3, 493);
            txtbMaderaCuer.Name = "txtbMaderaCuer";
            txtbMaderaCuer.PlaceholderText = "Madera del Cuerpo";
            txtbMaderaCuer.Size = new Size(320, 23);
            txtbMaderaCuer.TabIndex = 4;
            txtbMaderaCuer.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(txtbMaderaMastil, 0, 0);
            tableLayoutPanel6.Controls.Add(txtbPuente, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 695);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(323, 152);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // txtbMaderaMastil
            // 
            txtbMaderaMastil.Location = new Point(3, 3);
            txtbMaderaMastil.Name = "txtbMaderaMastil";
            txtbMaderaMastil.PlaceholderText = "Madera del Mástil";
            txtbMaderaMastil.Size = new Size(317, 23);
            txtbMaderaMastil.TabIndex = 9;
            txtbMaderaMastil.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPuente
            // 
            txtbPuente.Location = new Point(3, 79);
            txtbPuente.Name = "txtbPuente";
            txtbPuente.PlaceholderText = "Puente";
            txtbPuente.Size = new Size(317, 23);
            txtbPuente.TabIndex = 11;
            txtbPuente.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtbFijac, 0, 0);
            tableLayoutPanel7.Controls.Add(txtbUrl, 0, 2);
            tableLayoutPanel7.Controls.Add(txtbPastillas, 0, 1);
            tableLayoutPanel7.Location = new Point(575, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 111F));
            tableLayoutPanel7.Size = new Size(289, 257);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // txtbFijac
            // 
            txtbFijac.Location = new Point(3, 3);
            txtbFijac.Name = "txtbFijac";
            txtbFijac.PlaceholderText = "Fijación";
            txtbFijac.Size = new Size(283, 23);
            txtbFijac.TabIndex = 12;
            txtbFijac.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbUrl
            // 
            txtbUrl.Location = new Point(3, 149);
            txtbUrl.Name = "txtbUrl";
            txtbUrl.PlaceholderText = "URL Tienda ";
            txtbUrl.Size = new Size(283, 23);
            txtbUrl.TabIndex = 12;
            txtbUrl.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPastillas
            // 
            txtbPastillas.Location = new Point(3, 77);
            txtbPastillas.Name = "txtbPastillas";
            txtbPastillas.PlaceholderText = "Pastillas";
            txtbPastillas.Size = new Size(283, 23);
            txtbPastillas.TabIndex = 12;
            txtbPastillas.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.None;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(CargarIMG, 0, 1);
            tableLayoutPanel8.Controls.Add(picmuestra, 0, 0);
            tableLayoutPanel8.Location = new Point(903, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 161F));
            tableLayoutPanel8.Size = new Size(584, 686);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(903, 695);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(383, 108);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // BorrarGuit
            // 
            BorrarGuit.Controls.Add(tableLayoutPanel4);
            BorrarGuit.Location = new Point(4, 24);
            BorrarGuit.Name = "BorrarGuit";
            BorrarGuit.Padding = new Padding(3);
            BorrarGuit.Size = new Size(1496, 859);
            BorrarGuit.TabIndex = 1;
            BorrarGuit.Text = "Borrar";
            BorrarGuit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel4.Controls.Add(dataGridguitborrar, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1490, 853);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(btnBorrarGuitarra, 0, 1);
            tableLayoutPanel9.Controls.Add(txboxIdBorrar, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tableLayoutPanel9.Size = new Size(739, 847);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // btnBorrarGuitarra
            // 
            btnBorrarGuitarra.Anchor = AnchorStyles.None;
            btnBorrarGuitarra.Location = new Point(178, 728);
            btnBorrarGuitarra.Name = "btnBorrarGuitarra";
            btnBorrarGuitarra.Size = new Size(383, 108);
            btnBorrarGuitarra.TabIndex = 5;
            btnBorrarGuitarra.Text = "Borrar";
            btnBorrarGuitarra.UseVisualStyleBackColor = true;
            btnBorrarGuitarra.Click += btnBorrarGuitarra_Click;
            // 
            // txboxIdBorrar
            // 
            txboxIdBorrar.Anchor = AnchorStyles.None;
            txboxIdBorrar.Location = new Point(188, 347);
            txboxIdBorrar.Name = "txboxIdBorrar";
            txboxIdBorrar.PlaceholderText = "Id de la Guitarra ";
            txboxIdBorrar.Size = new Size(363, 23);
            txboxIdBorrar.TabIndex = 4;
            txboxIdBorrar.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridguitborrar
            // 
            dataGridguitborrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridguitborrar.Dock = DockStyle.Fill;
            dataGridguitborrar.Location = new Point(748, 3);
            dataGridguitborrar.Name = "dataGridguitborrar";
            dataGridguitborrar.Size = new Size(739, 847);
            dataGridguitborrar.TabIndex = 1;
            // 
            // UpdateGuit
            // 
            UpdateGuit.Controls.Add(tableLayoutPanel10);
            UpdateGuit.Location = new Point(4, 24);
            UpdateGuit.Name = "UpdateGuit";
            UpdateGuit.Padding = new Padding(3);
            UpdateGuit.Size = new Size(1496, 859);
            UpdateGuit.TabIndex = 2;
            UpdateGuit.Text = "Actualizar";
            UpdateGuit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6757355F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6757374F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6757374F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9727917F));
            tableLayoutPanel10.Controls.Add(GridActualizarGuitarra, 3, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel13, 2, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1490, 853);
            tableLayoutPanel10.TabIndex = 26;
            // 
            // GridActualizarGuitarra
            // 
            GridActualizarGuitarra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridActualizarGuitarra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridActualizarGuitarra.Location = new Point(1014, 3);
            GridActualizarGuitarra.Name = "GridActualizarGuitarra";
            GridActualizarGuitarra.Size = new Size(473, 847);
            GridActualizarGuitarra.TabIndex = 0;
            GridActualizarGuitarra.CellClick += GridActualizarGuitarra_CellClick;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(txbModeloAct, 0, 0);
            tableLayoutPanel11.Controls.Add(txbMarcaActu, 0, 1);
            tableLayoutPanel11.Controls.Add(txbCuerpoActu, 0, 2);
            tableLayoutPanel11.Controls.Add(txbYearActu, 0, 3);
            tableLayoutPanel11.Controls.Add(txbEscalaActu, 0, 4);
            tableLayoutPanel11.Controls.Add(txbPuenteActu, 0, 8);
            tableLayoutPanel11.Controls.Add(txbMCuerActu, 0, 5);
            tableLayoutPanel11.Controls.Add(txbMMastActu, 0, 7);
            tableLayoutPanel11.Controls.Add(txbMDiapActu, 0, 6);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 9;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.Size = new Size(331, 847);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // txbModeloAct
            // 
            txbModeloAct.Location = new Point(3, 3);
            txbModeloAct.Name = "txbModeloAct";
            txbModeloAct.PlaceholderText = "Modelo";
            txbModeloAct.Size = new Size(325, 23);
            txbModeloAct.TabIndex = 13;
            txbModeloAct.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMarcaActu
            // 
            txbMarcaActu.Location = new Point(3, 97);
            txbMarcaActu.Name = "txbMarcaActu";
            txbMarcaActu.PlaceholderText = "Marca";
            txbMarcaActu.Size = new Size(325, 23);
            txbMarcaActu.TabIndex = 18;
            txbMarcaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbCuerpoActu
            // 
            txbCuerpoActu.Location = new Point(3, 191);
            txbCuerpoActu.Name = "txbCuerpoActu";
            txbCuerpoActu.PlaceholderText = "Cuerpo";
            txbCuerpoActu.Size = new Size(325, 23);
            txbCuerpoActu.TabIndex = 17;
            txbCuerpoActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbYearActu
            // 
            txbYearActu.Location = new Point(3, 285);
            txbYearActu.Name = "txbYearActu";
            txbYearActu.PlaceholderText = "Año";
            txbYearActu.Size = new Size(325, 23);
            txbYearActu.TabIndex = 16;
            txbYearActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbEscalaActu
            // 
            txbEscalaActu.Location = new Point(3, 379);
            txbEscalaActu.Name = "txbEscalaActu";
            txbEscalaActu.PlaceholderText = "Escala";
            txbEscalaActu.Size = new Size(325, 23);
            txbEscalaActu.TabIndex = 15;
            txbEscalaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPuenteActu
            // 
            txbPuenteActu.Location = new Point(3, 755);
            txbPuenteActu.Name = "txbPuenteActu";
            txbPuenteActu.PlaceholderText = "Puente";
            txbPuenteActu.Size = new Size(325, 23);
            txbPuenteActu.TabIndex = 21;
            txbPuenteActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMCuerActu
            // 
            txbMCuerActu.Location = new Point(3, 473);
            txbMCuerActu.Name = "txbMCuerActu";
            txbMCuerActu.PlaceholderText = "Madera del Cuerpo";
            txbMCuerActu.Size = new Size(325, 23);
            txbMCuerActu.TabIndex = 14;
            txbMCuerActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMMastActu
            // 
            txbMMastActu.Location = new Point(3, 661);
            txbMMastActu.Name = "txbMMastActu";
            txbMMastActu.PlaceholderText = "Madera del Mástil";
            txbMMastActu.Size = new Size(325, 23);
            txbMMastActu.TabIndex = 19;
            txbMMastActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbMDiapActu
            // 
            txbMDiapActu.Location = new Point(3, 567);
            txbMDiapActu.Name = "txbMDiapActu";
            txbMDiapActu.PlaceholderText = "Madera del Diapasón";
            txbMDiapActu.Size = new Size(325, 23);
            txbMDiapActu.TabIndex = 20;
            txbMDiapActu.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Controls.Add(txbFijaActu, 0, 0);
            tableLayoutPanel12.Controls.Add(txbPastActu, 0, 1);
            tableLayoutPanel12.Controls.Add(txbIdActu, 0, 3);
            tableLayoutPanel12.Controls.Add(txbURLActu, 0, 2);
            tableLayoutPanel12.Controls.Add(btnActualizar, 0, 4);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(340, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 5;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.Size = new Size(331, 847);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // txbFijaActu
            // 
            txbFijaActu.Location = new Point(3, 3);
            txbFijaActu.Name = "txbFijaActu";
            txbFijaActu.PlaceholderText = "Fijación";
            txbFijaActu.Size = new Size(325, 23);
            txbFijaActu.TabIndex = 24;
            txbFijaActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPastActu
            // 
            txbPastActu.Location = new Point(3, 172);
            txbPastActu.Name = "txbPastActu";
            txbPastActu.PlaceholderText = "Pastillas";
            txbPastActu.Size = new Size(325, 23);
            txbPastActu.TabIndex = 23;
            txbPastActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbIdActu
            // 
            txbIdActu.Location = new Point(3, 510);
            txbIdActu.Name = "txbIdActu";
            txbIdActu.PlaceholderText = "Id de la guitarra a actualizar";
            txbIdActu.Size = new Size(325, 23);
            txbIdActu.TabIndex = 15;
            txbIdActu.TextAlign = HorizontalAlignment.Center;
            // 
            // txbURLActu
            // 
            txbURLActu.Location = new Point(3, 341);
            txbURLActu.Name = "txbURLActu";
            txbURLActu.PlaceholderText = "URL Tienda ";
            txbURLActu.Size = new Size(325, 23);
            txbURLActu.TabIndex = 22;
            txbURLActu.TextAlign = HorizontalAlignment.Center;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.Location = new Point(3, 735);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(324, 53);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(picmuestraAct, 0, 0);
            tableLayoutPanel13.Controls.Add(cargImgAct, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(677, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 678F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel13.Size = new Size(331, 847);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // picmuestraAct
            // 
            picmuestraAct.Anchor = AnchorStyles.None;
            picmuestraAct.Location = new Point(72, 79);
            picmuestraAct.Name = "picmuestraAct";
            picmuestraAct.Size = new Size(187, 520);
            picmuestraAct.TabIndex = 3;
            picmuestraAct.TabStop = false;
            // 
            // cargImgAct
            // 
            cargImgAct.Anchor = AnchorStyles.None;
            cargImgAct.AutoSize = true;
            cargImgAct.Location = new Point(20, 737);
            cargImgAct.Name = "cargImgAct";
            cargImgAct.Size = new Size(290, 50);
            cargImgAct.TabIndex = 2;
            cargImgAct.Text = "Cargar Imagen ";
            cargImgAct.UseVisualStyleBackColor = true;
            cargImgAct.Click += cargImgAct_Click;
            // 
            // tabControlElegir
            // 
            tabControlElegir.Controls.Add(ElegirGuit);
            tabControlElegir.Controls.Add(ElegirUsuario);
            tabControlElegir.Dock = DockStyle.Fill;
            tabControlElegir.Location = new Point(0, 0);
            tabControlElegir.Name = "tabControlElegir";
            tabControlElegir.SelectedIndex = 0;
            tabControlElegir.Size = new Size(1518, 921);
            tabControlElegir.TabIndex = 3;
            // 
            // ElegirGuit
            // 
            ElegirGuit.Controls.Add(tabControlGuitar);
            ElegirGuit.Location = new Point(4, 24);
            ElegirGuit.Name = "ElegirGuit";
            ElegirGuit.Padding = new Padding(3);
            ElegirGuit.Size = new Size(1510, 893);
            ElegirGuit.TabIndex = 0;
            ElegirGuit.Text = "Guitarras";
            ElegirGuit.UseVisualStyleBackColor = true;
            // 
            // ElegirUsuario
            // 
            ElegirUsuario.Controls.Add(tableLayoutPanel1);
            ElegirUsuario.Location = new Point(4, 24);
            ElegirUsuario.Name = "ElegirUsuario";
            ElegirUsuario.Padding = new Padding(3);
            ElegirUsuario.Size = new Size(1510, 893);
            ElegirUsuario.TabIndex = 1;
            ElegirUsuario.Text = "Usuario";
            ElegirUsuario.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableUsuarios, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1504, 887);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnBorrarEmail, 0, 1);
            tableLayoutPanel2.Controls.Add(txboxUsuarioBorrar, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(504, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(495, 881);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBorrarEmail
            // 
            btnBorrarEmail.Anchor = AnchorStyles.None;
            btnBorrarEmail.Location = new Point(56, 606);
            btnBorrarEmail.Name = "btnBorrarEmail";
            btnBorrarEmail.Size = new Size(383, 108);
            btnBorrarEmail.TabIndex = 7;
            btnBorrarEmail.Text = "Borrar";
            btnBorrarEmail.UseVisualStyleBackColor = true;
            btnBorrarEmail.Click += btnBorrarEmail_Click;
            // 
            // txboxUsuarioBorrar
            // 
            txboxUsuarioBorrar.Anchor = AnchorStyles.None;
            txboxUsuarioBorrar.Location = new Point(76, 208);
            txboxUsuarioBorrar.Name = "txboxUsuarioBorrar";
            txboxUsuarioBorrar.PlaceholderText = "Email del usuario a borrar";
            txboxUsuarioBorrar.Size = new Size(343, 23);
            txboxUsuarioBorrar.TabIndex = 6;
            txboxUsuarioBorrar.TextAlign = HorizontalAlignment.Center;
            // 
            // tableUsuarios
            // 
            tableUsuarios.Anchor = AnchorStyles.None;
            tableUsuarios.ColumnCount = 1;
            tableUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableUsuarios.Controls.Add(gridBorrarUsuarios, 0, 0);
            tableUsuarios.Location = new Point(1020, 78);
            tableUsuarios.Name = "tableUsuarios";
            tableUsuarios.RowCount = 1;
            tableUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableUsuarios.Size = new Size(466, 730);
            tableUsuarios.TabIndex = 8;
            // 
            // gridBorrarUsuarios
            // 
            gridBorrarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBorrarUsuarios.Dock = DockStyle.Fill;
            gridBorrarUsuarios.Location = new Point(3, 3);
            gridBorrarUsuarios.Name = "gridBorrarUsuarios";
            gridBorrarUsuarios.Size = new Size(460, 724);
            gridBorrarUsuarios.TabIndex = 0;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 921);
            Controls.Add(tabControlElegir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Administrador";
            Text = "Administrador";
            TransparencyKey = Color.Lime;
            ((System.ComponentModel.ISupportInitialize)picmuestra).EndInit();
            tabControlGuitar.ResumeLayout(false);
            InsertarGuit.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            BorrarGuit.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridguitborrar).EndInit();
            UpdateGuit.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridActualizarGuitarra).EndInit();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picmuestraAct).EndInit();
            tabControlElegir.ResumeLayout(false);
            ElegirGuit.ResumeLayout(false);
            ElegirUsuario.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridBorrarUsuarios).EndInit();
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
        private TextBox txtbPastillas;
        private TextBox txtbFijac;
        private TextBox txtbPuente;
        private TextBox txboxIdBorrar;
        private Button btnBorrarGuitarra;
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
        private TextBox txbIdActu;
        private DataGridView GridActualizarGuitarra;
        private TableLayoutPanel tableUsuarios;
        private DataGridView gridBorrarUsuarios;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel9;
        private DataGridView dataGridguitborrar;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
    }
}
