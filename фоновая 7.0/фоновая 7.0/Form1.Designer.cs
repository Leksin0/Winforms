
namespace фоновая_7._0
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
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(171, 202);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(120, 61);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(548, 202);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(120, 61);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нажмите любую кнопку\r\nИ смотрите, что произойдёт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Сумасшедшая кнопка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Label label1;
    }
}

