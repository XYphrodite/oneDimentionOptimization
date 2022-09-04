namespace oneDimentionOptimization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SymbolOfVariableTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.a0TextBox = new System.Windows.Forms.TextBox();
            this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SymbolOfVariableLabel = new System.Windows.Forms.Label();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.a0Label = new System.Windows.Forms.Label();
            this.b0Label = new System.Windows.Forms.Label();
            this.b0TextBox = new System.Windows.Forms.TextBox();
            this.StatusBarLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // SymbolOfVariableTextBox
            // 
            this.SymbolOfVariableTextBox.Location = new System.Drawing.Point(89, 9);
            this.SymbolOfVariableTextBox.Name = "SymbolOfVariableTextBox";
            this.SymbolOfVariableTextBox.Size = new System.Drawing.Size(24, 20);
            this.SymbolOfVariableTextBox.TabIndex = 0;
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Location = new System.Drawing.Point(89, 35);
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(100, 20);
            this.FunctionTextBox.TabIndex = 1;
            // 
            // a0TextBox
            // 
            this.a0TextBox.Location = new System.Drawing.Point(89, 61);
            this.a0TextBox.Name = "a0TextBox";
            this.a0TextBox.Size = new System.Drawing.Size(100, 20);
            this.a0TextBox.TabIndex = 2;
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Location = new System.Drawing.Point(12, 329);
            this.StatusRichTextBox.Name = "StatusRichTextBox";
            this.StatusRichTextBox.Size = new System.Drawing.Size(902, 109);
            this.StatusRichTextBox.TabIndex = 3;
            this.StatusRichTextBox.Text = "";
            // 
            // SymbolOfVariableLabel
            // 
            this.SymbolOfVariableLabel.AutoSize = true;
            this.SymbolOfVariableLabel.Location = new System.Drawing.Point(12, 16);
            this.SymbolOfVariableLabel.Name = "SymbolOfVariableLabel";
            this.SymbolOfVariableLabel.Size = new System.Drawing.Size(71, 13);
            this.SymbolOfVariableLabel.TabIndex = 4;
            this.SymbolOfVariableLabel.Text = "Переменная";
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Location = new System.Drawing.Point(12, 42);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(53, 13);
            this.FunctionLabel.TabIndex = 5;
            this.FunctionLabel.Text = "Функция";
            // 
            // a0Label
            // 
            this.a0Label.AutoSize = true;
            this.a0Label.Location = new System.Drawing.Point(12, 68);
            this.a0Label.Name = "a0Label";
            this.a0Label.Size = new System.Drawing.Size(19, 13);
            this.a0Label.TabIndex = 6;
            this.a0Label.Text = "a0";
            // 
            // b0Label
            // 
            this.b0Label.AutoSize = true;
            this.b0Label.Location = new System.Drawing.Point(12, 94);
            this.b0Label.Name = "b0Label";
            this.b0Label.Size = new System.Drawing.Size(19, 13);
            this.b0Label.TabIndex = 7;
            this.b0Label.Text = "b0";
            // 
            // b0TextBox
            // 
            this.b0TextBox.Location = new System.Drawing.Point(89, 87);
            this.b0TextBox.Name = "b0TextBox";
            this.b0TextBox.Size = new System.Drawing.Size(100, 20);
            this.b0TextBox.TabIndex = 8;
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.AutoSize = true;
            this.StatusBarLabel.Location = new System.Drawing.Point(12, 313);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(99, 13);
            this.StatusBarLabel.TabIndex = 9;
            this.StatusBarLabel.Text = "Строка состояния";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 262);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(71, 13);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Результат: —";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(225, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(338, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(569, 12);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(345, 300);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(15, 134);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(174, 23);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.StatusBarLabel);
            this.Controls.Add(this.b0TextBox);
            this.Controls.Add(this.b0Label);
            this.Controls.Add(this.a0Label);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.SymbolOfVariableLabel);
            this.Controls.Add(this.StatusRichTextBox);
            this.Controls.Add(this.a0TextBox);
            this.Controls.Add(this.FunctionTextBox);
            this.Controls.Add(this.SymbolOfVariableTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SymbolOfVariableTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.TextBox a0TextBox;
        private System.Windows.Forms.RichTextBox StatusRichTextBox;
        private System.Windows.Forms.Label SymbolOfVariableLabel;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Label a0Label;
        private System.Windows.Forms.Label b0Label;
        private System.Windows.Forms.TextBox b0TextBox;
        private System.Windows.Forms.Label StatusBarLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button CalculateButton;
    }
}

