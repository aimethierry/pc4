using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1_2_3___Ref_and_Out_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(Tb1stNr.Text);
            double nr2 = Convert.ToDouble(Tb2ndNr.Text);
            double Sum, Product;
            CalculateProductAndSum(nr1,nr2,out Sum,out Product);
            LblProductResult.Text = Product.ToString();
            LblSumResult.Text = Sum.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(Tb1stNr.Text);
            double nr2 = Convert.ToDouble(Tb2ndNr.Text);
            Swap(ref nr1, ref nr2);
            Lbl1stNr.Text = nr1.ToString();
            Lbl2ndNr.Text = nr2.ToString();
        }

        private void CalculateProductAndSum(double a, double b, out double Sum, out double Product)
        {
            Sum = a + b;
            Product = a * b;
        }

        private void Swap(ref double a, ref double b)
        {
            a = b * a;
            b = a/b;
            a = a/b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PredictTheOutPut()
        {
            double a = Convert.ToDouble(Tb1stNr.Text);
            double b = Convert.ToDouble(Tb2ndNr.Text);
            double c = Puzzle(a, ref b);


            double Puzzle(double A, ref double B)
            {
                double C = A + B;
                A = 5;
                B = A * 3;
                return C;
            }
            MessageBox.Show($"A: {a}, B: {b}, C: {c}");

        }

        private void BtnPredict_Click(object sender, EventArgs e)
        {
            PredictTheOutPut();
        }
    }
}
