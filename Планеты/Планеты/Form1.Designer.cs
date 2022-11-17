namespace Планеты
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
            this.Space = new System.Windows.Forms.Panel();
            this.chbSun = new System.Windows.Forms.CheckBox();
            this.chbComet = new System.Windows.Forms.CheckBox();
            this.chbSaturn = new System.Windows.Forms.CheckBox();
            this.chbMoon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Space
            // 
            this.Space.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Space.Location = new System.Drawing.Point(13, 36);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(759, 513);
            this.Space.TabIndex = 0;
            this.Space.SizeChanged += new System.EventHandler(this.Space_SizeChanged);
            this.Space.Paint += new System.Windows.Forms.PaintEventHandler(this.Space_Paint);
            // 
            // chbSun
            // 
            this.chbSun.AutoSize = true;
            this.chbSun.Location = new System.Drawing.Point(13, 13);
            this.chbSun.Name = "chbSun";
            this.chbSun.Size = new System.Drawing.Size(63, 17);
            this.chbSun.TabIndex = 1;
            this.chbSun.Text = "Солнце";
            this.chbSun.UseVisualStyleBackColor = true;
            this.chbSun.CheckedChanged += new System.EventHandler(this.chbSun_CheckedChanged);
            // 
            // chbComet
            // 
            this.chbComet.AutoSize = true;
            this.chbComet.Location = new System.Drawing.Point(139, 12);
            this.chbComet.Name = "chbComet";
            this.chbComet.Size = new System.Drawing.Size(64, 17);
            this.chbComet.TabIndex = 2;
            this.chbComet.Text = "Комета";
            this.chbComet.UseVisualStyleBackColor = true;
            this.chbComet.CheckedChanged += new System.EventHandler(this.chbComet_CheckedChanged);
            // 
            // chbSaturn
            // 
            this.chbSaturn.AutoSize = true;
            this.chbSaturn.Location = new System.Drawing.Point(209, 12);
            this.chbSaturn.Name = "chbSaturn";
            this.chbSaturn.Size = new System.Drawing.Size(61, 17);
            this.chbSaturn.TabIndex = 3;
            this.chbSaturn.Text = "Сатурн";
            this.chbSaturn.UseVisualStyleBackColor = true;
            this.chbSaturn.CheckedChanged += new System.EventHandler(this.chbSaturn_CheckedChanged);
            // 
            // chbMoon
            // 
            this.chbMoon.AutoSize = true;
            this.chbMoon.Location = new System.Drawing.Point(82, 12);
            this.chbMoon.Name = "chbMoon";
            this.chbMoon.Size = new System.Drawing.Size(51, 17);
            this.chbMoon.TabIndex = 4;
            this.chbMoon.Text = "Луна";
            this.chbMoon.UseVisualStyleBackColor = true;
            this.chbMoon.CheckedChanged += new System.EventHandler(this.chbMoon_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.chbMoon);
            this.Controls.Add(this.chbSaturn);
            this.Controls.Add(this.chbComet);
            this.Controls.Add(this.chbSun);
            this.Controls.Add(this.Space);
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Space;
        private System.Windows.Forms.CheckBox chbSun;
        private System.Windows.Forms.CheckBox chbComet;
        private System.Windows.Forms.CheckBox chbSaturn;
        private System.Windows.Forms.CheckBox chbMoon;
    }
}

