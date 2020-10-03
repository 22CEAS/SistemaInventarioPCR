namespace Vistas
{
    partial class frmReporteStocksLaptops
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Video = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadDisco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadDisco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemoriaRam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerieFabrica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(390, 12);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProducto.TabIndex = 36;
            this.btnAgregarProducto.Text = "Exportar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Reporte de Laptops";
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Location = new System.Drawing.Point(12, 71);
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1145, 356);
            this.dgvLaptops.TabIndex = 132;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista,
            this.gridView1,
            this.gridView2});
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
            this.CodigoLC,
            this.Marca,
            this.Modelo,
            this.Procesador,
            this.Video,
            this.CapacidadVideo,
            this.Disco1,
            this.CapacidadDisco1,
            this.Disco2,
            this.CapacidadDisco2,
            this.MemoriaRam,
            this.Estado,
            this.Cliente,
            this.Ubicacion,
            this.SerieFabrica});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // CodigoLC
            // 
            this.CodigoLC.Caption = "CodigoLC";
            this.CodigoLC.FieldName = "Codigo";
            this.CodigoLC.MaxWidth = 130;
            this.CodigoLC.MinWidth = 130;
            this.CodigoLC.Name = "CodigoLC";
            this.CodigoLC.Visible = true;
            this.CodigoLC.VisibleIndex = 0;
            this.CodigoLC.Width = 130;
            // 
            // Marca
            // 
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "MarcaLC";
            this.Marca.MaxWidth = 100;
            this.Marca.MinWidth = 100;
            this.Marca.Name = "Marca";
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 1;
            this.Marca.Width = 100;
            // 
            // Modelo
            // 
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "NombreModeloLC";
            this.Modelo.MaxWidth = 200;
            this.Modelo.MinWidth = 200;
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 2;
            this.Modelo.Width = 200;
            // 
            // Procesador
            // 
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "TipoProcesador";
            this.Procesador.MaxWidth = 100;
            this.Procesador.MinWidth = 100;
            this.Procesador.Name = "Procesador";
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 3;
            this.Procesador.Width = 100;
            // 
            // Video
            // 
            this.Video.Caption = "Video";
            this.Video.FieldName = "NombreModeloVideo";
            this.Video.MaxWidth = 170;
            this.Video.MinWidth = 170;
            this.Video.Name = "Video";
            this.Video.Visible = true;
            this.Video.VisibleIndex = 4;
            this.Video.Width = 170;
            // 
            // CapacidadVideo
            // 
            this.CapacidadVideo.Caption = "CapacidadVideo";
            this.CapacidadVideo.FieldName = "CapacidadVideo";
            this.CapacidadVideo.MaxWidth = 130;
            this.CapacidadVideo.MinWidth = 130;
            this.CapacidadVideo.Name = "CapacidadVideo";
            this.CapacidadVideo.Visible = true;
            this.CapacidadVideo.VisibleIndex = 5;
            this.CapacidadVideo.Width = 130;
            // 
            // Disco1
            // 
            this.Disco1.Caption = "Disco1";
            this.Disco1.FieldName = "Disco1";
            this.Disco1.MaxWidth = 70;
            this.Disco1.MinWidth = 70;
            this.Disco1.Name = "Disco1";
            this.Disco1.Visible = true;
            this.Disco1.VisibleIndex = 6;
            this.Disco1.Width = 70;
            // 
            // CapacidadDisco1
            // 
            this.CapacidadDisco1.Caption = "CapacidadDisco1";
            this.CapacidadDisco1.FieldName = "CapacidadDisco1";
            this.CapacidadDisco1.MaxWidth = 130;
            this.CapacidadDisco1.MinWidth = 130;
            this.CapacidadDisco1.Name = "CapacidadDisco1";
            this.CapacidadDisco1.Visible = true;
            this.CapacidadDisco1.VisibleIndex = 7;
            this.CapacidadDisco1.Width = 130;
            // 
            // Disco2
            // 
            this.Disco2.Caption = "Disco2";
            this.Disco2.FieldName = "Disco2";
            this.Disco2.MaxWidth = 70;
            this.Disco2.MinWidth = 70;
            this.Disco2.Name = "Disco2";
            this.Disco2.Visible = true;
            this.Disco2.VisibleIndex = 8;
            this.Disco2.Width = 70;
            // 
            // CapacidadDisco2
            // 
            this.CapacidadDisco2.Caption = "CapacidadDisco2";
            this.CapacidadDisco2.FieldName = "CapacidadDisco2";
            this.CapacidadDisco2.MaxWidth = 130;
            this.CapacidadDisco2.MinWidth = 130;
            this.CapacidadDisco2.Name = "CapacidadDisco2";
            this.CapacidadDisco2.Visible = true;
            this.CapacidadDisco2.VisibleIndex = 9;
            this.CapacidadDisco2.Width = 130;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.Caption = "MemoriaRam";
            this.MemoriaRam.FieldName = "CapacidadMemoria";
            this.MemoriaRam.MaxWidth = 100;
            this.MemoriaRam.MinWidth = 100;
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Visible = true;
            this.MemoriaRam.VisibleIndex = 10;
            this.MemoriaRam.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "EstadoNombre";
            this.Estado.MaxWidth = 130;
            this.Estado.MinWidth = 130;
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 11;
            this.Estado.Width = 130;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.MaxWidth = 150;
            this.Cliente.MinWidth = 150;
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 12;
            this.Cliente.Width = 150;
            // 
            // Ubicacion
            // 
            this.Ubicacion.Caption = "Ubicacion";
            this.Ubicacion.FieldName = "Ubicacion";
            this.Ubicacion.MaxWidth = 150;
            this.Ubicacion.MinWidth = 150;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Visible = true;
            this.Ubicacion.VisibleIndex = 13;
            this.Ubicacion.Width = 150;
            // 
            // SerieFabrica
            // 
            this.SerieFabrica.Caption = "SerieFabrica";
            this.SerieFabrica.FieldName = "SerieFabrica";
            this.SerieFabrica.MaxWidth = 150;
            this.SerieFabrica.MinWidth = 150;
            this.SerieFabrica.Name = "SerieFabrica";
            this.SerieFabrica.Visible = true;
            this.SerieFabrica.VisibleIndex = 14;
            this.SerieFabrica.Width = 150;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvLaptops;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgvLaptops;
            this.gridView2.Name = "gridView2";
            // 
            // frmReporteStocksLaptops
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteStocksLaptops";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Laptops";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Video;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadVideo;
        private DevExpress.XtraGrid.Columns.GridColumn Disco1;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadDisco1;
        private DevExpress.XtraGrid.Columns.GridColumn Disco2;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadDisco2;
        private DevExpress.XtraGrid.Columns.GridColumn MemoriaRam;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn SerieFabrica;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}