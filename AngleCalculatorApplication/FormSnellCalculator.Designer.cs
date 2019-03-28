namespace AngleCalculatorApplication
{
    partial class FormSnellCalculator
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
            this.btn_SineCalc2 = new System.Windows.Forms.Button();
            this.textBoxDegrees = new System.Windows.Forms.TextBox();
            this.lbl_Degrees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SineCalc2
            // 
            this.btn_SineCalc2.Location = new System.Drawing.Point(515, 171);
            this.btn_SineCalc2.Name = "btn_SineCalc2";
            this.btn_SineCalc2.Size = new System.Drawing.Size(155, 23);
            this.btn_SineCalc2.TabIndex = 0;
            this.btn_SineCalc2.Text = "Caclulate from Degrees";
            this.btn_SineCalc2.UseVisualStyleBackColor = true;
            this.btn_SineCalc2.Click += new System.EventHandler(this.btn_SineCalc2_Click);
            // 
            // textBoxDegrees
            // 
            this.textBoxDegrees.Location = new System.Drawing.Point(337, 171);
            this.textBoxDegrees.Name = "textBoxDegrees";
            this.textBoxDegrees.Size = new System.Drawing.Size(100, 20);
            this.textBoxDegrees.TabIndex = 1;
            this.textBoxDegrees.TextChanged += new System.EventHandler(this.textBoxDegrees_TextChanged);
            // 
            // lbl_Degrees
            // 
            this.lbl_Degrees.AutoSize = true;
            this.lbl_Degrees.Location = new System.Drawing.Point(256, 174);
            this.lbl_Degrees.Name = "lbl_Degrees";
            this.lbl_Degrees.Size = new System.Drawing.Size(78, 13);
            this.lbl_Degrees.TabIndex = 2;
            this.lbl_Degrees.Text = "Enter Degrees:";
            // 
            // FormSnellCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Degrees);
            this.Controls.Add(this.textBoxDegrees);
            this.Controls.Add(this.btn_SineCalc2);
            this.Name = "FormSnellCalculator";
            this.Text = "FormSnellCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SineCalc2;
        private System.Windows.Forms.TextBox textBoxDegrees;
        private System.Windows.Forms.Label lbl_Degrees;
    }
}