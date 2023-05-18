namespace keszletezo2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.letoltes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kesz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiánycikkek lekérdezése";
            // 
            // letoltes
            // 
            this.letoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.letoltes.Location = new System.Drawing.Point(12, 68);
            this.letoltes.Name = "letoltes";
            this.letoltes.Size = new System.Drawing.Size(174, 94);
            this.letoltes.TabIndex = 1;
            this.letoltes.Text = "&Lista letöltése .csv-ben";
            this.letoltes.UseVisualStyleBackColor = true;
            this.letoltes.Click += new System.EventHandler(this.letoltes_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(207, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Lista megtekintése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 42);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // kesz
            // 
            this.kesz.AutoSize = true;
            this.kesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kesz.Location = new System.Drawing.Point(141, 245);
            this.kesz.Name = "kesz";
            this.kesz.Size = new System.Drawing.Size(103, 29);
            this.kesz.TabIndex = 4;
            this.kesz.Text = "Letöltve!";
            this.kesz.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 286);
            this.Controls.Add(this.kesz);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.letoltes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Készletező";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button letoltes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label kesz;
    }
}

