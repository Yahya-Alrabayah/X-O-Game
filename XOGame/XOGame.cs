using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }
      

        bool IsWinner()
        {
            // فحص الصفوف والأعمدة والأقطار باستخدام الـ Tag
            // الصفوف
            if (pb1.Tag != null && pb1.Tag.ToString() == pb2.Tag?.ToString() && pb2.Tag?.ToString() == pb3.Tag?.ToString() && pb1.Tag.ToString() != "") 
            {
                pb1.BackColor = Color.White;
                pb2.BackColor = Color.White;
                pb3.BackColor = Color.White;
                pb1.BackgroundImage = null;
                pb2.BackgroundImage = null;
                pb3.BackgroundImage = null;
                return true;
            }
            if (pb4.Tag != null && pb4.Tag.ToString() == pb5.Tag?.ToString() && pb5.Tag?.ToString() == pb6.Tag?.ToString() && pb4.Tag.ToString() != ""){
                pb4.BackColor = Color.White;
                pb5.BackColor = Color.White;
                pb6.BackColor = Color.White;
                pb4.BackgroundImage=null;
                pb5.BackgroundImage=null;
                pb6.BackgroundImage=null;
                return true;
            }
            if (pb7.Tag != null && pb7.Tag.ToString() == pb8.Tag?.ToString() && pb8.Tag?.ToString() == pb9.Tag?.ToString() && pb7.Tag.ToString() != "")
            {
                pb7.BackColor = Color.White;
                pb8.BackColor = Color.White;
                pb9.BackColor = Color.White;
                pb7.BackgroundImage=null;
                pb8.BackgroundImage=null;
                pb9.BackgroundImage=null;
                return true;
            }
                                                                                                                                                       
           
                                                                                                                                           
           
            if (pb1.Tag != null && pb1.Tag.ToString() == pb4.Tag?.ToString() && pb4.Tag?.ToString() == pb7.Tag?.ToString() && pb1.Tag.ToString() != "")
            {
                pb1.BackColor = Color.White;
                pb4.BackColor = Color.White;
                pb7.BackColor = Color.White;
                pb1.BackgroundImage=null;
                pb4.BackgroundImage=null;
                pb7.BackgroundImage=null;
                return true;
            }
            if (pb2.Tag != null && pb2.Tag.ToString() == pb5.Tag?.ToString() && pb5.Tag?.ToString() == pb8.Tag?.ToString() && pb2.Tag.ToString() != "")
            {
                pb2.BackColor = Color.White;
                pb5.BackColor = Color.White;
                pb8.BackColor = Color.White;
                pb2.BackgroundImage = null;
                pb5.BackgroundImage = null;
                pb8.BackgroundImage = null;
                return true;
            }
            if (pb3.Tag != null && pb3.Tag.ToString() == pb6.Tag?.ToString() && pb6.Tag?.ToString() == pb9.Tag?.ToString() && pb3.Tag.ToString() != "")
            {
                pb3.BackColor = Color.White;
                pb6.BackColor = Color.White;
                pb9.BackColor = Color.White;
                pb3.BackgroundImage = null;
                pb6.BackgroundImage = null;
                pb9.BackgroundImage = null;
                return true;
            }
                                                                                                                                                      
                                                                                                                                      
           
             if (pb1.Tag != null && pb1.Tag.ToString() == pb5.Tag?.ToString() && pb5.Tag?.ToString() == pb9.Tag?.ToString() && pb1.Tag.ToString() != "")
            {
                pb1.BackColor = Color.White;
                pb5.BackColor = Color.White;
                pb9.BackColor = Color.White;
                pb1.BackgroundImage = null;
                pb5.BackgroundImage = null;
                pb9.BackgroundImage = null;
                return true;
                }
                if (pb3.Tag != null && pb3.Tag.ToString() == pb5.Tag?.ToString() && pb5.Tag?.ToString() == pb7.Tag?.ToString() && pb3.Tag.ToString() != "")
            {
                pb3.BackColor = Color.White;
                pb5.BackColor = Color.White;
                pb7.BackColor = Color.White;
                pb3.BackgroundImage = null;
                pb5.BackgroundImage = null;
                pb7.BackgroundImage = null;
                return true; 
               }

            return false;
        }
        void Updatepb(PictureBox l)
        {
            if (lbWhoPlay.Text == "Player 1")
            {
                l.Image = Properties.Resources.x;
                l.Tag = "X"; // تخزين علامة اللاعب الأول
                l.Enabled = false;

                if (IsWinner())
                {
                    lbWhoPlay.Text = "Game Over";
                    lbWhoIsWiner.Text = "Player 1";
                    pb1.Enabled = false;
                    pb2.Enabled = false;
                    pb3.Enabled = false;
                    pb4.Enabled = false;
                    pb5.Enabled = false;
                    pb6.Enabled = false;
                    pb7.Enabled = false;
                    pb8.Enabled = false;
                    pb9.Enabled = false;
                }
                else
                {
                    lbWhoPlay.Text = "Player 2";
                }
                return;
            }

            if (lbWhoPlay.Text == "Player 2")
            {
                l.Image = Properties.Resources.O;
                l.Tag = "O"; // تخزين علامة اللاعب الثاني
                l.Enabled = false;

                if (IsWinner())
                {
                    lbWhoPlay.Text = "Game Over";
                    lbWhoIsWiner.Text = "Player 2";
                    pb1.Enabled = false;
                    pb2.Enabled = false;
                    pb3.Enabled = false;
                    pb4.Enabled = false;
                    pb5.Enabled = false;
                    pb6.Enabled = false;
                    pb7.Enabled = false;
                    pb8.Enabled = false;
                    pb9.Enabled = false;
                }
                else
                {
                    lbWhoPlay.Text = "Player 1";
                }
                return;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {  


        }

    

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);

            pen.Width = 10;
            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen,527,30,527,400);
            e.Graphics.DrawLine(pen, 383,30,383, 400);
            e.Graphics.DrawLine(pen, 245, 151, 665, 151);
            e.Graphics.DrawLine(pen, 245, 276, 665, 276);
        }

        

        private void pictureBox9_Click(object sender, EventArgs e)
        {
    
            Updatepb(pb9);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources.pngegg;
            pb2.Image = Properties.Resources.pngegg;
            pb3.Image = Properties.Resources.pngegg;
            pb4.Image = Properties.Resources.pngegg;
            pb5.Image = Properties.Resources.pngegg;
            pb6.Image = Properties.Resources.pngegg;
            pb7.Image = Properties.Resources.pngegg;
            pb8.Image = Properties.Resources.pngegg;
            pb9.Image = Properties.Resources.pngegg;

            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;

           pb1.Tag=null;
           pb2.Tag=null;
           pb3.Tag=null;
           pb4.Tag=null;
           pb5.Tag=null;
           pb6.Tag=null;
           pb7.Tag=null;
           pb8.Tag=null;
           pb9.Tag = null;

            pb1.BackgroundImage = Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb2.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb3.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb4.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb5.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb6.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb7.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb8.BackgroundImage= Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            pb9.BackgroundImage = Properties.Resources.abstract_smooth_blue_with_black_vignette_studio_well_use_as_backgroundbusiness_reportdigitalwebsite_template;
            lbWhoIsWiner.Text = "In Progress..";
            lbWhoPlay.Text = "Player 1";
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Updatepb(pb1);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Updatepb(pb2);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Updatepb(pb3);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Updatepb(pb4);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            Updatepb(pb5);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            Updatepb(pb6);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            Updatepb(pb7);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            Updatepb(pb8);
        }
    }
}
