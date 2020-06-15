namespace Ежедневник
{
    partial class Login
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswod = new System.Windows.Forms.TextBox();
            this.toRegistationForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.CancelButton.Location = new System.Drawing.Point(36, 330);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 36);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Відминити";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.OkButton.Location = new System.Drawing.Point(171, 330);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 36);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вхід";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логін:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxLogin.Location = new System.Drawing.Point(34, 100);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(196, 37);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPasswod
            // 
            this.textBoxPasswod.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic);
            this.textBoxPasswod.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxPasswod.Location = new System.Drawing.Point(34, 223);
            this.textBoxPasswod.Multiline = true;
            this.textBoxPasswod.Name = "textBoxPasswod";
            this.textBoxPasswod.Size = new System.Drawing.Size(196, 37);
            this.textBoxPasswod.TabIndex = 6;
            // 
            // toRegistationForm
            // 
            this.toRegistationForm.FlatAppearance.BorderSize = 0;
            this.toRegistationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toRegistationForm.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.toRegistationForm.ForeColor = System.Drawing.Color.SteelBlue;
            this.toRegistationForm.Location = new System.Drawing.Point(171, 277);
            this.toRegistationForm.Name = "toRegistationForm";
            this.toRegistationForm.Size = new System.Drawing.Size(107, 29);
            this.toRegistationForm.TabIndex = 7;
            this.toRegistationForm.Text = "Реєстрація";
            this.toRegistationForm.UseVisualStyleBackColor = true;
            this.toRegistationForm.Click += new System.EventHandler(this.toRegistationForm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(327, 396);
            this.Controls.Add(this.toRegistationForm);
            this.Controls.Add(this.textBoxPasswod);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "Login";
            this.Text = "Вхід";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPasswod;
        private System.Windows.Forms.Button toRegistationForm;
    }
}