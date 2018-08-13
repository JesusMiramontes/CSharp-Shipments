namespace ProyectoFinalv2
    {
    partial class Master
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
            this.FullTopBar = new System.Windows.Forms.Panel();
            this.TituloForma = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TopBar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnRecepcionL = new System.Windows.Forms.Label();
            this.btnRecepcion = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnHistorial = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnCamiones = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnEnvios = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnGuardar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnGuardarL = new System.Windows.Forms.Label();
            this.btnEnviosL = new System.Windows.Forms.Label();
            this.btnCamionesL = new System.Windows.Forms.Label();
            this.btnHistorialL = new System.Windows.Forms.Label();
            this.FullTopBar.SuspendLayout();
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
            this.FullTopBar.Size = new System.Drawing.Size(663, 22);
            this.FullTopBar.TabIndex = 4;
            // 
            // TituloForma
            // 
            this.TituloForma.AutoSize = true;
            this.TituloForma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TituloForma.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloForma.ForeColor = System.Drawing.Color.White;
            this.TituloForma.Location = new System.Drawing.Point(2, 3);
            this.TituloForma.Name = "TituloForma";
            this.TituloForma.Size = new System.Drawing.Size(49, 14);
            this.TituloForma.TabIndex = 2;
            this.TituloForma.Text = "Master";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(625, -2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 22);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(643, -2);
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
            this.shapeContainer2.Size = new System.Drawing.Size(663, 22);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TopBar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.TopBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Location = new System.Drawing.Point(0, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopBar.Size = new System.Drawing.Size(662, 23);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnRecepcionL
            // 
            this.btnRecepcionL.AutoSize = true;
            this.btnRecepcionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.btnRecepcionL.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.btnRecepcionL.ForeColor = System.Drawing.Color.White;
            this.btnRecepcionL.Location = new System.Drawing.Point(199, 67);
            this.btnRecepcionL.Name = "btnRecepcionL";
            this.btnRecepcionL.Size = new System.Drawing.Size(258, 55);
            this.btnRecepcionL.TabIndex = 19;
            this.btnRecepcionL.Text = "Recepción";
            this.btnRecepcionL.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.btnRecepcion.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnRecepcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(89)))));
            this.btnRecepcion.CornerRadius = 3;
            this.btnRecepcion.Location = new System.Drawing.Point(33, 53);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnRecepcion.Size = new System.Drawing.Size(595, 79);
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnHistorial,
            this.btnCamiones,
            this.btnEnvios,
            this.btnGuardar,
            this.btnRecepcion});
            this.shapeContainer1.Size = new System.Drawing.Size(663, 383);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(43)))));
            this.btnHistorial.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnHistorial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(43)))));
            this.btnHistorial.CornerRadius = 3;
            this.btnHistorial.Location = new System.Drawing.Point(34, 279);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnHistorial.Size = new System.Drawing.Size(277, 79);
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCamiones
            // 
            this.btnCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnCamiones.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnCamiones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnCamiones.CornerRadius = 3;
            this.btnCamiones.Location = new System.Drawing.Point(351, 163);
            this.btnCamiones.Name = "btnCamiones";
            this.btnCamiones.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnCamiones.Size = new System.Drawing.Size(277, 79);
            this.btnCamiones.Click += new System.EventHandler(this.btnCamiones_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnEnvios.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnEnvios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnEnvios.CornerRadius = 3;
            this.btnEnvios.Location = new System.Drawing.Point(34, 162);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnEnvios.Size = new System.Drawing.Size(277, 79);
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(73)))), ((int)(((byte)(186)))));
            this.btnGuardar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(73)))), ((int)(((byte)(186)))));
            this.btnGuardar.CornerRadius = 3;
            this.btnGuardar.Location = new System.Drawing.Point(351, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnGuardar.Size = new System.Drawing.Size(277, 79);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarL
            // 
            this.btnGuardarL.AutoSize = true;
            this.btnGuardarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(73)))), ((int)(((byte)(186)))));
            this.btnGuardarL.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.btnGuardarL.ForeColor = System.Drawing.Color.White;
            this.btnGuardarL.Location = new System.Drawing.Point(390, 292);
            this.btnGuardarL.Name = "btnGuardarL";
            this.btnGuardarL.Size = new System.Drawing.Size(206, 55);
            this.btnGuardarL.TabIndex = 21;
            this.btnGuardarL.Text = "Guardar";
            this.btnGuardarL.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEnviosL
            // 
            this.btnEnviosL.AutoSize = true;
            this.btnEnviosL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnEnviosL.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.btnEnviosL.ForeColor = System.Drawing.Color.White;
            this.btnEnviosL.Location = new System.Drawing.Point(92, 176);
            this.btnEnviosL.Name = "btnEnviosL";
            this.btnEnviosL.Size = new System.Drawing.Size(180, 55);
            this.btnEnviosL.TabIndex = 22;
            this.btnEnviosL.Text = "Envios";
            this.btnEnviosL.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnCamionesL
            // 
            this.btnCamionesL.AutoSize = true;
            this.btnCamionesL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnCamionesL.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.btnCamionesL.ForeColor = System.Drawing.Color.White;
            this.btnCamionesL.Location = new System.Drawing.Point(380, 177);
            this.btnCamionesL.Name = "btnCamionesL";
            this.btnCamionesL.Size = new System.Drawing.Size(232, 55);
            this.btnCamionesL.TabIndex = 23;
            this.btnCamionesL.Text = "Camiones";
            this.btnCamionesL.Click += new System.EventHandler(this.btnCamiones_Click);
            // 
            // btnHistorialL
            // 
            this.btnHistorialL.AutoSize = true;
            this.btnHistorialL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(43)))));
            this.btnHistorialL.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.btnHistorialL.ForeColor = System.Drawing.Color.White;
            this.btnHistorialL.Location = new System.Drawing.Point(41, 292);
            this.btnHistorialL.Name = "btnHistorialL";
            this.btnHistorialL.Size = new System.Drawing.Size(258, 55);
            this.btnHistorialL.TabIndex = 24;
            this.btnHistorialL.Text = "Historial";
            this.btnHistorialL.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(663, 383);
            this.Controls.Add(this.btnHistorialL);
            this.Controls.Add(this.btnCamionesL);
            this.Controls.Add(this.btnEnviosL);
            this.Controls.Add(this.btnGuardarL);
            this.Controls.Add(this.btnRecepcionL);
            this.Controls.Add(this.FullTopBar);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Consolas", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            this.FullTopBar.ResumeLayout(false);
            this.FullTopBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Panel FullTopBar;
        private System.Windows.Forms.Label TituloForma;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TopBar;
        private System.Windows.Forms.Label btnRecepcionL;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnRecepcion;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnCamiones;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnEnvios;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnGuardar;
        private System.Windows.Forms.Label btnGuardarL;
        private System.Windows.Forms.Label btnEnviosL;
        private System.Windows.Forms.Label btnCamionesL;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnHistorial;
        private System.Windows.Forms.Label btnHistorialL;
    }
    }