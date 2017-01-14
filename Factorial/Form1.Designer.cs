namespace Factorial
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
            this.FactorialLabel = new System.Windows.Forms.Label();
            this.FactorialtextBox2 = new System.Windows.Forms.TextBox();
            this.DigiteNumerotextBox1 = new System.Windows.Forms.TextBox();
            this.DigiteNumeroLabel1 = new System.Windows.Forms.Label();
            this.CalcularBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FactorialLabel
            // 
            this.FactorialLabel.AutoSize = true;
            this.FactorialLabel.Location = new System.Drawing.Point(29, 54);
            this.FactorialLabel.Name = "FactorialLabel";
            this.FactorialLabel.Size = new System.Drawing.Size(61, 13);
            this.FactorialLabel.TabIndex = 9;
            this.FactorialLabel.Text = "Factorial es";
            // 
            // FactorialtextBox2
            // 
            this.FactorialtextBox2.Location = new System.Drawing.Point(96, 54);
            this.FactorialtextBox2.Name = "FactorialtextBox2";
            this.FactorialtextBox2.Size = new System.Drawing.Size(100, 20);
            this.FactorialtextBox2.TabIndex = 8;
            // 
            // DigiteNumerotextBox1
            // 
            this.DigiteNumerotextBox1.Location = new System.Drawing.Point(98, 12);
            this.DigiteNumerotextBox1.Name = "DigiteNumerotextBox1";
            this.DigiteNumerotextBox1.Size = new System.Drawing.Size(100, 20);
            this.DigiteNumerotextBox1.TabIndex = 7;
            // 
            // DigiteNumeroLabel1
            // 
            this.DigiteNumeroLabel1.AutoSize = true;
            this.DigiteNumeroLabel1.Location = new System.Drawing.Point(16, 15);
            this.DigiteNumeroLabel1.Name = "DigiteNumeroLabel1";
            this.DigiteNumeroLabel1.Size = new System.Drawing.Size(74, 13);
            this.DigiteNumeroLabel1.TabIndex = 6;
            this.DigiteNumeroLabel1.Text = "Digite Numero";
            // 
            // CalcularBotton
            // 
            this.CalcularBotton.Location = new System.Drawing.Point(66, 108);
            this.CalcularBotton.Name = "CalcularBotton";
            this.CalcularBotton.Size = new System.Drawing.Size(75, 23);
            this.CalcularBotton.TabIndex = 5;
            this.CalcularBotton.Text = "Calcular";
            this.CalcularBotton.UseVisualStyleBackColor = true;
            this.CalcularBotton.Click += new System.EventHandler(this.CalcularBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 154);
            this.Controls.Add(this.FactorialLabel);
            this.Controls.Add(this.FactorialtextBox2);
            this.Controls.Add(this.DigiteNumerotextBox1);
            this.Controls.Add(this.DigiteNumeroLabel1);
            this.Controls.Add(this.CalcularBotton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FactorialLabel;
        private System.Windows.Forms.TextBox FactorialtextBox2;
        private System.Windows.Forms.TextBox DigiteNumerotextBox1;
        private System.Windows.Forms.Label DigiteNumeroLabel1;
        private System.Windows.Forms.Button CalcularBotton;
    }
}

