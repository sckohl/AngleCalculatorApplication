using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_HelloWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataProcessing.Class1.message);

        }

        public void btn_Calculate_Click(object sender, EventArgs e)
        {

            
            int var1;
            var1 = Convert.ToInt32(textBox1.Text);

           int var2;
            var2 = Convert.ToInt32(textBox2.Text);
        

         string calculate()
            {
                int result = var1 * var2;

                return Convert.ToString(result);
            }

            string calc = calculate();


            MessageBox.Show(calc);
        }

        private static void NewMethod1(string var2)
        {
            int int2 = Convert.ToInt32(var2);
        }

        private static void NewMethod(string var1)
        {
            int int1 = Convert.ToInt32(var1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
