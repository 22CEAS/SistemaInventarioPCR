namespace Vistas
{
    partial class frmEditarLicencia
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
            this.superGridControl3 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.superGridControl3.Location = new System.Drawing.Point(33, 31);
            this.superGridControl3.Name = "superGridControl3";
            this.superGridControl3.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl3.PrimaryGrid.AllowRowResize = true;
            this.superGridControl3.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Selec,";
            gridColumn1.Width = 30;
            gridColumn2.FilterAutoScan = true;
            gridColumn2.Name = "Tipo";
            gridColumn2.Width = 140;
            gridColumn3.Name = "Nombre";
            gridColumn3.Width = 140;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn4.Name = "Versión";
            gridColumn4.Width = 140;
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl3.PrimaryGrid.Columns.Add(gridColumn4);
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
            this.superGridControl3.Size = new System.Drawing.Size(496, 237);
            this.superGridControl3.TabIndex = 72;
            this.superGridControl3.Text = "superGridControl3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditarLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.superGridControl3);
            this.Name = "frmEditarLicencia";
            this.Text = "Editar Licencia";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}