using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            proxy = new CalculatorForm.ServiceReference.CalculatorClient();
        }
        private CalculatorForm.ServiceReference.CalculatorClient proxy;

        private void btnadd_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.add(number1, number2);
            tbanswer.Text = answer.ToString();

        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.subtract(number1, number2);
            tbanswer.Text = answer.ToString();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.multiply(number1, number2);
            tbanswer.Text = answer.ToString();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.divide(number1, number2);
            tbanswer.Text = answer.ToString();
        }
    }
}
