﻿namespace Vistas
{
    partial class frmReportePendienteFacturar
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.superGridControl5 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(453, 28);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProducto.TabIndex = 33;
            this.btnAgregarProducto.Text = "Exportar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // superGridControl5
            // 
            this.superGridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl5.BackColor = System.Drawing.Color.White;
            this.superGridControl5.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl5.ForeColor = System.Drawing.Color.Black;
            this.superGridControl5.Location = new System.Drawing.Point(40, 96);
            this.superGridControl5.Name = "superGridControl5";
            this.superGridControl5.PrimaryGrid.AllowRowDelete = true;
            this.superGridControl5.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl5.PrimaryGrid.AllowRowInsert = true;
            this.superGridControl5.PrimaryGrid.AllowRowResize = true;
            this.superGridControl5.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Cliente";
            gridColumn1.Width = 120;
            gridColumn2.Name = "Inicio Contrato";
            gridColumn3.Name = "Fin Contrato";
            gridColumn4.Name = "Factura";
            gridColumn5.Name = "Inicio Periodo de Alquiler";
            gridColumn5.Width = 200;
            gridColumn6.Name = "Fin Periodo de Alquiler";
            gridColumn6.Width = 200;
            gridColumn7.Name = "CódigoEquipo";
            gridColumn8.Name = "Estado";
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn7);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn8);
            this.superGridControl5.PrimaryGrid.DefaultRowHeight = 24;
            this.superGridControl5.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl5.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl5.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl5.PrimaryGrid.EnableFiltering = true;
            this.superGridControl5.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl5.PrimaryGrid.Filter.Visible = true;
            this.superGridControl5.PrimaryGrid.NullString = "<<null>>";
            this.superGridControl5.PrimaryGrid.RowHeaderWidth = 45;
            this.superGridControl5.PrimaryGrid.ShowInsertRow = true;
            this.superGridControl5.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl5.Size = new System.Drawing.Size(1065, 275);
            this.superGridControl5.TabIndex = 32;
            this.superGridControl5.Text = "superGridControl5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Reporte Pendiente de Facturar";
            // 
            // frmReportePendienteFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 405);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.superGridControl5);
            this.Controls.Add(this.label1);
            this.Name = "frmReportePendienteFacturar";
            this.Text = "frmReportePendienteFacturar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl5;
        private System.Windows.Forms.Label label1;
    }
}