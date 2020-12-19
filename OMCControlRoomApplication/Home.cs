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

namespace OMCControlRoomApplication
{
    public partial class Home : Form
    {


        private const string DEFAULT_NAME_SPACE = "OMCControlRoomApplication";

        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();

            OpenForm("MainDashboard",true);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        
       
    
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private Form OpenForm(string FormName, bool NewInstant)
        {
            
                var form = NewInstant ? CreateForm(FormName) : GetFormOrCreate(FormName);
                form.MdiParent = this;
                form.Show();

            return form;
        }

        private bool IsFormOpen(string FormName)
        {
            Form fc = Application.OpenForms[FormName];

            return fc != null;
        }

        private Form GetFormOrCreate(string FormName)
        {



            foreach (var x in Application.OpenForms)
                MessageBox.Show(x.GetType().Name);
            Form fc = Application.OpenForms[FormName];

            if (fc != null)
                return fc;
            else
                return CreateForm (  FormName) ;
        }

        private Form CreateForm(string FormName)
        {
 
                return Activator.CreateInstance(Type.GetType(DEFAULT_NAME_SPACE + "." + FormName)) as Form;
        }



        private void ConnectMainMenuItem_Click(object sender, EventArgs e)
        {

            //Thread t = new Thread(Connect);
            //t.Start();

         

        }

        private void DisconnectMainMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogsButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutMainMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SettingMainMenuItem_Click(object sender, EventArgs e)
        {
          
            OpenForm(MAIN_CONNECT, false);
        }
    }
}
