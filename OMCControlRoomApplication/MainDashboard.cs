using OMCControlRoomApplication.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMCControlRoomApplication
{
    public partial class MainDashboard : Form
    {

        private static Random rand = new Random();
        public static int RandomNumber(int min, int max)
        {
            lock (new Object())
                return rand.Next(min, max);
        }
        public MainDashboard()
        {
            InitializeComponent();



            for (int i = 0; i < 52; i++)
            {

                ItemCard b = new ItemCard();
                b.CalculateWidth(Width);
                b.SetCity("Jeddah");
                b.SetCode("JWF-201");
                b.SetLastActivity("2020-12-14");
                b.SetLocation("Jeddah Map");
                b.SetType("Common Bathrooms");
                b.SetProject("JWF");

                //Button b = new Button();
                //b.Width = 200;
                //b.Height = 150;
                //b.Text = string.Format("Button {0}", i);
                //b.Font= new Font("Tahoma", 30F, FontStyle.Bold);


                //var code = GetRandomColorCode(RandomNumber(1,4));
                //var cp = GetColorProfile(code);


                //b.ForeColor = cp.ForeColor;
                //b.BackColor = cp.BackColor;


                //b.MouseHover += B_MouseHover;
                //b.MouseLeave += B_MouseLeave;

                b.KeyDown += MainDashboard_KeyDown;

                MainLayout.Controls.Add(b);
                 
            }
        }

      
       
        private void B_MouseLeave(object sender, EventArgs e)
        {
            if (ActiveToolTip != null)
                ActiveToolTip = null;
             
        }

        private ToolTip ActiveToolTip;
        private void B_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Control c = (Control)sender;

            ActiveToolTip = new ToolTip();
            ActiveToolTip.ToolTipIcon = ToolTipIcon.Info;
            ActiveToolTip.SetToolTip(c, "helllllo\nkhalid abbas\nregards");

            ActiveToolTip.ToolTipTitle = "hi again\nhe he ha";
          
            //this.tip.SetToolTip(c, string.Format("this is a test"+ b.Text));

       //     MessageBox.Show(b.Text);
        }

        private ColorsCode GetRandomColorCode(int v)
        {
            switch(v)
            {
                case 1: return ColorsCode.ACTIVE;
                case 2: return ColorsCode.DEAD;
                case 3: return ColorsCode.DISACTIVE;
                case 4: return ColorsCode.IDLE;
                default: return ColorsCode.ACTIVE;
            }
        }

        private ColorProfile GetColorProfile(ColorsCode ColorsCode)
        {
            ColorProfile cp = new ColorProfile();

            switch(ColorsCode)
            {
                case ColorsCode.ACTIVE:
                    cp.ForeColor = Color.DarkGreen;
                    cp.BackColor = Color.LightGreen;
                    break;

                case ColorsCode.DEAD:
                    cp.ForeColor = Color.DarkRed;
                    cp.BackColor = Color.Red;
                    break;

                case ColorsCode.IDLE:
                    cp.ForeColor = Color.DarkOrange;
                    cp.BackColor = Color.Orange;
                    break;

                case ColorsCode.DISACTIVE:
                    cp.ForeColor = Color.White;
                    cp.BackColor = Color.Black;
                    break;
 
            }

            return cp;
           
        }

        private void MainDashboard_Resize(object sender, EventArgs e)
        {
            foreach (ItemCard x in MainLayout.Controls)
            {
                x.CalculateWidth(Width);
            }
        }

        private void MainDashboard_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }


    class ColorProfile
    {
        public Color ForeColor { set; get; }
        public Color BackColor { set; get; }
    }

    enum ColorsCode { ACTIVE, DEAD, IDLE, DISACTIVE };

}
