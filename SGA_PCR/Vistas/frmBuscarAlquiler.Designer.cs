﻿namespace Vistas
{
    partial class frmBuscarAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAlquiler));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelNumOP = new System.Windows.Forms.GroupBox();
            this.txtNumAlquiler = new System.Windows.Forms.TextBox();
            this.rbtnFiltros = new System.Windows.Forms.RadioButton();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.GroupBox();
            this.cmbKam = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.chbCliente = new System.Windows.Forms.CheckBox();
            this.chbKam = new System.Windows.Forms.CheckBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.chbFecProceso = new System.Windows.Forms.CheckBox();
            this.dtpFecProceso = new System.Windows.Forms.DateTimePicker();
            this.rbtnNumAlquiler = new System.Windows.Forms.RadioButton();
            this.dgvAlquiler = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panelNumOP.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNumOP
            // 
            this.panelNumOP.Controls.Add(this.txtNumAlquiler);
            this.panelNumOP.Location = new System.Drawing.Point(15, 224);
            this.panelNumOP.Name = "panelNumOP";
            this.panelNumOP.Size = new System.Drawing.Size(722, 41);
            this.panelNumOP.TabIndex = 56;
            this.panelNumOP.TabStop = false;
            // 
            // txtNumAlquiler
            // 
            this.txtNumAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlquiler.Location = new System.Drawing.Point(13, 13);
            this.txtNumAlquiler.MaxLength = 5;
            this.txtNumAlquiler.Name = "txtNumAlquiler";
            this.txtNumAlquiler.Size = new System.Drawing.Size(172, 22);
            this.txtNumAlquiler.TabIndex = 12;
            this.txtNumAlquiler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAlquiler_KeyPress);
            // 
            // rbtnFiltros
            // 
            this.rbtnFiltros.AutoSize = true;
            this.rbtnFiltros.Checked = true;
            this.rbtnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltros.Location = new System.Drawing.Point(21, 12);
            this.rbtnFiltros.Name = "rbtnFiltros";
            this.rbtnFiltros.Size = new System.Drawing.Size(102, 20);
            this.rbtnFiltros.TabIndex = 55;
            this.rbtnFiltros.TabStop = true;
            this.rbtnFiltros.Text = "Buscar Por";
            this.rbtnFiltros.UseVisualStyleBackColor = true;
            this.rbtnFiltros.CheckedChanged += new System.EventHandler(this.rbtnFiltros_CheckedChanged);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(755, 207);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 67);
            this.btnSeleccionar.TabIndex = 54;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(755, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 60);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.cmbKam);
            this.panelFiltros.Controls.Add(this.cmbCliente);
            this.panelFiltros.Controls.Add(this.chbEstado);
            this.panelFiltros.Controls.Add(this.chbCliente);
            this.panelFiltros.Controls.Add(this.chbKam);
            this.panelFiltros.Controls.Add(this.cmbEstado);
            this.panelFiltros.Controls.Add(this.chbFecProceso);
            this.panelFiltros.Controls.Add(this.dtpFecProceso);
            this.panelFiltros.Location = new System.Drawing.Point(15, 29);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(722, 149);
            this.panelFiltros.TabIndex = 51;
            this.panelFiltros.TabStop = false;
            // 
            // cmbKam
            // 
            this.cmbKam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKam.FormattingEnabled = true;
            this.cmbKam.Location = new System.Drawing.Point(97, 37);
            this.cmbKam.Name = "cmbKam";
            this.cmbKam.Size = new System.Drawing.Size(274, 24);
            this.cmbKam.TabIndex = 134;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(97, 104);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(274, 24);
            this.cmbCliente.TabIndex = 133;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEstado.Location = new System.Drawing.Point(394, 104);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(84, 20);
            this.chbEstado.TabIndex = 47;
            this.chbEstado.Text = "Estados";
            this.chbEstado.UseVisualStyleBackColor = true;
            this.chbEstado.CheckedChanged += new System.EventHandler(this.chbEstado_CheckedChanged);
            // 
            // chbCliente
            // 
            this.chbCliente.AutoSize = true;
            this.chbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCliente.Location = new System.Drawing.Point(6, 104);
            this.chbCliente.Name = "chbCliente";
            this.chbCliente.Size = new System.Drawing.Size(75, 20);
            this.chbCliente.TabIndex = 46;
            this.chbCliente.Text = "Cliente";
            this.chbCliente.UseVisualStyleBackColor = true;
            this.chbCliente.CheckedChanged += new System.EventHandler(this.chbCliente_CheckedChanged);
            // 
            // chbKam
            // 
            this.chbKam.AutoSize = true;
            this.chbKam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbKam.Location = new System.Drawing.Point(10, 41);
            this.chbKam.Name = "chbKam";
            this.chbKam.Size = new System.Drawing.Size(58, 20);
            this.chbKam.TabIndex = 45;
            this.chbKam.Text = "KAM";
            this.chbKam.UseVisualStyleBackColor = true;
            this.chbKam.CheckedChanged += new System.EventHandler(this.chbKam_CheckedChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(499, 102);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(182, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // chbFecProceso
            // 
            this.chbFecProceso.AutoSize = true;
            this.chbFecProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFecProceso.Location = new System.Drawing.Point(393, 43);
            this.chbFecProceso.Name = "chbFecProceso";
            this.chbFecProceso.Size = new System.Drawing.Size(119, 20);
            this.chbFecProceso.TabIndex = 44;
            this.chbFecProceso.Text = "Fec. Proceso";
            this.chbFecProceso.UseVisualStyleBackColor = true;
            this.chbFecProceso.CheckedChanged += new System.EventHandler(this.chbFecProceso_CheckedChanged);
            // 
            // dtpFecProceso
            // 
            this.dtpFecProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecProceso.CustomFormat = "dd-MM-yyyy";
            this.dtpFecProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecProceso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecProceso.Location = new System.Drawing.Point(518, 43);
            this.dtpFecProceso.Name = "dtpFecProceso";
            this.dtpFecProceso.Size = new System.Drawing.Size(163, 22);
            this.dtpFecProceso.TabIndex = 8;
            // 
            // rbtnNumAlquiler
            // 
            this.rbtnNumAlquiler.AutoSize = true;
            this.rbtnNumAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNumAlquiler.Location = new System.Drawing.Point(17, 204);
            this.rbtnNumAlquiler.Name = "rbtnNumAlquiler";
            this.rbtnNumAlquiler.Size = new System.Drawing.Size(114, 20);
            this.rbtnNumAlquiler.TabIndex = 52;
            this.rbtnNumAlquiler.Text = "Num Alquiler";
            this.rbtnNumAlquiler.UseVisualStyleBackColor = true;
            this.rbtnNumAlquiler.CheckedChanged += new System.EventHandler(this.rbtnNumAlquiler_CheckedChanged);
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlquiler.BackColor = System.Drawing.Color.White;
            this.dgvAlquiler.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvAlquiler.ForeColor = System.Drawing.Color.Black;
            this.dgvAlquiler.Location = new System.Drawing.Point(12, 295);
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvAlquiler.PrimaryGrid.AllowRowResize = true;
            this.dgvAlquiler.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.AllowEdit = false;
            gridColumn1.DataPropertyName = "idAlquiler";
            gridColumn1.Name = "ID ALQUILER";
            gridColumn2.AllowEdit = false;
            gridColumn2.DataPropertyName = "nombreCliente";
            gridColumn2.Name = "CLIENTE";
            gridColumn2.Width = 210;
            gridColumn3.AllowEdit = false;
            gridColumn3.DataPropertyName = "nombreKam";
            gridColumn3.MinimumWidth = 100;
            gridColumn3.Name = "KAM";
            gridColumn3.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn3.Width = 200;
            gridColumn4.AllowEdit = false;
            gridColumn4.DataPropertyName = "fechaProceso";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            gridColumn4.MinimumWidth = 100;
            gridColumn4.Name = "FECHA PROCESO";
            gridColumn4.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn4.Width = 115;
            gridColumn5.AllowEdit = false;
            gridColumn5.DataPropertyName = "estado";
            gridColumn5.MinimumWidth = 100;
            gridColumn5.Name = "ESTADO";
            gridColumn6.DataPropertyName = "idEstado";
            gridColumn6.Name = "idEstado";
            gridColumn6.Visible = false;
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvAlquiler.PrimaryGrid.Columns.Add(gridColumn6);
            this.dgvAlquiler.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvAlquiler.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAlquiler.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAlquiler.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvAlquiler.PrimaryGrid.EnableFiltering = true;
            this.dgvAlquiler.PrimaryGrid.EnableRowFiltering = true;
            this.dgvAlquiler.PrimaryGrid.Filter.Visible = true;
            this.dgvAlquiler.PrimaryGrid.MultiSelect = false;
            this.dgvAlquiler.PrimaryGrid.NoRowsText = "No hay ningun alquiler";
            this.dgvAlquiler.PrimaryGrid.NullString = "<<null>>";
            this.dgvAlquiler.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvAlquiler.PrimaryGrid.ShowRowHeaders = false;
            this.dgvAlquiler.PrimaryGrid.UseAlternateColumnStyle = true;
            this.dgvAlquiler.Size = new System.Drawing.Size(725, 266);
            this.dgvAlquiler.TabIndex = 135;
            this.dgvAlquiler.Text = "Tabla Laptops";
            // 
            // frmBuscarAlquiler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 606);
            this.Controls.Add(this.dgvAlquiler);
            this.Controls.Add(this.panelNumOP);
            this.Controls.Add(this.rbtnFiltros);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.rbtnNumAlquiler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarAlquiler";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarAlquiler";
            this.panelNumOP.ResumeLayout(false);
            this.panelNumOP.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panelNumOP;
        private System.Windows.Forms.TextBox txtNumAlquiler;
        private System.Windows.Forms.RadioButton rbtnFiltros;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox panelFiltros;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.CheckBox chbCliente;
        private System.Windows.Forms.CheckBox chbKam;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox chbFecProceso;
        private System.Windows.Forms.DateTimePicker dtpFecProceso;
        private System.Windows.Forms.RadioButton rbtnNumAlquiler;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbKam;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvAlquiler;
    }
}