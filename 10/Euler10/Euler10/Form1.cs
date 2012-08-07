using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool[] isPrime = new bool[2000000];
            for (int i = 1; i <= isPrime.Length; i++)
            {
                isPrime[i - 1] = true;
            }
            for (int i = 2; i <= (int)Math.Sqrt(2000000); i++)
            {
                if (isPrime[i - 1])
                {
                    int j = 2;
                    while (i * j <= 2000000)
                    {
                        isPrime[i * j - 1] = false;
                        j++;
                    }
                }
            }
            Int64 sum = 0;
            for (int i = 2; i <= isPrime.Length; i++)
            {
                if (isPrime[i - 1]) sum += i;
            }
            lblAnswer.Text = sum.ToString();
        }
    }
}
