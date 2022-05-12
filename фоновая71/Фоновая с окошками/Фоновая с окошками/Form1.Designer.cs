
namespace Фоновая_с_окошками
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ravnostr = new System.Windows.Forms.RadioButton();
            this.Rectangular = new System.Windows.Forms.RadioButton();
            this.Manually = new System.Windows.Forms.RadioButton();
            this.Automaticaly = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Generate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ravnostr);
            this.groupBox1.Controls.Add(this.Rectangular);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тип треугольника";
            // 
            // Ravnostr
            // 
            this.Ravnostr.AutoSize = true;
            this.Ravnostr.Location = new System.Drawing.Point(124, 19);
            this.Ravnostr.Name = "Ravnostr";
            this.Ravnostr.Size = new System.Drawing.Size(109, 17);
            this.Ravnostr.TabIndex = 1;
            this.Ravnostr.TabStop = true;
            this.Ravnostr.Text = "Равносторонний";
            this.Ravnostr.UseVisualStyleBackColor = true;
            this.Ravnostr.CheckedChanged += new System.EventHandler(this.Ravnostr_CheckedChanged);
            // 
            // Rectangular
            // 
            this.Rectangular.AutoSize = true;
            this.Rectangular.Location = new System.Drawing.Point(11, 19);
            this.Rectangular.Name = "Rectangular";
            this.Rectangular.Size = new System.Drawing.Size(107, 17);
            this.Rectangular.TabIndex = 0;
            this.Rectangular.TabStop = true;
            this.Rectangular.Text = "Прямоугольный";
            this.Rectangular.UseVisualStyleBackColor = true;
            this.Rectangular.CheckedChanged += new System.EventHandler(this.Rectangular_CheckedChanged);
            // 
            // Manually
            // 
            this.Manually.AutoSize = true;
            this.Manually.Location = new System.Drawing.Point(6, 19);
            this.Manually.Name = "Manually";
            this.Manually.Size = new System.Drawing.Size(67, 17);
            this.Manually.TabIndex = 1;
            this.Manually.TabStop = true;
            this.Manually.Text = "Вручную";
            this.Manually.UseVisualStyleBackColor = true;
            this.Manually.CheckedChanged += new System.EventHandler(this.Manually_CheckedChanged);
            // 
            // Automaticaly
            // 
            this.Automaticaly.AutoSize = true;
            this.Automaticaly.Location = new System.Drawing.Point(79, 19);
            this.Automaticaly.Name = "Automaticaly";
            this.Automaticaly.Size = new System.Drawing.Size(103, 17);
            this.Automaticaly.TabIndex = 2;
            this.Automaticaly.TabStop = true;
            this.Automaticaly.Text = "Автоматически";
            this.Automaticaly.UseVisualStyleBackColor = true;
            this.Automaticaly.CheckedChanged += new System.EventHandler(this.Automaticaly_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Manually);
            this.groupBox2.Controls.Add(this.Automaticaly);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите вариант создания";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 56);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(1, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 57);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина стороны 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Длина стороны 2 ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(1, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 85);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(399, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 277);
            this.panel4.TabIndex = 11;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Generate.ForeColor = System.Drawing.Color.Black;
            this.Generate.Location = new System.Drawing.Point(1, 221);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(395, 59);
            this.Generate.TabIndex = 12;
            this.Generate.Text = "Создать";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ravnostr;
        private System.Windows.Forms.RadioButton Rectangular;
        private System.Windows.Forms.RadioButton Manually;
        private System.Windows.Forms.RadioButton Automaticaly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Generate;
    }
}

