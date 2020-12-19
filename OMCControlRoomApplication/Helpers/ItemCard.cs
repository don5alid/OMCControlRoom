using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OMCControlRoomApplication.Helpers
{
    public partial class ItemCard : UserControl
    {
        private const int MIN_WIDTH= 200;
        private int index=0;
        public void SetNumber(int Number)
        {
            index = Number / 10;
        }
        public ItemCard( )
        {
            
            InitializeComponent();


            Task.Factory.StartNew(() => RetriveDate() );


         var t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }
        private static Random rand = new Random();
        public static int RandomNumber(int min, int max)
        {
            lock (new Object())
                return rand.Next(min, max);
        }

        private void WriteTextSafe(string text)
        {
            if (btnMainName.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                btnMainName.Invoke(d, new object[] { text });
            }
            else
            {
                btnMainName.Text = text;
            }
        }
        private delegate void SafeCallDelegate(string text);
        private void SetText(string Text)
        {
            WriteTextSafe(Text);
        }

        private void RetriveDate()
        {
            Thread.Sleep(RandomNumber(3000, 10000));
            SetText("Loaded");
             
        }

        public void CalculateWidth(int SuperWidth)
        {
            Width = Math.Max(MIN_WIDTH,(int)(SuperWidth * .9 / 5));

        }

        public void SetCode(string Text) {
            btnMainName.Text=btnSubName.Text = Text;

        }
        public void SetCity(string Text)
        {
            lblCity.Text = Text;
        }
        public void SetType(string Text)
        {
            lblType.Text = Text;
        }
        public void SetProject(string Text)
        {
            lblProject.Text = Text;
        }
        public void SetLocation(string Text)
        {
            btnMap.Text = Text;
        }
        public void SetLastActivity(string Text)
        {
            lblLastActivity.Text = Text;
        }
        public void SetStatus(string Text)
        {
            lblStatus.Text = Text;
        }

 

        private void T_Tick(object sender, EventArgs e)
        {
            btnSubName.Text = DateTime.Now.Second.ToString();
            
        }

   
          

        private void ToggleDetails_Click(object sender, EventArgs e)
        {
            lytMain.Visible = !lytMain.Visible;
            btnSubName.Visible = lytMain.Visible;
            btnMainName.Visible = !btnSubName.Visible;
        }
    }
}
