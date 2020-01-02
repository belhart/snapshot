using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Snapshot
{
    public partial class Form1 : Form
    {
        //[DllImport("user32.dll")]
        //public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        public Form1()
        {
            InitializeComponent();
            //int MYACTION_HOTKEY_ID = 1;
            //RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 6, (int)Keys.F12);
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Snapshot - Press {} button to capture";
            this.Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //protected override void WndProc(ref Message m)
        //{
        //if (m.Msg == 0x0312 && m.WParam.ToInt32() == 1)
        //{
        // My hotkey has been typed
        //MessageBox.Show("F9 Was pressed !");
        //this.notifyIcon1.Text = "asd";
        // Do what you want here
        // ...
        //}
        //base.WndProc(ref m);
        //}
    }
}
