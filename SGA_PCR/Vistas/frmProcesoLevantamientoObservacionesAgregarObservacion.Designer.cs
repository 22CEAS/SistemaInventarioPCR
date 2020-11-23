namespace Apolo
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
            this.btnCancelar.Location = new System.Drawing.Point(688, 293);
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
            this.btnGrabar.Location = new System.Drawing.Point(765, 295);
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
            this.dgvObservaciones.Location = new System.Drawing.Point(22, 40);
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
            this.dgvObservaciones.Size = new System.Drawing.Size(832, 247);
            this.dgvObservaciones.TabIndex = 124;
            this.dgvObservaciones.Text = "Tabla Laptops";
            // 
            // frmProcesoLevantamientoObservacionesAgregarObservacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 370);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvObservaciones;
    }
}