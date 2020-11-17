namespace Apolo
{
    partial class frmReportePendienteRecoger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePendienteRecoger));
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DireccionCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CódigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guía = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaInicioContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiasAtrasoRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MotivoNoRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecInicioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptops.Location = new System.Drawing.Point(22, 78);
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1249, 401);
            this.dgvLaptops.TabIndex = 133;
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
            this.DireccionCliente,
            this.TelefonoContacto,
            this.CódigoLC,
            this.Guía,
            this.MarcaLC,
            this.NombreModeloLC,
            this.CodigoAntiguo,
            this.FechaInicioContrato,
            this.FechaFinContrato,
            this.TipoProcesador,
            this.NombreModeloVideo,
            this.DiasAtrasoRecojo,
            this.MotivoNoRecojo,
            this.factura,
            this.fecInicioFactura,
            this.fecFinFactura,
            this.MontoSoles,
            this.MontoDolares,
            this.TotalDolares,
            this.KAM});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Cliente.MinWidth = 40;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 200;
            // 
            // Contacto
            // 
            this.Contacto.Caption = "Contacto";
            this.Contacto.FieldName = "Contacto";
            this.Contacto.MinWidth = 40;
            this.Contacto.Name = "Contacto";
            this.Contacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Contacto.Visible = true;
            this.Contacto.VisibleIndex = 1;
            this.Contacto.Width = 200;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Caption = "Dirección Cliente";
            this.DireccionCliente.FieldName = "DireccionCliente";
            this.DireccionCliente.MinWidth = 40;
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DireccionCliente.Visible = true;
            this.DireccionCliente.VisibleIndex = 2;
            this.DireccionCliente.Width = 300;
            // 
            // TelefonoContacto
            // 
            this.TelefonoContacto.Caption = "Telefono Contacto";
            this.TelefonoContacto.FieldName = "TelefonoContacto";
            this.TelefonoContacto.MinWidth = 40;
            this.TelefonoContacto.Name = "TelefonoContacto";
            this.TelefonoContacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TelefonoContacto.Visible = true;
            this.TelefonoContacto.VisibleIndex = 3;
            this.TelefonoContacto.Width = 100;
            // 
            // CódigoLC
            // 
            this.CódigoLC.Caption = "Código LC";
            this.CódigoLC.FieldName = "Codigo";
            this.CódigoLC.MinWidth = 40;
            this.CódigoLC.Name = "CódigoLC";
            this.CódigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CódigoLC.Visible = true;
            this.CódigoLC.VisibleIndex = 4;
            this.CódigoLC.Width = 150;
            // 
            // Guía
            // 
            this.Guía.Caption = "Guía";
            this.Guía.FieldName = "guia";
            this.Guía.MinWidth = 40;
            this.Guía.Name = "Guía";
            this.Guía.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Guía.Visible = true;
            this.Guía.VisibleIndex = 5;
            this.Guía.Width = 200;
            // 
            // MarcaLC
            // 
            this.MarcaLC.Caption = "Marca LC";
            this.MarcaLC.FieldName = "MarcaLC";
            this.MarcaLC.MinWidth = 40;
            this.MarcaLC.Name = "MarcaLC";
            this.MarcaLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MarcaLC.Visible = true;
            this.MarcaLC.VisibleIndex = 6;
            this.MarcaLC.Width = 150;
            // 
            // NombreModeloLC
            // 
            this.NombreModeloLC.Caption = "Nombre Modelo LC";
            this.NombreModeloLC.FieldName = "NombreModeloLC";
            this.NombreModeloLC.MinWidth = 40;
            this.NombreModeloLC.Name = "NombreModeloLC";
            this.NombreModeloLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreModeloLC.Visible = true;
            this.NombreModeloLC.VisibleIndex = 7;
            this.NombreModeloLC.Width = 200;
            // 
            // CodigoAntiguo
            // 
            this.CodigoAntiguo.Caption = "Código Antiguo";
            this.CodigoAntiguo.FieldName = "CodigoAntiguo";
            this.CodigoAntiguo.MinWidth = 40;
            this.CodigoAntiguo.Name = "CodigoAntiguo";
            this.CodigoAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoAntiguo.Visible = true;
            this.CodigoAntiguo.VisibleIndex = 8;
            this.CodigoAntiguo.Width = 140;
            // 
            // FechaInicioContrato
            // 
            this.FechaInicioContrato.Caption = "Fecha Inicio Contrato";
            this.FechaInicioContrato.FieldName = "fecIniContrato";
            this.FechaInicioContrato.MinWidth = 40;
            this.FechaInicioContrato.Name = "FechaInicioContrato";
            this.FechaInicioContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioContrato.Visible = true;
            this.FechaInicioContrato.VisibleIndex = 9;
            this.FechaInicioContrato.Width = 150;
            // 
            // FechaFinContrato
            // 
            this.FechaFinContrato.Caption = "Fecha Fin Contrato";
            this.FechaFinContrato.FieldName = "fecFinContrato";
            this.FechaFinContrato.MinWidth = 40;
            this.FechaFinContrato.Name = "FechaFinContrato";
            this.FechaFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinContrato.Visible = true;
            this.FechaFinContrato.VisibleIndex = 10;
            this.FechaFinContrato.Width = 150;
            // 
            // TipoProcesador
            // 
            this.TipoProcesador.Caption = "Tipo Procesador";
            this.TipoProcesador.FieldName = "TipoProcesador";
            this.TipoProcesador.MinWidth = 40;
            this.TipoProcesador.Name = "TipoProcesador";
            this.TipoProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoProcesador.Visible = true;
            this.TipoProcesador.VisibleIndex = 11;
            this.TipoProcesador.Width = 150;
            // 
            // NombreModeloVideo
            // 
            this.NombreModeloVideo.Caption = "Nombre Modelo Video";
            this.NombreModeloVideo.FieldName = "NombreModeloVideo";
            this.NombreModeloVideo.MinWidth = 40;
            this.NombreModeloVideo.Name = "NombreModeloVideo";
            this.NombreModeloVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreModeloVideo.Width = 200;
            // 
            // DiasAtrasoRecojo
            // 
            this.DiasAtrasoRecojo.Caption = "Dias Atraso Recojo";
            this.DiasAtrasoRecojo.FieldName = "diasAtrasoRecojo";
            this.DiasAtrasoRecojo.MinWidth = 40;
            this.DiasAtrasoRecojo.Name = "DiasAtrasoRecojo";
            this.DiasAtrasoRecojo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DiasAtrasoRecojo.Visible = true;
            this.DiasAtrasoRecojo.VisibleIndex = 12;
            this.DiasAtrasoRecojo.Width = 150;
            // 
            // MotivoNoRecojo
            // 
            this.MotivoNoRecojo.Caption = "Motivo No Recojo";
            this.MotivoNoRecojo.FieldName = "motivoNoRecojo";
            this.MotivoNoRecojo.MinWidth = 40;
            this.MotivoNoRecojo.Name = "MotivoNoRecojo";
            this.MotivoNoRecojo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MotivoNoRecojo.Width = 200;
            // 
            // factura
            // 
            this.factura.Caption = "Factura";
            this.factura.FieldName = "factura";
            this.factura.MinWidth = 40;
            this.factura.Name = "factura";
            this.factura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.factura.Visible = true;
            this.factura.VisibleIndex = 13;
            this.factura.Width = 150;
            // 
            // fecInicioFactura
            // 
            this.fecInicioFactura.Caption = "Fecha Inicio Factura";
            this.fecInicioFactura.FieldName = "fecInicioFactura";
            this.fecInicioFactura.MinWidth = 40;
            this.fecInicioFactura.Name = "fecInicioFactura";
            this.fecInicioFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecInicioFactura.Visible = true;
            this.fecInicioFactura.VisibleIndex = 14;
            this.fecInicioFactura.Width = 150;
            // 
            // fecFinFactura
            // 
            this.fecFinFactura.Caption = "Fecha Fin Factura";
            this.fecFinFactura.FieldName = "fecFinFactura";
            this.fecFinFactura.MinWidth = 40;
            this.fecFinFactura.Name = "fecFinFactura";
            this.fecFinFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecFinFactura.Visible = true;
            this.fecFinFactura.VisibleIndex = 15;
            this.fecFinFactura.Width = 150;
            // 
            // MontoSoles
            // 
            this.MontoSoles.Caption = "Monto Soles";
            this.MontoSoles.FieldName = "MontoSoles";
            this.MontoSoles.MinWidth = 40;
            this.MontoSoles.Name = "MontoSoles";
            this.MontoSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.MontoSoles.Visible = true;
            this.MontoSoles.VisibleIndex = 16;
            this.MontoSoles.Width = 150;
            // 
            // MontoDolares
            // 
            this.MontoDolares.Caption = "Monto Dolares";
            this.MontoDolares.FieldName = "MontoDolares";
            this.MontoDolares.MinWidth = 40;
            this.MontoDolares.Name = "MontoDolares";
            this.MontoDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.MontoDolares.Visible = true;
            this.MontoDolares.VisibleIndex = 17;
            this.MontoDolares.Width = 150;
            // 
            // TotalDolares
            // 
            this.TotalDolares.Caption = "Total Dolares";
            this.TotalDolares.FieldName = "TotalDolares";
            this.TotalDolares.MinWidth = 40;
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalDolares.Visible = true;
            this.TotalDolares.VisibleIndex = 18;
            this.TotalDolares.Width = 150;
            // 
            // KAM
            // 
            this.KAM.Caption = "KAM";
            this.KAM.FieldName = "KAM";
            this.KAM.MinWidth = 40;
            this.KAM.Name = "KAM";
            this.KAM.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KAM.Visible = true;
            this.KAM.VisibleIndex = 19;
            this.KAM.Width = 200;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(1196, 9);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 135;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReportePendienteRecoger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 506);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvLaptops);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmReportePendienteRecoger";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendiente Recoger";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Contacto;
        private DevExpress.XtraGrid.Columns.GridColumn DireccionCliente;
        private DevExpress.XtraGrid.Columns.GridColumn TelefonoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn CódigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaLC;
        private DevExpress.XtraGrid.Columns.GridColumn NombreModeloLC;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn TipoProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn NombreModeloVideo;
        private DevExpress.XtraGrid.Columns.GridColumn DiasAtrasoRecojo;
        private DevExpress.XtraGrid.Columns.GridColumn Guía;
        private DevExpress.XtraGrid.Columns.GridColumn MotivoNoRecojo;
        private DevExpress.XtraGrid.Columns.GridColumn KAM;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn factura;
        private DevExpress.XtraGrid.Columns.GridColumn fecInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinFactura;
        private DevExpress.XtraGrid.Columns.GridColumn MontoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn MontoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
    }
}