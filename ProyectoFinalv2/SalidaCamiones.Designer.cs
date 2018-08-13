namespace ProyectoFinalv2
    {
    partial class SalidaCamiones
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
            if ( disposing && ( components != null ) )
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FullTopBar = new System.Windows.Forms.Panel();
            this.TituloForma = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TopBar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panelIngresoDatos = new System.Windows.Forms.Panel();
            this.btnEnvialL_cola = new System.Windows.Forms.Label();
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
            this.btnEnviar_cola = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkFechaE_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDireccionR_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDestinatario_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkRemitente_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkPeso_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkDireccionD_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bkId_rec = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DownDgv = new System.Windows.Forms.Panel();
            this.btnNuevoL = new System.Windows.Forms.Label();
            this.pb_cola = new System.Windows.Forms.ProgressBar();
            this.btnRecargarL = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnNuevo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnRecargar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dgv_cola = new System.Windows.Forms.DataGridView();
            this.dgvEnviarACamion_cola = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvRuta_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdEnvio_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPeso_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionD_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullTopBar.SuspendLayout();
            this.panelIngresoDatos.SuspendLayout();
            this.DownDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola)).BeginInit();
            this.SuspendLayout();
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
            this.FullTopBar.Size = new System.Drawing.Size(820, 23);
            this.FullTopBar.TabIndex = 4;
            // 
            // TituloForma
            // 
            this.TituloForma.AutoSize = true;
            this.TituloForma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.TituloForma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloForma.ForeColor = System.Drawing.Color.White;
            this.TituloForma.Location = new System.Drawing.Point(2, 3);
            this.TituloForma.Name = "TituloForma";
            this.TituloForma.Size = new System.Drawing.Size(98, 14);
            this.TituloForma.TabIndex = 2;
            this.TituloForma.Text = "Cola camiones";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
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
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
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
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TopBar});
            this.shapeContainer2.Size = new System.Drawing.Size(820, 23);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.TopBar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.TopBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Location = new System.Drawing.Point(-4, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Size = new System.Drawing.Size(825, 23);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // panelIngresoDatos
            // 
            this.panelIngresoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelIngresoDatos.Controls.Add(this.btnEnvialL_cola);
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
            this.panelIngresoDatos.Location = new System.Drawing.Point(0, 23);
            this.panelIngresoDatos.Name = "panelIngresoDatos";
            this.panelIngresoDatos.Size = new System.Drawing.Size(136, 450);
            this.panelIngresoDatos.TabIndex = 5;
            // 
            // btnEnvialL_cola
            // 
            this.btnEnvialL_cola.AutoSize = true;
            this.btnEnvialL_cola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnvialL_cola.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvialL_cola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnvialL_cola.Location = new System.Drawing.Point(42, 338);
            this.btnEnvialL_cola.Name = "btnEnvialL_cola";
            this.btnEnvialL_cola.Size = new System.Drawing.Size(49, 14);
            this.btnEnvialL_cola.TabIndex = 19;
            this.btnEnvialL_cola.Text = "Enviar";
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
            this.btnEnviar_cola,
            this.bkFechaE_rec,
            this.bkDireccionR_rec,
            this.bkDestinatario_rec,
            this.bkRemitente_rec,
            this.bkPeso_rec,
            this.bkDireccionD_rec,
            this.bkId_rec});
            this.shapeContainer3.Size = new System.Drawing.Size(136, 450);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // btnEnviar_cola
            // 
            this.btnEnviar_cola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnviar_cola.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnEnviar_cola.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnviar_cola.CornerRadius = 3;
            this.btnEnviar_cola.Location = new System.Drawing.Point(28, 334);
            this.btnEnviar_cola.Name = "btnEnviar_cola";
            this.btnEnviar_cola.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnEnviar_cola.Size = new System.Drawing.Size(76, 20);
            this.btnEnviar_cola.Click += new System.EventHandler(this.btnEnviar_cola_Click);
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
            // DownDgv
            // 
            this.DownDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.DownDgv.Controls.Add(this.btnNuevoL);
            this.DownDgv.Controls.Add(this.pb_cola);
            this.DownDgv.Controls.Add(this.btnRecargarL);
            this.DownDgv.Controls.Add(this.shapeContainer4);
            this.DownDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownDgv.Location = new System.Drawing.Point(136, 441);
            this.DownDgv.Name = "DownDgv";
            this.DownDgv.Size = new System.Drawing.Size(684, 32);
            this.DownDgv.TabIndex = 10;
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
            // 
            // pb_cola
            // 
            this.pb_cola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.pb_cola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_cola.ForeColor = System.Drawing.Color.Maroon;
            this.pb_cola.Location = new System.Drawing.Point(0, 30);
            this.pb_cola.Name = "pb_cola";
            this.pb_cola.Size = new System.Drawing.Size(684, 2);
            this.pb_cola.Step = 1;
            this.pb_cola.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_cola.TabIndex = 10;
            // 
            // btnRecargarL
            // 
            this.btnRecargarL.AutoSize = true;
            this.btnRecargarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRecargarL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecargarL.Location = new System.Drawing.Point(602, 10);
            this.btnRecargarL.Name = "btnRecargarL";
            this.btnRecargarL.Size = new System.Drawing.Size(63, 14);
            this.btnRecargarL.TabIndex = 20;
            this.btnRecargarL.Text = "Recargar";
            this.btnRecargarL.Click += new System.EventHandler(this.btnRecargarClick);
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnNuevo,
            this.btnRecargar});
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
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRecargar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnRecargar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRecargar.CornerRadius = 3;
            this.btnRecargar.Location = new System.Drawing.Point(590, 6);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnRecargar.Size = new System.Drawing.Size(84, 20);
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargarClick);
            // 
            // dgv_cola
            // 
            this.dgv_cola.AllowUserToAddRows = false;
            this.dgv_cola.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_cola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cola.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_cola.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEnviarACamion_cola,
            this.dgvRuta_cola,
            this.dgvIdEnvio_cola,
            this.dgvPeso_cola,
            this.dgvDireccionD_cola});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cola.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_cola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cola.EnableHeadersVisualStyles = false;
            this.dgv_cola.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_cola.Location = new System.Drawing.Point(136, 23);
            this.dgv_cola.Name = "dgv_cola";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cola.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_cola.RowHeadersVisible = false;
            this.dgv_cola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_cola.Size = new System.Drawing.Size(684, 418);
            this.dgv_cola.TabIndex = 12;
            this.dgv_cola.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cola_CellContentClick);
            this.dgv_cola.SelectionChanged += new System.EventHandler(this.dgv_cola_SelectionChanged);
            // 
            // dgvEnviarACamion_cola
            // 
            this.dgvEnviarACamion_cola.HeaderText = "Enviar";
            this.dgvEnviarACamion_cola.Name = "dgvEnviarACamion_cola";
            // 
            // dgvRuta_cola
            // 
            this.dgvRuta_cola.HeaderText = "Ruta asignada";
            this.dgvRuta_cola.Name = "dgvRuta_cola";
            this.dgvRuta_cola.ReadOnly = true;
            this.dgvRuta_cola.Width = 140;
            // 
            // dgvIdEnvio_cola
            // 
            this.dgvIdEnvio_cola.HeaderText = "ID";
            this.dgvIdEnvio_cola.Name = "dgvIdEnvio_cola";
            this.dgvIdEnvio_cola.ReadOnly = true;
            this.dgvIdEnvio_cola.Width = 50;
            // 
            // dgvPeso_cola
            // 
            this.dgvPeso_cola.HeaderText = "Peso";
            this.dgvPeso_cola.Name = "dgvPeso_cola";
            this.dgvPeso_cola.ReadOnly = true;
            this.dgvPeso_cola.Width = 50;
            // 
            // dgvDireccionD_cola
            // 
            this.dgvDireccionD_cola.HeaderText = "Dirección D.";
            this.dgvDireccionD_cola.Name = "dgvDireccionD_cola";
            this.dgvDireccionD_cola.ReadOnly = true;
            this.dgvDireccionD_cola.Width = 400;
            // 
            // SalidaCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.Controls.Add(this.dgv_cola);
            this.Controls.Add(this.DownDgv);
            this.Controls.Add(this.panelIngresoDatos);
            this.Controls.Add(this.FullTopBar);
            this.Font = new System.Drawing.Font("Consolas", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalidaCamiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalidaCamiones";
            this.FullTopBar.ResumeLayout(false);
            this.FullTopBar.PerformLayout();
            this.panelIngresoDatos.ResumeLayout(false);
            this.panelIngresoDatos.PerformLayout();
            this.DownDgv.ResumeLayout(false);
            this.DownDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel FullTopBar;
        private System.Windows.Forms.Label TituloForma;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TopBar;
        private System.Windows.Forms.Panel panelIngresoDatos;
        private System.Windows.Forms.Label btnEnvialL_cola;
        private System.Windows.Forms.MaskedTextBox rec_fechaE;
        private System.Windows.Forms.Label lbFechaE_rec;
        private System.Windows.Forms.TextBox rec_direccionD;
        private System.Windows.Forms.Label lbDireccionD_rec;
        private System.Windows.Forms.TextBox rec_direccionR;
        private System.Windows.Forms.Label lbDireccionR_rec;
        private System.Windows.Forms.TextBox rec_destinatario;
        private System.Windows.Forms.Label lbDestinatario_rec;
        private System.Windows.Forms.TextBox rec_remitente;
        private System.Windows.Forms.TextBox rec_peso;
        private System.Windows.Forms.Label lbRemitente_rec;
        private System.Windows.Forms.Label lbPeso_rec;
        private System.Windows.Forms.TextBox rec_id;
        private System.Windows.Forms.Label lbId_rec;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnEnviar_cola;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkFechaE_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDireccionR_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDestinatario_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkRemitente_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkPeso_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkDireccionD_rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkId_rec;
        private System.Windows.Forms.Panel DownDgv;
        private System.Windows.Forms.Label btnNuevoL;
        private System.Windows.Forms.ProgressBar pb_cola;
        private System.Windows.Forms.Label btnRecargarL;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnNuevo;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnRecargar;
        private System.Windows.Forms.DataGridView dgv_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionD_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPeso_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEnvio_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRuta_cola;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvEnviarACamion_cola;
    }
    }