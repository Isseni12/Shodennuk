namespace Ежедневник
{
    partial class AddForm
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
            this.dateCalendar = new System.Windows.Forms.DateTimePicker();
            this.adress = new System.Windows.Forms.TextBox();
            this.freq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.NumericUpDown();
            this.minuteLabel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.durationHour = new System.Windows.Forms.NumericUpDown();
            this.durationMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ToDo = new System.Windows.Forms.Label();
            this.ActionField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCalendar
            // 
            this.dateCalendar.CalendarFont = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCalendar.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCalendar.Location = new System.Drawing.Point(206, 52);
            this.dateCalendar.Name = "dateCalendar";
            this.dateCalendar.Size = new System.Drawing.Size(193, 27);
            this.dateCalendar.TabIndex = 0;
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.adress.Location = new System.Drawing.Point(206, 235);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(193, 25);
            this.adress.TabIndex = 3;
            // 
            // freq
            // 
            this.freq.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.freq.Location = new System.Drawing.Point(206, 281);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(53, 25);
            this.freq.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(25, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Повторити через:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(25, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Адреса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(25, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тривалість:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата:";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonOk.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonOk.Location = new System.Drawing.Point(289, 464);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 32);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.BackColorChanged += new System.EventHandler(this.buttonOk_Click);
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.hourLabel.Location = new System.Drawing.Point(206, 96);
            this.hourLabel.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(193, 25);
            this.hourLabel.TabIndex = 21;
            // 
            // minuteLabel
            // 
            this.minuteLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.minuteLabel.Location = new System.Drawing.Point(206, 143);
            this.minuteLabel.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(193, 25);
            this.minuteLabel.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(25, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Хвилини:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(25, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Година:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(86, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Заповніть усі поля форми:";
            // 
            // durationHour
            // 
            this.durationHour.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.durationHour.Location = new System.Drawing.Point(206, 186);
            this.durationHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.durationHour.Name = "durationHour";
            this.durationHour.Size = new System.Drawing.Size(45, 25);
            this.durationHour.TabIndex = 26;
            // 
            // durationMin
            // 
            this.durationMin.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.durationMin.Location = new System.Drawing.Point(304, 186);
            this.durationMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.durationMin.Name = "durationMin";
            this.durationMin.Size = new System.Drawing.Size(46, 25);
            this.durationMin.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(257, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "год.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(356, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "хв.";
            // 
            // ToDo
            // 
            this.ToDo.AutoSize = true;
            this.ToDo.ForeColor = System.Drawing.Color.SteelBlue;
            this.ToDo.Location = new System.Drawing.Point(25, 330);
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(50, 21);
            this.ToDo.TabIndex = 30;
            this.ToDo.Text = "Подія:";
            // 
            // ActionField
            // 
            this.ActionField.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.ActionField.Location = new System.Drawing.Point(206, 330);
            this.ActionField.Multiline = true;
            this.ActionField.Name = "ActionField";
            this.ActionField.Size = new System.Drawing.Size(193, 89);
            this.ActionField.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(276, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "дні";
            // 
            // AddForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(439, 519);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ActionField);
            this.Controls.Add(this.ToDo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.durationMin);
            this.Controls.Add(this.durationHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.dateCalendar);
            this.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Italic);
            this.Name = "AddForm";
            this.Text = "Подія";
            ((System.ComponentModel.ISupportInitialize)(this.hourLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCalendar;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox freq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown hourLabel;
        private System.Windows.Forms.NumericUpDown minuteLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown durationHour;
        private System.Windows.Forms.NumericUpDown durationMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ToDo;
        private System.Windows.Forms.TextBox ActionField;
        private System.Windows.Forms.Label label10;
    }
}