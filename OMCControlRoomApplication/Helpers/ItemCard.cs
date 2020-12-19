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
        private int ItemId;
        private ColorProfile cp;
        private bool ShouldBlink;
        private DateTime LastUpdate;
        private ColorsCode CurrentColorCode;
         
     
        public ItemCard(int ItemId )
        {
            this.ItemId = ItemId;
            InitializeComponent();
            RetriveDate();
      


         
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
            var data = new ControlDataContext();
            var item = data.GetItem(ItemId);


            //Thread.Sleep(OMCControl.RandomNumber(1000, 6000));

            SetCode(item.EnglishCode);

              SetType(item.ItemCategory != null? item.ItemCategory.EnglishName: "-");
            SetCity(item.Project!=null && item.Project.City!=null? item.Project.City.EnglishName: "-");
            SetProject(item.Project!=null? item.Project.EnglishName : "-");
            SetLastActivity(item.ChangedTime.Value );
            SetName(item.EnglishName);


            SetColors(item.ChangedTime.Value);
            
             
        }

        enum TimeUnits { YEAR= 483840, HALFYEAR= 241920, QUARTER= 120960, MONTH=40320 , TWOWEEKS=20160, ONEWEEK=10080, THREEDAYS=4320, DAY=1440, HALFDAY=720, SIXHOURS = 360, THREEHOURS = 180, HOUR=60 }
        private void SetColors(DateTime ChangedTime)
        {
            


            double Minutes = (OMCControl.LocalTime - ChangedTime).TotalMinutes;
         
            if (Minutes < (int)TimeUnits.SIXHOURS)
               CurrentColorCode = ColorsCode.ACTIVE ;
            else
                if (Minutes < (int)TimeUnits.DAY)
                CurrentColorCode  = ColorsCode.IDLE ;
            else
                if (Minutes < (int)TimeUnits.THREEDAYS)
                CurrentColorCode   =ColorsCode.DEAD ;
            else


                CurrentColorCode =  ColorsCode.DISACTIVE ;

            cp = GetColorProfile(CurrentColorCode);

            lytMain.BackColor = lytInner_1.BackColor = btnMainName.BackColor=  cp.BackColor;
            lytMain.ForeColor = lytInner_1.ForeColor = btnMainName.ForeColor = cp.ForeColor;

            LastUpdate = OMCControl.LocalTime;


                 ShouldBlink = CurrentColorCode == ColorsCode.DEAD || CurrentColorCode == ColorsCode.IDLE|| CurrentColorCode== ColorsCode.DISACTIVE;

            
                BlinkTimer.Enabled = ShouldBlink;

        }

        public void CalculateWidth(int SuperWidth)
        {
            Width = Math.Max(MIN_WIDTH,(int)(SuperWidth * .9 / 5));

        }

        public void SetName(string Text) {
            btnSubName.Text= Text;
        }
        public void SetCode(string Text) {
            btnMainName.Text= Text;

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
        public void SetLastActivity(DateTime DateTime)
        {
            lblLastActivity.Text = string.Format("{0}", DateTime.ToString("yy-MM-dd@HH:mm"));
        }
        public void SetStatus(string Text)
        {
            lblStatus.Text = Text;
        }

 

        private void T_Tick(object sender, EventArgs e)
        {
            RetriveDate();
            
            
        }

 
        private ColorProfile GetColorProfile(ColorsCode ColorsCode)
        {
            ColorProfile cp = new ColorProfile();

            switch (ColorsCode)
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
                    cp.BackColor = Color.LightYellow;
                    break;

                case ColorsCode.DISACTIVE:
                    cp.ForeColor = Color.White;
                    cp.BackColor = Color.Black;
                    break;

            }

            return cp;

        }



        private void ToggleDetails_Click(object sender, EventArgs e)
        {
            lytMain.Visible = !lytMain.Visible;
            btnSubName.Visible = lytMain.Visible;
            btnMainName.Visible = !btnSubName.Visible;
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (lytInner_1.ForeColor== cp.ForeColor)
            {
                lytMain.ForeColor = lytInner_1.ForeColor = btnMainName.ForeColor = cp.BackColor;
                lytMain.BackColor = lytInner_1.BackColor = btnMainName.BackColor = cp.ForeColor;


            }
            else
            {
                lytMain.BackColor = lytInner_1.BackColor = btnMainName.BackColor = cp.BackColor;
                lytMain.ForeColor = lytInner_1.ForeColor = btnMainName.ForeColor = cp.ForeColor;


            }
        }
    }
}
