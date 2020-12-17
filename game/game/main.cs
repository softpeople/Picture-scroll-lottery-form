using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            cha.Image = Image.FromFile(Application.StartupPath + @"\cha.jpg");
            butn.Image = Image.FromFile(Application.StartupPath + @"\yaogana.png");
        }
        bool btn=false;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (btn)
            {
                btn = false;
                butn.Image = Image.FromFile(Application.StartupPath + @"\yaogana.png");
            }
            else
            {
                btn = true;
                butn.Image = Image.FromFile(Application.StartupPath + @"\yaoganb.png");
            }
        }
    }
}
