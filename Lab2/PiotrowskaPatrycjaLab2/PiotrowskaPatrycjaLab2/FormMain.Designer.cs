namespace PiotrowskaPatrycjaLab2
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
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.buttonObwod = new System.Windows.Forms.Button();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label1Nazwisko = new System.Windows.Forms.Label();
            this.labelSelectFigure = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelCircle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(181, 90);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 0;
            this.buttonArea.Text = "Oblicz Pole";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Location = new System.Drawing.Point(317, 90);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(97, 23);
            this.buttonChangeSize.TabIndex = 1;
            this.buttonChangeSize.Text = "Zmien rozmiar";
            this.buttonChangeSize.UseVisualStyleBackColor = true;
            this.buttonChangeSize.Click += new System.EventHandler(this.buttonChangeSize_Click);
            // 
            // buttonObwod
            // 
            this.buttonObwod.Location = new System.Drawing.Point(467, 90);
            this.buttonObwod.Name = "buttonObwod";
            this.buttonObwod.Size = new System.Drawing.Size(87, 23);
            this.buttonObwod.TabIndex = 2;
            this.buttonObwod.Text = "Oblicz Obwód";
            this.buttonObwod.UseVisualStyleBackColor = true;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(306, 25);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShape.TabIndex = 3;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(467, 119);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 4;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(181, 119);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 5;
            // 
            // label1Nazwisko
            // 
            this.label1Nazwisko.AutoSize = true;
            this.label1Nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Nazwisko.Location = new System.Drawing.Point(691, 9);
            this.label1Nazwisko.Name = "label1Nazwisko";
            this.label1Nazwisko.Size = new System.Drawing.Size(201, 25);
            this.label1Nazwisko.TabIndex = 6;
            this.label1Nazwisko.Text = "Patrycja Piotrowska";
            // 
            // labelSelectFigure
            // 
            this.labelSelectFigure.AutoSize = true;
            this.labelSelectFigure.Location = new System.Drawing.Point(333, 9);
            this.labelSelectFigure.Name = "labelSelectFigure";
            this.labelSelectFigure.Size = new System.Drawing.Size(74, 13);
            this.labelSelectFigure.TabIndex = 7;
            this.labelSelectFigure.Text = "Wybierz figurę";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Location = new System.Drawing.Point(194, 57);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(62, 13);
            this.labelSquare.TabIndex = 9;
            this.labelSquare.Text = "KWADRAT";
            // 
            // labelCircle
            // 
            this.labelCircle.AutoSize = true;
            this.labelCircle.Location = new System.Drawing.Point(486, 57);
            this.labelCircle.Name = "labelCircle";
            this.labelCircle.Size = new System.Drawing.Size(45, 13);
            this.labelCircle.TabIndex = 10;
            this.labelCircle.Text = "OKRAG";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 281);
            this.Controls.Add(this.labelCircle);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.labelSelectFigure);
            this.Controls.Add(this.label1Nazwisko);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonObwod);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.buttonArea);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonChangeSize;
        private System.Windows.Forms.Button buttonObwod;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label label1Nazwisko;
        private System.Windows.Forms.Label labelSelectFigure;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelCircle;
    }
}

