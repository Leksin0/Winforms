namespace Многоугольники
{
    partial class Mnogougolniki
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smi_ShapesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Square = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_ShapesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smi_ShapesMenu
            // 
            this.smi_ShapesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_Circle,
            this.smi_Square,
            this.smi_Triangle});
            this.smi_ShapesMenu.Name = "smi_ShapesMenu";
            this.smi_ShapesMenu.Size = new System.Drawing.Size(113, 20);
            this.smi_ShapesMenu.Text = "Форма вершины";
            // 
            // smi_Circle
            // 
            this.smi_Circle.Name = "smi_Circle";
            this.smi_Circle.Size = new System.Drawing.Size(180, 22);
            this.smi_Circle.Text = "Круг";
            this.smi_Circle.Click += new System.EventHandler(this.smi_Circle_Click);
            // 
            // smi_Square
            // 
            this.smi_Square.Name = "smi_Square";
            this.smi_Square.Size = new System.Drawing.Size(180, 22);
            this.smi_Square.Text = "Квадрат";
            this.smi_Square.Click += new System.EventHandler(this.smi_Square_Click);
            // 
            // smi_Triangle
            // 
            this.smi_Triangle.Name = "smi_Triangle";
            this.smi_Triangle.Size = new System.Drawing.Size(180, 22);
            this.smi_Triangle.Text = "Тругольник";
            this.smi_Triangle.Click += new System.EventHandler(this.smi_Triangle_Click);
            // 
            // Mnogougolniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mnogougolniki";
            this.Text = "Многоугольники(скоро будут)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smi_ShapesMenu;
        private System.Windows.Forms.ToolStripMenuItem smi_Circle;
        private System.Windows.Forms.ToolStripMenuItem smi_Square;
        private System.Windows.Forms.ToolStripMenuItem smi_Triangle;
    }
}

