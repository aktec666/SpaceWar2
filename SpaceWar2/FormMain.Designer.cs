namespace SpaceWar2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.MyBox1 = new System.Windows.Forms.PictureBox();
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyBox
            // 
            this.EnemyBox.BackgroundImage = global::SpaceWar2.Properties.Resources.Enemy1;
            this.EnemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyBox.Location = new System.Drawing.Point(416, 99);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(125, 103);
            this.EnemyBox.TabIndex = 1;
            this.EnemyBox.TabStop = false;
            // 
            // MyBox1
            // 
            this.MyBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyBox1.BackgroundImage")));
            this.MyBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyBox1.Location = new System.Drawing.Point(560, 474);
            this.MyBox1.Name = "MyBox1";
            this.MyBox1.Size = new System.Drawing.Size(117, 93);
            this.MyBox1.TabIndex = 0;
            this.MyBox1.TabStop = false;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SpaceWar2.Properties.Resources.Enemy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(113, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 103);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SpaceWar2.Properties.Resources.Enemy1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(735, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 103);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1125, 596);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.MyBox1);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Космические войны";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyBox1;
        private System.Windows.Forms.PictureBox EnemyBox;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

