using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 계산기 : Form
    {
        public void asdf(string arg)
        {
            (double, int) t1 = (1.1, 5);
            Console.WriteLine($"튜플 내 항목은 {t1.Item1}과 {t1.Item2}입니다.");

            (double sum, int count) t2 = (1.1, 5);
            Console.WriteLine($"Count: {t2.count}, Sum: {t2.sum}.");
        }
        enum Operators
        {
            None,
            Add,
            SubStract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperators = Operators.None;
        Boolean operatorChangFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public 계산기()
        {
            InitializeComponent();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperators = Operators.None;
            display.Text = "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (operatorChangFlag == true)
            {
                display.Text = "";
                operatorChangFlag = false;
            }

            if (!display.Text.Contains("."))
            {
                display.Text = ".";
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperators = Operators.Divide;
            operatorChangFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperators = Operators.Multiply;
            operatorChangFlag = true;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperators = Operators.SubStract;
            operatorChangFlag = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperators = Operators.Add;
            operatorChangFlag = true;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperators == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperators == Operators.SubStract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperators == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperators == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }
    }
}
