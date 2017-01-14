namespace Cadena
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
            this.RegresaPalabratextBox1 = new System.Windows.Forms.TextBox();
            this.RegresaPalabraLabel1 = new System.Windows.Forms.Label();
            this.ClickButton = new System.Windows.Forms.Button();
            this.DigiteNumerotextBox1 = new System.Windows.Forms.TextBox();
            this.DigiteNumeroLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegresaPalabratextBox1
            // 
            this.RegresaPalabratextBox1.Location = new System.Drawing.Point(81, 49);
            this.RegresaPalabratextBox1.Name = "RegresaPalabratextBox1";
            this.RegresaPalabratextBox1.Size = new System.Drawing.Size(205, 20);
            this.RegresaPalabratextBox1.TabIndex = 9;
            // 
            // RegresaPalabraLabel1
            // 
            this.RegresaPalabraLabel1.AutoSize = true;
            this.RegresaPalabraLabel1.Location = new System.Drawing.Point(12, 52);
            this.RegresaPalabraLabel1.Name = "RegresaPalabraLabel1";
            this.RegresaPalabraLabel1.Size = new System.Drawing.Size(46, 13);
            this.RegresaPalabraLabel1.TabIndex = 8;
            this.RegresaPalabraLabel1.Text = "Palabra ";
            // 
            // ClickButton
            // 
            this.ClickButton.Location = new System.Drawing.Point(104, 92);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(75, 23);
            this.ClickButton.TabIndex = 7;
            this.ClickButton.Text = "Click";
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // DigiteNumerotextBox1
            // 
            this.DigiteNumerotextBox1.Location = new System.Drawing.Point(104, 15);
            this.DigiteNumerotextBox1.Name = "DigiteNumerotextBox1";
            this.DigiteNumerotextBox1.Size = new System.Drawing.Size(100, 20);
            this.DigiteNumerotextBox1.TabIndex = 6;
            // 
            // DigiteNumeroLabel1
            // 
            this.DigiteNumeroLabel1.AutoSize = true;
            this.DigiteNumeroLabel1.Location = new System.Drawing.Point(12, 18);
            this.DigiteNumeroLabel1.Name = "DigiteNumeroLabel1";
            this.DigiteNumeroLabel1.Size = new System.Drawing.Size(85, 13);
            this.DigiteNumeroLabel1.TabIndex = 5;
            this.DigiteNumeroLabel1.Text = "Digite el Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 151);
            this.Controls.Add(this.RegresaPalabratextBox1);
            this.Controls.Add(this.RegresaPalabraLabel1);
            this.Controls.Add(this.ClickButton);
            this.Controls.Add(this.DigiteNumerotextBox1);
            this.Controls.Add(this.DigiteNumeroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegresaPalabratextBox1;
        private System.Windows.Forms.Label RegresaPalabraLabel1;
        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.TextBox DigiteNumerotextBox1;
        private System.Windows.Forms.Label DigiteNumeroLabel1;
    }
}

