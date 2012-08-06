using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int upper = 999;
            int lower = 100;
            int product = 1;

            while (upper > lower)
            {
                for (int i = upper; i >= lower; i--)
                {
                    int testProduct = upper*i;
                    if (testProduct < product) break;
                    else if (isPalindrome(testProduct))
                    {
                        if (testProduct > product)
                        {
                            product = testProduct;
                            lower = i;
                        }
                        else break;
                    }
                }
                upper--;
            }

            lblAnswer.Text = product.ToString();
        }

        private bool isPalindrome(int number)
        {
            string numString = number.ToString();
            int index = 0;
            do
            {
                if (numString[index] != numString[numString.Length - 1 - index])
                {
                    return false;
                }
                index++;

            } while (index < Math.Ceiling((double)numString.Length / 2));
            return true;
        }
    }
}
