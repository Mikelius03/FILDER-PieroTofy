namespace GUI_FILDER_FORMS
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.FILDERFolderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxRic1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBoxFILDER1 = new System.Windows.Forms.TextBox();
            this.checkRicorsione2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxPattern1 = new System.Windows.Forms.CheckBox();
            this.labelPattern1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click_SEARCH);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "AVVIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click_AVVIA);
            // 
            // checkBoxRic1
            // 
            this.checkBoxRic1.AutoSize = true;
            this.checkBoxRic1.Location = new System.Drawing.Point(48, 237);
            this.checkBoxRic1.Name = "checkBoxRic1";
            this.checkBoxRic1.Size = new System.Drawing.Size(110, 24);
            this.checkBoxRic1.TabIndex = 2;
            this.checkBoxRic1.Text = "Ricorsione";
            this.checkBoxRic1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(428, 187);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "txt";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(428, 208);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "markdown";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(428, 227);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 24);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "html";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(428, 248);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 24);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "xml";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(428, 269);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(68, 24);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "latex";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBoxFILDER1
            // 
            this.textBoxFILDER1.Location = new System.Drawing.Point(27, 71);
            this.textBoxFILDER1.Name = "textBoxFILDER1";
            this.textBoxFILDER1.Size = new System.Drawing.Size(327, 26);
            this.textBoxFILDER1.TabIndex = 8;
            this.textBoxFILDER1.TextChanged += new System.EventHandler(this.textBoxFILDER1_TextChanged);
            // 
            // checkRicorsione2
            // 
            this.checkRicorsione2.AutoSize = true;
            this.checkRicorsione2.Enabled = false;
            this.checkRicorsione2.Location = new System.Drawing.Point(48, 267);
            this.checkRicorsione2.Name = "checkRicorsione2";
            this.checkRicorsione2.Size = new System.Drawing.Size(108, 24);
            this.checkRicorsione2.TabIndex = 9;
            this.checkRicorsione2.Text = "Profondità";
            this.checkRicorsione2.UseVisualStyleBackColor = true;
            //
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(167, 265);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(78, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 11;
            // 
            // checkBoxPattern1
            // 
            this.checkBoxPattern1.AutoSize = true;
            this.checkBoxPattern1.Location = new System.Drawing.Point(45, 161);
            this.checkBoxPattern1.Name = "checkBoxPattern1";
            this.checkBoxPattern1.Size = new System.Drawing.Size(22, 21);
            this.checkBoxPattern1.TabIndex = 12;
            this.checkBoxPattern1.UseVisualStyleBackColor = true;
            this.checkBoxPattern1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // labelPattern1
            // 
            this.labelPattern1.AutoSize = true;
            this.labelPattern1.Enabled = false;
            this.labelPattern1.Location = new System.Drawing.Point(74, 145);
            this.labelPattern1.Name = "labelPattern1";
            this.labelPattern1.Size = new System.Drawing.Size(61, 20);
            this.labelPattern1.TabIndex = 13;
            this.labelPattern1.Text = "Pattern";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 551);
            this.Controls.Add(this.labelPattern1);
            this.Controls.Add(this.checkBoxPattern1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkRicorsione2);
            this.Controls.Add(this.textBoxFILDER1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxRic1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FILDER";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FILDERFolderDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxRic1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBoxFILDER1;
        private System.Windows.Forms.CheckBox checkRicorsione2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxPattern1;
        private System.Windows.Forms.Label labelPattern1;
    }
}

