namespace MasaTvari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.racunanje = new System.Windows.Forms.Button();
            this.duzina = new System.Windows.Forms.TextBox();
            this.sirina = new System.Windows.Forms.TextBox();
            this.visina = new System.Windows.Forms.TextBox();
            this.gustoca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // racunanje
            // 
            this.racunanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.racunanje.Location = new System.Drawing.Point(580, 75);
            this.racunanje.Name = "racunanje";
            this.racunanje.Size = new System.Drawing.Size(140, 77);
            this.racunanje.TabIndex = 0;
            this.racunanje.Text = "Racunanje";
            this.racunanje.UseVisualStyleBackColor = true;
            // 
            // duzina
            // 
            this.duzina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.duzina.Location = new System.Drawing.Point(12, 306);
            this.duzina.Name = "duzina";
            this.duzina.Size = new System.Drawing.Size(150, 31);
            this.duzina.TabIndex = 1;
            // 
            // sirina
            // 
            this.sirina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sirina.Location = new System.Drawing.Point(210, 306);
            this.sirina.Name = "sirina";
            this.sirina.Size = new System.Drawing.Size(150, 31);
            this.sirina.TabIndex = 2;
            this.sirina.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // visina
            // 
            this.visina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visina.Location = new System.Drawing.Point(415, 306);
            this.visina.Name = "visina";
            this.visina.Size = new System.Drawing.Size(150, 31);
            this.visina.TabIndex = 3;
            // 
            // gustoca
            // 
            this.gustoca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gustoca.Location = new System.Drawing.Point(607, 306);
            this.gustoca.Name = "gustoca";
            this.gustoca.Size = new System.Drawing.Size(150, 31);
            this.gustoca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gustoca);
            this.Controls.Add(this.visina);
            this.Controls.Add(this.sirina);
            this.Controls.Add(this.duzina);
            this.Controls.Add(this.racunanje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button racunanje;
        private TextBox duzina;
        private TextBox sirina;
        private TextBox visina;
        private TextBox gustoca;
        private Label label1;
    }
}