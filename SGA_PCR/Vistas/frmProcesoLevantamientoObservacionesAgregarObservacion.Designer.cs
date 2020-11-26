﻿namespace Apolo
{
    partial class frmProcesoLevantamientoObservacionesAgregarObservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoLevantamientoObservacionesAgregarObservacion));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvObservaciones = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.dgvObs = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.seleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservacionDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.btnCancelar.Location = new System.Drawing.Point(696, 65);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.AutoSize = true;
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(773, 67);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 125;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvObservaciones
            // 
            this.dgvObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObservaciones.BackColor = System.Drawing.Color.White;
            this.dgvObservaciones.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvObservaciones.ForeColor = System.Drawing.Color.Black;
            this.dgvObservaciones.Location = new System.Drawing.Point(12, 12);
            this.dgvObservaciones.Name = "dgvObservaciones";
            this.dgvObservaciones.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvObservaciones.PrimaryGrid.AllowRowResize = true;
            this.dgvObservaciones.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.DataPropertyName = "";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn1.MinimumWidth = 80;
            gridColumn1.Name = "Seleccionar";
            gridColumn1.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn1.Width = 80;
            gridColumn2.AllowEdit = false;
            gridColumn2.DataPropertyName = "CodigoLC";
            gridColumn2.MinimumWidth = 100;
            gridColumn2.Name = "Código";
            gridColumn2.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn3.DataPropertyName = "ObservacionDeuda";
            gridColumn3.Name = "Observacion";
            gridColumn3.Width = 570;
            gridColumn4.DataPropertyName = "IdLC";
            gridColumn4.Name = "Id LC";
            gridColumn4.Visible = false;
            gridColumn5.DataPropertyName = "IdObservacion";
            gridColumn5.Name = "IdObservacion";
            gridColumn5.Visible = false;
            this.dgvObservaciones.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvObservaciones.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvObservaciones.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvObservaciones.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvObservaciones.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvObservaciones.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvObservaciones.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvObservaciones.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvObservaciones.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvObservaciones.PrimaryGrid.EnableFiltering = true;
            this.dgvObservaciones.PrimaryGrid.EnableRowFiltering = true;
            this.dgvObservaciones.PrimaryGrid.Filter.Visible = true;
            this.dgvObservaciones.PrimaryGrid.MultiSelect = false;
            this.dgvObservaciones.PrimaryGrid.NoRowsText = "No hay ninguna observacion de deuda para este cliente";
            this.dgvObservaciones.PrimaryGrid.NullString = "<<null>>";
            this.dgvObservaciones.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvObservaciones.PrimaryGrid.ShowRowHeaders = false;
            this.dgvObservaciones.PrimaryGrid.UseAlternateColumnStyle = true;
            this.dgvObservaciones.Size = new System.Drawing.Size(659, 176);
            this.dgvObservaciones.TabIndex = 124;
            this.dgvObservaciones.Text = "Tabla Laptops";
            // 
            // dgvObs
            // 
            this.dgvObs.Location = new System.Drawing.Point(12, 194);
            this.dgvObs.MainView = this.vista;
            this.dgvObs.Name = "dgvObs";
            this.dgvObs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemButtonEdit1});
            this.dgvObs.Size = new System.Drawing.Size(609, 321);
            this.dgvObs.TabIndex = 131;
            this.dgvObs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.seleccion,
            this.Codigo,
            this.ObservacionDeuda,
            this.IdLC,
            this.IdObservacion});
            this.vista.GridControl = this.dgvObs;
            this.vista.Name = "vista";
            this.vista.OptionsSelection.MultiSelect = true;
            this.vista.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // seleccion
            // 
            this.seleccion.Caption = "seleccion";
            this.seleccion.ColumnEdit = this.repositoryItemCheckEdit1;
            this.seleccion.FieldName = "seleccion";
            this.seleccion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.seleccion.MinWidth = 50;
            this.seleccion.Name = "seleccion";
            this.seleccion.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.seleccion.Visible = true;
            this.seleccion.VisibleIndex = 0;
            this.seleccion.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "CodigoLC";
            this.Codigo.MinWidth = 140;
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 140;
            // 
            // ObservacionDeuda
            // 
            this.ObservacionDeuda.Caption = "Observacion";
            this.ObservacionDeuda.FieldName = "ObservacionDeuda";
            this.ObservacionDeuda.MinWidth = 140;
            this.ObservacionDeuda.Name = "ObservacionDeuda";
            this.ObservacionDeuda.OptionsColumn.AllowEdit = false;
            this.ObservacionDeuda.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservacionDeuda.Visible = true;
            this.ObservacionDeuda.VisibleIndex = 2;
            this.ObservacionDeuda.Width = 140;
            // 
            // IdLC
            // 
            this.IdLC.Caption = "IdLC";
            this.IdLC.FieldName = "IdLC";
            this.IdLC.MinWidth = 100;
            this.IdLC.Name = "IdLC";
            this.IdLC.OptionsColumn.AllowEdit = false;
            this.IdLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.IdLC.Width = 100;
            // 
            // IdObservacion
            // 
            this.IdObservacion.Caption = "IdObservacion";
            this.IdObservacion.FieldName = "IdObservacion";
            this.IdObservacion.MinWidth = 100;
            this.IdObservacion.Name = "IdObservacion";
            this.IdObservacion.OptionsColumn.AllowEdit = false;
            this.IdObservacion.Width = 100;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // frmProcesoLevantamientoObservacionesAgregarObservacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 521);
            this.Controls.Add(this.dgvObs);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvObservaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoLevantamientoObservacionesAgregarObservacion";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvObservaciones;
        private DevExpress.XtraGrid.GridControl dgvObs;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn seleccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn ObservacionDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private DevExpress.XtraGrid.Columns.GridColumn IdObservacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}