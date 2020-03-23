using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaceWar2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EnemyBox.Top += 1;
            pictureBox1.Top += 1;
            pictureBox2.Top += 1;
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: MyBox1.Left -= 10; break;
                case Keys.Right: MyBox1.Left += 10; break;
            }

            
        }
    }
}
