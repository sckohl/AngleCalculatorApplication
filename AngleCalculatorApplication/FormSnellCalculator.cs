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
    public partial class FormSnellCalculator : Form
    {
        public FormSnellCalculator()
        {
            InitializeComponent();
        }

        private void btn_SineCalc2_Click(object sender, EventArgs e)
        {
            DataProcessing.AngleConversion angleConversion = new DataProcessing.AngleConversion(Convert.ToInt32(textBoxDegrees.Text));
            MessageBox.Show(angleConversion.DSCresult);
        }

        private void textBoxDegrees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
