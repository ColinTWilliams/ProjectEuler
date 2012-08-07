using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler7
{
    public partial class Form1 : Form
    {
        //I will use a Sieve of Eratosthenes to find the 10,001th prime number.
        //In order to determine the range of the sieve, i will use the bound:
        //p(n) < n (log n + log log n - 0.9385) = 

        private int _answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool[] isPrime = new bool[150000];
            for (int i=1; i<=isPrime.Length; i++)
            {
                isPrime[i-1] = true;
            }
            for (int i = 2; i<=(int)Math.Sqrt(150000); i++)
            {
                if (isPrime[i-1])
                {
                    int j = 2;
                    while (i*j <= 150000)
                    {
                        isPrime[i*j - 1] = false;
                        j++;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i <= isPrime.Length; i++)
            {
                if (isPrime[i - 1]) count++;
                if (count == 10001)
                {
                    _answer = i;
                    lblAnswer.Text = _answer.ToString();
                    break;
                }
            }
        }
    }
}
