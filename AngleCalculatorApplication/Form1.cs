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
            bs.DataSource = calcList;
            listBox1.DataSource = bs; //[0].CalcResult;

            listBox1.DisplayMember = "CalcResult";
         

        }
        List<DataProcessing.Class1> calcList = new List<DataProcessing.Class1>();

        BindingSource bs = new BindingSource();



        private void btn_HelloWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataProcessing.Class1.message);
            //DataProcessing.AngleConversion angleConversion = new DataProcessing.AngleConversion();
            //MessageBox.Show(angleConversion.DSCresult);

        }

        public void btn_Calculate_Click(object sender, EventArgs e)
        {
            DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            calcList.Add(class1);
            bs.ResetBindings(false);
            }



        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public void btn_Add_Click(object sender, EventArgs e)
        {



            //listBox1.Update();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            {
                DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

                calcList.Add(class1);
                class1.Multiply(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                bs.ResetBindings(false);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_Addition_Click(object sender, EventArgs e)
        {
            {
                DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

                calcList.Add(class1);
                class1.Addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                bs.ResetBindings(false);
            }
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            {
                DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

                calcList.Add(class1);
                class1.Division(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                bs.ResetBindings(false);
            }
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            {
                DataProcessing.Class1 class1 = new DataProcessing.Class1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

                calcList.Add(class1);
                class1.Subtraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                bs.ResetBindings(false);
            }
        }

        private void SnellCalc_Click(object sender, EventArgs e)
        {
            FormSnellCalculator formSnellCalculator = new FormSnellCalculator();
            formSnellCalculator.Show();
        }
    }
}
