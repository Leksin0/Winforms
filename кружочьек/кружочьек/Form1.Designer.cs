
namespace кружочьек
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
            this.panCanvas = new System.Windows.Forms.Panel();
            this.cmbxSize = new System.Windows.Forms.ComboBox();
            this.cmbxShape = new System.Windows.Forms.ComboBox();
            this.cmbxColor = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblShape = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panCanvas
            // 
            this.panCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCanvas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panCanvas.Location = new System.Drawing.Point(12, 122);
            this.panCanvas.Name = "panCanvas";
            this.panCanvas.Size = new System.Drawing.Size(776, 316);
            this.panCanvas.TabIndex = 0;
            this.panCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panCanvas_Paint);
            // 
            // cmbxSize
            // 
            this.cmbxSize.FormattingEnabled = true;
            this.cmbxSize.Items.AddRange(new object[] {
            "Большой",
            "Средний",
            "Маленький"});
            this.cmbxSize.Location = new System.Drawing.Point(38, 55);
            this.cmbxSize.Name = "cmbxSize";
            this.cmbxSize.Size = new System.Drawing.Size(121, 21);
            this.cmbxSize.TabIndex = 1;
            // 
            // cmbxShape
            // 
            this.cmbxShape.FormattingEnabled = true;
            this.cmbxShape.Location = new System.Drawing.Point(214, 55);
            this.cmbxShape.Name = "cmbxShape";
            this.cmbxShape.Size = new System.Drawing.Size(121, 21);
            this.cmbxShape.TabIndex = 2;
            // 
            // cmbxColor
            // 
            this.cmbxColor.FormattingEnabled = true;
            this.cmbxColor.Location = new System.Drawing.Point(392, 55);
            this.cmbxColor.Name = "cmbxColor";
            this.cmbxColor.Size = new System.Drawing.Size(121, 21);
            this.cmbxColor.TabIndex = 3;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(38, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Размер";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(570, 15);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(218, 61);
            this.btnDraw.TabIndex = 5;
            this.btnDraw.Text = "Рисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(211, 20);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(44, 13);
            this.lblShape.TabIndex = 6;
            this.lblShape.Text = "Форма";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(389, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Цвет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cmbxColor);
            this.Controls.Add(this.cmbxShape);
            this.Controls.Add(this.cmbxSize);
            this.Controls.Add(this.panCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panCanvas;
        private System.Windows.Forms.ComboBox cmbxSize;
        private System.Windows.Forms.ComboBox cmbxShape;
        private System.Windows.Forms.ComboBox cmbxColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblColor;
    }
}

