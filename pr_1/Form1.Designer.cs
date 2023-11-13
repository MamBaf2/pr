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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblArr = new System.Windows.Forms.Label();
            this.btnNewArr = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Enabled = false;
            this.txtN.Location = new System.Drawing.Point(168, 24);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(69, 20);
            this.txtN.TabIndex = 0;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(139, 68);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(69, 20);
            this.txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(139, 107);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(69, 20);
            this.txtMax.TabIndex = 0;
            // 
            // lblArr
            // 
            this.lblArr.AutoSize = true;
            this.lblArr.BackColor = System.Drawing.SystemColors.Control;
            this.lblArr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblArr.Location = new System.Drawing.Point(3, 0);
            this.lblArr.Name = "lblArr";
            this.lblArr.Size = new System.Drawing.Size(99, 13);
            this.lblArr.TabIndex = 2;
            this.lblArr.Text = "Исходный массив";
            // 
            // btnNewArr
            // 
            this.btnNewArr.BackColor = System.Drawing.SystemColors.Menu;
            this.btnNewArr.Location = new System.Drawing.Point(77, 354);
            this.btnNewArr.Name = "btnNewArr";
            this.btnNewArr.Size = new System.Drawing.Size(111, 26);
            this.btnNewArr.TabIndex = 3;
            this.btnNewArr.Text = "Новый массив";
            this.btnNewArr.UseVisualStyleBackColor = false;
            this.btnNewArr.Click += new System.EventHandler(this.btnNewArr_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(215, 354);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(111, 26);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировка";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(445, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(7, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(142, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Преобразованный массив";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество чисел в массиве:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нижняя граница чисел:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Верхняя граница чисел:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Параметры массива";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Location = new System.Drawing.Point(7, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArr);
            this.groupBox2.Location = new System.Drawing.Point(10, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Location = new System.Drawing.Point(6, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 50);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnNewArr);
            this.Name = "Form1";
            this.Text = "Сортировка массива";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblArr;
        private System.Windows.Forms.Button btnNewArr;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

