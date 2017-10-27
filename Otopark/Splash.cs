using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Otopark
{
    public partial class Splash : SplashScreen
    {
        public Splash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        int i = 0;
        public enum SplashScreenCommand
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i!=100)
            {
                i += 2;
                lblYuzde.Text = "%" + i;
               
            }
            
        }
    }
}