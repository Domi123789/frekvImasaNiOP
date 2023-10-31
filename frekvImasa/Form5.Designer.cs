namespace frekvImasa
{
    partial class Form5
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
            this.izracun = new System.Windows.Forms.Button();
            this.povratak = new System.Windows.Forms.Button();
            this.Masa = new System.Windows.Forms.Label();
            this.MMasa = new System.Windows.Forms.Label();
            this.duzina = new System.Windows.Forms.TextBox();
            this.visina = new System.Windows.Forms.TextBox();
            this.sirina = new System.Windows.Forms.TextBox();
            this.gustoca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // izracun
            // 
            this.izracun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.izracun.Location = new System.Drawing.Point(630, 50);
            this.izracun.Name = "izracun";
            this.izracun.Size = new System.Drawing.Size(129, 60);
            this.izracun.TabIndex = 0;
            this.izracun.Text = "izracun";
            this.izracun.UseVisualStyleBackColor = true;
            this.izracun.Click += new System.EventHandler(this.izracun_Click);
            // 
            // povratak
            // 
            this.povratak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.povratak.Location = new System.Drawing.Point(630, 284);
            this.povratak.Name = "povratak";
            this.povratak.Size = new System.Drawing.Size(129, 65);
            this.povratak.TabIndex = 1;
            this.povratak.Text = "povratak";
            this.povratak.UseVisualStyleBackColor = true;
            this.povratak.Click += new System.EventHandler(this.povratak_Click);
            // 
            // Masa
            // 
            this.Masa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Masa.AutoSize = true;
            this.Masa.Location = new System.Drawing.Point(388, 55);
            this.Masa.Name = "Masa";
            this.Masa.Size = new System.Drawing.Size(0, 25);
            this.Masa.TabIndex = 2;
            // 
            // MMasa
            // 
            this.MMasa.AutoSize = true;
            this.MMasa.Location = new System.Drawing.Point(281, 55);
            this.MMasa.Name = "MMasa";
            this.MMasa.Size = new System.Drawing.Size(54, 25);
            this.MMasa.TabIndex = 3;
            this.MMasa.Text = "Masa";
            // 
            // duzina
            // 
            this.duzina.Location = new System.Drawing.Point(12, 192);
            this.duzina.Name = "duzina";
            this.duzina.Size = new System.Drawing.Size(150, 31);
            this.duzina.TabIndex = 4;
            // 
            // visina
            // 
            this.visina.Location = new System.Drawing.Point(205, 192);
            this.visina.Name = "visina";
            this.visina.Size = new System.Drawing.Size(150, 31);
            this.visina.TabIndex = 5;
            // 
            // sirina
            // 
            this.sirina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sirina.Location = new System.Drawing.Point(424, 192);
            this.sirina.Name = "sirina";
            this.sirina.Size = new System.Drawing.Size(150, 31);
            this.sirina.TabIndex = 6;
            // 
            // gustoca
            // 
            this.gustoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gustoca.Location = new System.Drawing.Point(609, 192);
            this.gustoca.Name = "gustoca";
            this.gustoca.Size = new System.Drawing.Size(150, 31);
            this.gustoca.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gustoca);
            this.Controls.Add(this.sirina);
            this.Controls.Add(this.visina);
            this.Controls.Add(this.duzina);
            this.Controls.Add(this.MMasa);
            this.Controls.Add(this.Masa);
            this.Controls.Add(this.povratak);
            this.Controls.Add(this.izracun);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button izracun;
        private Button povratak;
        private Label Masa;
        private Label MMasa;
        private TextBox duzina;
        private TextBox visina;
        private TextBox sirina;
        private TextBox gustoca;
    }
}