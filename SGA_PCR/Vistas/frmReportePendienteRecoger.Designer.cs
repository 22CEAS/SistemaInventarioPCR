namespace Vistas
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DireccionCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CódigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaInicioContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiasAtrasoRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guía = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MotivoNoRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1196, 12);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProducto.TabIndex = 36;
            this.btnAgregarProducto.Text = "Exportar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Location = new System.Drawing.Point(22, 78);
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1249, 281);
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
            this.MarcaLC,
            this.NombreModeloLC,
            this.FechaInicioContrato,
            this.FechaFinContrato,
            this.TipoProcesador,
            this.NombreModeloVideo,
            this.DiasAtrasoRecojo,
            this.Guía,
            this.MotivoNoRecojo,
            this.KAM});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Cliente.MaxWidth = 200;
            this.Cliente.MinWidth = 200;
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
            this.Contacto.MaxWidth = 200;
            this.Contacto.MinWidth = 200;
            this.Contacto.Name = "Contacto";
            this.Contacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Contacto.Visible = true;
            this.Contacto.VisibleIndex = 1;
            this.Contacto.Width = 200;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Caption = "DireccionCliente";
            this.DireccionCliente.FieldName = "DireccionCliente";
            this.DireccionCliente.MaxWidth = 300;
            this.DireccionCliente.MinWidth = 300;
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DireccionCliente.Visible = true;
            this.DireccionCliente.VisibleIndex = 2;
            this.DireccionCliente.Width = 300;
            // 
            // TelefonoContacto
            // 
            this.TelefonoContacto.Caption = "TelefonoContacto";
            this.TelefonoContacto.FieldName = "TelefonoContacto";
            this.TelefonoContacto.MaxWidth = 100;
            this.TelefonoContacto.MinWidth = 100;
            this.TelefonoContacto.Name = "TelefonoContacto";
            this.TelefonoContacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TelefonoContacto.Visible = true;
            this.TelefonoContacto.VisibleIndex = 3;
            this.TelefonoContacto.Width = 100;
            // 
            // CódigoLC
            // 
            this.CódigoLC.Caption = "CódigoLC";
            this.CódigoLC.FieldName = "Codigo";
            this.CódigoLC.MaxWidth = 150;
            this.CódigoLC.MinWidth = 150;
            this.CódigoLC.Name = "CódigoLC";
            this.CódigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CódigoLC.Visible = true;
            this.CódigoLC.VisibleIndex = 4;
            this.CódigoLC.Width = 150;
            // 
            // MarcaLC
            // 
            this.MarcaLC.Caption = "MarcaLC";
            this.MarcaLC.FieldName = "MarcaLC";
            this.MarcaLC.MaxWidth = 150;
            this.MarcaLC.MinWidth = 150;
            this.MarcaLC.Name = "MarcaLC";
            this.MarcaLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MarcaLC.Visible = true;
            this.MarcaLC.VisibleIndex = 5;
            this.MarcaLC.Width = 150;
            // 
            // NombreModeloLC
            // 
            this.NombreModeloLC.Caption = "NombreModeloLC";
            this.NombreModeloLC.FieldName = "NombreModeloLC";
            this.NombreModeloLC.MaxWidth = 200;
            this.NombreModeloLC.MinWidth = 200;
            this.NombreModeloLC.Name = "NombreModeloLC";
            this.NombreModeloLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreModeloLC.Visible = true;
            this.NombreModeloLC.VisibleIndex = 6;
            this.NombreModeloLC.Width = 200;
            // 
            // FechaInicioContrato
            // 
            this.FechaInicioContrato.Caption = "FechaInicioContrato";
            this.FechaInicioContrato.FieldName = "fecIniContrato";
            this.FechaInicioContrato.MaxWidth = 150;
            this.FechaInicioContrato.MinWidth = 150;
            this.FechaInicioContrato.Name = "FechaInicioContrato";
            this.FechaInicioContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioContrato.Visible = true;
            this.FechaInicioContrato.VisibleIndex = 7;
            this.FechaInicioContrato.Width = 150;
            // 
            // FechaFinContrato
            // 
            this.FechaFinContrato.Caption = "FechaFinContrato";
            this.FechaFinContrato.FieldName = "fecFinContrato";
            this.FechaFinContrato.MaxWidth = 150;
            this.FechaFinContrato.MinWidth = 150;
            this.FechaFinContrato.Name = "FechaFinContrato";
            this.FechaFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinContrato.Visible = true;
            this.FechaFinContrato.VisibleIndex = 8;
            this.FechaFinContrato.Width = 150;
            // 
            // TipoProcesador
            // 
            this.TipoProcesador.Caption = "TipoProcesador";
            this.TipoProcesador.FieldName = "TipoProcesador";
            this.TipoProcesador.MaxWidth = 150;
            this.TipoProcesador.MinWidth = 150;
            this.TipoProcesador.Name = "TipoProcesador";
            this.TipoProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoProcesador.Visible = true;
            this.TipoProcesador.VisibleIndex = 9;
            this.TipoProcesador.Width = 150;
            // 
            // NombreModeloVideo
            // 
            this.NombreModeloVideo.Caption = "NombreModeloVideo";
            this.NombreModeloVideo.FieldName = "NombreModeloVideo";
            this.NombreModeloVideo.MaxWidth = 200;
            this.NombreModeloVideo.MinWidth = 200;
            this.NombreModeloVideo.Name = "NombreModeloVideo";
            this.NombreModeloVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreModeloVideo.Visible = true;
            this.NombreModeloVideo.VisibleIndex = 10;
            this.NombreModeloVideo.Width = 200;
            // 
            // DiasAtrasoRecojo
            // 
            this.DiasAtrasoRecojo.Caption = "DiasAtrasoRecojo";
            this.DiasAtrasoRecojo.FieldName = "diasAtrasoRecojo";
            this.DiasAtrasoRecojo.MaxWidth = 150;
            this.DiasAtrasoRecojo.MinWidth = 150;
            this.DiasAtrasoRecojo.Name = "DiasAtrasoRecojo";
            this.DiasAtrasoRecojo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DiasAtrasoRecojo.Visible = true;
            this.DiasAtrasoRecojo.VisibleIndex = 11;
            this.DiasAtrasoRecojo.Width = 150;
            // 
            // Guía
            // 
            this.Guía.Caption = "Guía";
            this.Guía.FieldName = "guia";
            this.Guía.MaxWidth = 200;
            this.Guía.MinWidth = 200;
            this.Guía.Name = "Guía";
            this.Guía.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Guía.Visible = true;
            this.Guía.VisibleIndex = 12;
            this.Guía.Width = 200;
            // 
            // MotivoNoRecojo
            // 
            this.MotivoNoRecojo.Caption = "MotivoNoRecojo";
            this.MotivoNoRecojo.FieldName = "motivoNoRecojo";
            this.MotivoNoRecojo.MaxWidth = 200;
            this.MotivoNoRecojo.MinWidth = 200;
            this.MotivoNoRecojo.Name = "MotivoNoRecojo";
            this.MotivoNoRecojo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MotivoNoRecojo.Visible = true;
            this.MotivoNoRecojo.VisibleIndex = 13;
            this.MotivoNoRecojo.Width = 200;
            // 
            // KAM
            // 
            this.KAM.Caption = "KAM";
            this.KAM.FieldName = "KAM";
            this.KAM.MaxWidth = 200;
            this.KAM.MinWidth = 200;
            this.KAM.Name = "KAM";
            this.KAM.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KAM.Visible = true;
            this.KAM.VisibleIndex = 14;
            this.KAM.Width = 200;
            // 
            // frmReportePendienteRecoger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 371);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.btnAgregarProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePendienteRecoger";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendiente Recoger";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
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
    }
}