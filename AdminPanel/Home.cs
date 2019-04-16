using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.widthOfHeader = this.pnlHeader.Width;
            this.formWidth = this.Width;
        }

        #region BorderMove
        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        #endregion

        void active(object sender)
        {
            btn1.Checked = false;
            btn2.Checked = false;

            ((System.Windows.Forms.CheckBox)sender).Checked = true;
        }

        private void Btn1_MouseClick(object sender, MouseEventArgs e)
        {
            active(sender);
            container.Controls.Clear();
            container.Controls.Add(new Index());
            this.lblHeader.Text = btn1.Text.Trim();
        }

        private void Btn2_MouseClick(object sender, MouseEventArgs e)
        {
            active(sender);
            container.Controls.Clear();
            container.Controls.Add(new Detail());
            this.lblHeader.Text = btn2.Text.Trim();
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        private void PicBoxMenu_Click(object sender, EventArgs e)
        {
            if (sideVisible)
            {
                this.pnlSide.Hide();
                this.pnlHeader.Width = formWidth;
                this.container.Width = formWidth;

                foreach (UserControl item in container.Controls)
                {
                    item.Width = formWidth;
                }
            }
            else
            {
                this.pnlSide.Show();
                this.pnlHeader.Width = widthOfHeader;
                this.container.Width = widthOfHeader;
                foreach (UserControl item in container.Controls)
                {
                    item.Width = widthOfHeader;
                }
            }

            sideVisible = !sideVisible;
        }

        private void PicBoxHome_Click(object sender, MouseEventArgs e)
        {
            Btn1_MouseClick(btn1, e);
        }        

        private bool sideVisible = true;
        private int widthOfHeader;
        private int formWidth;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

    }
}
