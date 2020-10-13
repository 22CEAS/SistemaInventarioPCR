namespace Apolo
{
    partial class frmReporteMemoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMemoria));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMemorias = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Frecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Reporte Discos";
            // 
            // dgvMemorias
            // 
            this.dgvMemorias.Location = new System.Drawing.Point(40, 81);
            this.dgvMemorias.MainView = this.vista;
            this.dgvMemorias.Name = "dgvMemorias";
            this.dgvMemorias.Size = new System.Drawing.Size(621, 276);
            this.dgvMemorias.TabIndex = 135;
            this.dgvMemorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Modelo,
            this.TipoMemoria,
            this.Capacidad,
            this.Frecuencia,
            this.Cantidad,
            this.Estado});
            this.vista.GridControl = this.dgvMemorias;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Modelo
            // 
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "TipoMemoria";
            this.Modelo.MaxWidth = 100;
            this.Modelo.MinWidth = 100;
            this.Modelo.Name = "Modelo";
            this.Modelo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 0;
            this.Modelo.Width = 100;
            // 
            // TipoMemoria
            // 
            this.TipoMemoria.Caption = "TipoMemoria";
            this.TipoMemoria.FieldName = "Tipo2";
            this.TipoMemoria.MaxWidth = 100;
            this.TipoMemoria.MinWidth = 100;
            this.TipoMemoria.Name = "TipoMemoria";
            this.TipoMemoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoMemoria.Visible = true;
            this.TipoMemoria.VisibleIndex = 1;
            this.TipoMemoria.Width = 100;
            // 
            // Capacidad
            // 
            this.Capacidad.Caption = "Capacidad";
            this.Capacidad.FieldName = "Capacidad";
            this.Capacidad.MaxWidth = 100;
            this.Capacidad.MinWidth = 100;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Capacidad.Visible = true;
            this.Capacidad.VisibleIndex = 2;
            this.Capacidad.Width = 100;
            // 
            // Frecuencia
            // 
            this.Frecuencia.Caption = "Frecuencia";
            this.Frecuencia.FieldName = "frecuencia";
            this.Frecuencia.MaxWidth = 100;
            this.Frecuencia.MinWidth = 100;
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Frecuencia.Visible = true;
            this.Frecuencia.VisibleIndex = 3;
            this.Frecuencia.Width = 100;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.MaxWidth = 100;
            this.Cantidad.MinWidth = 100;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 4;
            this.Cantidad.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "estado";
            this.Estado.MaxWidth = 100;
            this.Estado.MinWidth = 100;
            this.Estado.Name = "Estado";
            this.Estado.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 5;
            this.Estado.Width = 100;
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
            this.btnExportar.Location = new System.Drawing.Point(586, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 136;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReporteMemoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 394);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvMemorias);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteMemoria";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Memoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgvMemorias;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn TipoMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidad;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Frecuencia;
        private System.Windows.Forms.Button btnExportar;
    }
}