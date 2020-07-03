namespace Vistas
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
            this.btnSubirFactura = new System.Windows.Forms.Button();
            this.dgvEquipos = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubirFactura
            // 
            this.btnSubirFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFactura.Location = new System.Drawing.Point(517, 29);
            this.btnSubirFactura.Name = "btnSubirFactura";
            this.btnSubirFactura.Size = new System.Drawing.Size(75, 41);
            this.btnSubirFactura.TabIndex = 58;
            this.btnSubirFactura.Text = "Subir Factura";
            this.btnSubirFactura.UseVisualStyleBackColor = true;
            this.btnSubirFactura.Click += new System.EventHandler(this.btnSubirFactura_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipos.BackColor = System.Drawing.Color.White;
            this.dgvEquipos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvEquipos.ForeColor = System.Drawing.Color.Black;
            this.dgvEquipos.Location = new System.Drawing.Point(50, 109);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.PrimaryGrid.AllowRowDelete = true;
            this.dgvEquipos.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvEquipos.PrimaryGrid.AllowRowInsert = true;
            this.dgvEquipos.PrimaryGrid.AllowRowResize = true;
            this.dgvEquipos.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Número";
            gridColumn1.Width = 110;
            gridColumn2.FilterAutoScan = true;
            gridColumn2.Name = "TipoDocumento";
            gridColumn2.Width = 110;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn3.Name = "NroDocumento";
            gridColumn3.Width = 110;
            gridColumn4.Name = "FechaInicioPeriodoFactura";
            gridColumn4.Width = 130;
            gridColumn5.Name = "FechaFinPeriodoFactura";
            gridColumn5.Width = 130;
            gridColumn6.Name = "Cliente";
            gridColumn7.Name = "Código Laptop";
            gridColumn8.Name = "KAM";
            gridColumn9.Name = "FormaPago";
            gridColumn10.Name = "TipoVenta";
            gridColumn11.Name = "Moneda";
            gridColumn12.Name = "TipoCambio";
            gridColumn13.Name = "NroOC";
            gridColumn14.Name = "NroDocRef";
            gridColumn15.Name = "Observación";
            gridColumn16.Name = "TotalNeto";
            gridColumn17.Name = "TotalIGV";
            gridColumn18.Name = "Total";
            gridColumn19.Name = "Pagado";
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn6);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn7);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn8);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn9);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn10);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn11);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn12);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn13);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn14);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn15);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn16);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn17);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn18);
            this.dgvEquipos.PrimaryGrid.Columns.Add(gridColumn19);
            this.dgvEquipos.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvEquipos.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvEquipos.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvEquipos.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvEquipos.PrimaryGrid.EnableFiltering = true;
            this.dgvEquipos.PrimaryGrid.EnableRowFiltering = true;
            this.dgvEquipos.PrimaryGrid.Filter.Visible = true;
            this.dgvEquipos.PrimaryGrid.NullString = "<<null>>";
            this.dgvEquipos.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvEquipos.PrimaryGrid.ShowInsertRow = true;
            this.dgvEquipos.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvEquipos.Size = new System.Drawing.Size(1009, 306);
            this.dgvEquipos.TabIndex = 72;
            this.dgvEquipos.Text = "superGridControl3";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(623, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 73;
            this.button1.Text = "Grabar Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Facturas Sisgeco";
            // 
            // frmProcesoSubirFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.btnSubirFactura);
            this.Name = "frmProcesoSubirFacturas";
            this.Text = "frmProcesoSubirFacturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubirFactura;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvEquipos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}