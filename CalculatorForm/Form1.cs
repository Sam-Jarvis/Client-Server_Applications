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
        Proxy proxy;

        public Form1()
        {
            InitializeComponent();
            
            // instantiate a proxy to contact the service
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new Proxy(binding, endpointAddress);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.GetCalculatorService().add(number1, number2);
            tbanswer.Text = answer.ToString();

        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.GetCalculatorService().subtract(number1, number2);
            tbanswer.Text = answer.ToString();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.GetCalculatorService().multiply(number1, number2);
            tbanswer.Text = answer.ToString();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(tbno1.Text);
            double number2 = Convert.ToDouble(tbno2.Text);
            double answer = proxy.GetCalculatorService().divide(number1, number2);
            tbanswer.Text = answer.ToString();
        }
    }
}
