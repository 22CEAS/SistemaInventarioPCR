namespace Vistas
{
    partial class frmProcesoProductoCambio
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn11 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn12 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn14 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.superGridControl5 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.label14 = new System.Windows.Forms.Label();
            this.superGridControl4 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnEditarLicencia = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.superGridControl3 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.superGridControl2 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnEditarDisco = new System.Windows.Forms.Button();
            this.btnEditarMemoria = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // superGridControl5
            // 
            this.superGridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl5.BackColor = System.Drawing.Color.White;
            this.superGridControl5.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl5.ForeColor = System.Drawing.Color.Black;
            this.superGridControl5.Location = new System.Drawing.Point(12, 62);
            this.superGridControl5.Name = "superGridControl5";
            this.superGridControl5.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl5.PrimaryGrid.AllowRowResize = true;
            this.superGridControl5.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Código";
            gridColumn1.Width = 110;
            gridColumn2.Name = "Equipo";
            gridColumn2.Width = 110;
            gridColumn3.FilterAutoScan = true;
            gridColumn3.Name = "Modelo";
            gridColumn3.Width = 110;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn4.Name = "Marca";
            gridColumn4.Width = 110;
            gridColumn5.Name = "Pantalla";
            gridColumn5.Width = 110;
            gridColumn6.Name = "Procesador";
            gridColumn7.Name = "Generación";
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn7);
            this.superGridControl5.PrimaryGrid.DefaultRowHeight = 24;
            this.superGridControl5.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl5.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl5.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl5.PrimaryGrid.EnableFiltering = true;
            this.superGridControl5.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl5.PrimaryGrid.Filter.Visible = true;
            this.superGridControl5.PrimaryGrid.NullString = "<<null>>";
            this.superGridControl5.PrimaryGrid.RowHeaderWidth = 45;
            this.superGridControl5.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl5.Size = new System.Drawing.Size(519, 472);
            this.superGridControl5.TabIndex = 63;
            this.superGridControl5.Text = "superGridControl5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 16);
            this.label14.TabIndex = 62;
            this.label14.Text = "Productos seleccionados:";
            // 
            // superGridControl4
            // 
            this.superGridControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.superGridControl4.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl4.ForeColor = System.Drawing.Color.Black;
            this.superGridControl4.Location = new System.Drawing.Point(570, 378);
            this.superGridControl4.Name = "superGridControl4";
            gridColumn8.Name = "Codigo";
            gridColumn9.Name = "frecuencuia";
            gridColumn10.Name = "Generación";
            gridColumn11.Name = "Contraseña";
            this.superGridControl4.PrimaryGrid.Columns.Add(gridColumn8);
            this.superGridControl4.PrimaryGrid.Columns.Add(gridColumn9);
            this.superGridControl4.PrimaryGrid.Columns.Add(gridColumn10);
            this.superGridControl4.PrimaryGrid.Columns.Add(gridColumn11);
            this.superGridControl4.Size = new System.Drawing.Size(287, 99);
            this.superGridControl4.TabIndex = 61;
            this.superGridControl4.Text = "superGridControl4";
            // 
            // btnEditarLicencia
            // 
            this.btnEditarLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLicencia.Location = new System.Drawing.Point(788, 347);
            this.btnEditarLicencia.Name = "btnEditarLicencia";
            this.btnEditarLicencia.Size = new System.Drawing.Size(69, 25);
            this.btnEditarLicencia.TabIndex = 60;
            this.btnEditarLicencia.Text = "Editar";
            this.btnEditarLicencia.UseVisualStyleBackColor = true;
            this.btnEditarLicencia.Click += new System.EventHandler(this.btnEditarLicencia_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(572, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Licencia:";
            // 
            // superGridControl3
            // 
            this.superGridControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.superGridControl3.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl3.ForeColor = System.Drawing.Color.Black;
            this.superGridControl3.Location = new System.Drawing.Point(570, 219);
            this.superGridControl3.Name = "superGridControl3";
            gridColumn12.Name = "Codigo";
            gridColumn13.Name = "frecuencuia";
            gridColumn14.Name = "Generación";
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn12);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn13);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn14);
            this.superGridControl3.Size = new System.Drawing.Size(287, 99);
            this.superGridControl3.TabIndex = 58;
            this.superGridControl3.Text = "superGridControl3";
            // 
            // superGridControl2
            // 
            this.superGridControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl2.ForeColor = System.Drawing.Color.Black;
            this.superGridControl2.Location = new System.Drawing.Point(570, 62);
            this.superGridControl2.Name = "superGridControl2";
            gridColumn15.Name = "Codigo";
            gridColumn16.Name = "frecuencuia";
            gridColumn17.Name = "Generación";
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn15);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn16);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn17);
            this.superGridControl2.Size = new System.Drawing.Size(287, 99);
            this.superGridControl2.TabIndex = 57;
            this.superGridControl2.Text = "superGridControl2";
            // 
            // btnEditarDisco
            // 
            this.btnEditarDisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarDisco.Location = new System.Drawing.Point(788, 188);
            this.btnEditarDisco.Name = "btnEditarDisco";
            this.btnEditarDisco.Size = new System.Drawing.Size(69, 25);
            this.btnEditarDisco.TabIndex = 56;
            this.btnEditarDisco.Text = "Editar";
            this.btnEditarDisco.UseVisualStyleBackColor = true;
            // 
            // btnEditarMemoria
            // 
            this.btnEditarMemoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMemoria.Location = new System.Drawing.Point(788, 31);
            this.btnEditarMemoria.Name = "btnEditarMemoria";
            this.btnEditarMemoria.Size = new System.Drawing.Size(69, 25);
            this.btnEditarMemoria.TabIndex = 55;
            this.btnEditarMemoria.Text = "Editar";
            this.btnEditarMemoria.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(572, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Disco Duro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(572, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = "Memoria:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Location = new System.Drawing.Point(723, 509);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(134, 25);
            this.btnSeleccionar.TabIndex = 64;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmProductoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 596);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.superGridControl5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.superGridControl4);
            this.Controls.Add(this.btnEditarLicencia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.superGridControl3);
            this.Controls.Add(this.superGridControl2);
            this.Controls.Add(this.btnEditarDisco);
            this.Controls.Add(this.btnEditarMemoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "frmProductoCambio";
            this.Text = "frmProductoCambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl5;
        private System.Windows.Forms.Label label14;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl4;
        private System.Windows.Forms.Button btnEditarLicencia;
        private System.Windows.Forms.Label label13;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl2;
        private System.Windows.Forms.Button btnEditarDisco;
        private System.Windows.Forms.Button btnEditarMemoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}