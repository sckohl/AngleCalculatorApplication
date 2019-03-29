namespace AngleCalculatorApplication
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
            this.btn_HelloWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Subtraction = new System.Windows.Forms.Button();
            this.SnellCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HelloWord
            // 
            this.btn_HelloWord.Location = new System.Drawing.Point(70, 355);
            this.btn_HelloWord.Name = "btn_HelloWord";
            this.btn_HelloWord.Size = new System.Drawing.Size(75, 23);
            this.btn_HelloWord.TabIndex = 0;
            this.btn_HelloWord.Text = "HelloWorld!";
            this.btn_HelloWord.UseVisualStyleBackColor = true;
            this.btn_HelloWord.Click += new System.EventHandler(this.btn_HelloWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(440, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Location = new System.Drawing.Point(320, 355);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiply.TabIndex = 9;
            this.btn_Multiply.Text = "Multiply";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.btn_Multiply_Click);
            // 
            // btn_Addition
            // 
            this.btn_Addition.Location = new System.Drawing.Point(416, 355);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(75, 23);
            this.btn_Addition.TabIndex = 10;
            this.btn_Addition.Text = "Add";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.btn_Addition_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(320, 393);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(75, 23);
            this.btn_Division.TabIndex = 12;
            this.btn_Division.Text = "Divide";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Subtraction
            // 
            this.btn_Subtraction.Location = new System.Drawing.Point(416, 393);
            this.btn_Subtraction.Name = "btn_Subtraction";
            this.btn_Subtraction.Size = new System.Drawing.Size(75, 23);
            this.btn_Subtraction.TabIndex = 13;
            this.btn_Subtraction.Text = "Subtract";
            this.btn_Subtraction.UseVisualStyleBackColor = true;
            this.btn_Subtraction.Click += new System.EventHandler(this.btn_Subtraction_Click);
            // 
            // SnellCalc
            // 
            this.SnellCalc.Location = new System.Drawing.Point(621, 371);
            this.SnellCalc.Name = "SnellCalc";
            this.SnellCalc.Size = new System.Drawing.Size(118, 45);
            this.SnellCalc.TabIndex = 14;
            this.SnellCalc.Text = "Snell Calculator";
            this.SnellCalc.UseVisualStyleBackColor = true;
            this.SnellCalc.Click += new System.EventHandler(this.SnellCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SnellCalc);
            this.Controls.Add(this.btn_Subtraction);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HelloWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HelloWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Subtraction;
        private System.Windows.Forms.Button SnellCalc;
    }
}

