namespace Apolo
{
    partial class frmReportePendienteFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePendienteFacturar));
            this.dgvFacturas = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaInicioContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaInicioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CódigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guía = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DíasVencidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PendienteFacturarSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PendienteFacturarDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.GuiaAntigua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Location = new System.Drawing.Point(27, 94);
            this.dgvFacturas.MainView = this.vista;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1161, 378);
            this.dgvFacturas.TabIndex = 132;
            this.dgvFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.FechaInicioContrato,
            this.FechaFinContrato,
            this.Factura,
            this.FechaInicioFactura,
            this.FechaFinFactura,
            this.CódigoLC,
            this.Guía,
            this.CodigoAntiguo,
            this.GuiaAntigua,
            this.DíasVencidos,
            this.TotalSoles,
            this.TotalDolares,
            this.CostoSoles,
            this.CostoDolares,
            this.PendienteFacturarSoles,
            this.PendienteFacturarDolares,
            this.KAM});
            this.vista.GridControl = this.dgvFacturas;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "cliente";
            this.Cliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Cliente.MinWidth = 200;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 200;
            // 
            // FechaInicioContrato
            // 
            this.FechaInicioContrato.Caption = "Inicio Plazo Alquiler";
            this.FechaInicioContrato.FieldName = "fecIniPlazoAlquiler";
            this.FechaInicioContrato.MinWidth = 140;
            this.FechaInicioContrato.Name = "FechaInicioContrato";
            this.FechaInicioContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioContrato.Visible = true;
            this.FechaInicioContrato.VisibleIndex = 1;
            this.FechaInicioContrato.Width = 140;
            // 
            // FechaFinContrato
            // 
            this.FechaFinContrato.Caption = "Fin Plazo Alquiler";
            this.FechaFinContrato.FieldName = "fecFinPlazoAlquiler";
            this.FechaFinContrato.MinWidth = 140;
            this.FechaFinContrato.Name = "FechaFinContrato";
            this.FechaFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinContrato.Visible = true;
            this.FechaFinContrato.VisibleIndex = 2;
            this.FechaFinContrato.Width = 140;
            // 
            // Factura
            // 
            this.Factura.Caption = "Factura";
            this.Factura.FieldName = "factura";
            this.Factura.MinWidth = 140;
            this.Factura.Name = "Factura";
            this.Factura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Factura.Visible = true;
            this.Factura.VisibleIndex = 3;
            this.Factura.Width = 140;
            // 
            // FechaInicioFactura
            // 
            this.FechaInicioFactura.Caption = "Fecha Inicio Factura";
            this.FechaInicioFactura.FieldName = "fecInicioFactura";
            this.FechaInicioFactura.MinWidth = 140;
            this.FechaInicioFactura.Name = "FechaInicioFactura";
            this.FechaInicioFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioFactura.Visible = true;
            this.FechaInicioFactura.VisibleIndex = 4;
            this.FechaInicioFactura.Width = 140;
            // 
            // FechaFinFactura
            // 
            this.FechaFinFactura.Caption = "Fecha Fin Factura";
            this.FechaFinFactura.FieldName = "fecFinFactura";
            this.FechaFinFactura.MinWidth = 140;
            this.FechaFinFactura.Name = "FechaFinFactura";
            this.FechaFinFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinFactura.Visible = true;
            this.FechaFinFactura.VisibleIndex = 5;
            this.FechaFinFactura.Width = 140;
            // 
            // CódigoLC
            // 
            this.CódigoLC.Caption = "Código LC";
            this.CódigoLC.FieldName = "codigoEquipo";
            this.CódigoLC.MinWidth = 140;
            this.CódigoLC.Name = "CódigoLC";
            this.CódigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CódigoLC.Visible = true;
            this.CódigoLC.VisibleIndex = 6;
            this.CódigoLC.Width = 140;
            // 
            // Guía
            // 
            this.Guía.Caption = "Guía";
            this.Guía.FieldName = "guia";
            this.Guía.MinWidth = 140;
            this.Guía.Name = "Guía";
            this.Guía.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Guía.Visible = true;
            this.Guía.VisibleIndex = 7;
            this.Guía.Width = 140;
            // 
            // DíasVencidos
            // 
            this.DíasVencidos.Caption = "Días Vencidos";
            this.DíasVencidos.FieldName = "diasVencidos";
            this.DíasVencidos.MinWidth = 100;
            this.DíasVencidos.Name = "DíasVencidos";
            this.DíasVencidos.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DíasVencidos.Visible = true;
            this.DíasVencidos.VisibleIndex = 10;
            this.DíasVencidos.Width = 100;
            // 
            // TotalSoles
            // 
            this.TotalSoles.Caption = "Total Soles";
            this.TotalSoles.FieldName = "TotalSoles";
            this.TotalSoles.MinWidth = 100;
            this.TotalSoles.Name = "TotalSoles";
            this.TotalSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalSoles.Visible = true;
            this.TotalSoles.VisibleIndex = 11;
            this.TotalSoles.Width = 100;
            // 
            // TotalDolares
            // 
            this.TotalDolares.Caption = "Total Dolares";
            this.TotalDolares.FieldName = "TotalDolares";
            this.TotalDolares.MinWidth = 100;
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalDolares.Visible = true;
            this.TotalDolares.VisibleIndex = 12;
            this.TotalDolares.Width = 100;
            // 
            // CostoSoles
            // 
            this.CostoSoles.Caption = "Costo Soles";
            this.CostoSoles.FieldName = "CostoSoles";
            this.CostoSoles.MinWidth = 100;
            this.CostoSoles.Name = "CostoSoles";
            this.CostoSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoSoles.Visible = true;
            this.CostoSoles.VisibleIndex = 13;
            this.CostoSoles.Width = 100;
            // 
            // CostoDolares
            // 
            this.CostoDolares.Caption = "Costo Dolares";
            this.CostoDolares.FieldName = "CostoDolares";
            this.CostoDolares.MinWidth = 100;
            this.CostoDolares.Name = "CostoDolares";
            this.CostoDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoDolares.Visible = true;
            this.CostoDolares.VisibleIndex = 14;
            this.CostoDolares.Width = 100;
            // 
            // PendienteFacturarSoles
            // 
            this.PendienteFacturarSoles.Caption = "Pendiente Facturar Soles";
            this.PendienteFacturarSoles.FieldName = "PendienteFacturarSoles";
            this.PendienteFacturarSoles.MinWidth = 100;
            this.PendienteFacturarSoles.Name = "PendienteFacturarSoles";
            this.PendienteFacturarSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PendienteFacturarSoles.Visible = true;
            this.PendienteFacturarSoles.VisibleIndex = 15;
            this.PendienteFacturarSoles.Width = 100;
            // 
            // PendienteFacturarDolares
            // 
            this.PendienteFacturarDolares.Caption = "Pendiente Facturar Dolares";
            this.PendienteFacturarDolares.FieldName = "PendienteFacturarDolares";
            this.PendienteFacturarDolares.MinWidth = 100;
            this.PendienteFacturarDolares.Name = "PendienteFacturarDolares";
            this.PendienteFacturarDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PendienteFacturarDolares.Visible = true;
            this.PendienteFacturarDolares.VisibleIndex = 16;
            this.PendienteFacturarDolares.Width = 100;
            // 
            // KAM
            // 
            this.KAM.Caption = "KAM";
            this.KAM.FieldName = "KAM";
            this.KAM.MinWidth = 200;
            this.KAM.Name = "KAM";
            this.KAM.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KAM.Visible = true;
            this.KAM.VisibleIndex = 17;
            this.KAM.Width = 200;
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
            this.btnExportar.Location = new System.Drawing.Point(1113, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 135;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // GuiaAntigua
            // 
            this.GuiaAntigua.Caption = "Guía Antigua";
            this.GuiaAntigua.FieldName = "GuiaAntigua";
            this.GuiaAntigua.MinWidth = 140;
            this.GuiaAntigua.Name = "GuiaAntigua";
            this.GuiaAntigua.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GuiaAntigua.Visible = true;
            this.GuiaAntigua.VisibleIndex = 9;
            this.GuiaAntigua.Width = 140;
            // 
            // CodigoAntiguo
            // 
            this.CodigoAntiguo.Caption = "Código Antiguo";
            this.CodigoAntiguo.FieldName = "CodigoAntiguo";
            this.CodigoAntiguo.MinWidth = 140;
            this.CodigoAntiguo.Name = "CodigoAntiguo";
            this.CodigoAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoAntiguo.Visible = true;
            this.CodigoAntiguo.VisibleIndex = 8;
            this.CodigoAntiguo.Width = 140;
            // 
            // frmReportePendienteFacturar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 515);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvFacturas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePendienteFacturar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendientes de Facturar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgvFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Factura;
        private DevExpress.XtraGrid.Columns.GridColumn CódigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn Guía;
        private DevExpress.XtraGrid.Columns.GridColumn DíasVencidos;
        private DevExpress.XtraGrid.Columns.GridColumn KAM;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinFactura;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSoles;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn PendienteFacturarSoles;
        private DevExpress.XtraGrid.Columns.GridColumn PendienteFacturarDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaAntigua;
    }
}