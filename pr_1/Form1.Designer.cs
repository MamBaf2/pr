namespace pr_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(21, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "sin(x)";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "cos(x)";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(628, 271);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xmin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xmax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Шаг";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(21, 359);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(72, 20);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(99, 359);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(72, 20);
            this.txtMax.TabIndex = 4;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(177, 359);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(72, 20);
            this.txtStep.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(255, 353);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(92, 30);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Расчёт!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Переход ко второй форме";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Построение графика функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button button1;
    }
}

