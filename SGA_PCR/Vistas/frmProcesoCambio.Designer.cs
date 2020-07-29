namespace Vistas
{
    partial class frmProcesoCambio
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
            this.btnCambiarProducto = new System.Windows.Forms.Button();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEquipos = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarProducto
            // 
            this.btnCambiarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarProducto.Location = new System.Drawing.Point(616, 253);
            this.btnCambiarProducto.Name = "btnCambiarProducto";
            this.btnCambiarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnCambiarProducto.TabIndex = 57;
            this.btnCambiarProducto.Text = "Cambiar";
            this.btnCambiarProducto.UseVisualStyleBackColor = true;
            this.btnCambiarProducto.Click += new System.EventHandler(this.btnCambiarProducto_Click);
            // 
            // LabelX4
            // 
            this.LabelX4.AutoSize = true;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX4.ForeColor = System.Drawing.Color.Black;
            this.LabelX4.Location = new System.Drawing.Point(406, 84);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(42, 16);
            this.LabelX4.TabIndex = 51;
            this.LabelX4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Guía de Remision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cliente";
            // 
            // dtpFechaIngreso
            // 
            // 
            // 
            // 
            this.dtpFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaIngreso.ButtonDropDown.Visible = true;
            this.dtpFechaIngreso.IsPopupCalendarOpen = false;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(273, 159);
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaIngreso.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaIngreso.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(406, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(616, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 58;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipos.BackColor = System.Drawing.Color.White;
            this.dgvEquipos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvEquipos.ForeColor = System.Drawing.Color.Black;
            this.dgvEquipos.Location = new System.Drawing.Point(42, 205);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.PrimaryGrid.AllowRowDelete = true;
            this.dgvEquipos.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvEquipos.PrimaryGrid.AllowRowInsert = true;
            this.dgvEquipos.PrimaryGrid.AllowRowResize = true;
            this.dgvEquipos.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Codigo";
            gridColumn1.Width = 110;
            gridColumn2.FilterAutoScan = true;
            gridColumn2.Name = "Equipo";
            gridColumn2.Width = 110;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn3.Name = "Modelo";
            gridColumn3.Width = 110;
            gridColumn4.Name = "Marca";
            gridColumn4.Width = 110;
            gridColumn5.Name = "Pantalla";
            gridColumn5.Width = 110;
            gridColumn6.Name = "Procesador";
            gridColumn7.Name = "Generacion";
            gridColumn8.Name = "Disco";
            gridColumn9.Name = "TipoDisco";
            gridColumn10.Name = "Memoria";
            gridColumn11.Name = "Observación";
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
            this.dgvEquipos.Size = new System.Drawing.Size(537, 402);
            this.dgvEquipos.TabIndex = 71;
            this.dgvEquipos.Text = "superGridControl3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Código a Buscar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 20);
            this.textBox5.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(469, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "N° Ticket Técnico";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(471, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 20);
            this.textBox6.TabIndex = 80;
            // 
            // frmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCambiarProducto);
            this.Controls.Add(this.LabelX4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmCambio";
            this.Text = "frmCambio";
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarProducto;
        internal DevComponents.DotNetBar.LabelX LabelX4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaIngreso;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvEquipos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
    }
}