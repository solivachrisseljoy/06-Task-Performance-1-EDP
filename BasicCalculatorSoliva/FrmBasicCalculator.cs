using CalculatorPrivateAssemblySoliva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * PROGRAM: Private Assemblies
 * DESCRIPTION: Determine the purpose of assemblies; and
                Create and use assemblies
 * AUTHOR: Soliva, Chrissel Joy C. 
 * SECTION: BSIT 501 
 */

namespace BasicCalculatorSoliva
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float result = 0;

            switch (cboOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(num1, num2);
                    break;

                case "-":
                    result = BasicComputation.Subtaction(num1, num2);
                    break;

                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;

                case "/":
                    result = BasicComputation.Division(num1, num2);
                    break;
            }

            lblTotal.Text = result.ToString();
        
    
        }
    }
}
