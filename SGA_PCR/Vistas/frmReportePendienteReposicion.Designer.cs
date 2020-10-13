namespace Apolo
{
    partial class frmReportePendienteReposicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePendienteReposicion));
            this.dgvObservaciones = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservaciónDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaLevantamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservacionLevantamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaLevantamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObservaciones
            // 
            this.dgvObservaciones.Location = new System.Drawing.Point(27, 79);
            this.dgvObservaciones.MainView = this.vista;
            this.dgvObservaciones.Name = "dgvObservaciones";
            this.dgvObservaciones.Size = new System.Drawing.Size(1018, 260);
            this.dgvObservaciones.TabIndex = 133;
            this.dgvObservaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Cliente,
            this.RUC,
            this.CodigoLC,
            this.ObservaciónDeuda,
            this.GuiaLevantamiento,
            this.ObservacionLevantamiento,
            this.FechaLevantamiento,
            this.Estado});
            this.vista.GridControl = this.dgvObservaciones;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.MaxWidth = 150;
            this.Cliente.MinWidth = 150;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 150;
            // 
            // RUC
            // 
            this.RUC.Caption = "RUC";
            this.RUC.FieldName = "RUC";
            this.RUC.MaxWidth = 75;
            this.RUC.MinWidth = 75;
            this.RUC.Name = "RUC";
            this.RUC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RUC.Visible = true;
            this.RUC.VisibleIndex = 1;
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
            this.CodigoLC.VisibleIndex = 2;
            this.CodigoLC.Width = 100;
            // 
            // ObservaciónDeuda
            // 
            this.ObservaciónDeuda.Caption = "ObservaciónDeuda";
            this.ObservaciónDeuda.FieldName = "ObservacionDeuda";
            this.ObservaciónDeuda.MaxWidth = 250;
            this.ObservaciónDeuda.MinWidth = 250;
            this.ObservaciónDeuda.Name = "ObservaciónDeuda";
            this.ObservaciónDeuda.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservaciónDeuda.Visible = true;
            this.ObservaciónDeuda.VisibleIndex = 3;
            this.ObservaciónDeuda.Width = 250;
            // 
            // GuiaLevantamiento
            // 
            this.GuiaLevantamiento.Caption = "GuiaLevantamiento";
            this.GuiaLevantamiento.FieldName = "GuiaLevantamiento";
            this.GuiaLevantamiento.MaxWidth = 100;
            this.GuiaLevantamiento.MinWidth = 100;
            this.GuiaLevantamiento.Name = "GuiaLevantamiento";
            this.GuiaLevantamiento.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GuiaLevantamiento.Visible = true;
            this.GuiaLevantamiento.VisibleIndex = 4;
            this.GuiaLevantamiento.Width = 100;
            // 
            // ObservacionLevantamiento
            // 
            this.ObservacionLevantamiento.Caption = "ObservacionLevantamiento";
            this.ObservacionLevantamiento.FieldName = "ObservacionLevantamiento";
            this.ObservacionLevantamiento.MaxWidth = 250;
            this.ObservacionLevantamiento.MinWidth = 250;
            this.ObservacionLevantamiento.Name = "ObservacionLevantamiento";
            this.ObservacionLevantamiento.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservacionLevantamiento.Visible = true;
            this.ObservacionLevantamiento.VisibleIndex = 5;
            this.ObservacionLevantamiento.Width = 250;
            // 
            // FechaLevantamiento
            // 
            this.FechaLevantamiento.Caption = "FechaLevantamiento";
            this.FechaLevantamiento.FieldName = "FechaLevantamiento";
            this.FechaLevantamiento.MaxWidth = 75;
            this.FechaLevantamiento.MinWidth = 75;
            this.FechaLevantamiento.Name = "FechaLevantamiento";
            this.FechaLevantamiento.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaLevantamiento.Visible = true;
            this.FechaLevantamiento.VisibleIndex = 6;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.MaxWidth = 80;
            this.Estado.MinWidth = 80;
            this.Estado.Name = "Estado";
            this.Estado.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 80;
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
            this.btnExportar.Location = new System.Drawing.Point(970, 10);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 134;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReportePendienteReposicion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 372);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvObservaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePendienteReposicion";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Observaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgvObservaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn RUC;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn ObservaciónDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaLevantamiento;
        private DevExpress.XtraGrid.Columns.GridColumn ObservacionLevantamiento;
        private DevExpress.XtraGrid.Columns.GridColumn FechaLevantamiento;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private System.Windows.Forms.Button btnExportar;
    }
}