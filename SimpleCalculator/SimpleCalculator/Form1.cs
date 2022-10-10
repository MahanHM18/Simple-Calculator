using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Math math = new Math();

        private double GetNumeric(int index)
        {
            if (index == 1)
                return Convert.ToDouble(Numeric1.Value);
            else if (index == 2)
                return Convert.ToDouble(Numeric2.Value);

            return 0;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "";
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            math.Sum(GetNumeric(1), GetNumeric(2));
            ResultLbl.Text = $"The Result is : {Convert.ToString(math.Result())}";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            math.Minus(GetNumeric(1), GetNumeric(2));
            ResultLbl.Text = $"The Result is : {Convert.ToString(math.Result())}";
        }

        private void MultipleBtn_Click(object sender, EventArgs e)
        {
            math.Multiple(GetNumeric(1), GetNumeric(2));
            ResultLbl.Text = $"The Result is : {Convert.ToString(math.Result())}";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            math.Division(GetNumeric(1), GetNumeric(2));
            ResultLbl.Text = $"The Result is : {Convert.ToString(math.Result())}";
        }
    }
}
