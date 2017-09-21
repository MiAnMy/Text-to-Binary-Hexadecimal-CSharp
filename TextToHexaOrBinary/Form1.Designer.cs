namespace TextToHexaOrBinary
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
            this.ToBinary = new System.Windows.Forms.Button();
            this.ToHexa = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToBinary
            // 
            this.ToBinary.AutoSize = true;
            this.ToBinary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToBinary.Location = new System.Drawing.Point(26, 52);
            this.ToBinary.Name = "ToBinary";
            this.ToBinary.Size = new System.Drawing.Size(46, 23);
            this.ToBinary.TabIndex = 0;
            this.ToBinary.Text = "Binary";
            this.ToBinary.UseVisualStyleBackColor = true;
            this.ToBinary.Click += new System.EventHandler(this.ToBinary_Click);
            // 
            // ToHexa
            // 
            this.ToHexa.AutoSize = true;
            this.ToHexa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToHexa.Location = new System.Drawing.Point(221, 52);
            this.ToHexa.Name = "ToHexa";
            this.ToHexa.Size = new System.Drawing.Size(78, 23);
            this.ToHexa.TabIndex = 1;
            this.ToHexa.Text = "Hexadecimal";
            this.ToHexa.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(97, 12);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(100, 20);
            this.Text.TabIndex = 2;
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Location = new System.Drawing.Point(126, 95);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(35, 13);
            this.Wynik.TabIndex = 3;
            this.Wynik.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 288);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.ToHexa);
            this.Controls.Add(this.ToBinary);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToBinary;
        private System.Windows.Forms.Button ToHexa;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Label Wynik;
    }
}

