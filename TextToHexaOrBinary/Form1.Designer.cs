namespace TextToHexaOrBinary
{
    partial class ToHexOrBin
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
            this.TextToConv = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToBinary
            // 
            this.ToBinary.AutoSize = true;
            this.ToBinary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToBinary.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToBinary.Location = new System.Drawing.Point(0, 20);
            this.ToBinary.Name = "ToBinary";
            this.ToBinary.Size = new System.Drawing.Size(350, 23);
            this.ToBinary.TabIndex = 0;
            this.ToBinary.Text = "Binary";
            this.ToBinary.UseVisualStyleBackColor = true;
            this.ToBinary.Click += new System.EventHandler(this.ToBinary_Click);
            // 
            // ToHexa
            // 
            this.ToHexa.AutoSize = true;
            this.ToHexa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToHexa.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToHexa.Location = new System.Drawing.Point(0, 43);
            this.ToHexa.Name = "ToHexa";
            this.ToHexa.Size = new System.Drawing.Size(350, 23);
            this.ToHexa.TabIndex = 1;
            this.ToHexa.Text = "Hexadecimal";
            this.ToHexa.UseVisualStyleBackColor = true;
            this.ToHexa.Click += new System.EventHandler(this.ToHexa_Click);
            // 
            // TextToConv
            // 
            this.TextToConv.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextToConv.Location = new System.Drawing.Point(0, 0);
            this.TextToConv.Name = "TextToConv";
            this.TextToConv.Size = new System.Drawing.Size(350, 20);
            this.TextToConv.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(-3, 69);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 3;
            // 
            // ToHexOrBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 80);
            this.Controls.Add(this.ToHexa);
            this.Controls.Add(this.ToBinary);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TextToConv);
            this.MaximizeBox = false;
            this.Name = "ToHexOrBin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToHexOrBin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToBinary;
        private System.Windows.Forms.Button ToHexa;
        private System.Windows.Forms.TextBox TextToConv;
        private System.Windows.Forms.Label Result;
    }
}

