namespace Vistas
{
    partial class frmCrearDiscoDuro
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.superGridControl3 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 82;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(594, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 81;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Capacidad:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(26, 217);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(178, 21);
            this.comboBox4.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tamaño:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tipo:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 21);
            this.comboBox3.TabIndex = 73;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 72;
            // 
            // superGridControl3
            // 
            this.superGridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl3.BackColor = System.Drawing.Color.White;
            this.superGridControl3.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl3.ForeColor = System.Drawing.Color.Black;
            this.superGridControl3.Location = new System.Drawing.Point(248, 26);
            this.superGridControl3.Name = "superGridControl3";
            this.superGridControl3.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl3.PrimaryGrid.AllowRowResize = true;
            this.superGridControl3.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.FilterAutoScan = true;
            gridColumn1.Name = "Tipo";
            gridColumn1.Width = 140;
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn2.Name = "Tamaño";
            gridColumn2.Width = 140;
            gridColumn3.Name = "Capacidad";
            gridColumn3.Width = 140;
            gridColumn4.Name = "Hab./Desh.";
            gridColumn4.Width = 50;
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
            this.superGridControl3.Size = new System.Drawing.Size(517, 239);
            this.superGridControl3.TabIndex = 70;
            this.superGridControl3.Text = "superGridControl3";
            // 
            // CrearDiscoDuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.superGridControl3);
            this.Name = "CrearDiscoDuro";
            this.Text = "Crear Disco Duro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl3;
    }
}