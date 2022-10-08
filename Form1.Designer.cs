
namespace ComGraph_Lab_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnRotateXY = new System.Windows.Forms.Button();
            this.tbYToRotate = new System.Windows.Forms.TextBox();
            this.tbXToRotate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToDefault = new System.Windows.Forms.Button();
            this.refl_45 = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.reflect45 = new System.Windows.Forms.Button();
            this.reflectY = new System.Windows.Forms.Button();
            this.reflectX = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(764, 492);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(55, 20);
            this.tbAngle.TabIndex = 8;
            this.tbAngle.Text = "0";
            this.tbAngle.TextChanged += new System.EventHandler(this.tbAngle_TextChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelX.Location = new System.Drawing.Point(762, 235);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 20);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelY.Location = new System.Drawing.Point(763, 259);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 20);
            this.labelY.TabIndex = 11;
            this.labelY.Text = "Y";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(788, 235);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(46, 20);
            this.tbX.TabIndex = 12;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_Changed);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(788, 259);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(46, 20);
            this.tbY.TabIndex = 13;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_Changed);
            // 
            // btnRotateXY
            // 
            this.btnRotateXY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRotateXY.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.rotation;
            this.btnRotateXY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateXY.Location = new System.Drawing.Point(764, 518);
            this.btnRotateXY.Name = "btnRotateXY";
            this.btnRotateXY.Size = new System.Drawing.Size(55, 55);
            this.btnRotateXY.TabIndex = 16;
            this.btnRotateXY.UseVisualStyleBackColor = false;
            this.btnRotateXY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRotate_MouseDown);
            this.btnRotateXY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRotate_MouseUp);
            // 
            // tbYToRotate
            // 
            this.tbYToRotate.Location = new System.Drawing.Point(764, 462);
            this.tbYToRotate.Name = "tbYToRotate";
            this.tbYToRotate.Size = new System.Drawing.Size(55, 20);
            this.tbYToRotate.TabIndex = 17;
            this.tbYToRotate.Text = "0";
            this.tbYToRotate.TextChanged += new System.EventHandler(this.tbYToRotate_TextChanged);
            // 
            // tbXToRotate
            // 
            this.tbXToRotate.Location = new System.Drawing.Point(764, 436);
            this.tbXToRotate.Name = "tbXToRotate";
            this.tbXToRotate.Size = new System.Drawing.Size(55, 20);
            this.tbXToRotate.TabIndex = 18;
            this.tbXToRotate.Text = "0";
            this.tbXToRotate.TextChanged += new System.EventHandler(this.tbXToRotate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(738, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(738, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            // 
            // btnToDefault
            // 
            this.btnToDefault.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToDefault.BackgroundImage")));
            this.btnToDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToDefault.Location = new System.Drawing.Point(788, 12);
            this.btnToDefault.Name = "btnToDefault";
            this.btnToDefault.Size = new System.Drawing.Size(55, 55);
            this.btnToDefault.TabIndex = 21;
            this.btnToDefault.UseVisualStyleBackColor = false;
            this.btnToDefault.Click += new System.EventHandler(this.btnToDefault_Click);
            // 
            // refl_45
            // 
            this.refl_45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refl_45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refl_45.BackgroundImage")));
            this.refl_45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refl_45.Location = new System.Drawing.Point(803, 375);
            this.refl_45.Name = "refl_45";
            this.refl_45.Size = new System.Drawing.Size(55, 55);
            this.refl_45.TabIndex = 15;
            this.refl_45.UseVisualStyleBackColor = false;
            this.refl_45.Click += new System.EventHandler(this.refl_45_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCenter.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.toCenter;
            this.btnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCenter.Location = new System.Drawing.Point(634, 117);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(55, 55);
            this.btnCenter.TabIndex = 14;
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // reflect45
            // 
            this.reflect45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reflect45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reflect45.BackgroundImage")));
            this.reflect45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reflect45.Location = new System.Drawing.Point(742, 375);
            this.reflect45.Name = "reflect45";
            this.reflect45.Size = new System.Drawing.Size(55, 55);
            this.reflect45.TabIndex = 7;
            this.reflect45.UseVisualStyleBackColor = false;
            this.reflect45.Click += new System.EventHandler(this.reflect45_Click);
            // 
            // reflectY
            // 
            this.reflectY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reflectY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reflectY.BackgroundImage")));
            this.reflectY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reflectY.Location = new System.Drawing.Point(803, 314);
            this.reflectY.Name = "reflectY";
            this.reflectY.Size = new System.Drawing.Size(55, 55);
            this.reflectY.TabIndex = 6;
            this.reflectY.UseVisualStyleBackColor = false;
            this.reflectY.Click += new System.EventHandler(this.reflectY_Click);
            // 
            // reflectX
            // 
            this.reflectX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reflectX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reflectX.BackgroundImage")));
            this.reflectX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reflectX.Location = new System.Drawing.Point(742, 314);
            this.reflectX.Name = "reflectX";
            this.reflectX.Size = new System.Drawing.Size(55, 55);
            this.reflectX.TabIndex = 5;
            this.reflectX.UseVisualStyleBackColor = false;
            this.reflectX.Click += new System.EventHandler(this.reflectX_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDown.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.arrowDown;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(634, 178);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRight.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.arrowRight;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(695, 117);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 55);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeft.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.arrowLeft;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(573, 117);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 55);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUp.BackgroundImage = global::ComGraph_Lab_4.Properties.Resources.arrowUp;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(634, 61);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(568, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Центр вращения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(564, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Угол поворота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(569, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Перемещение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(738, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Отражение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(569, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Вращение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(567, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Координаты центра";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(202, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "По Y: Ctrl + стрелки (вверх, вниз - увеличение и уменьшение)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(202, 610);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(453, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "По X: Ctrl + стрелки (вправо, влево - увеличение и уменьшение)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(202, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(471, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "По X: Shift + стрелки (вправо, влево - сдвиг влево и сдвиг вправо)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(202, 669);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(430, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "По Y: Shift + стрелки (вверх, вниз - сдвиг вверх и сдвиг вниз)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 676);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 24);
            this.label14.TabIndex = 33;
            this.label14.Text = "Перемещение";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 592);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 24);
            this.label15.TabIndex = 34;
            this.label15.Text = "Масштабирование";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Горячие клавиши";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(203, 628);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(587, 18);
            this.label16.TabIndex = 36;
            this.label16.Text = "Пропорционально: Ctrl + клавиша знака (\'+\' - для увеличения, \'-\' - для уменьшения" +
    ")";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 711);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbXToRotate);
            this.Controls.Add(this.tbYToRotate);
            this.Controls.Add(this.btnRotateXY);
            this.Controls.Add(this.refl_45);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.reflect45);
            this.Controls.Add(this.reflectY);
            this.Controls.Add(this.reflectX);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(882, 750);
            this.MinimumSize = new System.Drawing.Size(882, 750);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button reflectX;
        private System.Windows.Forms.Button reflectY;
        private System.Windows.Forms.Button reflect45;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button refl_45;
        private System.Windows.Forms.Button btnRotateXY;
        private System.Windows.Forms.TextBox tbYToRotate;
        private System.Windows.Forms.TextBox tbXToRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
    }
}

