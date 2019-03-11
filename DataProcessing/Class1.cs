using System.Windows.Forms;


namespace DataProcessing
{
    public class Class1
    {
            public static string message = "Hello World";
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

}
