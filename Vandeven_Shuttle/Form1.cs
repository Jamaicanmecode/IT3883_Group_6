using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vandeven_Shuttle
{
    public partial class vandevenShuttleSystem : Form
    {
        /// <summary>
        /// This is the GUI
        /// </summary>
        public vandevenShuttleSystem()
        {
            InitializeComponent();
            
        }

        private void vandevenShuttleSystem_Load(object sender, EventArgs e)
        {

        }


        private void newCustomerDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            
            newUserPanel.Visible = true;
            newUserPanel.BringToFront();
            mainPanel.Visible = false;

        }
    }
}
