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
            this.components = new System.ComponentModel.Container();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(263, 79);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtSeconds.TabIndex = 0;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(55, 79);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(100, 20);
            this.txtMinutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(174, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "мин";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(369, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "сек";
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(321, 186);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 24);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(44, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(12, 12);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(103, 20);
            this.Date.TabIndex = 4;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 239);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtSeconds);
            this.Name = "Form1";
            this.Text = "Секундомер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox Date;
    }
}

