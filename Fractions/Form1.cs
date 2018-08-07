using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Fractions First = new Fractions(int.Parse(tbNumerator1.Text), int.Parse(tbDenominator1.Text));
            Fractions Second = new Fractions(int.Parse(tbNumerator2.Text), int.Parse(tbDenominator2.Text));
            Fractions Result = new Fractions(0,0);

            switch(cbJob.SelectedItem)
            {
                case "*": Result = First.MultiFractions(Second);
                    break;
                case "/": Result = First.DividingFractions(Second);
                    break;
            }
            

            tbNumeratorResult.Text = Result.GetNumerator;
            tbDenominatorResult.Text = Result.GetDenominator;
        }
    }
}
