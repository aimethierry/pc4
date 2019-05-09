using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_3._2._1
{
    public partial class Form1 : Form
    {   
        private int sum;
        private int[] x = new[] {1060,  1501,2100, 5, 7, 12, 14};
        public delegate int answerhandler(int[] x,int n);
        public answerhandler CalculateRightAnswerint;
        public delegate bool answerhandler1(int[] x,int n);
        public answerhandler1 CalculateRightAnswerBool;
        public Form1()
        {
            InitializeComponent();
        }

        private void job_Click(object sender, EventArgs e)
        {
            if (rbBig.Checked != true&& rbasce.Checked !=true )
            {
                tbout.Text = CalculateRightAnswerint(x, Convert.ToInt32(tbin.Text)).ToString();
            }
            else{tbout.Text = CalculateRightAnswerBool(x, Convert.ToInt32(tbin.Text)).ToString();}
        }

        public int sumSqaures(int[] x,int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else
            {
                sum = (int)Math.Pow(n, 2) + sumSqaures(x,n - 1);
                return sum;
            }
        }

        public int Sum(int[] x, int n)
        {
            if (n == 0)
            {
                return x[0];
            }

            return x[n]+Sum(x, n - 1);
        }
        public int Max(int[] x, int n)
        {
            if (n == 1)
                return x[n];
            var tmp = Max(x, n - 1);
          
            if (x[n] > tmp)
               return x[n];

            return tmp;

        }
        public int sumOfDigits(int[] x,int n)
        { if(n ==0)
            {
                return 0;
            } 
                return (n % 10)+ sumOfDigits(x,n / 10);
        }

        public bool allBig(int[] x, int n)
        {
            if (n == 0)
            {
                if (x[n] > 1000){
                    return true;
                }

            return false;

            }
            
            var tmp = allBig(x, n - 1);
          
            if (tmp == true&& x[n]>1000)
                return true;

            return false;
           
        }

        public bool isAssending(int[] x, int n)
        {
            if (n == 1)
            {
             return true;
            }
            
            return  x[n-2]<x[n-1] && isAssending(x, n - 1);
           
        }
        private void rbsquares_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerint += new answerhandler(sumSqaures);
        }

        private void rbdigits_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerint += new answerhandler(sumOfDigits);
        }

        private void rbsum_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerint += new answerhandler(Sum);
        }

        private void rbmx_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerint += new answerhandler(Max);
        }

        private void rbBig_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerBool += new answerhandler1(allBig);
        }

        private void rbasce_CheckedChanged(object sender, EventArgs e)
        {
            CalculateRightAnswerBool += new answerhandler1(isAssending);
        }
    }
}
