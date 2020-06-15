namespace Ежедневник
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.informationTextBox = new System.Windows.Forms.TextBox();
            this.timetableListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.rewriteButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.GDlabel = new System.Windows.Forms.Label();
            this.MainDateCalendar = new System.Windows.Forms.DateTimePicker();
            this.buttonInctruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationTextBox
            // 
            this.informationTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.informationTextBox.Location = new System.Drawing.Point(12, 61);
            this.informationTextBox.Multiline = true;
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.ReadOnly = true;
            this.informationTextBox.Size = new System.Drawing.Size(824, 41);
            this.informationTextBox.TabIndex = 0;
            // 
            // timetableListBox
            // 
            this.timetableListBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableListBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.timetableListBox.FormattingEnabled = true;
            this.timetableListBox.HorizontalScrollbar = true;
            this.timetableListBox.ItemHeight = 18;
            this.timetableListBox.Location = new System.Drawing.Point(16, 219);
            this.timetableListBox.Name = "timetableListBox";
            this.timetableListBox.Size = new System.Drawing.Size(820, 202);
            this.timetableListBox.TabIndex = 1;
            this.timetableListBox.DoubleClick += new System.EventHandler(this.timetableListBox_DoubleClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.addButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addButton.Location = new System.Drawing.Point(37, 437);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // rewriteButton
            // 
            this.rewriteButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.rewriteButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.rewriteButton.Location = new System.Drawing.Point(372, 437);
            this.rewriteButton.Name = "rewriteButton";
            this.rewriteButton.Size = new System.Drawing.Size(130, 30);
            this.rewriteButton.TabIndex = 3;
            this.rewriteButton.Text = "Редагувати";
            this.rewriteButton.UseVisualStyleBackColor = true;
            this.rewriteButton.Click += new System.EventHandler(this.rewriteButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.deleteButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.deleteButton.Location = new System.Drawing.Point(706, 437);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.leftButton.Location = new System.Drawing.Point(16, 172);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(152, 39);
            this.leftButton.TabIndex = 5;
            this.leftButton.Text = "\t🢤";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.rightButton.Location = new System.Drawing.Point(689, 172);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(147, 41);
            this.rightButton.TabIndex = 6;
            this.rightButton.Text = "🢥";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Найближча:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Italic);
            this.dateLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.dateLabel.Location = new System.Drawing.Point(106, 137);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 16);
            this.dateLabel.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сьогодні:";
            // 
            // GDlabel
            // 
            this.GDlabel.AutoSize = true;
            this.GDlabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDlabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.GDlabel.Location = new System.Drawing.Point(298, 9);
            this.GDlabel.Name = "GDlabel";
            this.GDlabel.Size = new System.Drawing.Size(154, 34);
            this.GDlabel.TabIndex = 11;
            this.GDlabel.Text = "Гарного дня";
            // 
            // MainDateCalendar
            // 
            this.MainDateCalendar.CalendarFont = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDateCalendar.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDateCalendar.Location = new System.Drawing.Point(329, 172);
            this.MainDateCalendar.Name = "MainDateCalendar";
            this.MainDateCalendar.Size = new System.Drawing.Size(202, 27);
            this.MainDateCalendar.TabIndex = 12;
            this.MainDateCalendar.ValueChanged += new System.EventHandler(this.MainDateCalendar_ValueChanged);
            // 
            // buttonInctruction
            // 
            this.buttonInctruction.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonInctruction.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonInctruction.Location = new System.Drawing.Point(123, 9);
            this.buttonInctruction.Name = "buttonInctruction";
            this.buttonInctruction.Size = new System.Drawing.Size(131, 30);
            this.buttonInctruction.TabIndex = 13;
            this.buttonInctruction.Text = "Інструкція";
            this.buttonInctruction.UseVisualStyleBackColor = true;
            this.buttonInctruction.Click += new System.EventHandler(this.buttonInctruction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(861, 496);
            this.Controls.Add(this.buttonInctruction);
            this.Controls.Add(this.MainDateCalendar);
            this.Controls.Add(this.GDlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.rewriteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.timetableListBox);
            this.Controls.Add(this.informationTextBox);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MainForm";
            this.Text = "Щоденник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox informationTextBox;
        private System.Windows.Forms.ListBox timetableListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button rewriteButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GDlabel;
        private System.Windows.Forms.DateTimePicker MainDateCalendar;
        private System.Windows.Forms.Button buttonInctruction;
    }
}

