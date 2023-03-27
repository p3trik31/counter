namespace matika
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VysledekOutput = new System.Windows.Forms.RichTextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.textboxM = new System.Windows.Forms.TextBox();
            this.textboxME = new System.Windows.Forms.TextBox();
            this.textboxVV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(560, 184);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "výsledek";
            // 
            // VysledekOutput
            // 
            this.VysledekOutput.Location = new System.Drawing.Point(16, 263);
            this.VysledekOutput.Name = "VysledekOutput";
            this.VysledekOutput.Size = new System.Drawing.Size(429, 175);
            this.VysledekOutput.TabIndex = 4;
            this.VysledekOutput.Text = "";
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(476, 279);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(258, 20);
            this.textbox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Možná funguje?:";
            // 
            // textbox4
            // 
            this.textbox4.Location = new System.Drawing.Point(476, 305);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(258, 20);
            this.textbox4.TabIndex = 7;
            // 
            // textbox5
            // 
            this.textbox5.Location = new System.Drawing.Point(476, 331);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(258, 20);
            this.textbox5.TabIndex = 8;
            // 
            // textboxM
            // 
            this.textboxM.Location = new System.Drawing.Point(476, 357);
            this.textboxM.Name = "textboxM";
            this.textboxM.Size = new System.Drawing.Size(258, 20);
            this.textboxM.TabIndex = 9;
            // 
            // textboxME
            // 
            this.textboxME.Location = new System.Drawing.Point(476, 383);
            this.textboxME.Name = "textboxME";
            this.textboxME.Size = new System.Drawing.Size(258, 20);
            this.textboxME.TabIndex = 10;
            // 
            // textboxVV
            // 
            this.textboxVV.Location = new System.Drawing.Point(476, 409);
            this.textboxVV.Name = "textboxVV";
            this.textboxVV.Size = new System.Drawing.Size(258, 20);
            this.textboxVV.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxVV);
            this.Controls.Add(this.textboxME);
            this.Controls.Add(this.textboxM);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.VysledekOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "idk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox VysledekOutput;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.TextBox textboxM;
        private System.Windows.Forms.TextBox textboxME;
        private System.Windows.Forms.TextBox textboxVV;
    }
}

