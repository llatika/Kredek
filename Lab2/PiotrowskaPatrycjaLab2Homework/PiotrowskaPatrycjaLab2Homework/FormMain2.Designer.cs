namespace PiotrowskaPatrycjaLab2Homework
{
    partial class FormMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain2));
            this.pictureBoxBreakfast = new System.Windows.Forms.PictureBox();
            this.pictureBoxDinner = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupper = new System.Windows.Forms.PictureBox();
            this.labelBreakfast = new System.Windows.Forms.Label();
            this.labelDinner = new System.Windows.Forms.Label();
            this.labelSupper = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.textBoxFinishList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupper)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBreakfast
            // 
            this.pictureBoxBreakfast.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBreakfast.Image")));
            this.pictureBoxBreakfast.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBreakfast.InitialImage")));
            this.pictureBoxBreakfast.Location = new System.Drawing.Point(64, 237);
            this.pictureBoxBreakfast.Name = "pictureBoxBreakfast";
            this.pictureBoxBreakfast.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBreakfast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBreakfast.TabIndex = 0;
            this.pictureBoxBreakfast.TabStop = false;
            this.pictureBoxBreakfast.Click += new System.EventHandler(this.PictureBoxBreakfast_Click);
            this.pictureBoxBreakfast.DoubleClick += new System.EventHandler(this.PictureBoxBreakfast_Click);
            // 
            // pictureBoxDinner
            // 
            this.pictureBoxDinner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDinner.Image")));
            this.pictureBoxDinner.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDinner.InitialImage")));
            this.pictureBoxDinner.Location = new System.Drawing.Point(272, 237);
            this.pictureBoxDinner.Name = "pictureBoxDinner";
            this.pictureBoxDinner.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxDinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDinner.TabIndex = 1;
            this.pictureBoxDinner.TabStop = false;
            this.pictureBoxDinner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDinner_MouseClick);
            this.pictureBoxDinner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDinner_MouseClick);
            // 
            // pictureBoxSupper
            // 
            this.pictureBoxSupper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSupper.Image")));
            this.pictureBoxSupper.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSupper.InitialImage")));
            this.pictureBoxSupper.Location = new System.Drawing.Point(483, 237);
            this.pictureBoxSupper.Name = "pictureBoxSupper";
            this.pictureBoxSupper.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxSupper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSupper.TabIndex = 2;
            this.pictureBoxSupper.TabStop = false;
            this.pictureBoxSupper.WaitOnLoad = true;
            this.pictureBoxSupper.Click += new System.EventHandler(this.PictureBoxSupper_Click);
            this.pictureBoxSupper.DoubleClick += new System.EventHandler(this.PictureBoxSupper_Click);
            // 
            // labelBreakfast
            // 
            this.labelBreakfast.AutoSize = true;
            this.labelBreakfast.Location = new System.Drawing.Point(92, 195);
            this.labelBreakfast.Name = "labelBreakfast";
            this.labelBreakfast.Size = new System.Drawing.Size(46, 13);
            this.labelBreakfast.TabIndex = 3;
            this.labelBreakfast.Text = "Breafast";
            // 
            // labelDinner
            // 
            this.labelDinner.AutoSize = true;
            this.labelDinner.Location = new System.Drawing.Point(306, 195);
            this.labelDinner.Name = "labelDinner";
            this.labelDinner.Size = new System.Drawing.Size(38, 13);
            this.labelDinner.TabIndex = 4;
            this.labelDinner.Text = "Dinner";
            // 
            // labelSupper
            // 
            this.labelSupper.AutoSize = true;
            this.labelSupper.Location = new System.Drawing.Point(513, 195);
            this.labelSupper.Name = "labelSupper";
            this.labelSupper.Size = new System.Drawing.Size(41, 13);
            this.labelSupper.TabIndex = 5;
            this.labelSupper.Text = "Supper";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(107, 22);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price (zl)";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(107, 65);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 13);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Time (h)";
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxPrice.Location = new System.Drawing.Point(165, 19);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrice.TabIndex = 8;
            this.comboBoxPrice.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrice_SelectedIndexChanged);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(165, 62);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 9;
            this.comboBoxTime.Visible = false;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTime_SelectedIndexChanged);
            // 
            // textBoxFinishList
            // 
            this.textBoxFinishList.Location = new System.Drawing.Point(739, 22);
            this.textBoxFinishList.Multiline = true;
            this.textBoxFinishList.Name = "textBoxFinishList";
            this.textBoxFinishList.Size = new System.Drawing.Size(316, 284);
            this.textBoxFinishList.TabIndex = 10;
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 345);
            this.Controls.Add(this.textBoxFinishList);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSupper);
            this.Controls.Add(this.labelDinner);
            this.Controls.Add(this.labelBreakfast);
            this.Controls.Add(this.pictureBoxSupper);
            this.Controls.Add(this.pictureBoxDinner);
            this.Controls.Add(this.pictureBoxBreakfast);
            this.Name = "FormMain2";
            this.Text = "myNewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBreakfast;
        private System.Windows.Forms.PictureBox pictureBoxDinner;
        private System.Windows.Forms.PictureBox pictureBoxSupper;
        private System.Windows.Forms.Label labelBreakfast;
        private System.Windows.Forms.Label labelDinner;
        private System.Windows.Forms.Label labelSupper;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.TextBox textBoxFinishList;
    }
}