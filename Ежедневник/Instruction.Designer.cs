namespace Ежедневник
{
    partial class Insruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insruction));
            this.InstructionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InstructionBox
            // 
            this.InstructionBox.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.InstructionBox.Location = new System.Drawing.Point(12, 12);
            this.InstructionBox.Multiline = true;
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.ReadOnly = true;
            this.InstructionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InstructionBox.Size = new System.Drawing.Size(413, 465);
            this.InstructionBox.TabIndex = 0;
            this.InstructionBox.TabStop = false;
            this.InstructionBox.Text = resources.GetString("InstructionBox.Text");
            // 
            // Insruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(437, 489);
            this.Controls.Add(this.InstructionBox);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Insruction";
            this.Text = "Інструкція";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox InstructionBox;
    }
}