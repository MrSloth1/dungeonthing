namespace DungeonSkr
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpButt = new System.Windows.Forms.Button();
            this.RightButt = new System.Windows.Forms.Button();
            this.LeftButt = new System.Windows.Forms.Button();
            this.DownButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InvButt = new System.Windows.Forms.Button();
            this.SettButt = new System.Windows.Forms.Button();
            this.TextBoxBitchFuerAlles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(110, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpButt
            // 
            this.UpButt.Location = new System.Drawing.Point(485, 523);
            this.UpButt.Name = "UpButt";
            this.UpButt.Size = new System.Drawing.Size(75, 23);
            this.UpButt.TabIndex = 1;
            this.UpButt.Text = "↑";
            this.UpButt.UseVisualStyleBackColor = true;
            this.UpButt.Click += new System.EventHandler(this.UpButt_Click);
            // 
            // RightButt
            // 
            this.RightButt.Location = new System.Drawing.Point(566, 552);
            this.RightButt.Name = "RightButt";
            this.RightButt.Size = new System.Drawing.Size(75, 23);
            this.RightButt.TabIndex = 2;
            this.RightButt.Text = "→";
            this.RightButt.UseVisualStyleBackColor = true;
            // 
            // LeftButt
            // 
            this.LeftButt.Location = new System.Drawing.Point(404, 552);
            this.LeftButt.Name = "LeftButt";
            this.LeftButt.Size = new System.Drawing.Size(75, 23);
            this.LeftButt.TabIndex = 3;
            this.LeftButt.Text = "←";
            this.LeftButt.UseVisualStyleBackColor = true;
            // 
            // DownButt
            // 
            this.DownButt.Location = new System.Drawing.Point(485, 552);
            this.DownButt.Name = "DownButt";
            this.DownButt.Size = new System.Drawing.Size(75, 23);
            this.DownButt.TabIndex = 4;
            this.DownButt.Text = "↓";
            this.DownButt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Playername";
            // 
            // InvButt
            // 
            this.InvButt.Location = new System.Drawing.Point(13, 523);
            this.InvButt.Name = "InvButt";
            this.InvButt.Size = new System.Drawing.Size(75, 23);
            this.InvButt.TabIndex = 6;
            this.InvButt.Text = "Inventory";
            this.InvButt.UseVisualStyleBackColor = true;
            // 
            // SettButt
            // 
            this.SettButt.Location = new System.Drawing.Point(12, 552);
            this.SettButt.Name = "SettButt";
            this.SettButt.Size = new System.Drawing.Size(75, 23);
            this.SettButt.TabIndex = 7;
            this.SettButt.Text = "Settings";
            this.SettButt.UseVisualStyleBackColor = true;
            // 
            // TextBoxBitchFuerAlles
            // 
            this.TextBoxBitchFuerAlles.Location = new System.Drawing.Point(4, 164);
            this.TextBoxBitchFuerAlles.Name = "TextBoxBitchFuerAlles";
            this.TextBoxBitchFuerAlles.Size = new System.Drawing.Size(100, 20);
            this.TextBoxBitchFuerAlles.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 602);
            this.Controls.Add(this.TextBoxBitchFuerAlles);
            this.Controls.Add(this.SettButt);
            this.Controls.Add(this.InvButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownButt);
            this.Controls.Add(this.LeftButt);
            this.Controls.Add(this.RightButt);
            this.Controls.Add(this.UpButt);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpButt;
        private System.Windows.Forms.Button RightButt;
        private System.Windows.Forms.Button LeftButt;
        private System.Windows.Forms.Button DownButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InvButt;
        private System.Windows.Forms.Button SettButt;
        private System.Windows.Forms.TextBox TextBoxBitchFuerAlles;
    }
}

