using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace oneDimentionOptimization
{
    public partial class Form1 : Form
    {
        double a0, b0; //-6 1
        double E; 
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            StatusRichTextBox.Clear();
            //-2*x^3 + 6*x^2 + 4
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            try
            {
                string symbolOfVariable = SymbolOfVariableTextBox.Text;
                //получение и разделение выражения на числа и знаки
                string function = FunctionTextBox.Text;
                string pattern = @"(\s+)";
                Regex regex = new Regex(pattern);
                List<string> buf = new List<string>();
                foreach (string result in regex.Split(function))
                {
                    buf.Add(result);
                }
                function = string.Empty;
                foreach(var item in buf)
                {
                    function += item;
                }
                string toCalculateOrigin = string.Empty;
                for(int i = 0; i < function.Length; i++)
                {
                    if (function[i] == '^')
                    {
                        for(int j = 1; j < int.Parse(function[i+1].ToString()); j++)
                        {
                            toCalculateOrigin += "*"+ function[i - 1];
                        }
                        i++;
                        continue;
                    }
                    toCalculateOrigin+= function[i];
                }
                a0 = double.Parse(a0TextBox.Text);
                b0 = double.Parse(b0TextBox.Text);
                E = double.Parse(EtextBox.Text);
                for(double i = a0; i <= b0; i += 0.01)
                {
                    string toCalculate1 = toCalculateOrigin.Replace(symbolOfVariable, "(" + i.ToString() + ")");
                    toCalculate1 = toCalculate1.Replace(',', '.');
                    double y = double.Parse(new DataTable().Compute(toCalculate1, null).ToString());
                    chart1.Series[1].Points.AddXY(i, y);
                }
                double x0,b,a,x1,x2;
                a = a0;
                b = b0;
                double res = 0;
                int count = 0;
                if (radioButton1.Checked)   //половинного деления
                {
                    x0 = (a - b) / 2;
                    while ((Math.Abs(b-a))>E)
                    {
                        count++;
                        x1 = a + 0.25 * (b - a);
                        x2 = b - 0.25 * (b - a);
                        string toCalculate1 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x1.ToString() + ")");
                        toCalculate1 = toCalculate1.Replace(',', '.');
                        double value1 = double.Parse(new DataTable().Compute(toCalculate1, null).ToString());
                        string toCalculate2 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x2.ToString() + ")");
                        toCalculate2 = toCalculate2.Replace(',', '.');
                        double value2 = double.Parse(new DataTable().Compute(toCalculate2, null).ToString());
                        
                        chart1.Series[0].Points.AddXY(x1, value1);
                        chart1.Series[0].Points.AddXY(x2, value2);
                        if (value1 > value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) > f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x2;
                            a = x0;
                            x0 = x1;
                        }
                        else if (value1 < value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) < f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x1;
                            b = x0;
                            x0 = x2;
                        }
                        else
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) = f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x0;
                            
                            break;
                        }
                    }
                    
                    ResultLabel.Text = symbolOfVariable+" = " + res.ToString();
                    StatusRichTextBox.Text += Environment.NewLine+ Environment.NewLine+"Ответ: x = " + res.ToString() + Environment.NewLine + "Количество итераций = " + count.ToString();

                }
                else if (radioButton2.Checked)  //золотго сечения
                {
                    while ((Math.Abs(b - a)) > E)
                    {
                        count++;
                        double s = b - a;
                        x1 = 0.38 * s + a;
                        x2 = 0.62 * s + a;
                        double s1 = b - x2;
                        double s2 = s - 2 * s1;
                        string toCalculate1 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x1.ToString() + ")");
                        toCalculate1 = toCalculate1.Replace(',', '.');
                        double value1 = double.Parse(new DataTable().Compute(toCalculate1, null).ToString());
                        string toCalculate2 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x2.ToString() + ")");
                        toCalculate2 = toCalculate2.Replace(',', '.');
                        double value2 = double.Parse(new DataTable().Compute(toCalculate2, null).ToString());

                        chart1.Series[0].Points.AddXY(x1, value1);
                        chart1.Series[0].Points.AddXY(x2, value2);
                        if (value1 > value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) > f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x2;
                            a = x1;
                        }
                        else if (value1 < value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) < f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x1;
                            b = x2;
                        }
                        else
                        {
                            res = x1;
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) = f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            break;
                        }
                    }
                    ResultLabel.Text = symbolOfVariable + " = " + res.ToString();
                    StatusRichTextBox.Text += Environment.NewLine + Environment.NewLine + "Ответ: x = " + res.ToString() + Environment.NewLine + "Количество итераций = " + count.ToString();
                }
                else if (radioButton3.Checked)  //Фибоначчи
                {
                    int n=1;
                    while(((Math.Abs(b - a) / E) > Fibonacci(n))){
                        n++;
                    }
                    x1 = a + (b - a) * Fibonacci(n - 2) / Fibonacci(n);
                    x2 = a + (b - a) * Fibonacci(n - 1) / Fibonacci(n);

                    while (((Math.Abs(b - a)) > E)||(n<=0))
                    {
                        count++;
                        string toCalculate1 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x1.ToString() + ")");
                        toCalculate1 = toCalculate1.Replace(',', '.');
                        double value1 = double.Parse(new DataTable().Compute(toCalculate1, null).ToString());
                        string toCalculate2 = toCalculateOrigin.Replace(symbolOfVariable, "(" + x2.ToString() + ")");
                        toCalculate2 = toCalculate2.Replace(',', '.');
                        double value2 = double.Parse(new DataTable().Compute(toCalculate2, null).ToString());
                        n--;
                        chart1.Series[0].Points.AddXY(x1, value1);
                        chart1.Series[0].Points.AddXY(x2, value2);
                        if (value1 > value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) > f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x2;
                            a = x1;
                            x1 = x2;
                            x2 = b - (x1 - a);
                        }
                        else if (value1 < value2)
                        {
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) < f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            res = x1;
                            b = x2;
                            x2 = x1;
                            x1 = a + (b - x2);
                        }
                        else
                        {
                            res = x1;
                            StatusRichTextBox.Text += Environment.NewLine + "f(x1) = f(x2), f(x1) = " + value1.ToString() + ", f(x2) = " + value2.ToString() +
                                Environment.NewLine + "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                            break;
                        }
                    }
                    ResultLabel.Text = symbolOfVariable + " = " + res.ToString();
                    StatusRichTextBox.Text += Environment.NewLine + Environment.NewLine + "Ответ: x = " + res.ToString()+ Environment.NewLine+"Количество итераций = "+count.ToString();
                }  
            }
            catch
            {
                StatusRichTextBox.Text = "!>Не удалось!";
            }
        }

        int Fibonacci(int a)
        {
            if(a == 1)
            {
                return 1;
            }
            else if(a == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(a - 1) + Fibonacci(a - 2);
            }
        }
    }
}
