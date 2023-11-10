namespace pr_1
{
    partial class form
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(121, 12);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(202, 199);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(147, 247);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(140, 27);
            this.btn.TabIndex = 1;
            this.btn.Text = "Загрузить картинОЧКУ";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(461, 326);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pct);
            this.Name = "form";
            this.Text = "формОЧКА";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog file1;
    }
}

