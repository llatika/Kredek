namespace PiotrowskaPatrycjaLab2Homework
{
    partial class FormMain
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
            this.buttonBio = new System.Windows.Forms.Button();
            this.buttonNotBio = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBioOrNot = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBio
            // 
            this.buttonBio.Location = new System.Drawing.Point(190, 129);
            this.buttonBio.Name = "buttonBio";
            this.buttonBio.Size = new System.Drawing.Size(75, 23);
            this.buttonBio.TabIndex = 0;
            this.buttonBio.Text = "Bio";
            this.buttonBio.UseVisualStyleBackColor = true;
            this.buttonBio.Click += new System.EventHandler(this.ButtonBio_Click);
            // 
            // buttonNotBio
            // 
            this.buttonNotBio.Location = new System.Drawing.Point(499, 129);
            this.buttonNotBio.Name = "buttonNotBio";
            this.buttonNotBio.Size = new System.Drawing.Size(75, 23);
            this.buttonNotBio.TabIndex = 1;
            this.buttonNotBio.Text = "Not Bio";
            this.buttonNotBio.UseVisualStyleBackColor = true;
            this.buttonNotBio.Click += new System.EventHandler(this.ButtonNotBio_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(622, 13);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(166, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Pani Kucharz-Piotrowska Patrycja";
            // 
            // labelBioOrNot
            // 
            this.labelBioOrNot.AutoSize = true;
            this.labelBioOrNot.Location = new System.Drawing.Point(336, 13);
            this.labelBioOrNot.Name = "labelBioOrNot";
            this.labelBioOrNot.Size = new System.Drawing.Size(126, 13);
            this.labelBioOrNot.TabIndex = 3;
            this.labelBioOrNot.Text = "How do you want to eat?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelBioOrNot);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonNotBio);
            this.Controls.Add(this.buttonBio);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBio;
        private System.Windows.Forms.Button buttonNotBio;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBioOrNot;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

