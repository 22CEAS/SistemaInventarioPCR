namespace Vistas
{
    partial class frmEditarMemoria
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.superGridControl3 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // superGridControl3
            // 
            this.superGridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl3.BackColor = System.Drawing.Color.White;
            this.superGridControl3.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl3.ForeColor = System.Drawing.Color.Black;
            this.superGridControl3.Location = new System.Drawing.Point(12, 27);
            this.superGridControl3.Name = "superGridControl3";
            this.superGridControl3.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl3.PrimaryGrid.AllowRowResize = true;
            this.superGridControl3.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn16.Name = "Selec";
            gridColumn16.Width = 30;
            gridColumn17.Name = "Categoría";
            gridColumn17.Width = 110;
            gridColumn18.FilterAutoScan = true;
            gridColumn18.Name = "Tipo";
            gridColumn18.Width = 110;
            gridColumn19.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn19.Name = "Frecuencia";
            gridColumn19.Width = 110;
            gridColumn20.Name = "Capacidad";
            gridColumn20.Width = 110;
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn16);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn17);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn18);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn19);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn20);
            this.superGridControl3.PrimaryGrid.DefaultRowHeight = 24;
            this.superGridControl3.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl3.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl3.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl3.PrimaryGrid.EnableFiltering = true;
            this.superGridControl3.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl3.PrimaryGrid.Filter.Visible = true;
            this.superGridControl3.PrimaryGrid.NullString = "<<null>>";
            this.superGridControl3.PrimaryGrid.RowHeaderWidth = 45;
            this.superGridControl3.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl3.Size = new System.Drawing.Size(515, 226);
            this.superGridControl3.TabIndex = 45;
            this.superGridControl3.Text = "superGridControl3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(356, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Nota: Máximo se pueden elegir 2 discos por laptop o CPU.";
            // 
            // frmEditarMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 312);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.superGridControl3);
            this.Name = "frmEditarMemoria";
            this.Text = "Editar Memoria";
            this.Load += new System.EventHandler(this.frmEditarMemoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
    }
}