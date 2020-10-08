﻿namespace Apolo
{
    partial class frmProcesoRenovacionAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoRenovacionAgregarProducto));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantMeses = new System.Windows.Forms.TextBox();
            this.dgvPrueba = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSalidaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnAgregarMeses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(574, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantMeses
            // 
            this.txtCantMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMeses.Location = new System.Drawing.Point(157, 23);
            this.txtCantMeses.Name = "txtCantMeses";
            this.txtCantMeses.Size = new System.Drawing.Size(124, 22);
            this.txtCantMeses.TabIndex = 129;
            this.txtCantMeses.TextChanged += new System.EventHandler(this.txtCantMeses_TextChanged);
            this.txtCantMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMeses_KeyPress);
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.Location = new System.Drawing.Point(30, 77);
            this.dgvPrueba.MainView = this.vista;
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.Size = new System.Drawing.Size(750, 321);
            this.dgvPrueba.TabIndex = 130;
            this.dgvPrueba.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Codigo,
            this.Marca,
            this.Modelo,
            this.Pantalla,
            this.Procesador,
            this.Generacion,
            this.Video,
            this.Capacidad,
            this.fecIniContrato,
            this.fecFinContrato,
            this.IdLC,
            this.IdVideo,
            this.IdProcesador,
            this.IdSalidaDetalle,
            this.IdSucursal});
            this.vista.GridControl = this.dgvPrueba;
            this.vista.Name = "vista";
            this.vista.OptionsSelection.MultiSelect = true;
            this.vista.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Codigo.MaxWidth = 100;
            this.Codigo.MinWidth = 100;
            this.Codigo.Name = "Codigo";
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
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
            this.Marca.VisibleIndex = 2;
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
            this.Modelo.VisibleIndex = 3;
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
            this.Pantalla.VisibleIndex = 4;
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
            this.Procesador.VisibleIndex = 5;
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
            this.Generacion.VisibleIndex = 6;
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
            this.Video.VisibleIndex = 7;
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
            this.Capacidad.VisibleIndex = 8;
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
            this.fecIniContrato.VisibleIndex = 9;
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
            this.fecFinContrato.VisibleIndex = 10;
            this.fecFinContrato.Width = 100;
            // 
            // IdLC
            // 
            this.IdLC.Caption = "IdLC";
            this.IdLC.FieldName = "IdLC";
            this.IdLC.Name = "IdLC";
            // 
            // IdVideo
            // 
            this.IdVideo.Caption = "IdVideo";
            this.IdVideo.FieldName = "IdVideo";
            this.IdVideo.Name = "IdVideo";
            // 
            // IdProcesador
            // 
            this.IdProcesador.Caption = "IdProcesador";
            this.IdProcesador.FieldName = "IdProcesador";
            this.IdProcesador.Name = "IdProcesador";
            // 
            // IdSalidaDetalle
            // 
            this.IdSalidaDetalle.Caption = "IdSalidaDetalle";
            this.IdSalidaDetalle.FieldName = "IdSalidaDetalle";
            this.IdSalidaDetalle.Name = "IdSalidaDetalle";
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 131;
            this.label1.Text = "Número de Meses";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.AutoSize = true;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionar.Location = new System.Drawing.Point(660, 413);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 67);
            this.btnSeleccionar.TabIndex = 132;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnAgregarMeses
            // 
            this.btnAgregarMeses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMeses.AutoSize = true;
            this.btnAgregarMeses.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMeses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMeses.FlatAppearance.BorderSize = 0;
            this.btnAgregarMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMeses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMeses.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMeses.Image")));
            this.btnAgregarMeses.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarMeses.Location = new System.Drawing.Point(287, 12);
            this.btnAgregarMeses.Name = "btnAgregarMeses";
            this.btnAgregarMeses.Size = new System.Drawing.Size(68, 42);
            this.btnAgregarMeses.TabIndex = 133;
            this.btnAgregarMeses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarMeses.UseVisualStyleBackColor = false;
            this.btnAgregarMeses.Click += new System.EventHandler(this.btnAgregarMeses_Click);
            // 
            // frmProcesoRenovacionAgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 493);
            this.Controls.Add(this.btnAgregarMeses);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrueba);
            this.Controls.Add(this.txtCantMeses);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoRenovacionAgregarProducto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantMeses;
        private DevExpress.XtraGrid.GridControl dgvPrueba;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Pantalla;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Generacion;
        private DevExpress.XtraGrid.Columns.GridColumn Video;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidad;
        private DevExpress.XtraGrid.Columns.GridColumn fecIniContrato;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private DevExpress.XtraGrid.Columns.GridColumn IdVideo;
        private DevExpress.XtraGrid.Columns.GridColumn IdProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn IdSalidaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnAgregarMeses;
    }
}