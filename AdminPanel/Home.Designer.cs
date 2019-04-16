using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminPanel
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.pnlSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlSide.Controls.Add(this.btn2);
            this.pnlSide.Controls.Add(this.btn1);
            this.pnlSide.Controls.Add(this.panel1);
            this.pnlSide.Controls.Add(this.pnlLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(227, 551);
            this.pnlSide.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Location = new System.Drawing.Point(0, 107);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(227, 45);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "         Detay";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn2_MouseClick);
            // 
            // btn1
            // 
            this.btn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn1.Checked = true;
            this.btn1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(0, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(227, 45);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "         Anasayfa";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 39);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(115, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Çağlar Durmuş";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFooter.Location = new System.Drawing.Point(27, 11);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(91, 16);
            this.lblFooter.TabIndex = 10;
            this.lblFooter.Text = "Designed by ";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Orange;
            this.pnlLogo.Controls.Add(this.picBoxLogo);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(227, 62);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(8, 6);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(58, 50);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 3;
            this.picBoxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.Location = new System.Drawing.Point(64, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(148, 23);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Çağlar Durmuş";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblExit);
            this.pnlHeader.Controls.Add(this.lblMinimize);
            this.pnlHeader.Controls.Add(this.picBoxHome);
            this.pnlHeader.Controls.Add(this.picBoxMenu);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(227, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(660, 62);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.Location = new System.Drawing.Point(107, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(94, 23);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Anasayfa";
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExit.Location = new System.Drawing.Point(625, 16);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 24);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinimize.Location = new System.Drawing.Point(588, 16);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(31, 24);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "—";
            this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHome.Image")));
            this.picBoxHome.Location = new System.Drawing.Point(21, 17);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(27, 27);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHome.TabIndex = 5;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicBoxHome_Click);
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMenu.Image")));
            this.picBoxMenu.Location = new System.Drawing.Point(64, 17);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(30, 27);
            this.picBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenu.TabIndex = 4;
            this.picBoxMenu.TabStop = false;
            this.picBoxMenu.Click += new System.EventHandler(this.PicBoxMenu_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(227, 62);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(660, 489);
            this.container.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(887, 551);
            this.Controls.Add(this.container);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "home";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            this.pnlSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region CursorList
        private List<object> GetCursorList()
        {
            var cursorList = new List<object>();

            cursorList.Add(this.btn1);
            cursorList.Add(this.btn2);
            cursorList.Add(this.picBoxHome);
            cursorList.Add(this.picBoxMenu);
            cursorList.Add(this.lblExit);
            cursorList.Add(this.lblMinimize);

            return cursorList;
        }

        private void MakeCursor()
        {
            var list = GetCursorList();

            foreach (Control item in list)
            {
                item.MouseEnter += (s, e) => item.Cursor = Cursors.Hand;
                item.MouseLeave += (s, e) => item.Cursor = Cursors.Arrow;
            }
        }

        #endregion
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.PictureBox picBoxMenu;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox btn1;
        private System.Windows.Forms.CheckBox btn2;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFooter;
    }
}

