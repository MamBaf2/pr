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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtKolvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSymb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите строку: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество символов: ";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(219, 151);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(74, 29);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Подсчитать";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(155, 33);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(138, 20);
            this.txtStr.TabIndex = 2;
            // 
            // txtKolvo
            // 
            this.txtKolvo.Location = new System.Drawing.Point(182, 112);
            this.txtKolvo.Name = "txtKolvo";
            this.txtKolvo.Size = new System.Drawing.Size(111, 20);
            this.txtKolvo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите символ \"ма\" или \"а\"";
            // 
            // txtSymb
            // 
            this.txtSymb.Location = new System.Drawing.Point(206, 74);
            this.txtSymb.Name = "txtSymb";
            this.txtSymb.Size = new System.Drawing.Size(87, 20);
            this.txtSymb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 215);
            this.Controls.Add(this.txtSymb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKolvo);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Строковые функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtKolvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSymb;
    }
}

