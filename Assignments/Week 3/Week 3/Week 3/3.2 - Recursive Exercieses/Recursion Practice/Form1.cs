using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Recursion_Practice
{
    public partial class Form1 : Form
    {
        private int[] sumArray = new int[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        private Random rand;

        private int[] randomArray;
        public Form1()
        {
            rand = new Random();
            InitializeComponent();
        }

        private void BtnSquSum_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            if (RbA.Checked)
            {
                int result = A_SumSquares(n);
                ShowInfo($"Result of Squres Sum: {result}");
            }else if (RbB.Checked)
            {
                int result1 = B_SumRecursive(sumArray,n);
                int result2 = B_SumIterative(sumArray, n);
                ShowInfo($"Result of B - Recursive: {result1}");
                ShowInfo($"Result of B - Recursive: {result2}");
            }else if (RbC.Checked)
            {
                
                randomArray = new int[20];
                for (int i = 0; i < 20; i++)
                {
                    randomArray[i] = rand.Next(1, 40);
                }

                foreach (var j in randomArray)
                {
                    ShowInfo(j);
                }
                
                ShowInfo("=================");
                int maxInArray1 = C_MaxRecursive(randomArray, n);
                int maxInArray2 = C_MaxIterative(randomArray, n);
                ShowInfo($"Result of C - Iterative: {maxInArray2}");
                ShowInfo($"Result of C - Recursive: {maxInArray1}");
            }else if (RbD.Checked)
            {
                int result = D_SumOfDigit(n);
                ShowInfo($"Result of D - Recursive: {result}");

            }
            else if (RbE.Checked)
            {
                randomArray = new int[100];
                randomArray[0] = 1112;
                randomArray[1] = 12312;
                randomArray[2] = 12302;
                randomArray[3] = 11321;
                randomArray[4] = 121402;
                for (int i = 5; i < 100; i++)
                {
                    randomArray[i] = rand.Next(950, 1500);
                }
                bool t = E_AllBig(randomArray, n);
                int minInArray2 = C_MinIterative(randomArray, n);
                ShowInfo($"Result of E - Min: {minInArray2}");
                ShowInfo($"Result of E - Recursive: {t}");
            
            }else if (RbF.Checked)
            {
                randomArray = new int[100];
                randomArray[0] = 0;
                randomArray[1] = 1;
                randomArray[2] = 2;
                randomArray[3] = 3;
                randomArray[4] = 4;
                for (int i = 5; i < 100; i++)
                {
                    randomArray[i] = rand.Next(5, 100);
                }

                for (int i = 0; i < n;i++)
                {
                    listBox1.Items.Add(randomArray[i]);
                }

                bool t = F_IsAscending(randomArray, n);
                int minInArray2 = C_MinIterative(randomArray, n);
                ShowInfo($"Result of F - Min: {minInArray2}");
                ShowInfo($"Result of F - Recursive: {t}");
            }
        }
        
        //A
        public int A_SumSquares(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else
            {
                return (int)Math.Pow(i, 2) + A_SumSquares(i - 1);
            }
        }
        
        //B
        public int B_SumRecursive(int[] X, int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return X[0];
            }
            else
            {
                return X[n-1] + B_SumRecursive(X,n - 1);
            }
        }

        public int B_SumIterative(int[] X, int n)
        {
            int result = 0;

            for (int i = 1; i <=n; i++)
            {
                result += X[i - 1];
            }

            return result;
        }

        //C
        public int C_MaxRecursive(int[] X, int n)
        {
            int max = X[n - 1];
            if (n == 1)
            {
                return X[0];
            }
            else
            {
                return Math.Max(X[n - 1], C_MaxRecursive(X, n - 1));
            }
        }

        public int C_MaxIterative(int[] X, int n)
        {
            int Max = X[0];
            for (int i = 0; i < n; i++)
            {
                if (X[i] > Max)
                {
                    Max = X[i];
                }
            }

            return Max;
        }

        public int C_MinIterative(int[] X, int n)
        {
            int Min = X[0];
            for (int i = 0; i < n; i++)
            {
                if (X[i] < Min)
                {
                    Min = X[i];
                }
            }

            return Min;
        } 

        //D
        public int D_SumOfDigit(int n)
        {
            string temp = n.ToString();
            int l = (int) Math.Pow(10, temp.Length - 1);
            if (temp.Length==1)
            {
                return n;
            }
            else
            {
                
                int a = n / l;
                return a + D_SumOfDigit(n- (a*l));
            }
        }

        //E
        public bool E_AllBig(int[] X, int n)
        {
            if (n <= 1)
            {
                if (X[0] < 1000)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (X[n - 1] < 1000)
                {
                    return false;
                }
                else
                {
                    return E_AllBig(X, n - 1);
                }
            }
        }

        //F
        public bool F_IsAscending(int[] X, int n)
        {
            if (n <= 2)
            {
                if (X[0]<=X[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (X[n - 1] > X[n - 2])
                {
                    return F_IsAscending(X, n - 1);
                }
                else
                {
                    return false;
                }
            }
        }
        public void ShowInfo(object i)
        {
            listBox1.Items.Add(i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
