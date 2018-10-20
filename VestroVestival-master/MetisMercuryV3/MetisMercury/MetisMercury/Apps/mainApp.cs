using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetisMercury.Apps
{
    public partial class mainApp : Form
    {
        public mainApp()
        {
            InitializeComponent();
        }

        private void btnOrganizationStatus_Click(object sender, EventArgs e)
        {
            Form EVENTSTATUS = new EventStatus();
            EVENTSTATUS.Show();
        }

        private void btnSupplyCenter_Click(object sender, EventArgs e)
        {
            Form cafeteria = new CafeTeria();
            cafeteria.Show();
        }

        private void btnEventEntrance_Click(object sender, EventArgs e)
        {
            Form eventEntrance = new EventEntrance();
            eventEntrance.Show();
        }

        private void btnCampingEntrance_Click(object sender, EventArgs e)
        {
            Form campingEntrance = new CampingEntrance();
            campingEntrance.Show();
        }

        private void btnPayPalTransactions_Click(object sender, EventArgs e)
        {
            Form boatEntrance = new BoatEntrance();
            boatEntrance.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form CheckOut = new Exit();
            CheckOut.Show();
        }

        private void btnEquipmentCenter_Click(object sender, EventArgs e)
        {
            Form EQUIPMENT = new EquipmentShop();
            EQUIPMENT.Show();
        }
    }
}
