namespace Apolo
{
    partial class frmArchivoCrearMemoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivoCrearMemoria));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn9 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn10 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbCapacidad = new System.Windows.Forms.ComboBox();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.dgvMemoria = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(22, 263);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 16);
            this.labelX3.TabIndex = 104;
            this.labelX3.Text = "Capacidad:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(22, 173);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 16);
            this.labelX2.TabIndex = 103;
            this.labelX2.Text = "Frecuencia:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(22, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(47, 16);
            this.labelX1.TabIndex = 102;
            this.labelX1.Text = "Modelo:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbActivo.Checked = true;
            this.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActivo.Location = new System.Drawing.Point(22, 354);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(62, 17);
            this.chbActivo.TabIndex = 101;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(730, 314);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 63);
            this.btnImprimir.TabIndex = 100;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(725, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSize = true;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(725, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 65);
            this.btnEditar.TabIndex = 98;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(725, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 97;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnGrabar.Location = new System.Drawing.Point(725, 174);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 96;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbCapacidad
            // 
            this.cmbCapacidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCapacidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCapacidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCapacidad.FormattingEnabled = true;
            this.cmbCapacidad.Location = new System.Drawing.Point(22, 285);
            this.cmbCapacidad.Name = "cmbCapacidad";
            this.cmbCapacidad.Size = new System.Drawing.Size(117, 21);
            this.cmbCapacidad.TabIndex = 95;
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(22, 195);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(117, 21);
            this.cmbFrecuencia.TabIndex = 94;
            // 
            // cmbModelo
            // 
            this.cmbModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(22, 64);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(117, 21);
            this.cmbModelo.TabIndex = 93;
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // dgvMemoria
            // 
            this.dgvMemoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemoria.BackColor = System.Drawing.Color.White;
            this.dgvMemoria.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvMemoria.ForeColor = System.Drawing.Color.Black;
            this.dgvMemoria.Location = new System.Drawing.Point(158, 25);
            this.dgvMemoria.Name = "dgvMemoria";
            this.dgvMemoria.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvMemoria.PrimaryGrid.AllowRowResize = true;
            this.dgvMemoria.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.AllowEdit = false;
            gridColumn1.DataPropertyName = "idMemoria";
            gridColumn1.MinimumWidth = 50;
            gridColumn1.Name = "Id";
            gridColumn1.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn1.Width = 50;
            gridColumn2.AllowEdit = false;
            gridColumn2.DataPropertyName = "tipo";
            gridColumn2.FilterAutoScan = true;
            gridColumn2.MinimumWidth = 100;
            gridColumn2.Name = "Modelo";
            gridColumn2.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn3.DataPropertyName = "tipo2";
            gridColumn3.Name = "Tipo";
            gridColumn4.AllowEdit = false;
            gridColumn4.DataPropertyName = "frecuencia";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn4.MinimumWidth = 100;
            gridColumn4.Name = "Frecuencia";
            gridColumn4.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn5.AllowEdit = false;
            gridColumn5.DataPropertyName = "capacidad";
            gridColumn5.MinimumWidth = 100;
            gridColumn5.Name = "Capacidad";
            gridColumn5.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn6.AllowEdit = false;
            gridColumn6.DataPropertyName = "estado";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn6.MinimumWidth = 100;
            gridColumn6.Name = "Activo";
            gridColumn6.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn7.AllowEdit = false;
            gridColumn7.DataPropertyName = "idTipo";
            gridColumn7.MinimumWidth = 100;
            gridColumn7.Name = "idModelo";
            gridColumn7.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn7.Visible = false;
            gridColumn8.DataPropertyName = "idTipo2";
            gridColumn8.Name = "idTipo";
            gridColumn8.Visible = false;
            gridColumn9.AllowEdit = false;
            gridColumn9.DataPropertyName = "idBusFrecuencia";
            gridColumn9.MinimumWidth = 100;
            gridColumn9.Name = "idFrecuencia";
            gridColumn9.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn9.Visible = false;
            gridColumn10.AllowEdit = false;
            gridColumn10.DataPropertyName = "idCapacidad";
            gridColumn10.MinimumWidth = 100;
            gridColumn10.Name = "idCapacidad";
            gridColumn10.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn10.Visible = false;
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn6);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn7);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn8);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn9);
            this.dgvMemoria.PrimaryGrid.Columns.Add(gridColumn10);
            this.dgvMemoria.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvMemoria.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMemoria.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMemoria.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvMemoria.PrimaryGrid.EnableFiltering = true;
            this.dgvMemoria.PrimaryGrid.EnableRowFiltering = true;
            this.dgvMemoria.PrimaryGrid.Filter.Visible = true;
            this.dgvMemoria.PrimaryGrid.MultiSelect = false;
            this.dgvMemoria.PrimaryGrid.NoRowsText = "No hay ninguna memoria, cree una memoria";
            this.dgvMemoria.PrimaryGrid.NullString = "<<null>>";
            this.dgvMemoria.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvMemoria.PrimaryGrid.ShowRowHeaders = false;
            this.dgvMemoria.Size = new System.Drawing.Size(550, 352);
            this.dgvMemoria.TabIndex = 92;
            this.dgvMemoria.Text = "Tabla Memoria";
            this.dgvMemoria.Click += new System.EventHandler(this.dgvMemoria_Click);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(22, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(30, 16);
            this.labelX4.TabIndex = 106;
            this.labelX4.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(22, 127);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(117, 21);
            this.cmbTipo.TabIndex = 105;
            // 
            // frmArchivoCrearMemoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 414);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbCapacidad);
            this.Controls.Add(this.cmbFrecuencia);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.dgvMemoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArchivoCrearMemoria";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Memoria";
            this.Load += new System.EventHandler(this.frmArchivoCrearMemoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbCapacidad;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.ComboBox cmbModelo;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvMemoria;
        internal DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}