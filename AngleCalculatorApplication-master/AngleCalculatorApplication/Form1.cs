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
            DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(class1.CalcResult);
        }



        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
