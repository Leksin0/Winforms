
namespace Лучники
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
            this.lblArcher1Arrows = new System.Windows.Forms.Label();
            this.lblArcher2Arrows = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnArcher1Soldier = new System.Windows.Forms.RadioButton();
            this.rbnArcher1Healer = new System.Windows.Forms.RadioButton();
            this.rbnArcher1Tank = new System.Windows.Forms.RadioButton();
            this.rbnArcher1Sniper = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnArcher2Soldier = new System.Windows.Forms.RadioButton();
            this.rbnArcher2Healer = new System.Windows.Forms.RadioButton();
            this.rbnArcher2Tank = new System.Windows.Forms.RadioButton();
            this.rbnArcher2Sniper = new System.Windows.Forms.RadioButton();
            this.btnArcher1Heal = new System.Windows.Forms.Button();
            this.btnArcher2Heal = new System.Windows.Forms.Button();
            this.lblClassesDescription1 = new System.Windows.Forms.Label();
            this.lblClassesDescription2 = new System.Windows.Forms.Label();
            this.grpStarterControls = new System.Windows.Forms.GroupBox();
            this.grpArcher1Controls = new System.Windows.Forms.GroupBox();
            this.grpArcher2Controls = new System.Windows.Forms.GroupBox();
            this.grpArcher1Stats = new System.Windows.Forms.GroupBox();
            this.grpArcher2Stats = new System.Windows.Forms.GroupBox();
            this.grpMainArchers = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpStarterControls.SuspendLayout();
            this.grpArcher1Controls.SuspendLayout();
            this.grpArcher2Controls.SuspendLayout();
            this.grpArcher1Stats.SuspendLayout();
            this.grpArcher2Stats.SuspendLayout();
            this.grpMainArchers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArcher1Shot
            // 
            this.btnArcher1Shot.Location = new System.Drawing.Point(6, 47);
            this.btnArcher1Shot.Name = "btnArcher1Shot";
            this.btnArcher1Shot.Size = new System.Drawing.Size(149, 47);
            this.btnArcher1Shot.TabIndex = 0;
            this.btnArcher1Shot.Text = "Выстрел";
            this.btnArcher1Shot.UseVisualStyleBackColor = true;
            this.btnArcher1Shot.Click += new System.EventHandler(this.btnArcher1Shot_Click);
            // 
            // btnArcher2Shot
            // 
            this.btnArcher2Shot.Location = new System.Drawing.Point(6, 47);
            this.btnArcher2Shot.Name = "btnArcher2Shot";
            this.btnArcher2Shot.Size = new System.Drawing.Size(147, 47);
            this.btnArcher2Shot.TabIndex = 1;
            this.btnArcher2Shot.Text = "Выстрел";
            this.btnArcher2Shot.UseVisualStyleBackColor = true;
            this.btnArcher2Shot.Click += new System.EventHandler(this.btnArcher2Shot_Click);
            // 
            // chbArcher1Load
            // 
            this.chbArcher1Load.AutoSize = true;
            this.chbArcher1Load.Location = new System.Drawing.Point(6, 22);
            this.chbArcher1Load.Name = "chbArcher1Load";
            this.chbArcher1Load.Size = new System.Drawing.Size(76, 19);
            this.chbArcher1Load.TabIndex = 2;
            this.chbArcher1Load.Text = "Зарядить";
            this.chbArcher1Load.UseVisualStyleBackColor = true;
            // 
            // chbArcher2Load
            // 
            this.chbArcher2Load.AutoSize = true;
            this.chbArcher2Load.Location = new System.Drawing.Point(6, 22);
            this.chbArcher2Load.Name = "chbArcher2Load";
            this.chbArcher2Load.Size = new System.Drawing.Size(76, 19);
            this.chbArcher2Load.TabIndex = 3;
            this.chbArcher2Load.Text = "Зарядить";
            this.chbArcher2Load.UseVisualStyleBackColor = true;
            // 
            // imgArcher1
            // 
            this.imgArcher1.Image = ((System.Drawing.Image)(resources.GetObject("imgArcher1.Image")));
            this.imgArcher1.Location = new System.Drawing.Point(6, 77);
            this.imgArcher1.Name = "imgArcher1";
            this.imgArcher1.Size = new System.Drawing.Size(149, 256);
            this.imgArcher1.TabIndex = 4;
            this.imgArcher1.TabStop = false;
            // 
            // imgArcher2
            // 
            this.imgArcher2.Image = ((System.Drawing.Image)(resources.GetObject("imgArcher2.Image")));
            this.imgArcher2.Location = new System.Drawing.Point(6, 77);
            this.imgArcher2.Name = "imgArcher2";
            this.imgArcher2.Size = new System.Drawing.Size(147, 255);
            this.imgArcher2.TabIndex = 5;
            this.imgArcher2.TabStop = false;
            // 
            // lblArcher1Health
            // 
            this.lblArcher1Health.AutoSize = true;
            this.lblArcher1Health.Location = new System.Drawing.Point(6, 38);
            this.lblArcher1Health.Name = "lblArcher1Health";
            this.lblArcher1Health.Size = new System.Drawing.Size(77, 15);
            this.lblArcher1Health.TabIndex = 6;
            this.lblArcher1Health.Text = "Здоровье: xx";
            this.lblArcher1Health.Visible = false;
            // 
            // lblArcher2Health
            // 
            this.lblArcher2Health.AutoSize = true;
            this.lblArcher2Health.Location = new System.Drawing.Point(6, 38);
            this.lblArcher2Health.Name = "lblArcher2Health";
            this.lblArcher2Health.Size = new System.Drawing.Size(77, 15);
            this.lblArcher2Health.TabIndex = 7;
            this.lblArcher2Health.Text = "Здоровье: xx";
            this.lblArcher2Health.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(149, 258);
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
            this.lblArcher1Name.Location = new System.Drawing.Point(6, 15);
            this.lblArcher1Name.Name = "lblArcher1Name";
            this.lblArcher1Name.Size = new System.Drawing.Size(37, 15);
            this.lblArcher1Name.TabIndex = 9;
            this.lblArcher1Name.Text = "Имя1";
            this.lblArcher1Name.Visible = false;
            // 
            // lblArcher2Name
            // 
            this.lblArcher2Name.AutoSize = true;
            this.lblArcher2Name.Location = new System.Drawing.Point(6, 15);
            this.lblArcher2Name.Name = "lblArcher2Name";
            this.lblArcher2Name.Size = new System.Drawing.Size(37, 15);
            this.lblArcher2Name.TabIndex = 10;
            this.lblArcher2Name.Text = "Имя2";
            this.lblArcher2Name.Visible = false;
            // 
            // txbName1
            // 
            this.txbName1.Location = new System.Drawing.Point(45, 57);
            this.txbName1.Name = "txbName1";
            this.txbName1.Size = new System.Drawing.Size(100, 23);
            this.txbName1.TabIndex = 11;
            // 
            // lblEnterUrNames
            // 
            this.lblEnterUrNames.AutoSize = true;
            this.lblEnterUrNames.Location = new System.Drawing.Point(85, 31);
            this.lblEnterUrNames.Name = "lblEnterUrNames";
            this.lblEnterUrNames.Size = new System.Drawing.Size(236, 15);
            this.lblEnterUrNames.TabIndex = 12;
            this.lblEnterUrNames.Text = "Введите имена игроков и выберите класс";
            // 
            // txbName2
            // 
            this.txbName2.Location = new System.Drawing.Point(248, 57);
            this.txbName2.Name = "txbName2";
            this.txbName2.Size = new System.Drawing.Size(100, 23);
            this.txbName2.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(346, 279);
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
            // lblArcher1Arrows
            // 
            this.lblArcher1Arrows.AutoSize = true;
            this.lblArcher1Arrows.Location = new System.Drawing.Point(6, 57);
            this.lblArcher1Arrows.Name = "lblArcher1Arrows";
            this.lblArcher1Arrows.Size = new System.Drawing.Size(67, 15);
            this.lblArcher1Arrows.TabIndex = 15;
            this.lblArcher1Arrows.Text = "Стрелы: xx";
            this.lblArcher1Arrows.Visible = false;
            // 
            // lblArcher2Arrows
            // 
            this.lblArcher2Arrows.AutoSize = true;
            this.lblArcher2Arrows.Location = new System.Drawing.Point(6, 57);
            this.lblArcher2Arrows.Name = "lblArcher2Arrows";
            this.lblArcher2Arrows.Size = new System.Drawing.Size(67, 15);
            this.lblArcher2Arrows.TabIndex = 16;
            this.lblArcher2Arrows.Text = "Стрелы: xx";
            this.lblArcher2Arrows.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnArcher1Soldier);
            this.groupBox1.Controls.Add(this.rbnArcher1Healer);
            this.groupBox1.Controls.Add(this.rbnArcher1Tank);
            this.groupBox1.Controls.Add(this.rbnArcher1Sniper);
            this.groupBox1.Location = new System.Drawing.Point(39, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите класс лучника";
            // 
            // rbnArcher1Soldier
            // 
            this.rbnArcher1Soldier.AutoSize = true;
            this.rbnArcher1Soldier.Location = new System.Drawing.Point(6, 22);
            this.rbnArcher1Soldier.Name = "rbnArcher1Soldier";
            this.rbnArcher1Soldier.Size = new System.Drawing.Size(64, 19);
            this.rbnArcher1Soldier.TabIndex = 3;
            this.rbnArcher1Soldier.TabStop = true;
            this.rbnArcher1Soldier.Text = "Солдат";
            this.rbnArcher1Soldier.UseVisualStyleBackColor = true;
            // 
            // rbnArcher1Healer
            // 
            this.rbnArcher1Healer.AutoSize = true;
            this.rbnArcher1Healer.Location = new System.Drawing.Point(6, 86);
            this.rbnArcher1Healer.Name = "rbnArcher1Healer";
            this.rbnArcher1Healer.Size = new System.Drawing.Size(61, 19);
            this.rbnArcher1Healer.TabIndex = 2;
            this.rbnArcher1Healer.TabStop = true;
            this.rbnArcher1Healer.Text = "Медик";
            this.rbnArcher1Healer.UseVisualStyleBackColor = true;
            // 
            // rbnArcher1Tank
            // 
            this.rbnArcher1Tank.AutoSize = true;
            this.rbnArcher1Tank.Location = new System.Drawing.Point(6, 64);
            this.rbnArcher1Tank.Name = "rbnArcher1Tank";
            this.rbnArcher1Tank.Size = new System.Drawing.Size(50, 19);
            this.rbnArcher1Tank.TabIndex = 1;
            this.rbnArcher1Tank.TabStop = true;
            this.rbnArcher1Tank.Text = "Танк";
            this.rbnArcher1Tank.UseVisualStyleBackColor = true;
            // 
            // rbnArcher1Sniper
            // 
            this.rbnArcher1Sniper.AutoSize = true;
            this.rbnArcher1Sniper.Location = new System.Drawing.Point(6, 43);
            this.rbnArcher1Sniper.Name = "rbnArcher1Sniper";
            this.rbnArcher1Sniper.Size = new System.Drawing.Size(73, 19);
            this.rbnArcher1Sniper.TabIndex = 0;
            this.rbnArcher1Sniper.TabStop = true;
            this.rbnArcher1Sniper.Text = "Снайпер";
            this.rbnArcher1Sniper.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnArcher2Soldier);
            this.groupBox2.Controls.Add(this.rbnArcher2Healer);
            this.groupBox2.Controls.Add(this.rbnArcher2Tank);
            this.groupBox2.Controls.Add(this.rbnArcher2Sniper);
            this.groupBox2.Location = new System.Drawing.Point(242, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 111);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберните класс лучника";
            // 
            // rbnArcher2Soldier
            // 
            this.rbnArcher2Soldier.AutoSize = true;
            this.rbnArcher2Soldier.Location = new System.Drawing.Point(6, 22);
            this.rbnArcher2Soldier.Name = "rbnArcher2Soldier";
            this.rbnArcher2Soldier.Size = new System.Drawing.Size(64, 19);
            this.rbnArcher2Soldier.TabIndex = 3;
            this.rbnArcher2Soldier.TabStop = true;
            this.rbnArcher2Soldier.Text = "Солдат";
            this.rbnArcher2Soldier.UseVisualStyleBackColor = true;
            // 
            // rbnArcher2Healer
            // 
            this.rbnArcher2Healer.AutoSize = true;
            this.rbnArcher2Healer.Location = new System.Drawing.Point(6, 86);
            this.rbnArcher2Healer.Name = "rbnArcher2Healer";
            this.rbnArcher2Healer.Size = new System.Drawing.Size(61, 19);
            this.rbnArcher2Healer.TabIndex = 2;
            this.rbnArcher2Healer.TabStop = true;
            this.rbnArcher2Healer.Text = "Медик";
            this.rbnArcher2Healer.UseVisualStyleBackColor = true;
            // 
            // rbnArcher2Tank
            // 
            this.rbnArcher2Tank.AutoSize = true;
            this.rbnArcher2Tank.Location = new System.Drawing.Point(6, 64);
            this.rbnArcher2Tank.Name = "rbnArcher2Tank";
            this.rbnArcher2Tank.Size = new System.Drawing.Size(50, 19);
            this.rbnArcher2Tank.TabIndex = 1;
            this.rbnArcher2Tank.TabStop = true;
            this.rbnArcher2Tank.Text = "Танк";
            this.rbnArcher2Tank.UseVisualStyleBackColor = true;
            // 
            // rbnArcher2Sniper
            // 
            this.rbnArcher2Sniper.AutoSize = true;
            this.rbnArcher2Sniper.Location = new System.Drawing.Point(6, 43);
            this.rbnArcher2Sniper.Name = "rbnArcher2Sniper";
            this.rbnArcher2Sniper.Size = new System.Drawing.Size(73, 19);
            this.rbnArcher2Sniper.TabIndex = 0;
            this.rbnArcher2Sniper.TabStop = true;
            this.rbnArcher2Sniper.Text = "Снайпер";
            this.rbnArcher2Sniper.UseVisualStyleBackColor = true;
            // 
            // btnArcher1Heal
            // 
            this.btnArcher1Heal.Location = new System.Drawing.Point(7, 106);
            this.btnArcher1Heal.Name = "btnArcher1Heal";
            this.btnArcher1Heal.Size = new System.Drawing.Size(148, 23);
            this.btnArcher1Heal.TabIndex = 19;
            this.btnArcher1Heal.Text = "Лечение";
            this.btnArcher1Heal.UseVisualStyleBackColor = true;
            this.btnArcher1Heal.Visible = false;
            // 
            // btnArcher2Heal
            // 
            this.btnArcher2Heal.Location = new System.Drawing.Point(6, 106);
            this.btnArcher2Heal.Name = "btnArcher2Heal";
            this.btnArcher2Heal.Size = new System.Drawing.Size(147, 23);
            this.btnArcher2Heal.TabIndex = 20;
            this.btnArcher2Heal.Text = "Лечение";
            this.btnArcher2Heal.UseVisualStyleBackColor = true;
            this.btnArcher2Heal.Visible = false;
            // 
            // lblClassesDescription1
            // 
            this.lblClassesDescription1.AutoSize = true;
            this.lblClassesDescription1.Location = new System.Drawing.Point(39, 204);
            this.lblClassesDescription1.Name = "lblClassesDescription1";
            this.lblClassesDescription1.Size = new System.Drawing.Size(316, 15);
            this.lblClassesDescription1.TabIndex = 21;
            this.lblClassesDescription1.Text = "Солдат - Базовые характеристики    Снайпер - Урон х1.5";
            // 
            // lblClassesDescription2
            // 
            this.lblClassesDescription2.AutoSize = true;
            this.lblClassesDescription2.Location = new System.Drawing.Point(39, 228);
            this.lblClassesDescription2.Name = "lblClassesDescription2";
            this.lblClassesDescription2.Size = new System.Drawing.Size(346, 15);
            this.lblClassesDescription2.TabIndex = 22;
            this.lblClassesDescription2.Text = "Танк - Здоровье х1.5    Медик - Может восстановить здоровье";
            // 
            // grpStarterControls
            // 
            this.grpStarterControls.Controls.Add(this.lblEnterUrNames);
            this.grpStarterControls.Controls.Add(this.lblClassesDescription2);
            this.grpStarterControls.Controls.Add(this.btnStart);
            this.grpStarterControls.Controls.Add(this.lblClassesDescription1);
            this.grpStarterControls.Controls.Add(this.txbName1);
            this.grpStarterControls.Controls.Add(this.txbName2);
            this.grpStarterControls.Controls.Add(this.groupBox1);
            this.grpStarterControls.Controls.Add(this.groupBox2);
            this.grpStarterControls.Location = new System.Drawing.Point(824, 43);
            this.grpStarterControls.Name = "grpStarterControls";
            this.grpStarterControls.Size = new System.Drawing.Size(432, 316);
            this.grpStarterControls.TabIndex = 23;
            this.grpStarterControls.TabStop = false;
            // 
            // grpArcher1Controls
            // 
            this.grpArcher1Controls.Controls.Add(this.chbArcher1Load);
            this.grpArcher1Controls.Controls.Add(this.btnArcher1Shot);
            this.grpArcher1Controls.Controls.Add(this.btnArcher1Heal);
            this.grpArcher1Controls.Location = new System.Drawing.Point(174, 99);
            this.grpArcher1Controls.Name = "grpArcher1Controls";
            this.grpArcher1Controls.Size = new System.Drawing.Size(160, 137);
            this.grpArcher1Controls.TabIndex = 24;
            this.grpArcher1Controls.TabStop = false;
            this.grpArcher1Controls.Visible = false;
            // 
            // grpArcher2Controls
            // 
            this.grpArcher2Controls.Controls.Add(this.chbArcher2Load);
            this.grpArcher2Controls.Controls.Add(this.btnArcher2Shot);
            this.grpArcher2Controls.Controls.Add(this.btnArcher2Heal);
            this.grpArcher2Controls.Location = new System.Drawing.Point(433, 99);
            this.grpArcher2Controls.Name = "grpArcher2Controls";
            this.grpArcher2Controls.Size = new System.Drawing.Size(160, 137);
            this.grpArcher2Controls.TabIndex = 25;
            this.grpArcher2Controls.TabStop = false;
            this.grpArcher2Controls.Visible = false;
            // 
            // grpArcher1Stats
            // 
            this.grpArcher1Stats.Controls.Add(this.imgArcher1);
            this.grpArcher1Stats.Controls.Add(this.lblArcher1Health);
            this.grpArcher1Stats.Controls.Add(this.lblArcher1Name);
            this.grpArcher1Stats.Controls.Add(this.lblArcher1Arrows);
            this.grpArcher1Stats.Location = new System.Drawing.Point(6, 22);
            this.grpArcher1Stats.Name = "grpArcher1Stats";
            this.grpArcher1Stats.Size = new System.Drawing.Size(162, 347);
            this.grpArcher1Stats.TabIndex = 26;
            this.grpArcher1Stats.TabStop = false;
            this.grpArcher1Stats.Visible = false;
            // 
            // grpArcher2Stats
            // 
            this.grpArcher2Stats.Controls.Add(this.imgArcher2);
            this.grpArcher2Stats.Controls.Add(this.lblArcher2Name);
            this.grpArcher2Stats.Controls.Add(this.lblArcher2Health);
            this.grpArcher2Stats.Controls.Add(this.lblArcher2Arrows);
            this.grpArcher2Stats.Location = new System.Drawing.Point(599, 22);
            this.grpArcher2Stats.Name = "grpArcher2Stats";
            this.grpArcher2Stats.Size = new System.Drawing.Size(161, 347);
            this.grpArcher2Stats.TabIndex = 27;
            this.grpArcher2Stats.TabStop = false;
            this.grpArcher2Stats.Visible = false;
            // 
            // grpMainArchers
            // 
            this.grpMainArchers.Controls.Add(this.grpArcher2Stats);
            this.grpMainArchers.Controls.Add(this.grpArcher1Stats);
            this.grpMainArchers.Controls.Add(this.lblWinner);
            this.grpMainArchers.Controls.Add(this.grpArcher1Controls);
            this.grpMainArchers.Controls.Add(this.grpArcher2Controls);
            this.grpMainArchers.Location = new System.Drawing.Point(12, 12);
            this.grpMainArchers.Name = "grpMainArchers";
            this.grpMainArchers.Size = new System.Drawing.Size(765, 365);
            this.grpMainArchers.TabIndex = 28;
            this.grpMainArchers.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 444);
            this.Controls.Add(this.grpStarterControls);
            this.Controls.Add(this.grpMainArchers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArcher2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpStarterControls.ResumeLayout(false);
            this.grpStarterControls.PerformLayout();
            this.grpArcher1Controls.ResumeLayout(false);
            this.grpArcher1Controls.PerformLayout();
            this.grpArcher2Controls.ResumeLayout(false);
            this.grpArcher2Controls.PerformLayout();
            this.grpArcher1Stats.ResumeLayout(false);
            this.grpArcher1Stats.PerformLayout();
            this.grpArcher2Stats.ResumeLayout(false);
            this.grpArcher2Stats.PerformLayout();
            this.grpMainArchers.ResumeLayout(false);
            this.grpMainArchers.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblArcher1Arrows;
        private System.Windows.Forms.Label lblArcher2Arrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnArcher1Healer;
        private System.Windows.Forms.RadioButton rbnArcher1Tank;
        private System.Windows.Forms.RadioButton rbnArcher1Sniper;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnArcher2Healer;
        private System.Windows.Forms.RadioButton rbnArcher2Tank;
        private System.Windows.Forms.RadioButton rbnArcher2Sniper;
        private System.Windows.Forms.RadioButton rbnArcher1Soldier;
        private System.Windows.Forms.RadioButton rbnArcher2Soldier;
        private System.Windows.Forms.Button btnArcher1Heal;
        private System.Windows.Forms.Button btnArcher2Heal;
        private System.Windows.Forms.Label lblClassesDescription1;
        private System.Windows.Forms.Label lblClassesDescription2;
        private System.Windows.Forms.GroupBox grpStarterControls;
        private System.Windows.Forms.GroupBox grpArcher1Controls;
        private System.Windows.Forms.GroupBox grpArcher2Controls;
        private System.Windows.Forms.GroupBox grpArcher1Stats;
        private System.Windows.Forms.GroupBox grpArcher2Stats;
        private System.Windows.Forms.GroupBox grpMainArchers;
    }
}

