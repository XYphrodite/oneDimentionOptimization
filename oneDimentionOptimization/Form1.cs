using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneDimentionOptimization
{
    public partial class Form1 : Form
    {
        int a0, b0; //-6 1
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            StatusRichTextBox.Clear();
            //–2x^3 + 6x^2 + 4
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
                string toCalculate = string.Empty;
                for(int i = 0; i < function.Length; i++)
                {
                    if (function[i] == '^')
                    {
                        for(int j = 1; j < int.Parse(function[i+1].ToString()); j++)
                        {
                            toCalculate += "*"+ function[i - 1];
                        }
                        i++;
                        continue;
                    }
                    toCalculate+= function[i];
                }
                a0 = int.Parse(a0TextBox.Text);
                b0 = int.Parse(b0TextBox.Text);
                int d = 5;
                toCalculate = toCalculate.Replace(symbolOfVariable, d.ToString());
                string value = new DataTable().Compute(toCalculate, null).ToString();
                StatusRichTextBox.Text += value;


                
            }
            catch
            {
                StatusRichTextBox.Text = "!>Не удалось!";
            }
            
            
        }
    }
}
