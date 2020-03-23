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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.MyBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyBox
            // 
            this.EnemyBox.BackgroundImage = global::SpaceWar2.Properties.Resources.Enemy1;
            this.EnemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyBox.Location = new System.Drawing.Point(586, 85);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(125, 103);
            this.EnemyBox.TabIndex = 1;
            this.EnemyBox.TabStop = false;
            // 
            // MyBox1
            // 
            this.MyBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyBox1.BackgroundImage")));
            this.MyBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyBox1.Location = new System.Drawing.Point(424, 462);
            this.MyBox1.Name = "MyBox1";
            this.MyBox1.Size = new System.Drawing.Size(117, 93);
            this.MyBox1.TabIndex = 0;
            this.MyBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1125, 596);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.MyBox1);
            this.Name = "FormMain";
            this.Text = "Космические войны";
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyBox1;
        private System.Windows.Forms.PictureBox EnemyBox;
    }
}

