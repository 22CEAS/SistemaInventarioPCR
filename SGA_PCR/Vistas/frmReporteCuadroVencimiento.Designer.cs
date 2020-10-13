﻿namespace Apolo
{
    partial class frmReporteCuadroVencimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCuadroVencimiento));
            this.btnExportar = new System.Windows.Forms.Button();
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
            this.DíasAntesVencer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
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
            this.btnExportar.Location = new System.Drawing.Point(1115, 27);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 137;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Location = new System.Drawing.Point(29, 109);
            this.dgvFacturas.MainView = this.vista;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1161, 378);
            this.dgvFacturas.TabIndex = 136;
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
            this.DíasAntesVencer,
            this.KAM});
            this.vista.GridControl = this.dgvFacturas;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "cliente";
            this.Cliente.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Cliente.MaxWidth = 200;
            this.Cliente.MinWidth = 200;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 200;
            // 
            // FechaInicioContrato
            // 
            this.FechaInicioContrato.Caption = "FechaInicioContrato";
            this.FechaInicioContrato.FieldName = "fecIniPlazoAlquiler";
            this.FechaInicioContrato.MaxWidth = 140;
            this.FechaInicioContrato.MinWidth = 140;
            this.FechaInicioContrato.Name = "FechaInicioContrato";
            this.FechaInicioContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioContrato.Visible = true;
            this.FechaInicioContrato.VisibleIndex = 1;
            this.FechaInicioContrato.Width = 140;
            // 
            // FechaFinContrato
            // 
            this.FechaFinContrato.Caption = "FechaFinContrato";
            this.FechaFinContrato.FieldName = "fecFinPlazoAlquiler";
            this.FechaFinContrato.MaxWidth = 140;
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
            this.Factura.MaxWidth = 140;
            this.Factura.MinWidth = 140;
            this.Factura.Name = "Factura";
            this.Factura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Factura.Visible = true;
            this.Factura.VisibleIndex = 3;
            this.Factura.Width = 140;
            // 
            // FechaInicioFactura
            // 
            this.FechaInicioFactura.Caption = "FechaInicioFactura";
            this.FechaInicioFactura.FieldName = "fecInicioFactura";
            this.FechaInicioFactura.MaxWidth = 140;
            this.FechaInicioFactura.MinWidth = 140;
            this.FechaInicioFactura.Name = "FechaInicioFactura";
            this.FechaInicioFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaInicioFactura.Visible = true;
            this.FechaInicioFactura.VisibleIndex = 4;
            this.FechaInicioFactura.Width = 140;
            // 
            // FechaFinFactura
            // 
            this.FechaFinFactura.Caption = "FechaFinFactura";
            this.FechaFinFactura.FieldName = "fecFinFactura";
            this.FechaFinFactura.MaxWidth = 140;
            this.FechaFinFactura.MinWidth = 140;
            this.FechaFinFactura.Name = "FechaFinFactura";
            this.FechaFinFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinFactura.Visible = true;
            this.FechaFinFactura.VisibleIndex = 5;
            this.FechaFinFactura.Width = 140;
            // 
            // CódigoLC
            // 
            this.CódigoLC.Caption = "CódigoLC";
            this.CódigoLC.FieldName = "codigoEquipo";
            this.CódigoLC.MaxWidth = 140;
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
            this.Guía.MaxWidth = 140;
            this.Guía.MinWidth = 140;
            this.Guía.Name = "Guía";
            this.Guía.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Guía.Visible = true;
            this.Guía.VisibleIndex = 7;
            this.Guía.Width = 140;
            // 
            // DíasAntesVencer
            // 
            this.DíasAntesVencer.Caption = "DíasAntesVencer";
            this.DíasAntesVencer.FieldName = "diasAntesVencer";
            this.DíasAntesVencer.MaxWidth = 100;
            this.DíasAntesVencer.MinWidth = 100;
            this.DíasAntesVencer.Name = "DíasAntesVencer";
            this.DíasAntesVencer.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DíasAntesVencer.Visible = true;
            this.DíasAntesVencer.VisibleIndex = 8;
            this.DíasAntesVencer.Width = 100;
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
            this.KAM.VisibleIndex = 9;
            this.KAM.Width = 200;
            // 
            // frmReporteCuadroVencimiento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 515);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvFacturas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteCuadroVencimiento";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas Por Vencer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.GridControl dgvFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn Factura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinFactura;
        private DevExpress.XtraGrid.Columns.GridColumn CódigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn Guía;
        private DevExpress.XtraGrid.Columns.GridColumn DíasAntesVencer;
        private DevExpress.XtraGrid.Columns.GridColumn KAM;
    }
}