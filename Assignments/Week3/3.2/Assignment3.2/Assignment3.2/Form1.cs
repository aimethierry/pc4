using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //methods
        public int sumSquares(int n)
        {
            //starting point
            if(n==0)
            {
                return 0;
            }
            else
            {
                return (n * n) + sumSquares(n - 1); 
            }
        }


        int[] numarray = new int[] { 10000, 23000, 500000,20,30,11,22,33,44,55,88  };


        /// <summary>
        /// this method return the sum of the first n numbers in the array x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int sum(int[] x, int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                return x[n-1] + sum(x, n - 1);
            }
        }



        public int max(int[] x, int n)
        {
            if (n == 1)
            {
                return x[0];




            }
            else
            {

                int temp = max(x, n - 1);


                if (temp >= x[n - 1])
                {
                    return temp;
                }
                else
                {
                    return x[n - 1];
                }

            }
        }


        public int SumofDigits(int n)
        {
            if(n ==0)
            {
                return 0;
                //if (x<10) {return x}
            }
            else
            {
                
               
             return (n % 10)+ SumofDigits(n / 10);
            }

           
          
        }


        public bool allbig(int[] x, int n)
        {
            if(n == 0)
            {
                return true;
            }
            else
            {
                return allbig(x,n-1) && (x[n-1] > 1000);
            }
        }

        public bool isascending(int[] x, int n)
        {
           if(n==1)
            {
                return true;
            }
           else
            {
                return   (x[n - 1] > x[n - 2]) && isascending(x, n - 1);
            }
        }




        private void btnsumsquares_Click(object sender, EventArgs e)
        {
            try
            {
                int result = sumSquares(Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            try
            {
                int result = sum(numarray,Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            try
            {
                int result = max(numarray, Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsumofdigits_Click(object sender, EventArgs e)
        {
            try
            {
                int result = SumofDigits(Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnallbig_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = allbig(numarray, Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnisascending_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = isascending(numarray, Convert.ToInt32(tbvalue.Text));

                MessageBox.Show(result.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
