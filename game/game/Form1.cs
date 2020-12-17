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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }
        bool bsualpha = true;
        bool baddalpha = false;
        main a = new main();
        private void logo_Load(object sender, EventArgs e)
        {
            begin.Enabled = true;
            
        }

        private void begin_Tick(object sender, EventArgs e)
        {
            if (bsualpha)
                FrmSplash.ActiveForm.Opacity += 0.1;
            if (baddalpha)
                FrmSplash.ActiveForm.Opacity -= 0.1;

            if (FrmSplash.ActiveForm.Opacity >= 1)
            {
                bsualpha = false;
                baddalpha = true;
            }
            if (FrmSplash.ActiveForm.Opacity <= 0)
            {
                begin.Enabled = false;
                a.Show();

            }
        }
    }
}
