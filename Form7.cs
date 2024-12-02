using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < 100)
            {
                ProgressBar.Value += 3;
                lblCarregando.Text = ProgressBar.Value.ToString() + "%";
            }
            else
            {
                Timer.Stop();
                Close();
            }
        }
    }
}