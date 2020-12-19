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

      
        public MainDashboard()
        {
            InitializeComponent();

            RetrieveData();


         }

        private void RetrieveData()
        {
            var data = new ControlDataContext();
            var Items = data.GetItems().OrderByDescending(x=>x.ChangedTime);


            foreach (var Item in Items)
            {
                ItemCard ic= new ItemCard(Item.Id);
                ic.CalculateWidth(Width);
                MainLayout.Controls.Add(ic);

            }
         
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



}
