using System.Windows.Forms;
using System;



namespace DataProcessing
{
    public class Class1
    {
        public Class1(int var1, int var2)
        {
            Var1 = var1;
            Var2 = var2;
            Calculate(Var1, Var2);
        }

        public int Var1 { get; set ; }
        public int Var2 { get; set; }
        public static string message = "Hello World";
        public string CalcResult;
                 
        public string Calculate(int var1, int var2)
        {
            int result = var1 * var2;
            
            return CalcResult = Convert.ToString(result);
        }

    }

}
