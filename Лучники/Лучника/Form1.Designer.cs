
namespace Лучника
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArcher1Shot = new System.Windows.Forms.Button();
            this.btnArcher2Shot = new System.Windows.Forms.Button();
            this.chbArcher1Load = new System.Windows.Forms.CheckBox();
            this.chbArcher2Load = new System.Windows.Forms.CheckBox();
            this.imgArcher1 = new System.Windows.Forms.PictureBox();
            this.imgArcher2 = new System.Windows.Forms.PictureBox();
            this.lblArcher1Health = new System.Windows.Forms.Label();
            this.lblArcher2Health = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblArcher1Name = new System.Windows.Forms.Label();
            this.lblArcher2Name = new System.Windows.Forms.Label();
            this.txbName1 = new System.Windows.Forms.TextBox();
            this.lblEnterUrNames = new System.Windows.Forms.Label();
            this.txbName2 = new System.Windows.Forms.TextBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArcher1Shot
            // 
            this.btnArcher1Shot.Location = new System.Drawing.Point(197, 212);
            this.btnArcher1Shot.Name = "btnArcher1Shot";
            this.btnArcher1Shot.Size = new System.Drawing.Size(149, 47);
            this.btnArcher1Shot.TabIndex = 0;
            this.btnArcher1Shot.Text = "Выстрел";
            this.btnArcher1Shot.UseVisualStyleBackColor = true;
            this.btnArcher1Shot.Visible = false;
            this.btnArcher1Shot.Click += new System.EventHandler(this.btnArcher1Shot_Click);
            // 
            // btnArcher2Shot
            // 
            this.btnArcher2Shot.Location = new System.Drawing.Point(470, 212);
            this.btnArcher2Shot.Name = "btnArcher2Shot";
            this.btnArcher2Shot.Size = new System.Drawing.Size(147, 47);
            this.btnArcher2Shot.TabIndex = 1;
            this.btnArcher2Shot.Text = "Выстрел";
            this.btnArcher2Shot.UseVisualStyleBackColor = true;
            this.btnArcher2Shot.Visible = false;
            this.btnArcher2Shot.Click += new System.EventHandler(this.btnArcher2Shot_Click);
            // 
            // chbArcher1Load
            // 
            this.chbArcher1Load.AutoSize = true;
            this.chbArcher1Load.Location = new System.Drawing.Point(197, 182);
            this.chbArcher1Load.Name = "chbArcher1Load";
            this.chbArcher1Load.Size = new System.Drawing.Size(76, 19);
            this.chbArcher1Load.TabIndex = 2;
            this.chbArcher1Load.Text = "Зарядить";
            this.chbArcher1Load.UseVisualStyleBackColor = true;
            this.chbArcher1Load.Visible = false;
            // 
            // chbArcher2Load
            // 
            this.chbArcher2Load.AutoSize = true;
            this.chbArcher2Load.Location = new System.Drawing.Point(541, 187);
            this.chbArcher2Load.Name = "chbArcher2Load";
            this.chbArcher2Load.Size = new System.Drawing.Size(76, 19);
            this.chbArcher2Load.TabIndex = 3;
            this.chbArcher2Load.Text = "Зарядить";
            this.chbArcher2Load.UseVisualStyleBackColor = true;
            this.chbArcher2Load.Visible = false;
            // 
            // imgArcher1
            // 
            this.imgArcher1.Image = ((System.Drawing.Image)(resources.GetObject("imgArcher1.Image")));
            this.imgArcher1.Location = new System.Drawing.Point(41, 183);
            this.imgArcher1.Name = "imgArcher1";
            this.imgArcher1.Size = new System.Drawing.Size(149, 256);
            this.imgArcher1.TabIndex = 4;
            this.imgArcher1.TabStop = false;
            // 
            // imgArcher2
            // 
            this.imgArcher2.Image = ((System.Drawing.Image)(resources.GetObject("imgArcher2.Image")));
            this.imgArcher2.Location = new System.Drawing.Point(623, 183);
            this.imgArcher2.Name = "imgArcher2";
            this.imgArcher2.Size = new System.Drawing.Size(147, 255);
            this.imgArcher2.TabIndex = 5;
            this.imgArcher2.TabStop = false;
            // 
            // lblArcher1Health
            // 
            this.lblArcher1Health.AutoSize = true;
            this.lblArcher1Health.Location = new System.Drawing.Point(41, 144);
            this.lblArcher1Health.Name = "lblArcher1Health";
            this.lblArcher1Health.Size = new System.Drawing.Size(83, 15);
            this.lblArcher1Health.TabIndex = 6;
            this.lblArcher1Health.Text = "Здоровье: 100";
            this.lblArcher1Health.Visible = false;
            // 
            // lblArcher2Health
            // 
            this.lblArcher2Health.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArcher2Health.AutoSize = true;
            this.lblArcher2Health.Location = new System.Drawing.Point(623, 144);
            this.lblArcher2Health.Name = "lblArcher2Health";
            this.lblArcher2Health.Size = new System.Drawing.Size(83, 15);
            this.lblArcher2Health.TabIndex = 7;
            this.lblArcher2Health.Text = "Здоровье: 100";
            this.lblArcher2Health.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(327, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 47);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblArcher1Name
            // 
            this.lblArcher1Name.AutoSize = true;
            this.lblArcher1Name.Location = new System.Drawing.Point(41, 121);
            this.lblArcher1Name.Name = "lblArcher1Name";
            this.lblArcher1Name.Size = new System.Drawing.Size(27, 15);
            this.lblArcher1Name.TabIndex = 9;
            this.lblArcher1Name.Text = "лох";
            this.lblArcher1Name.Visible = false;
            // 
            // lblArcher2Name
            // 
            this.lblArcher2Name.AutoSize = true;
            this.lblArcher2Name.Location = new System.Drawing.Point(623, 121);
            this.lblArcher2Name.Name = "lblArcher2Name";
            this.lblArcher2Name.Size = new System.Drawing.Size(32, 15);
            this.lblArcher2Name.TabIndex = 10;
            this.lblArcher2Name.Text = "негр";
            this.lblArcher2Name.Visible = false;
            // 
            // txbName1
            // 
            this.txbName1.Location = new System.Drawing.Point(262, 78);
            this.txbName1.Name = "txbName1";
            this.txbName1.Size = new System.Drawing.Size(100, 23);
            this.txbName1.TabIndex = 11;
            // 
            // lblEnterUrNames
            // 
            this.lblEnterUrNames.AutoSize = true;
            this.lblEnterUrNames.Location = new System.Drawing.Point(327, 43);
            this.lblEnterUrNames.Name = "lblEnterUrNames";
            this.lblEnterUrNames.Size = new System.Drawing.Size(136, 15);
            this.lblEnterUrNames.TabIndex = 12;
            this.lblEnterUrNames.Text = "Введите имена игроков";
            // 
            // txbName2
            // 
            this.txbName2.Location = new System.Drawing.Point(443, 78);
            this.txbName2.Name = "txbName2";
            this.txbName2.Size = new System.Drawing.Size(100, 23);
            this.txbName2.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(381, 380);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(30, 15);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "winr";
            this.lblWinner.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.txbName2);
            this.Controls.Add(this.lblEnterUrNames);
            this.Controls.Add(this.txbName1);
            this.Controls.Add(this.lblArcher2Name);
            this.Controls.Add(this.lblArcher1Name);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblArcher2Health);
            this.Controls.Add(this.lblArcher1Health);
            this.Controls.Add(this.imgArcher2);
            this.Controls.Add(this.imgArcher1);
            this.Controls.Add(this.chbArcher2Load);
            this.Controls.Add(this.chbArcher1Load);
            this.Controls.Add(this.btnArcher2Shot);
            this.Controls.Add(this.btnArcher1Shot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArcher1Shot;
        private System.Windows.Forms.Button btnArcher2Shot;
        private System.Windows.Forms.CheckBox chbArcher1Load;
        private System.Windows.Forms.CheckBox chbArcher2Load;
        private System.Windows.Forms.PictureBox imgArcher1;
        private System.Windows.Forms.PictureBox imgArcher2;
        private System.Windows.Forms.Label lblArcher1Health;
        private System.Windows.Forms.Label lblArcher2Health;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblArcher1Name;
        private System.Windows.Forms.Label lblArcher2Name;
        private System.Windows.Forms.TextBox txbName1;
        private System.Windows.Forms.Label lblEnterUrNames;
        private System.Windows.Forms.TextBox txbName2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Timer timer1;
    }
}

