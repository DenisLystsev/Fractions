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
            Fractions First;
            //= new Fractions(0, 0);
            Fractions Second;
                //= new Fractions(0, 0);
            Fractions Result;

            if(tbFullTile1.Text == "" || tbFullTile1.Text == "0")
            {
                First = new Fractions(int.Parse(tbNumerator1.Text), int.Parse(tbDenominator1.Text));
            }
            else
            {
                First = new Fractions(int.Parse(tbFullTile1.Text), int.Parse(tbNumerator1.Text), int.Parse(tbDenominator1.Text));
            }

            if (tbFullTile2.Text == "" || tbFullTile2.Text == "0")
            {
                Second = new Fractions(int.Parse(tbNumerator2.Text), int.Parse(tbDenominator2.Text));
            }
            else
            {
                Second = new Fractions(int.Parse(tbFullTile2.Text), int.Parse(tbNumerator2.Text), int.Parse(tbDenominator2.Text));
            }


            Result = new Fractions(0,0);

            switch (cbJob.SelectedItem)
            {
                case "Сложить":
                    Result = First.PlusFractions(Second);
                    break;
                case "Вычесть":
                    Result = First.SubstractFractions(Second);
                    break;
                case "Умножить": Result = First.MultiFractions(Second);
                    break;
                case "Разделить": Result = First.DividingFractions(Second);
                    break;
            }

            tbResultNumerator.Text = First.GetNumerator;
            tbResultDenominator.Text = First.GetDenominator;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для математических действий над дробями", "О программе");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Введите значения дробных чисел" + "\n" +
                "2 - Выберите действие из выпадающего списка" + "\n" +
                "3 - Нажмите кнопку \"Результат\" ", "Помощь");
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стесняется","Автор");
        }
    }
}
