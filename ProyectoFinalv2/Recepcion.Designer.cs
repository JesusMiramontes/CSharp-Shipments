namespace ProyectoFinalv2
    {
    partial class Form0
        {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
            {
            if ( disposing && ( components != null ) )
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
            {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.TopBar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.FullTopBar = new System.Windows.Forms.Panel();
            this.TituloForma = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ContenidoForma = new System.Windows.Forms.Panel();
            this.dgv_recepcion = new System.Windows.Forms.DataGridView();
            this.dgvIdEnvio_Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPeso_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemitente_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestinatario_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionR_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionD_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaE_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstante_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNivel_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownDgv = new System.Windows.Forms.Panel();
            this.btnNuevoL = new System.Windows.Forms.Label();
            this.pb_rec = new System.Windows.Forms.ProgressBar();
            this.btnFinalizarL = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnNuevo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnFinalizar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panelIngresoDatos = new System.Windows.Forms.Panel();
            this.btnLimpiarL = new System.Windows.Forms.Label();
            this.btnAgregarL = new System.Windows.Forms.Label();
            this.rec_fechaE = new System.Windows.Forms.MaskedTextBox();
            this.lbFechaE_rec = new System.Windows.Forms.Label();
            this.rec_direccionD = new System.Windows.Forms.TextBox();
            this.lbDireccionD_rec = new System.Windows.Forms.Label();
            this.rec_direccionR = new System.Windows.Forms.TextBox();
            this.lbDireccionR_rec = new System.Windows.Forms.Label();
            this.rec_destinatario = new System.Windows.Forms.TextBox();
            this.lbDestinatario_rec = new System.Windows.Forms.Label();
            this.rec_remitente = new System.Windows.Forms.TextBox();
            this.rec_peso = new System.Windows.Forms.TextBox();
            this.lbRemitente_rec = new System.Windows.Forms.Label();
            this.lbPeso_rec = new System.Windows.Forms.Label();
            this.rec_id = new System.Windows.Forms.TextBox();
            this.lbId_rec = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnLimpiar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnAgregar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkFechaE_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDireccionR_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDestinatario_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkRemitente_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkPeso_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDireccionD_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkId_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.FullTopBar.SuspendLayout();
            this.ContenidoForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recepcion)).BeginInit();
            this.DownDgv.SuspendLayout();
            this.panelIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(800, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 22);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(782, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 22);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.TopBar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.TopBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Location = new System.Drawing.Point(-2, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Size = new System.Drawing.Size(822, 23);
            this.TopBar.Click += new System.EventHandler(this.TopBar_Click);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // FullTopBar
            // 
            this.FullTopBar.Controls.Add(this.TituloForma);
            this.FullTopBar.Controls.Add(this.MinimizeButton);
            this.FullTopBar.Controls.Add(this.CloseButton);
            this.FullTopBar.Controls.Add(this.shapeContainer2);
            this.FullTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FullTopBar.Location = new System.Drawing.Point(0, 0);
            this.FullTopBar.Name = "FullTopBar";
            this.FullTopBar.Size = new System.Drawing.Size(820, 22);
            this.FullTopBar.TabIndex = 3;
            // 
            // TituloForma
            // 
            this.TituloForma.AutoSize = true;
            this.TituloForma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.TituloForma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloForma.ForeColor = System.Drawing.Color.White;
            this.TituloForma.Location = new System.Drawing.Point(2, 3);
            this.TituloForma.Name = "TituloForma";
            this.TituloForma.Size = new System.Drawing.Size(154, 14);
            this.TituloForma.TabIndex = 2;
            this.TituloForma.Text = "Recepción de paquetes";
            this.TituloForma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TituloForma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TituloForma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TopBar});
            this.shapeContainer2.Size = new System.Drawing.Size(820, 22);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // ContenidoForma
            // 
            this.ContenidoForma.Controls.Add(this.dgv_recepcion);
            this.ContenidoForma.Controls.Add(this.DownDgv);
            this.ContenidoForma.Controls.Add(this.panelIngresoDatos);
            this.ContenidoForma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenidoForma.Location = new System.Drawing.Point(0, 22);
            this.ContenidoForma.Name = "ContenidoForma";
            this.ContenidoForma.Size = new System.Drawing.Size(820, 451);
            this.ContenidoForma.TabIndex = 4;
            // 
            // dgv_recepcion
            // 
            this.dgv_recepcion.AllowUserToAddRows = false;
            this.dgv_recepcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_recepcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_recepcion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_recepcion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recepcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recepcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdEnvio_Rec,
            this.dgvPeso_rec,
            this.dgvRemitente_rec,
            this.dgvDestinatario_rec,
            this.dgvDireccionR_rec,
            this.dgvDireccionD_rec,
            this.dgvFechaE_rec,
            this.dgvEstante_rec,
            this.dgvNivel_rec});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recepcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_recepcion.EnableHeadersVisualStyles = false;
            this.dgv_recepcion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_recepcion.Location = new System.Drawing.Point(136, 0);
            this.dgv_recepcion.Name = "dgv_recepcion";
            this.dgv_recepcion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recepcion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_recepcion.RowHeadersVisible = false;
            this.dgv_recepcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_recepcion.Size = new System.Drawing.Size(684, 419);
            this.dgv_recepcion.TabIndex = 9;
            this.dgv_recepcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_recepcion_CellContentClick);
            // 
            // dgvIdEnvio_Rec
            // 
            this.dgvIdEnvio_Rec.HeaderText = "ID";
            this.dgvIdEnvio_Rec.Name = "dgvIdEnvio_Rec";
            this.dgvIdEnvio_Rec.ReadOnly = true;
            this.dgvIdEnvio_Rec.Width = 32;
            // 
            // dgvPeso_rec
            // 
            this.dgvPeso_rec.HeaderText = "Peso";
            this.dgvPeso_rec.Name = "dgvPeso_rec";
            this.dgvPeso_rec.ReadOnly = true;
            this.dgvPeso_rec.Width = 45;
            // 
            // dgvRemitente_rec
            // 
            this.dgvRemitente_rec.HeaderText = "Remitente";
            this.dgvRemitente_rec.Name = "dgvRemitente_rec";
            this.dgvRemitente_rec.ReadOnly = true;
            // 
            // dgvDestinatario_rec
            // 
            this.dgvDestinatario_rec.HeaderText = "Destinatario";
            this.dgvDestinatario_rec.Name = "dgvDestinatario_rec";
            this.dgvDestinatario_rec.ReadOnly = true;
            // 
            // dgvDireccionR_rec
            // 
            this.dgvDireccionR_rec.HeaderText = "Dirección R.";
            this.dgvDireccionR_rec.Name = "dgvDireccionR_rec";
            this.dgvDireccionR_rec.ReadOnly = true;
            this.dgvDireccionR_rec.Width = 136;
            // 
            // dgvDireccionD_rec
            // 
            this.dgvDireccionD_rec.HeaderText = "Dirección D.";
            this.dgvDireccionD_rec.Name = "dgvDireccionD_rec";
            this.dgvDireccionD_rec.ReadOnly = true;
            this.dgvDireccionD_rec.Width = 136;
            // 
            // dgvFechaE_rec
            // 
            this.dgvFechaE_rec.HeaderText = "Fecha envio";
            this.dgvFechaE_rec.Name = "dgvFechaE_rec";
            this.dgvFechaE_rec.ReadOnly = true;
            this.dgvFechaE_rec.Width = 75;
            // 
            // dgvEstante_rec
            // 
            this.dgvEstante_rec.HeaderText = "E";
            this.dgvEstante_rec.Name = "dgvEstante_rec";
            this.dgvEstante_rec.ReadOnly = true;
            this.dgvEstante_rec.Width = 30;
            // 
            // dgvNivel_rec
            // 
            this.dgvNivel_rec.HeaderText = "N";
            this.dgvNivel_rec.Name = "dgvNivel_rec";
            this.dgvNivel_rec.ReadOnly = true;
            this.dgvNivel_rec.Width = 30;
            // 
            // DownDgv
            // 
            this.DownDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.DownDgv.Controls.Add(this.btnNuevoL);
            this.DownDgv.Controls.Add(this.pb_rec);
            this.DownDgv.Controls.Add(this.btnFinalizarL);
            this.DownDgv.Controls.Add(this.shapeContainer4);
            this.DownDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownDgv.Location = new System.Drawing.Point(136, 419);
            this.DownDgv.Name = "DownDgv";
            this.DownDgv.Size = new System.Drawing.Size(684, 32);
            this.DownDgv.TabIndex = 9;
            this.DownDgv.Paint += new System.Windows.Forms.PaintEventHandler(this.DownDgv_Paint);
            // 
            // btnNuevoL
            // 
            this.btnNuevoL.AutoSize = true;
            this.btnNuevoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnNuevoL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoL.Location = new System.Drawing.Point(534, 10);
            this.btnNuevoL.Name = "btnNuevoL";
            this.btnNuevoL.Size = new System.Drawing.Size(42, 14);
            this.btnNuevoL.TabIndex = 21;
            this.btnNuevoL.Text = "Nuevo";
            this.btnNuevoL.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevoL.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            this.btnNuevoL.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            // 
            // pb_rec
            // 
            this.pb_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.pb_rec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_rec.ForeColor = System.Drawing.Color.Maroon;
            this.pb_rec.Location = new System.Drawing.Point(0, 30);
            this.pb_rec.Name = "pb_rec";
            this.pb_rec.Size = new System.Drawing.Size(684, 2);
            this.pb_rec.Step = 1;
            this.pb_rec.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_rec.TabIndex = 10;
            // 
            // btnFinalizarL
            // 
            this.btnFinalizarL.AutoSize = true;
            this.btnFinalizarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnFinalizarL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFinalizarL.Location = new System.Drawing.Point(599, 9);
            this.btnFinalizarL.Name = "btnFinalizarL";
            this.btnFinalizarL.Size = new System.Drawing.Size(70, 14);
            this.btnFinalizarL.TabIndex = 20;
            this.btnFinalizarL.Text = "Finalizar";
            this.btnFinalizarL.Click += new System.EventHandler(this.btnFinalizar_Click);
            this.btnFinalizarL.MouseEnter += new System.EventHandler(this.btnFinalizar_MouseEnter);
            this.btnFinalizarL.MouseLeave += new System.EventHandler(this.btnFinalizar_MouseLeave);
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnNuevo,
            this.btnFinalizar});
            this.shapeContainer4.Size = new System.Drawing.Size(684, 32);
            this.shapeContainer4.TabIndex = 8;
            this.shapeContainer4.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnNuevo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnNuevo.CornerRadius = 3;
            this.btnNuevo.Location = new System.Drawing.Point(526, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnNuevo.Size = new System.Drawing.Size(56, 20);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnFinalizar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnFinalizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnFinalizar.CornerRadius = 3;
            this.btnFinalizar.Location = new System.Drawing.Point(590, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnFinalizar.Size = new System.Drawing.Size(84, 20);
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            this.btnFinalizar.MouseEnter += new System.EventHandler(this.btnFinalizar_MouseEnter);
            this.btnFinalizar.MouseLeave += new System.EventHandler(this.btnFinalizar_MouseLeave);
            // 
            // panelIngresoDatos
            // 
            this.panelIngresoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelIngresoDatos.Controls.Add(this.btnLimpiarL);
            this.panelIngresoDatos.Controls.Add(this.btnAgregarL);
            this.panelIngresoDatos.Controls.Add(this.rec_fechaE);
            this.panelIngresoDatos.Controls.Add(this.lbFechaE_rec);
            this.panelIngresoDatos.Controls.Add(this.rec_direccionD);
            this.panelIngresoDatos.Controls.Add(this.lbDireccionD_rec);
            this.panelIngresoDatos.Controls.Add(this.rec_direccionR);
            this.panelIngresoDatos.Controls.Add(this.lbDireccionR_rec);
            this.panelIngresoDatos.Controls.Add(this.rec_destinatario);
            this.panelIngresoDatos.Controls.Add(this.lbDestinatario_rec);
            this.panelIngresoDatos.Controls.Add(this.rec_remitente);
            this.panelIngresoDatos.Controls.Add(this.rec_peso);
            this.panelIngresoDatos.Controls.Add(this.lbRemitente_rec);
            this.panelIngresoDatos.Controls.Add(this.lbPeso_rec);
            this.panelIngresoDatos.Controls.Add(this.rec_id);
            this.panelIngresoDatos.Controls.Add(this.lbId_rec);
            this.panelIngresoDatos.Controls.Add(this.shapeContainer3);
            this.panelIngresoDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIngresoDatos.Location = new System.Drawing.Point(0, 0);
            this.panelIngresoDatos.Name = "panelIngresoDatos";
            this.panelIngresoDatos.Size = new System.Drawing.Size(136, 451);
            this.panelIngresoDatos.TabIndex = 2;
            // 
            // btnLimpiarL
            // 
            this.btnLimpiarL.AutoSize = true;
            this.btnLimpiarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnLimpiarL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarL.Location = new System.Drawing.Point(40, 367);
            this.btnLimpiarL.Name = "btnLimpiarL";
            this.btnLimpiarL.Size = new System.Drawing.Size(56, 14);
            this.btnLimpiarL.TabIndex = 20;
            this.btnLimpiarL.Text = "Limpiar";
            this.btnLimpiarL.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiarL.MouseEnter += new System.EventHandler(this.btnLimpiar_MouseEnter);
            this.btnLimpiarL.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.AutoSize = true;
            this.btnAgregarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAgregarL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarL.Location = new System.Drawing.Point(39, 337);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(56, 14);
            this.btnAgregarL.TabIndex = 19;
            this.btnAgregarL.Text = "Agregar";
            this.btnAgregarL.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregarL.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregarL.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // rec_fechaE
            // 
            this.rec_fechaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_fechaE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_fechaE.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_fechaE.Location = new System.Drawing.Point(12, 297);
            this.rec_fechaE.Mask = "00/00/0000";
            this.rec_fechaE.Name = "rec_fechaE";
            this.rec_fechaE.Size = new System.Drawing.Size(110, 13);
            this.rec_fechaE.TabIndex = 18;
            this.rec_fechaE.ValidatingType = typeof(System.DateTime);
            // 
            // lbFechaE_rec
            // 
            this.lbFechaE_rec.AutoSize = true;
            this.lbFechaE_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaE_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbFechaE_rec.Location = new System.Drawing.Point(4, 276);
            this.lbFechaE_rec.Name = "lbFechaE_rec";
            this.lbFechaE_rec.Size = new System.Drawing.Size(112, 14);
            this.lbFechaE_rec.TabIndex = 16;
            this.lbFechaE_rec.Text = "Fecha de envío:";
            // 
            // rec_direccionD
            // 
            this.rec_direccionD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_direccionD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_direccionD.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_direccionD.Location = new System.Drawing.Point(12, 249);
            this.rec_direccionD.Name = "rec_direccionD";
            this.rec_direccionD.Size = new System.Drawing.Size(110, 13);
            this.rec_direccionD.TabIndex = 15;
            // 
            // lbDireccionD_rec
            // 
            this.lbDireccionD_rec.AutoSize = true;
            this.lbDireccionD_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccionD_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbDireccionD_rec.Location = new System.Drawing.Point(4, 228);
            this.lbDireccionD_rec.Name = "lbDireccionD_rec";
            this.lbDireccionD_rec.Size = new System.Drawing.Size(98, 14);
            this.lbDireccionD_rec.TabIndex = 14;
            this.lbDireccionD_rec.Text = "Direccion D.:";
            // 
            // rec_direccionR
            // 
            this.rec_direccionR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_direccionR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_direccionR.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_direccionR.Location = new System.Drawing.Point(12, 205);
            this.rec_direccionR.Name = "rec_direccionR";
            this.rec_direccionR.Size = new System.Drawing.Size(110, 13);
            this.rec_direccionR.TabIndex = 13;
            // 
            // lbDireccionR_rec
            // 
            this.lbDireccionR_rec.AutoSize = true;
            this.lbDireccionR_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccionR_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbDireccionR_rec.Location = new System.Drawing.Point(4, 184);
            this.lbDireccionR_rec.Name = "lbDireccionR_rec";
            this.lbDireccionR_rec.Size = new System.Drawing.Size(98, 14);
            this.lbDireccionR_rec.TabIndex = 12;
            this.lbDireccionR_rec.Text = "Dirección R.:";
            // 
            // rec_destinatario
            // 
            this.rec_destinatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_destinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_destinatario.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_destinatario.Location = new System.Drawing.Point(12, 161);
            this.rec_destinatario.Name = "rec_destinatario";
            this.rec_destinatario.Size = new System.Drawing.Size(110, 13);
            this.rec_destinatario.TabIndex = 11;
            // 
            // lbDestinatario_rec
            // 
            this.lbDestinatario_rec.AutoSize = true;
            this.lbDestinatario_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatario_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbDestinatario_rec.Location = new System.Drawing.Point(4, 140);
            this.lbDestinatario_rec.Name = "lbDestinatario_rec";
            this.lbDestinatario_rec.Size = new System.Drawing.Size(98, 14);
            this.lbDestinatario_rec.TabIndex = 10;
            this.lbDestinatario_rec.Text = "Destinatario:";
            // 
            // rec_remitente
            // 
            this.rec_remitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_remitente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_remitente.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_remitente.Location = new System.Drawing.Point(12, 117);
            this.rec_remitente.Name = "rec_remitente";
            this.rec_remitente.Size = new System.Drawing.Size(110, 13);
            this.rec_remitente.TabIndex = 9;
            // 
            // rec_peso
            // 
            this.rec_peso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_peso.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_peso.Location = new System.Drawing.Point(12, 73);
            this.rec_peso.Name = "rec_peso";
            this.rec_peso.Size = new System.Drawing.Size(110, 13);
            this.rec_peso.TabIndex = 8;
            // 
            // lbRemitente_rec
            // 
            this.lbRemitente_rec.AutoSize = true;
            this.lbRemitente_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemitente_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbRemitente_rec.Location = new System.Drawing.Point(4, 96);
            this.lbRemitente_rec.Name = "lbRemitente_rec";
            this.lbRemitente_rec.Size = new System.Drawing.Size(77, 14);
            this.lbRemitente_rec.TabIndex = 6;
            this.lbRemitente_rec.Text = "Remitente:";
            // 
            // lbPeso_rec
            // 
            this.lbPeso_rec.AutoSize = true;
            this.lbPeso_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbPeso_rec.Location = new System.Drawing.Point(4, 52);
            this.lbPeso_rec.Name = "lbPeso_rec";
            this.lbPeso_rec.Size = new System.Drawing.Size(126, 14);
            this.lbPeso_rec.TabIndex = 4;
            this.lbPeso_rec.Text = "Peso del paquete:";
            // 
            // rec_id
            // 
            this.rec_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rec_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_id.Font = new System.Drawing.Font("Consolas", 8F);
            this.rec_id.Location = new System.Drawing.Point(12, 28);
            this.rec_id.Name = "rec_id";
            this.rec_id.ReadOnly = true;
            this.rec_id.Size = new System.Drawing.Size(110, 13);
            this.rec_id.TabIndex = 2;
            // 
            // lbId_rec
            // 
            this.lbId_rec.AutoSize = true;
            this.lbId_rec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId_rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbId_rec.Location = new System.Drawing.Point(4, 8);
            this.lbId_rec.Name = "lbId_rec";
            this.lbId_rec.Size = new System.Drawing.Size(91, 14);
            this.lbId_rec.TabIndex = 0;
            this.lbId_rec.Text = "ID de envío:";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnLimpiar,
            this.btnAgregar,
            this.bkFechaE_rec,
            this.bkDireccionR_rec,
            this.bkDestinatario_rec,
            this.bkRemitente_rec,
            this.bkPeso_rec,
            this.bkDireccionD_rec,
            this.bkId_rec});
            this.shapeContainer3.Size = new System.Drawing.Size(136, 451);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnLimpiar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnLimpiar.CornerRadius = 3;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 363);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnLimpiar.Size = new System.Drawing.Size(76, 20);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseEnter += new System.EventHandler(this.btnLimpiar_MouseEnter);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAgregar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAgregar.CornerRadius = 3;
            this.btnAgregar.Location = new System.Drawing.Point(28, 334);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnAgregar.Size = new System.Drawing.Size(76, 20);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // bkFechaE_rec
            // 
            this.bkFechaE_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkFechaE_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkFechaE_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkFechaE_rec.CornerRadius = 3;
            this.bkFechaE_rec.Location = new System.Drawing.Point(4, 295);
            this.bkFechaE_rec.Name = "bkFechaE_rec";
            this.bkFechaE_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkFechaE_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkDireccionR_rec
            // 
            this.bkDireccionR_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDireccionR_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkDireccionR_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDireccionR_rec.CornerRadius = 3;
            this.bkDireccionR_rec.Location = new System.Drawing.Point(4, 203);
            this.bkDireccionR_rec.Name = "bkDireccionR_rec";
            this.bkDireccionR_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkDireccionR_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkDestinatario_rec
            // 
            this.bkDestinatario_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDestinatario_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkDestinatario_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDestinatario_rec.CornerRadius = 3;
            this.bkDestinatario_rec.Location = new System.Drawing.Point(4, 159);
            this.bkDestinatario_rec.Name = "bkDestinatario_rec";
            this.bkDestinatario_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkDestinatario_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkRemitente_rec
            // 
            this.bkRemitente_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkRemitente_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkRemitente_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkRemitente_rec.CornerRadius = 3;
            this.bkRemitente_rec.Location = new System.Drawing.Point(4, 115);
            this.bkRemitente_rec.Name = "bkRemitente_rec";
            this.bkRemitente_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkRemitente_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkPeso_rec
            // 
            this.bkPeso_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkPeso_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkPeso_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkPeso_rec.CornerRadius = 3;
            this.bkPeso_rec.Location = new System.Drawing.Point(4, 71);
            this.bkPeso_rec.Name = "bkPeso_rec";
            this.bkPeso_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkPeso_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkDireccionD_rec
            // 
            this.bkDireccionD_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDireccionD_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkDireccionD_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkDireccionD_rec.CornerRadius = 3;
            this.bkDireccionD_rec.Location = new System.Drawing.Point(4, 247);
            this.bkDireccionD_rec.Name = "bkDireccionD_rec";
            this.bkDireccionD_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkDireccionD_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // bkId_rec
            // 
            this.bkId_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkId_rec.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkId_rec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkId_rec.CornerRadius = 3;
            this.bkId_rec.Location = new System.Drawing.Point(4, 27);
            this.bkId_rec.Name = "bkId_rec";
            this.bkId_rec.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkId_rec.Size = new System.Drawing.Size(125, 15);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.Controls.Add(this.ContenidoForma);
            this.Controls.Add(this.FullTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.FullTopBar.ResumeLayout(false);
            this.FullTopBar.PerformLayout();
            this.ContenidoForma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recepcion)).EndInit();
            this.DownDgv.ResumeLayout(false);
            this.DownDgv.PerformLayout();
            this.panelIngresoDatos.ResumeLayout(false);
            this.panelIngresoDatos.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label MinimizeButton;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TopBar;
        private System.Windows.Forms.Panel FullTopBar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label TituloForma;
        private System.Windows.Forms.Panel ContenidoForma;
        private System.Windows.Forms.Panel panelIngresoDatos;
        private System.Windows.Forms.Label lbId_rec;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.TextBox rec_id;
        private System.Windows.Forms.Label lbPeso_rec;
        private System.Windows.Forms.Label lbRemitente_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkId_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDireccionD_rec;
        private System.Windows.Forms.TextBox rec_peso;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkPeso_rec;
        private System.Windows.Forms.TextBox rec_destinatario;
        private System.Windows.Forms.Label lbDestinatario_rec;
        private System.Windows.Forms.TextBox rec_remitente;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDestinatario_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkRemitente_rec;
        private System.Windows.Forms.Label lbDireccionR_rec;
        private System.Windows.Forms.MaskedTextBox rec_fechaE;
        private System.Windows.Forms.Label lbFechaE_rec;
        private System.Windows.Forms.TextBox rec_direccionD;
        private System.Windows.Forms.Label lbDireccionD_rec;
        private System.Windows.Forms.TextBox rec_direccionR;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkFechaE_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDireccionR_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnAgregar;
        private System.Windows.Forms.Label btnAgregarL;
        private System.Windows.Forms.DataGridView dgv_recepcion;
        private System.Windows.Forms.Panel DownDgv;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private System.Windows.Forms.Label btnFinalizarL;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnFinalizar;
        private System.Windows.Forms.ProgressBar pb_rec;
        private System.Windows.Forms.Label btnLimpiarL;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLimpiar;
        private System.Windows.Forms.Label btnNuevoL;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEnvio_Rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPeso_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemitente_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestinatario_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionR_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionD_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaE_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstante_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNivel_rec;
    }
    }

