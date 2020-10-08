namespace Apolo
{
    partial class frmProcesoSubirFacturas
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnSubirFactura = new System.Windows.Forms.Button();
            this.dgvFacturas = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubirFactura
            // 
            this.btnSubirFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFactura.Location = new System.Drawing.Point(956, 12);
            this.btnSubirFactura.Name = "btnSubirFactura";
            this.btnSubirFactura.Size = new System.Drawing.Size(75, 41);
            this.btnSubirFactura.TabIndex = 58;
            this.btnSubirFactura.Text = "Subir Factura";
            this.btnSubirFactura.UseVisualStyleBackColor = true;
            this.btnSubirFactura.Click += new System.EventHandler(this.btnSubirFactura_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvFacturas.ForeColor = System.Drawing.Color.Black;
            this.dgvFacturas.Location = new System.Drawing.Point(51, 76);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.PrimaryGrid.AllowEdit = false;
            this.dgvFacturas.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvFacturas.PrimaryGrid.AllowRowResize = true;
            this.dgvFacturas.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.DataPropertyName = "FechaPago";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn1.Name = "Fecha Pago";
            gridColumn1.Width = 110;
            gridColumn2.DataPropertyName = "TipoPago";
            gridColumn2.FilterAutoScan = true;
            gridColumn2.Name = "Tipo Pago";
            gridColumn2.Width = 110;
            gridColumn3.DataPropertyName = "CodigoLC";
            gridColumn3.Name = "Codigo Laptops";
            gridColumn3.Width = 110;
            gridColumn4.DataPropertyName = "FechaIniPago";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn4.Name = "Fecha Inicio Periodo Factura";
            gridColumn4.Width = 130;
            gridColumn5.DataPropertyName = "FechaFinPago";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn5.Name = "Fecha Fin Periodo Factura";
            gridColumn5.Width = 130;
            gridColumn6.DataPropertyName = "RucDni";
            gridColumn6.Name = "Nro Cliente";
            gridColumn7.DataPropertyName = "RazonSocial";
            gridColumn7.Name = "Cliente";
            gridColumn8.DataPropertyName = "NumeroOC";
            gridColumn8.Name = "Numero OC";
            gridColumn9.DataPropertyName = "NumeroDocRef";
            gridColumn9.Name = "Numero Doc Ref";
            gridColumn10.DataPropertyName = "NumeroFactura";
            gridColumn10.Name = "Numero Factura";
            gridColumn11.DataPropertyName = "TotalSoles";
            gridColumn11.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn11.Name = "Total Soles";
            gridColumn12.DataPropertyName = "TotalDolares";
            gridColumn12.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn12.Name = "Total Dolares";
            gridColumn13.DataPropertyName = "TipoCambio";
            gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn13.Name = "Tipo Cambio";
            gridColumn14.DataPropertyName = "VentaSoles";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn14.Name = "Venta Soles";
            gridColumn15.DataPropertyName = "CostoSoles";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn15.Name = "Costo Soles";
            gridColumn16.DataPropertyName = "CostoDolares";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn16.Name = "Costo Dolares";
            gridColumn17.DataPropertyName = "CostoTotalSolesSinIGV";
            gridColumn17.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn17.Name = "Costo Total Soles Sin IGV";
            gridColumn18.DataPropertyName = "UtilidadSoles";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn18.Name = "Utilidad Soles";
            gridColumn19.DataPropertyName = "UtilidadDolares";
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn19.Name = "Utilidad Dolares";
            gridColumn20.DataPropertyName = "UtilidadTotalSolesSinIGV";
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn20.Name = "Utilidad Total Soles Sin IGV";
            gridColumn21.DataPropertyName = "ObservacionXLevantar";
            gridColumn21.Name = "Observacion A Levantar";
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn6);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn7);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn8);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn9);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn10);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn11);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn12);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn13);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn14);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn15);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn16);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn17);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn18);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn19);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn20);
            this.dgvFacturas.PrimaryGrid.Columns.Add(gridColumn21);
            this.dgvFacturas.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvFacturas.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvFacturas.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvFacturas.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvFacturas.PrimaryGrid.EnableFiltering = true;
            this.dgvFacturas.PrimaryGrid.EnableRowFiltering = true;
            this.dgvFacturas.PrimaryGrid.Filter.Visible = true;
            this.dgvFacturas.PrimaryGrid.MultiSelect = false;
            this.dgvFacturas.PrimaryGrid.NullString = "<<null>>";
            this.dgvFacturas.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvFacturas.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvFacturas.Size = new System.Drawing.Size(1212, 417);
            this.dgvFacturas.TabIndex = 72;
            this.dgvFacturas.Text = "Tabla Facturas";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Location = new System.Drawing.Point(1055, 12);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 41);
            this.btnGrabar.TabIndex = 73;
            this.btnGrabar.Text = "Grabar Factura";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Location = new System.Drawing.Point(1159, 12);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 41);
            this.btnValidar.TabIndex = 74;
            this.btnValidar.Text = "Validar Factura";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // frmProcesoSubirFacturas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 533);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnSubirFactura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoSubirFacturas";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas Sisgeco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubirFactura;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvFacturas;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnValidar;
    }
}