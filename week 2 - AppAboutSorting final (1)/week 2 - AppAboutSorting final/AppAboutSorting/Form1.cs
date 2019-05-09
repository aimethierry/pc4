using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutSorting
{
    public partial class Form1 : Form
    {
        private int[] numbers = { 22, 55, 5, 77, 45, 39, 39, 45, 17, 29 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                this.listBox1.Items.Add(number.ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for (int firstIndexOfRest = 0; firstIndexOfRest < numbers.Length; firstIndexOfRest++)
            {
                int indexMinOfRest = GetIndexOfMinimumOfTheRest(firstIndexOfRest);
                swap(firstIndexOfRest, indexMinOfRest);
            }
        }
        private void swap(int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        private int GetIndexOfMinimumOfTheRest(int startingIndex)
        {
            int indexMin = startingIndex;
            for (int i = startingIndex+1; i < numbers.Length; i++)
            {
                if (numbers[i]<numbers[indexMin] )
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }
    }
}
