﻿namespace Apolo
{
    partial class frmArchivoCrearCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivoCrearCliente));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn24 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn25 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn27 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn28 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn29 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn30 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvCliente = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbKam = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(181, 31);
            this.txtNroDocumento.MaxLength = 11;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(152, 20);
            this.txtNroDocumento.TabIndex = 83;
            this.txtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumento_KeyPress);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(371, 31);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(400, 20);
            this.txtRazonSocial.TabIndex = 84;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 85;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(340, 62);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 20);
            this.txtTelefono.TabIndex = 87;
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
            this.btnImprimir.Location = new System.Drawing.Point(701, 394);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 63);
            this.btnImprimir.TabIndex = 97;
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
            this.btnCancelar.Location = new System.Drawing.Point(696, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 96;
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
            this.btnEditar.Location = new System.Drawing.Point(696, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 65);
            this.btnEditar.TabIndex = 95;
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
            this.btnNuevo.Location = new System.Drawing.Point(696, 108);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 94;
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
            this.btnGrabar.Location = new System.Drawing.Point(696, 254);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 93;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackColor = System.Drawing.Color.White;
            this.dgvCliente.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvCliente.ForeColor = System.Drawing.Color.Black;
            this.dgvCliente.Location = new System.Drawing.Point(23, 108);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvCliente.PrimaryGrid.AllowRowResize = true;
            this.dgvCliente.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn21.AllowEdit = false;
            gridColumn21.DataPropertyName = "idCliente";
            gridColumn21.MinimumWidth = 50;
            gridColumn21.Name = "Id";
            gridColumn21.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn21.Width = 50;
            gridColumn22.AllowEdit = false;
            gridColumn22.DataPropertyName = "nroDocumento";
            gridColumn22.MinimumWidth = 100;
            gridColumn22.Name = "Nro Documento";
            gridColumn22.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn23.AllowEdit = false;
            gridColumn23.DataPropertyName = "nombre_razonSocial";
            gridColumn23.MinimumWidth = 250;
            gridColumn23.Name = "Nombre";
            gridColumn23.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn23.Width = 250;
            gridColumn24.AllowEdit = false;
            gridColumn24.DataPropertyName = "nombreKam";
            gridColumn24.MinimumWidth = 150;
            gridColumn24.Name = "Nombre KAM";
            gridColumn24.Width = 150;
            gridColumn25.AllowEdit = false;
            gridColumn25.DataPropertyName = "estado";
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn25.MinimumWidth = 100;
            gridColumn25.Name = "Activo";
            gridColumn26.AllowEdit = false;
            gridColumn26.DataPropertyName = "tipoDocumento";
            gridColumn26.FilterAutoScan = true;
            gridColumn26.MinimumWidth = 140;
            gridColumn26.Name = "Tipo Documento";
            gridColumn26.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn26.Visible = false;
            gridColumn26.Width = 140;
            gridColumn27.AllowEdit = false;
            gridColumn27.DataPropertyName = "telefono";
            gridColumn27.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn27.MinimumWidth = 100;
            gridColumn27.Name = "Telefono";
            gridColumn27.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            gridColumn27.Visible = false;
            gridColumn28.AllowEdit = false;
            gridColumn28.DataPropertyName = "email";
            gridColumn28.Name = "Email";
            gridColumn28.Visible = false;
            gridColumn29.AllowEdit = false;
            gridColumn29.DataPropertyName = "idKAM";
            gridColumn29.Name = "Id Kam";
            gridColumn29.Visible = false;
            gridColumn30.DataPropertyName = "nombreTipoDocumento";
            gridColumn30.Name = "Nombre Tipo Documento";
            gridColumn30.Visible = false;
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn21);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn22);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn23);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn24);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn25);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn26);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn27);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn28);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn29);
            this.dgvCliente.PrimaryGrid.Columns.Add(gridColumn30);
            this.dgvCliente.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvCliente.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvCliente.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvCliente.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvCliente.PrimaryGrid.EnableFiltering = true;
            this.dgvCliente.PrimaryGrid.EnableRowFiltering = true;
            this.dgvCliente.PrimaryGrid.Filter.Visible = true;
            this.dgvCliente.PrimaryGrid.MultiSelect = false;
            this.dgvCliente.PrimaryGrid.NoRowsText = "No hay ningun Sucursal Cliente, cree un sucursal";
            this.dgvCliente.PrimaryGrid.NullString = "<<null>>";
            this.dgvCliente.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvCliente.PrimaryGrid.ShowRowHeaders = false;
            this.dgvCliente.Size = new System.Drawing.Size(650, 350);
            this.dgvCliente.TabIndex = 98;
            this.dgvCliente.Text = "Tabla Sucursal Clientes";
            this.dgvCliente.Click += new System.EventHandler(this.dgvCliente_Click);
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
            this.labelX1.Location = new System.Drawing.Point(510, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 16);
            this.labelX1.TabIndex = 100;
            this.labelX1.Text = "KAM: ";
            // 
            // cmbKam
            // 
            this.cmbKam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKam.FormattingEnabled = true;
            this.cmbKam.Location = new System.Drawing.Point(556, 62);
            this.cmbKam.Name = "cmbKam";
            this.cmbKam.Size = new System.Drawing.Size(117, 21);
            this.cmbKam.TabIndex = 99;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(23, 31);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoDocumento.TabIndex = 101;
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
            this.labelX2.Location = new System.Drawing.Point(279, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(55, 16);
            this.labelX2.TabIndex = 102;
            this.labelX2.Text = "Telefono:";
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
            this.labelX3.Location = new System.Drawing.Point(23, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(37, 16);
            this.labelX3.TabIndex = 103;
            this.labelX3.Text = "Email:";
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
            this.labelX4.Location = new System.Drawing.Point(371, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(127, 16);
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Razon Social/Nombre:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(181, 12);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 16);
            this.labelX5.TabIndex = 105;
            this.labelX5.Text = "N° Documento:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(23, 12);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 16);
            this.labelX6.TabIndex = 106;
            this.labelX6.Text = "Tipo documento:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbActivo.Checked = true;
            this.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActivo.Location = new System.Drawing.Point(709, 66);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(62, 17);
            this.chbActivo.TabIndex = 107;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // frmCrearCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbKam);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNroDocumento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearCliente";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvCliente;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cmbKam;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        internal DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.CheckBox chbActivo;
    }
}