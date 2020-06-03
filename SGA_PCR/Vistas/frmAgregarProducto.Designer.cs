namespace Vistas
{
    partial class frmAgregarProducto
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
            this.superGridControl5 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // superGridControl5
            // 
            this.superGridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl5.BackColor = System.Drawing.Color.White;
            this.superGridControl5.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl5.ForeColor = System.Drawing.Color.Black;
            this.superGridControl5.Location = new System.Drawing.Point(30, 30);
            this.superGridControl5.Name = "superGridControl5";
            this.superGridControl5.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl5.PrimaryGrid.AllowRowResize = true;
            this.superGridControl5.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn17.Name = "Selec.";
            gridColumn17.Width = 30;
            gridColumn18.Name = "Código";
            gridColumn18.Width = 110;
            gridColumn19.Name = "Equipo";
            gridColumn19.Width = 110;
            gridColumn20.FilterAutoScan = true;
            gridColumn20.Name = "Modelo";
            gridColumn20.Width = 110;
            gridColumn21.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn21.Name = "Marca";
            gridColumn21.Width = 110;
            gridColumn22.Name = "Pantalla";
            gridColumn22.Width = 110;
            gridColumn23.Name = "Procesador";
            gridColumn24.Name = "Generación";
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn17);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn18);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn19);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn20);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn21);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn22);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn23);
            this.superGridControl5.PrimaryGrid.Columns.Add(gridColumn24);
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
            this.superGridControl5.Size = new System.Drawing.Size(754, 277);
            this.superGridControl5.TabIndex = 53;
            this.superGridControl5.Text = "superGridControl5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.superGridControl5);
            this.Name = "frmAgregarProducto";
            this.Text = "frmAgregarProducto";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}