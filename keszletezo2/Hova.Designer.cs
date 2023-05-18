namespace keszletezo2
{
    partial class Hova
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.megse = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hova szeretnéd letölteni a csv-t?";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(29, 95);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(436, 26);
            this.pathBox.TabIndex = 1;
            this.pathBox.Validating += new System.ComponentModel.CancelEventHandler(this.pathBox_Validating);
            this.pathBox.Validated += new System.EventHandler(this.pathBox_Validated);
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ok.Location = new System.Drawing.Point(223, 208);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(119, 45);
            this.ok.TabIndex = 2;
            this.ok.Text = "&Ok!";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // megse
            // 
            this.megse.CausesValidation = false;
            this.megse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.megse.Location = new System.Drawing.Point(358, 208);
            this.megse.Name = "megse";
            this.megse.Size = new System.Drawing.Size(119, 45);
            this.megse.TabIndex = 3;
            this.megse.Text = "&Mégse!";
            this.megse.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kérlek az elérési utat az alábbi formátumban add meg: \r\nC:Mappanév/Mappanév/";
            // 
            // Hova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.megse);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "Hova";
            this.Text = "Letöltési hely megadása";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button megse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox pathBox;
        public System.Windows.Forms.Button ok;
    }
}