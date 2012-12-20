using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SwapMouseEg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rightToolStripMenuItem.Checked = true;
            SwapMouse.SwapMouseButton(0);
        }

        #region BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            SwapMouse.SwapMouseButton(1);
            pBox1.Hide();
            pBox2.Show();
            leftToolStripMenuItem.Checked = true;
            rightToolStripMenuItem.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwapMouse.SwapMouseButton(0);
            pBox1.Show();
            pBox2.Hide();
            leftToolStripMenuItem.Checked = false;
            rightToolStripMenuItem.Checked = true;
        }
        #endregion
        

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        #region NOTIFYICON
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                ni.BalloonTipTitle = "Mouse Button Switcher";
                ni.BalloonTipText = "Your application has been minimized to the taskbar."; 
                ni.ShowBalloonTip(2000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                ni.Visible = true;
            }
        }

        private void ni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        #endregion
        
        #region CONTEXT OPEN/CLOSE
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion

        #region CONTEXT RIGHT/LEFT
        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwapMouse.SwapMouseButton(0);
            pBox1.Show();
            pBox2.Hide();
            leftToolStripMenuItem.Checked = false;
            rightToolStripMenuItem.Checked = true;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwapMouse.SwapMouseButton(1);
            pBox1.Hide();
            pBox2.Show();
            leftToolStripMenuItem.Checked = true;
            rightToolStripMenuItem.Checked = false;
        }
        #endregion
    }
}
