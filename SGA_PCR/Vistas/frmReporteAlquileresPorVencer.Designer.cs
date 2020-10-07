namespace Vistas
{
    partial class frmReporteAlquileresPorVencer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAlquileresPorVencer));
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Generacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Video = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecIniContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Location = new System.Drawing.Point(21, 97);
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1245, 274);
            this.dgvLaptops.TabIndex = 131;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista});
            // 
            // vista
            // 
            this.vista.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vista.Appearance.HeaderPanel.Options.UseFont = true;
            this.vista.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vista.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vista.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vista.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vista.Appearance.Row.Options.UseFont = true;
            this.vista.Appearance.Row.Options.UseForeColor = true;
            this.vista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cliente,
            this.Contacto,
            this.Direccion,
            this.Codigo,
            this.Marca,
            this.Modelo,
            this.Pantalla,
            this.Procesador,
            this.Generacion,
            this.Video,
            this.Capacidad,
            this.fecIniContrato,
            this.fecFinContrato});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Cliente.MinWidth = 100;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 100;
            // 
            // Contacto
            // 
            this.Contacto.Caption = "Contacto";
            this.Contacto.FieldName = "Contacto";
            this.Contacto.MinWidth = 100;
            this.Contacto.Name = "Contacto";
            this.Contacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Contacto.Visible = true;
            this.Contacto.VisibleIndex = 1;
            this.Contacto.Width = 100;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Direccion";
            this.Direccion.FieldName = "DireccionCliente";
            this.Direccion.MinWidth = 100;
            this.Direccion.Name = "Direccion";
            this.Direccion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 2;
            this.Direccion.Width = 100;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.MaxWidth = 100;
            this.Codigo.MinWidth = 100;
            this.Codigo.Name = "Codigo";
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 3;
            this.Codigo.Width = 100;
            // 
            // Marca
            // 
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "MarcaLC";
            this.Marca.MaxWidth = 100;
            this.Marca.MinWidth = 100;
            this.Marca.Name = "Marca";
            this.Marca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 4;
            this.Marca.Width = 100;
            // 
            // Modelo
            // 
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "NombreModeloLC";
            this.Modelo.MaxWidth = 100;
            this.Modelo.MinWidth = 100;
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 5;
            this.Modelo.Width = 100;
            // 
            // Pantalla
            // 
            this.Pantalla.Caption = "Pantalla";
            this.Pantalla.FieldName = "TamanoPantalla";
            this.Pantalla.MaxWidth = 60;
            this.Pantalla.MinWidth = 60;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Pantalla.Visible = true;
            this.Pantalla.VisibleIndex = 6;
            this.Pantalla.Width = 60;
            // 
            // Procesador
            // 
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "TipoProcesador";
            this.Procesador.MaxWidth = 70;
            this.Procesador.MinWidth = 70;
            this.Procesador.Name = "Procesador";
            this.Procesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 7;
            this.Procesador.Width = 70;
            // 
            // Generacion
            // 
            this.Generacion.Caption = "Generación";
            this.Generacion.FieldName = "GeneracionProcesador";
            this.Generacion.MaxWidth = 70;
            this.Generacion.MinWidth = 70;
            this.Generacion.Name = "Generacion";
            this.Generacion.Visible = true;
            this.Generacion.VisibleIndex = 8;
            this.Generacion.Width = 70;
            // 
            // Video
            // 
            this.Video.Caption = "Video";
            this.Video.FieldName = "NombreModeloVideo";
            this.Video.MaxWidth = 100;
            this.Video.MinWidth = 100;
            this.Video.Name = "Video";
            this.Video.Visible = true;
            this.Video.VisibleIndex = 9;
            this.Video.Width = 100;
            // 
            // Capacidad
            // 
            this.Capacidad.Caption = "Capacidad";
            this.Capacidad.FieldName = "CapacidadVideo";
            this.Capacidad.MaxWidth = 70;
            this.Capacidad.MinWidth = 70;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Visible = true;
            this.Capacidad.VisibleIndex = 10;
            this.Capacidad.Width = 70;
            // 
            // fecIniContrato
            // 
            this.fecIniContrato.Caption = "Inicio Plazo Alquiler";
            this.fecIniContrato.FieldName = "fecIniContrato";
            this.fecIniContrato.MaxWidth = 100;
            this.fecIniContrato.MinWidth = 100;
            this.fecIniContrato.Name = "fecIniContrato";
            this.fecIniContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecIniContrato.Visible = true;
            this.fecIniContrato.VisibleIndex = 11;
            this.fecIniContrato.Width = 100;
            // 
            // fecFinContrato
            // 
            this.fecFinContrato.Caption = "Fin Plazo Alquiler";
            this.fecFinContrato.FieldName = "fecFinContrato";
            this.fecFinContrato.MaxWidth = 100;
            this.fecFinContrato.MinWidth = 100;
            this.fecFinContrato.Name = "fecFinContrato";
            this.fecFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecFinContrato.Visible = true;
            this.fecFinContrato.VisibleIndex = 12;
            this.fecFinContrato.Width = 100;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(1180, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 135;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReporteAlquileresPorVencer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 398);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvLaptops);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteAlquileresPorVencer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos Por Vencer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Pantalla;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Generacion;
        private DevExpress.XtraGrid.Columns.GridColumn Video;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidad;
        private DevExpress.XtraGrid.Columns.GridColumn fecIniContrato;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Contacto;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private System.Windows.Forms.Button btnExportar;
    }
}