namespace Vistas
{
    partial class frmReporteDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDisco));
            this.dgvDiscos = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TipoDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tamano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.Location = new System.Drawing.Point(12, 81);
            this.dgvDiscos.MainView = this.vista;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(521, 308);
            this.dgvDiscos.TabIndex = 137;
            this.dgvDiscos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.TipoDisco,
            this.Tamano,
            this.Capacidad,
            this.Cantidad,
            this.Estado});
            this.vista.GridControl = this.dgvDiscos;
            this.vista.Name = "vista";
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // TipoDisco
            // 
            this.TipoDisco.Caption = "TipoDisco";
            this.TipoDisco.FieldName = "TipoDisco";
            this.TipoDisco.MaxWidth = 100;
            this.TipoDisco.MinWidth = 100;
            this.TipoDisco.Name = "TipoDisco";
            this.TipoDisco.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoDisco.Visible = true;
            this.TipoDisco.VisibleIndex = 0;
            this.TipoDisco.Width = 100;
            // 
            // Tamano
            // 
            this.Tamano.Caption = "Tamano";
            this.Tamano.FieldName = "Tamano";
            this.Tamano.MaxWidth = 100;
            this.Tamano.MinWidth = 100;
            this.Tamano.Name = "Tamano";
            this.Tamano.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Tamano.Visible = true;
            this.Tamano.VisibleIndex = 1;
            this.Tamano.Width = 100;
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
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.MaxWidth = 100;
            this.Cantidad.MinWidth = 100;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 3;
            this.Cantidad.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.MaxWidth = 100;
            this.Estado.MinWidth = 100;
            this.Estado.Name = "Estado";
            this.Estado.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 4;
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
            this.btnExportar.Location = new System.Drawing.Point(458, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 138;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReporteDisco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 412);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvDiscos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteDisco";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Disco";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDiscos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn TipoDisco;
        private DevExpress.XtraGrid.Columns.GridColumn Tamano;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidad;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private System.Windows.Forms.Button btnExportar;
    }
}