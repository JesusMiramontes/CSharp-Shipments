namespace ProyectoFinalv2
    {
    partial class Envios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TituloForma = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TopBar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelDepartir_env = new System.Windows.Forms.Panel();
            this.btnEnviarACamionL_env = new System.Windows.Forms.Label();
            this.cbEnviarCamion_env = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnEnviarACamion_env = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bk_RutaEnviarCamon_env = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.PanelAsignarRuta = new System.Windows.Forms.Panel();
            this.btn_AsignarL_env = new System.Windows.Forms.Label();
            this.LbAsignarRuta_env = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnAsignar_env = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.PanelRutas = new System.Windows.Forms.Panel();
            this.cbRuta_env = new System.Windows.Forms.ComboBox();
            this.lbRuta_env = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bkRuta_env = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.pb_env = new System.Windows.Forms.ProgressBar();
            this.dgv_envios = new System.Windows.Forms.DataGridView();
            this.dgvIdEnvio_Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Check_Envios = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_RutaAsignada_Envios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPeso_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestinatario_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionD_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaE_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstante_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNivel_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.PanelDepartir_env.SuspendLayout();
            this.PanelAsignarRuta.SuspendLayout();
            this.PanelRutas.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_envios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.TituloForma);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 22);
            this.panel1.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(782, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 22);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(800, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TituloForma
            // 
            this.TituloForma.AutoSize = true;
            this.TituloForma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.TituloForma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloForma.ForeColor = System.Drawing.Color.White;
            this.TituloForma.Location = new System.Drawing.Point(2, 3);
            this.TituloForma.Name = "TituloForma";
            this.TituloForma.Size = new System.Drawing.Size(133, 14);
            this.TituloForma.TabIndex = 3;
            this.TituloForma.Text = "Envios de paquetes";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TopBar});
            this.shapeContainer1.Size = new System.Drawing.Size(820, 22);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.TopBar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.TopBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Location = new System.Drawing.Point(0, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Size = new System.Drawing.Size(820, 23);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelLeft.Controls.Add(this.PanelDepartir_env);
            this.PanelLeft.Controls.Add(this.PanelAsignarRuta);
            this.PanelLeft.Controls.Add(this.PanelRutas);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Font = new System.Drawing.Font("Consolas", 8F);
            this.PanelLeft.Location = new System.Drawing.Point(0, 22);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(136, 451);
            this.PanelLeft.TabIndex = 1;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint);
            // 
            // PanelDepartir_env
            // 
            this.PanelDepartir_env.Controls.Add(this.btnEnviarACamionL_env);
            this.PanelDepartir_env.Controls.Add(this.cbEnviarCamion_env);
            this.PanelDepartir_env.Controls.Add(this.label1);
            this.PanelDepartir_env.Controls.Add(this.shapeContainer4);
            this.PanelDepartir_env.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDepartir_env.Location = new System.Drawing.Point(0, 133);
            this.PanelDepartir_env.Name = "PanelDepartir_env";
            this.PanelDepartir_env.Size = new System.Drawing.Size(136, 100);
            this.PanelDepartir_env.TabIndex = 3;
            // 
            // btnEnviarACamionL_env
            // 
            this.btnEnviarACamionL_env.AutoSize = true;
            this.btnEnviarACamionL_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnviarACamionL_env.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarACamionL_env.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviarACamionL_env.Location = new System.Drawing.Point(44, 66);
            this.btnEnviarACamionL_env.Name = "btnEnviarACamionL_env";
            this.btnEnviarACamionL_env.Size = new System.Drawing.Size(49, 14);
            this.btnEnviarACamionL_env.TabIndex = 26;
            this.btnEnviarACamionL_env.Text = "Enviar";
            // 
            // cbEnviarCamion_env
            // 
            this.cbEnviarCamion_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.cbEnviarCamion_env.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEnviarCamion_env.FormattingEnabled = true;
            this.cbEnviarCamion_env.IntegralHeight = false;
            this.cbEnviarCamion_env.Items.AddRange(new object[] {
            "Centro",
            "Este",
            "Norte",
            "Oeste",
            "Sur"});
            this.cbEnviarCamion_env.Location = new System.Drawing.Point(5, 28);
            this.cbEnviarCamion_env.Name = "cbEnviarCamion_env";
            this.cbEnviarCamion_env.Size = new System.Drawing.Size(124, 21);
            this.cbEnviarCamion_env.TabIndex = 24;
            this.cbEnviarCamion_env.Text = "Norte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enviar a camión:";
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnEnviarACamion_env,
            this.bk_RutaEnviarCamon_env});
            this.shapeContainer4.Size = new System.Drawing.Size(136, 100);
            this.shapeContainer4.TabIndex = 25;
            this.shapeContainer4.TabStop = false;
            // 
            // btnEnviarACamion_env
            // 
            this.btnEnviarACamion_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnviarACamion_env.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnEnviarACamion_env.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEnviarACamion_env.CornerRadius = 3;
            this.btnEnviarACamion_env.Location = new System.Drawing.Point(30, 62);
            this.btnEnviarACamion_env.Name = "btnEnviarACamion_env";
            this.btnEnviarACamion_env.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnEnviarACamion_env.Size = new System.Drawing.Size(76, 20);
            this.btnEnviarACamion_env.Click += new System.EventHandler(this.btnEnviarACamion_env_Click);
            // 
            // bk_RutaEnviarCamon_env
            // 
            this.bk_RutaEnviarCamon_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bk_RutaEnviarCamon_env.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bk_RutaEnviarCamon_env.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bk_RutaEnviarCamon_env.CornerRadius = 3;
            this.bk_RutaEnviarCamon_env.Location = new System.Drawing.Point(4, 27);
            this.bk_RutaEnviarCamon_env.Name = "bk_RutaEnviarCamon_env";
            this.bk_RutaEnviarCamon_env.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bk_RutaEnviarCamon_env.Size = new System.Drawing.Size(125, 22);
            // 
            // PanelAsignarRuta
            // 
            this.PanelAsignarRuta.Controls.Add(this.btn_AsignarL_env);
            this.PanelAsignarRuta.Controls.Add(this.LbAsignarRuta_env);
            this.PanelAsignarRuta.Controls.Add(this.shapeContainer3);
            this.PanelAsignarRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAsignarRuta.Location = new System.Drawing.Point(0, 67);
            this.PanelAsignarRuta.Name = "PanelAsignarRuta";
            this.PanelAsignarRuta.Size = new System.Drawing.Size(136, 66);
            this.PanelAsignarRuta.TabIndex = 2;
            // 
            // btn_AsignarL_env
            // 
            this.btn_AsignarL_env.AutoSize = true;
            this.btn_AsignarL_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btn_AsignarL_env.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AsignarL_env.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AsignarL_env.Location = new System.Drawing.Point(44, 36);
            this.btn_AsignarL_env.Name = "btn_AsignarL_env";
            this.btn_AsignarL_env.Size = new System.Drawing.Size(49, 14);
            this.btn_AsignarL_env.TabIndex = 21;
            this.btn_AsignarL_env.Text = "Elegir";
            this.btn_AsignarL_env.Click += new System.EventHandler(this.btn_AsignarL_env_Click);
            // 
            // LbAsignarRuta_env
            // 
            this.LbAsignarRuta_env.AutoSize = true;
            this.LbAsignarRuta_env.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAsignarRuta_env.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.LbAsignarRuta_env.Location = new System.Drawing.Point(4, 8);
            this.LbAsignarRuta_env.Name = "LbAsignarRuta_env";
            this.LbAsignarRuta_env.Size = new System.Drawing.Size(98, 14);
            this.LbAsignarRuta_env.TabIndex = 21;
            this.LbAsignarRuta_env.Text = "Asignar ruta:";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnAsignar_env});
            this.shapeContainer3.Size = new System.Drawing.Size(136, 66);
            this.shapeContainer3.TabIndex = 22;
            this.shapeContainer3.TabStop = false;
            // 
            // btnAsignar_env
            // 
            this.btnAsignar_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAsignar_env.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnAsignar_env.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAsignar_env.CornerRadius = 3;
            this.btnAsignar_env.Location = new System.Drawing.Point(30, 32);
            this.btnAsignar_env.Name = "btnAsignar_env";
            this.btnAsignar_env.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnAsignar_env.Size = new System.Drawing.Size(76, 20);
            this.btnAsignar_env.Click += new System.EventHandler(this.btnAsignar_env_Click);
            this.btnAsignar_env.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAsignar_env.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // PanelRutas
            // 
            this.PanelRutas.Controls.Add(this.cbRuta_env);
            this.PanelRutas.Controls.Add(this.lbRuta_env);
            this.PanelRutas.Controls.Add(this.shapeContainer2);
            this.PanelRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRutas.Location = new System.Drawing.Point(0, 0);
            this.PanelRutas.Name = "PanelRutas";
            this.PanelRutas.Size = new System.Drawing.Size(136, 67);
            this.PanelRutas.TabIndex = 0;
            // 
            // cbRuta_env
            // 
            this.cbRuta_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.cbRuta_env.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRuta_env.FormattingEnabled = true;
            this.cbRuta_env.IntegralHeight = false;
            this.cbRuta_env.Items.AddRange(new object[] {
            "Centro",
            "Este",
            "Norte",
            "Oeste",
            "Sur"});
            this.cbRuta_env.Location = new System.Drawing.Point(5, 28);
            this.cbRuta_env.Name = "cbRuta_env";
            this.cbRuta_env.Size = new System.Drawing.Size(124, 21);
            this.cbRuta_env.TabIndex = 12;
            this.cbRuta_env.Text = "Norte";
            // 
            // lbRuta_env
            // 
            this.lbRuta_env.AutoSize = true;
            this.lbRuta_env.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta_env.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbRuta_env.Location = new System.Drawing.Point(4, 8);
            this.lbRuta_env.Name = "lbRuta_env";
            this.lbRuta_env.Size = new System.Drawing.Size(42, 14);
            this.lbRuta_env.TabIndex = 11;
            this.lbRuta_env.Text = "Ruta:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.bkRuta_env});
            this.shapeContainer2.Size = new System.Drawing.Size(136, 67);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // bkRuta_env
            // 
            this.bkRuta_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkRuta_env.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bkRuta_env.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bkRuta_env.CornerRadius = 3;
            this.bkRuta_env.Location = new System.Drawing.Point(4, 27);
            this.bkRuta_env.Name = "bkRuta_env";
            this.bkRuta_env.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bkRuta_env.Size = new System.Drawing.Size(125, 22);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.PanelBottom.Controls.Add(this.pb_env);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(136, 441);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(684, 32);
            this.PanelBottom.TabIndex = 2;
            // 
            // pb_env
            // 
            this.pb_env.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.pb_env.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_env.ForeColor = System.Drawing.Color.Maroon;
            this.pb_env.Location = new System.Drawing.Point(0, 30);
            this.pb_env.Name = "pb_env";
            this.pb_env.Size = new System.Drawing.Size(684, 2);
            this.pb_env.Step = 1;
            this.pb_env.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_env.TabIndex = 11;
            // 
            // dgv_envios
            // 
            this.dgv_envios.AllowUserToAddRows = false;
            this.dgv_envios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_envios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_envios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_envios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_envios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_envios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_envios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdEnvio_Rec,
            this.dgv_Check_Envios,
            this.dgv_RutaAsignada_Envios,
            this.dgvPeso_rec,
            this.dgvDestinatario_rec,
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
            this.dgv_envios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_envios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_envios.EnableHeadersVisualStyles = false;
            this.dgv_envios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_envios.Location = new System.Drawing.Point(136, 22);
            this.dgv_envios.Name = "dgv_envios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_envios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_envios.RowHeadersVisible = false;
            this.dgv_envios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_envios.Size = new System.Drawing.Size(684, 419);
            this.dgv_envios.TabIndex = 10;
            // 
            // dgvIdEnvio_Rec
            // 
            this.dgvIdEnvio_Rec.HeaderText = "ID";
            this.dgvIdEnvio_Rec.Name = "dgvIdEnvio_Rec";
            this.dgvIdEnvio_Rec.ReadOnly = true;
            this.dgvIdEnvio_Rec.Width = 32;
            // 
            // dgv_Check_Envios
            // 
            this.dgv_Check_Envios.HeaderText = "Asignar";
            this.dgv_Check_Envios.Name = "dgv_Check_Envios";
            this.dgv_Check_Envios.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Check_Envios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_Check_Envios.Width = 50;
            // 
            // dgv_RutaAsignada_Envios
            // 
            this.dgv_RutaAsignada_Envios.HeaderText = "Ruta asignada";
            this.dgv_RutaAsignada_Envios.Name = "dgv_RutaAsignada_Envios";
            this.dgv_RutaAsignada_Envios.ReadOnly = true;
            this.dgv_RutaAsignada_Envios.Width = 150;
            // 
            // dgvPeso_rec
            // 
            this.dgvPeso_rec.HeaderText = "Peso";
            this.dgvPeso_rec.Name = "dgvPeso_rec";
            this.dgvPeso_rec.ReadOnly = true;
            this.dgvPeso_rec.Width = 45;
            // 
            // dgvDestinatario_rec
            // 
            this.dgvDestinatario_rec.HeaderText = "Destinatario";
            this.dgvDestinatario_rec.Name = "dgvDestinatario_rec";
            this.dgvDestinatario_rec.ReadOnly = true;
            // 
            // dgvDireccionD_rec
            // 
            this.dgvDireccionD_rec.HeaderText = "Dirección D.";
            this.dgvDireccionD_rec.Name = "dgvDireccionD_rec";
            this.dgvDireccionD_rec.ReadOnly = true;
            this.dgvDireccionD_rec.Width = 165;
            // 
            // dgvFechaE_rec
            // 
            this.dgvFechaE_rec.HeaderText = "Fecha envio";
            this.dgvFechaE_rec.Name = "dgvFechaE_rec";
            this.dgvFechaE_rec.ReadOnly = true;
            this.dgvFechaE_rec.Width = 85;
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
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.Controls.Add(this.dgv_envios);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Envios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envios";
            this.Load += new System.EventHandler(this.Envios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.PanelDepartir_env.ResumeLayout(false);
            this.PanelDepartir_env.PerformLayout();
            this.PanelAsignarRuta.ResumeLayout(false);
            this.PanelAsignarRuta.PerformLayout();
            this.PanelRutas.ResumeLayout(false);
            this.PanelRutas.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_envios)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TopBar;
        private System.Windows.Forms.Label TituloForma;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.DataGridView dgv_envios;
        private System.Windows.Forms.Panel PanelRutas;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bkRuta_env;
        private System.Windows.Forms.Label lbRuta_env;
        private System.Windows.Forms.ComboBox cbRuta_env;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdEnvio_Rec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Check_Envios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RutaAsignada_Envios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPeso_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestinatario_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionD_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaE_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstante_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNivel_rec;
        private System.Windows.Forms.Panel PanelAsignarRuta;
        private System.Windows.Forms.Label btn_AsignarL_env;
        private System.Windows.Forms.Label LbAsignarRuta_env;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnAsignar_env;
        private System.Windows.Forms.Panel PanelDepartir_env;
        private System.Windows.Forms.Label btnEnviarACamionL_env;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnEnviarACamion_env;
        private System.Windows.Forms.ProgressBar pb_env;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbEnviarCamion_env;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bk_RutaEnviarCamon_env;
        }
    }