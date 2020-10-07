﻿namespace Vistas
{
    partial class frmReporteMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMantenimiento));
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvReparaciones = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionComoSeEncontro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoAntesReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoLuegoReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
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
            this.btnExportar.Location = new System.Drawing.Point(950, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 136;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.Location = new System.Drawing.Point(25, 82);
            this.dgvReparaciones.MainView = this.vista;
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.Size = new System.Drawing.Size(1000, 260);
            this.dgvReparaciones.TabIndex = 135;
            this.dgvReparaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.IdReparacion,
            this.CodigoLC,
            this.FechaReparacion,
            this.DescripcionComoSeEncontro,
            this.EstadoAntesReparacion,
            this.DescripcionReparacion,
            this.EstadoLuegoReparacion,
            this.Responsable,
            this.EstadoReparacion});
            this.vista.GridControl = this.dgvReparaciones;
            this.vista.Name = "vista";
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // CodigoLC
            // 
            this.CodigoLC.Caption = "CodigoLC";
            this.CodigoLC.FieldName = "CodigoLC";
            this.CodigoLC.MaxWidth = 100;
            this.CodigoLC.MinWidth = 100;
            this.CodigoLC.Name = "CodigoLC";
            this.CodigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoLC.Visible = true;
            this.CodigoLC.VisibleIndex = 1;
            this.CodigoLC.Width = 100;
            // 
            // IdReparacion
            // 
            this.IdReparacion.Caption = "IdReparacion";
            this.IdReparacion.FieldName = "IdReparacion";
            this.IdReparacion.MaxWidth = 75;
            this.IdReparacion.MinWidth = 75;
            this.IdReparacion.Name = "IdReparacion";
            this.IdReparacion.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdReparacion.Visible = true;
            this.IdReparacion.VisibleIndex = 0;
            // 
            // FechaReparacion
            // 
            this.FechaReparacion.Caption = "FechaReparacion";
            this.FechaReparacion.FieldName = "FechaReparacion";
            this.FechaReparacion.MaxWidth = 100;
            this.FechaReparacion.MinWidth = 100;
            this.FechaReparacion.Name = "FechaReparacion";
            this.FechaReparacion.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaReparacion.Visible = true;
            this.FechaReparacion.VisibleIndex = 2;
            this.FechaReparacion.Width = 100;
            // 
            // DescripcionComoSeEncontro
            // 
            this.DescripcionComoSeEncontro.Caption = "DescripcionComoSeEncontro";
            this.DescripcionComoSeEncontro.FieldName = "DescripcionComoSeEncontro";
            this.DescripcionComoSeEncontro.MaxWidth = 250;
            this.DescripcionComoSeEncontro.MinWidth = 250;
            this.DescripcionComoSeEncontro.Name = "DescripcionComoSeEncontro";
            this.DescripcionComoSeEncontro.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DescripcionComoSeEncontro.Visible = true;
            this.DescripcionComoSeEncontro.VisibleIndex = 3;
            this.DescripcionComoSeEncontro.Width = 250;
            // 
            // EstadoAntesReparacion
            // 
            this.EstadoAntesReparacion.Caption = "EstadoAntesReparacion";
            this.EstadoAntesReparacion.FieldName = "EstadoAntesReparacion";
            this.EstadoAntesReparacion.MaxWidth = 150;
            this.EstadoAntesReparacion.MinWidth = 150;
            this.EstadoAntesReparacion.Name = "EstadoAntesReparacion";
            this.EstadoAntesReparacion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.EstadoAntesReparacion.Visible = true;
            this.EstadoAntesReparacion.VisibleIndex = 4;
            this.EstadoAntesReparacion.Width = 150;
            // 
            // DescripcionReparacion
            // 
            this.DescripcionReparacion.Caption = "DescripcionReparacion";
            this.DescripcionReparacion.FieldName = "DescripcionReparacion";
            this.DescripcionReparacion.MaxWidth = 250;
            this.DescripcionReparacion.MinWidth = 250;
            this.DescripcionReparacion.Name = "DescripcionReparacion";
            this.DescripcionReparacion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DescripcionReparacion.Visible = true;
            this.DescripcionReparacion.VisibleIndex = 5;
            this.DescripcionReparacion.Width = 250;
            // 
            // EstadoLuegoReparacion
            // 
            this.EstadoLuegoReparacion.Caption = "EstadoLuegoReparacion";
            this.EstadoLuegoReparacion.FieldName = "EstadoLuegoReparacion";
            this.EstadoLuegoReparacion.MaxWidth = 150;
            this.EstadoLuegoReparacion.MinWidth = 150;
            this.EstadoLuegoReparacion.Name = "EstadoLuegoReparacion";
            this.EstadoLuegoReparacion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.EstadoLuegoReparacion.Visible = true;
            this.EstadoLuegoReparacion.VisibleIndex = 6;
            this.EstadoLuegoReparacion.Width = 150;
            // 
            // EstadoReparacion
            // 
            this.EstadoReparacion.Caption = "EstadoReparacion";
            this.EstadoReparacion.FieldName = "Estado";
            this.EstadoReparacion.MaxWidth = 150;
            this.EstadoReparacion.MinWidth = 150;
            this.EstadoReparacion.Name = "EstadoReparacion";
            this.EstadoReparacion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.EstadoReparacion.Visible = true;
            this.EstadoReparacion.VisibleIndex = 8;
            this.EstadoReparacion.Width = 150;
            // 
            // Responsable
            // 
            this.Responsable.Caption = "Responsable";
            this.Responsable.FieldName = "Responsable";
            this.Responsable.MaxWidth = 150;
            this.Responsable.MinWidth = 150;
            this.Responsable.Name = "Responsable";
            this.Responsable.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Responsable.Visible = true;
            this.Responsable.VisibleIndex = 7;
            this.Responsable.Width = 150;
            // 
            // frmReporteMantenimiento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 375);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvReparaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteMantenimiento";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Mantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.GridControl dgvReparaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn IdReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn FechaReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionComoSeEncontro;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoAntesReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoLuegoReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn Responsable;
    }
}