namespace Vistas
{
    partial class frmReporteCuadroVencimiento
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn31 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn32 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.superGridControl5 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reporte de Vencimiento";
            // 
            // superGridControl5
            // 
            this.superGridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl5.BackColor = System.Drawing.Color.White;
            this.superGridControl5.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl5.ForeColor = System.Drawing.Color.Black;
            this.superGridControl5.Location = new System.Drawing.Point(39, 63);
            this.superGridControl5.Name = "superGridControl5";
            this.superGridControl5.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl5.PrimaryGrid.AllowRowResize = true;
            this.superGridControl5.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn17.Name = "Cliente";
            gridColumn17.Width = 120;
            gridColumn18.Name = "Factura";
            gridColumn18.Width = 120;
            gridColumn19.FilterAutoScan = true;
            gridColumn19.Name = "Fecha Inicio";
            gridColumn19.Width = 120;
            gridColumn20.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn20.Name = "Fecha Vencimiento";
            gridColumn20.Width = 120;
            gridColumn21.Name = "Nro Orden";
            gridColumn22.Name = "Días Vencidos";
            gridColumn23.Name = "Monto $";
            gridColumn24.Name = "Monto S/";
            gridColumn25.Name = "Total $";
            gridColumn26.Name = "Pendiente Facturar $";
            gridColumn27.Name = "N° Facturas Pendientes";
            gridColumn28.Name = "Descripción";
            gridColumn29.Name = "Fecha Traslado";
            gridColumn30.Name = "Código CPU/LP";
            gridColumn31.Name = "Código Original";
            gridColumn32.Name = "Código Otros Equipos";
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn17);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn18);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn19);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn20);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn21);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn22);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn23);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn24);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn25);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn26);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn27);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn28);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn29);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn30);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn31);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn32);
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
            this.superGridControl5.Size = new System.Drawing.Size(723, 285);
            this.superGridControl5.TabIndex = 29;
            this.superGridControl5.Text = "superGridControl5";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(687, 376);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProducto.TabIndex = 30;
            this.btnAgregarProducto.Text = "Exportar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // frmCuadroVencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.superGridControl5);
            this.Controls.Add(this.label1);
            this.Name = "frmCuadroVencimiento";
            this.Text = "frmCuadroVencimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl5;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}