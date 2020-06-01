namespace Vistas
{
    partial class frmAlquiler
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
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.dtpFechaIngreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeInput3 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeInput4 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.superGridControl2 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput4)).BeginInit();
            this.SuspendLayout();
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
            this.LabelX4.Location = new System.Drawing.Point(531, 67);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(64, 16);
            this.LabelX4.TabIndex = 29;
            this.LabelX4.Text = "RUC / DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hora:";
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(663, 101);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.Visible = false;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(54, 20);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 27;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(769, 96);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(124, 29);
            this.btnAgregarProducto.TabIndex = 26;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Guía de Remisión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente:";
            // 
            // superGridControl1
            // 
            this.superGridControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(48, 155);
            this.superGridControl1.Name = "superGridControl1";
            gridColumn1.Name = "Codigo";
            gridColumn2.Name = "Equipo";
            gridColumn3.Name = "Modelo";
            gridColumn4.Name = "Marca";
            gridColumn5.Name = "Pantalla";
            gridColumn6.Name = "Procesador";
            gridColumn7.Name = "Generación";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn7);
            this.superGridControl1.Size = new System.Drawing.Size(517, 359);
            this.superGridControl1.TabIndex = 21;
            this.superGridControl1.Text = "superGridControl1";
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
            this.dtpFechaIngreso.Location = new System.Drawing.Point(525, 101);
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
            this.dtpFechaIngreso.Size = new System.Drawing.Size(70, 20);
            this.dtpFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaIngreso.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(601, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "99 meses 9 días";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fechas de Contrato:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimeInput3
            // 
            // 
            // 
            // 
            this.dateTimeInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput3.ButtonDropDown.Visible = true;
            this.dateTimeInput3.IsPopupCalendarOpen = false;
            this.dateTimeInput3.Location = new System.Drawing.Point(571, 28);
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateTimeInput3.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput3.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput3.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput3.Name = "dateTimeInput3";
            this.dateTimeInput3.Size = new System.Drawing.Size(92, 20);
            this.dateTimeInput3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput3.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Pedido:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Translado:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateTimeInput4
            // 
            // 
            // 
            // 
            this.dateTimeInput4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput4.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput4.ButtonDropDown.Visible = true;
            this.dateTimeInput4.IsPopupCalendarOpen = false;
            this.dateTimeInput4.Location = new System.Drawing.Point(687, 28);
            // 
            // 
            // 
            this.dateTimeInput4.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput4.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dateTimeInput4.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput4.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateTimeInput4.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput4.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput4.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput4.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput4.Name = "dateTimeInput4";
            this.dateTimeInput4.Size = new System.Drawing.Size(92, 20);
            this.dateTimeInput4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput4.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(608, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Memoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(608, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Disco Duro:";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(824, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 25);
            this.button3.TabIndex = 44;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(824, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 25);
            this.button4.TabIndex = 45;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // superGridControl2
            // 
            this.superGridControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl2.ForeColor = System.Drawing.Color.Black;
            this.superGridControl2.Location = new System.Drawing.Point(606, 177);
            this.superGridControl2.Name = "superGridControl2";
            gridColumn8.Name = "Codigo";
            gridColumn9.Name = "frecuencuia";
            gridColumn10.Name = "Generación";
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn8);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn9);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn10);
            this.superGridControl2.Size = new System.Drawing.Size(287, 99);
            this.superGridControl2.TabIndex = 46;
            this.superGridControl2.Text = "superGridControl2";
            this.superGridControl2.Click += new System.EventHandler(this.superGridControl2_Click);
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 547);
            this.Controls.Add(this.superGridControl2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimeInput4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeInput3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelX4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeInput1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmAlquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.LabelX LabelX4;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaIngreso;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl2;
    }
}