﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV___Calculator;

namespace PAV___Calculator
{
    public partial class Form1
    {
        Double resVal = 0;
        String operand = "";
        bool showprevoperation = false;
        string first_num, second_num;

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void Numbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((TotalDisplay.Text == "0") || (showprevoperation))
                TotalDisplay.Clear();
            showprevoperation = false;

            if (button.Text == ".")
            {
                if (!TotalDisplay.Text.Contains("."))
                    TotalDisplay.Text += button.Text;
            }
            else
            {
                TotalDisplay.Text += button.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            if (resVal != 0)
            {
                EqualButton.PerformClick();
                showprevoperation = true;
                operand = op.Text;
                prevOperation.Text = resVal + " " + operand;
            }

            else
            {
                operand = op.Text;
                resVal = Double.Parse(TotalDisplay.Text);
                showprevoperation = true;
                prevOperation.Text = resVal + " " + operand;
            }
            first_num = prevOperation.Text;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case "+":
                    {
                        TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                        second_num = (Double.Parse(TotalDisplay.Text) - resVal).ToString();
                        prevOperation.Text = first_num + " " + second_num + " " + "=";
                        break;
                    }
                case "-":
                    {
                        TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                        second_num = ((Double.Parse(TotalDisplay.Text) - resVal) * -1).ToString();
                        prevOperation.Text = first_num + " " + second_num + " " + "=";
                        break;
                    }
                case "×":
                    {
                        TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                        second_num = (Double.Parse(TotalDisplay.Text) / resVal).ToString();
                        prevOperation.Text = first_num + " " + second_num + " " + "=";
                        break;
                    }
                case "÷":
                    {
                        TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                        second_num = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                        prevOperation.Text = first_num + " " + second_num + " " + "=";
                        break;
                    }
                default:
                    break;
            }
            resVal = Double.Parse(TotalDisplay.Text);
            operand = "";
        }

        private void SquarerootButton_Click(object sender, EventArgs e)
        {
            if (prevOperation.Text == resVal + " " + operand)
            {
                TotalDisplay.Text = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
                switch (operand)
                {
                    case "+":
                        {
                            second_num = (Math.Round(Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqrt(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "-":
                        {
                            second_num = (Math.Round(Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqrt(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "×":
                        {
                            second_num = (Math.Round(Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqrt(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "÷":
                        {
                            second_num = (Math.Round(Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqrt(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    default:
                        break;
                }
                resVal = Double.Parse(TotalDisplay.Text);
                operand = "";
            }
            else
            {
                prevOperation.Text = "sqrt(" + TotalDisplay.Text + ")";
                TotalDisplay.Text = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            if (prevOperation.Text == resVal + " " + operand)
            {
                TotalDisplay.Text = (Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text)).ToString();
                switch (operand)
                {
                    case "+":
                        {
                            second_num = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqr(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "-":
                        {
                            second_num = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqr(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "×":
                        {
                            second_num = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqr(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "÷":
                        {
                            second_num = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
                            prevOperation.Text = first_num + " " + "sqr(" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    default:
                        break;
                }
                resVal = Double.Parse(TotalDisplay.Text);
                operand = "";
            }
            else
            {
                prevOperation.Text = "sqr(" + TotalDisplay.Text + ")";
                TotalDisplay.Text = (Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text)).ToString();
            }
        }


        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            if (prevOperation.Text == resVal + " " + operand)
            {
                TotalDisplay.Text = (1 / Double.Parse(TotalDisplay.Text)).ToString();
                switch (operand)
                {
                    case "+":
                        {
                            second_num = (1 / Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + "(1/" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "-":
                        {
                            second_num = (1 / Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + "(1/" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "×":
                        {
                            second_num = (1 / Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + "(1/" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "÷":
                        {
                            second_num = (1 / Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + "(1/" + second_num + ")" + " " + "=";
                            TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    default:
                        break;
                }
                resVal = Double.Parse(TotalDisplay.Text);
                operand = "";
            }
            else
            {
                prevOperation.Text = ("1" + " " + "/" + " " + TotalDisplay.Text);
                TotalDisplay.Text = (1 / Double.Parse(TotalDisplay.Text)).ToString();
            }
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (prevOperation.Text == resVal + " " + operand)
            {
                TotalDisplay.Text = (Double.Parse(TotalDisplay.Text) / 100).ToString();
                switch (operand)
                {
                    case "+":
                        {
                            second_num = (100 * Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + second_num + "%" + " " + "=";
                            TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "-":
                        {
                            second_num = (100 * Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + second_num + "%" + " " + "=";
                            TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "×":
                        {
                            second_num = (100 * Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + second_num + "%" + " " + "=";
                            TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    case "÷":
                        {
                            second_num = (100 * Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + second_num + "%" + " " + "=";
                            TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            break;
                        }
                    default:
                        break;
                }
                resVal = Double.Parse(TotalDisplay.Text);
                operand = "";
            }
            else
            {
                prevOperation.Text = (TotalDisplay.Text + "%");
                TotalDisplay.Text = (Double.Parse(TotalDisplay.Text) / 100).ToString();
            }
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = (0 - Double.Parse(TotalDisplay.Text)).ToString();
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text != "")
                TotalDisplay.Text = TotalDisplay.Text.Remove(TotalDisplay.Text.Length - 1);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = "0";
            prevOperation.Text = "";
        }

        private void ClearentryButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = "0";
            resVal = 0;

        }

        private void Table1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StandardLabel_Click_1(object sender, EventArgs e)
        {

        }

    }
}
