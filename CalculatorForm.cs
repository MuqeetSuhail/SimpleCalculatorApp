using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class CalculatorForm : Form
    {
        private MathOperation _operator;
        private double _firstOperand;
        private double _secondOperand;
        private string _Operand;
        private bool isFloatingpoint;
        private bool equalPressed;
        private double _result;
        private List <string> Expressions;

        public CalculatorForm()
        {
            InitializeComponent();
            isFloatingpoint = false;
            Disp_Label.Text = null;
            Expressions = new List<string>();
            equalPressed = false;
        }

        private void btn_Digit_Click(object sender, EventArgs e)
        {
            try
            {
                if (equalPressed == true)
                {
                    Disp_Label.Text = null;
                    equalPressed = false;
                }
                Button b = sender as Button;
                txt_input.Text += b.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                equalPressed = true;
                if (!txt_input.Text.Equals(""))
                {
                    _secondOperand = Convert.ToDouble(txt_input.Text);
                    _result = _operator.Calculate(_firstOperand, _secondOperand);
                    _operator = null;        // User Will Have to Select Operation to perform again
                    txt_input.Text = _result.ToString();
                    Disp_Label.Text += _secondOperand.ToString() + " = " + _result.ToString();
                    Expressions.Add(Disp_Label.Text);
                }
                if (isFloatingpoint == true)
                {
                    isFloatingpoint = false;
                }
            }
            catch (Exception ex)
            {
                if (_operator == null)
                {
                    MessageBox.Show("Error: Plz Select Operation To Perform");
                }
                else
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (equalPressed == true)
                {
                    Disp_Label.Text = txt_input.Text;
                    equalPressed = false;
                }
                if (!txt_input.Text.Equals(""))
                {
                    _firstOperand = Convert.ToDouble(txt_input.Text);
                    Disp_Label.Text = _firstOperand.ToString();
                    txt_input.Clear();
                    AddOperation addition = new AddOperation();
                    _operator = addition;
                    Disp_Label.Text += " + ";
                }
            }
            catch (Exception ex)
            {
                if (_operator == null)
                {
                    MessageBox.Show("Error: Plz Select Operation To Perform");
                }
                else
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            try
            {
                if (equalPressed == true)
                {
                    Disp_Label.Text = txt_input.Text;
                    equalPressed = false;
                }
                if (!txt_input.Text.Equals(""))
                {
                    _firstOperand = Convert.ToDouble(txt_input.Text);
                    Disp_Label.Text = _firstOperand.ToString();
                    txt_input.Clear();
                    SubtractOperation Minus = new SubtractOperation();
                    _operator = Minus;
                    Disp_Label.Text += " - ";
                }
            }
            catch (Exception ex)
            {
                if (_operator == null)
                {
                    MessageBox.Show("Error: Plz Select Operation To Perform");
                }
                else
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (equalPressed == true)
                {
                    Disp_Label.Text = txt_input.Text;
                    equalPressed = false;
                }
                if (!txt_input.Text.Equals(""))
                {
                    _firstOperand = Convert.ToDouble(txt_input.Text);
                    Disp_Label.Text = _firstOperand.ToString();
                    txt_input.Clear();
                    MultiplyOperation Multiply = new MultiplyOperation();
                    _operator = Multiply;
                    Disp_Label.Text += " * ";
                }
            }
            catch (Exception ex)
            {
                if (_operator == null)
                {
                    MessageBox.Show("Error: Plz Select Operation To Perform");
                }
                else
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                if (equalPressed == true)
                {
                    Disp_Label.Text = txt_input.Text;
                    equalPressed = false;
                }
                if (!txt_input.Text.Equals(""))
                {
                    _firstOperand = Convert.ToDouble(txt_input.Text);
                    Disp_Label.Text = _firstOperand.ToString();
                    txt_input.Clear();
                    DivideOperation Division = new DivideOperation();
                    _operator = Division;
                    Disp_Label.Text += " / ";
                }
            }
            catch (Exception ex)
            {
                if (_operator == null)
                {
                    MessageBox.Show("Error: Plz Select Operation To Perform");
                }
                else
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btn_Clearone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_input.Text.Equals(""))
                {
                    _Operand = txt_input.Text;
                    int size = _Operand.Length;
                    string _ModifiedString = _Operand.Remove(size - 1);
                    txt_input.Text = _ModifiedString;
                }
                if (txt_input.Text.Contains(".") && isFloatingpoint == true)
                {
                    isFloatingpoint = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_input.Text.Contains(".") && isFloatingpoint == true)
                {
                    isFloatingpoint = false;
                }
                txt_input.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            try
            {
                isFloatingpoint = true;
                if (txt_input.Text.Equals(""))
                {
                    txt_input.Text = "0.";
                }
                else
                {
                    txt_input.Text += ".";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (Expressions != null)
                {
                    string logs = null;
                    foreach (var var in Expressions)
                    {
                        logs += '\n' + var.ToString();
                    }
                    MessageBox.Show("Logs: " + logs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
