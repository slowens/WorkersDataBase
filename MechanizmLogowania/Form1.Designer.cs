namespace MechanizmLogowania
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogLabel = new System.Windows.Forms.Label();
            this.PasLabel = new System.Windows.Forms.Label();
            this.TextBoxPas = new System.Windows.Forms.TextBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogLabel.ForeColor = System.Drawing.Color.Lime;
            this.LogLabel.Location = new System.Drawing.Point(6, 17);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(79, 29);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Text = "Login:";
            // 
            // PasLabel
            // 
            this.PasLabel.AutoSize = true;
            this.PasLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasLabel.ForeColor = System.Drawing.Color.Lime;
            this.PasLabel.Location = new System.Drawing.Point(6, 69);
            this.PasLabel.Name = "PasLabel";
            this.PasLabel.Size = new System.Drawing.Size(126, 29);
            this.PasLabel.TabIndex = 1;
            this.PasLabel.Text = "Password:";
            // 
            // TextBoxPas
            // 
            this.TextBoxPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPas.Location = new System.Drawing.Point(148, 64);
            this.TextBoxPas.Name = "TextBoxPas";
            this.TextBoxPas.Size = new System.Drawing.Size(232, 34);
            this.TextBoxPas.TabIndex = 3;
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLog.Location = new System.Drawing.Point(148, 17);
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(232, 34);
            this.TextBoxLog.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MechanizmLogowania.Properties.Resources.Science_Test_Tube_icon;
            this.pictureBox1.Location = new System.Drawing.Point(421, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::MechanizmLogowania.Properties.Resources.ok_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(76, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zweryfikuj";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasLabel);
            this.groupBox1.Controls.Add(this.LogLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextBoxPas);
            this.groupBox1.Controls.Add(this.TextBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logowanie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PasLabel;
        private System.Windows.Forms.TextBox TextBoxPas;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

