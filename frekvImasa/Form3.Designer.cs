namespace frekvImasa
{
    partial class Form3
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
            this.period = new System.Windows.Forms.Label();
            this.frekvencija = new System.Windows.Forms.TextBox();
            this.povratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izracun
            // 
            this.izracun.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.izracun.Location = new System.Drawing.Point(581, 167);
            this.izracun.Name = "izracun";
            this.izracun.Size = new System.Drawing.Size(145, 51);
            this.izracun.TabIndex = 0;
            this.izracun.Text = "izracun";
            this.izracun.UseVisualStyleBackColor = true;
            this.izracun.Click += new System.EventHandler(this.izracun_Click);
            // 
            // period
            // 
            this.period.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(304, 307);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(64, 25);
            this.period.TabIndex = 1;
            this.period.Text = "period";
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // frekvencija
            // 
            this.frekvencija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frekvencija.Location = new System.Drawing.Point(277, 44);
            this.frekvencija.Name = "frekvencija";
            this.frekvencija.Size = new System.Drawing.Size(150, 31);
            this.frekvencija.TabIndex = 2;
            this.frekvencija.TextChanged += new System.EventHandler(this.frekvencija_TextChanged);
            // 
            // povratak
            // 
            this.povratak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.povratak.Location = new System.Drawing.Point(567, 282);
            this.povratak.Name = "povratak";
            this.povratak.Size = new System.Drawing.Size(159, 75);
            this.povratak.TabIndex = 3;
            this.povratak.Text = "povratak";
            this.povratak.UseVisualStyleBackColor = true;
            this.povratak.Click += new System.EventHandler(this.povratak_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.povratak);
            this.Controls.Add(this.frekvencija);
            this.Controls.Add(this.period);
            this.Controls.Add(this.izracun);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button izracun;
        private Label period;
        private TextBox frekvencija;
        private Button povratak;
    }
}