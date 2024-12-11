using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point mouseOffset;
        private Point formPosition;
        private void Login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseOffset = e.Location;
            formPosition = Location;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDragging && e.Button == MouseButtons.Left)
        {
                Point currentPosition = PointToScreen(e.Location);
                Location = new Point(currentPosition.X - mouseOffset.X, currentPosition.Y - mouseOffset.Y);
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging)
            {
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.SizeAll;
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
