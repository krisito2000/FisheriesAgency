using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FisheriesAgency.Controller;
using FisheriesAgency.Model;
using FisheriesAgency.Utils;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FisheriesAgency.View.Admin_Panel_Buttons;

namespace FisheriesAgency.View
{

    public partial class frmAdminsPanel : Form
    {
        private static List<Form> openForms = new List<Form>();

        public frmAdminsPanel()
        {
            InitializeComponent();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmUser frmUser = new Admin_Panel_Buttons.frmUser();
            frmUser.Show();
            openForms.Add(frmUser);
        }
        private void btnVessels_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmVessel frmVessel = new Admin_Panel_Buttons.frmVessel();
            frmVessel.Show();
            openForms.Add(frmVessel);
        }

        private void btnFishingPermits_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmFishingPermit frmPermits = new Admin_Panel_Buttons.frmFishingPermit();
            frmPermits.Show();
            openForms.Add(frmPermits);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmTicket frmTicket = new Admin_Panel_Buttons.frmTicket();
            frmTicket.Show();
            openForms.Add(frmTicket);
        }

        private void btnCaptains_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmCaptain frmCaptain = new Admin_Panel_Buttons.frmCaptain();
            frmCaptain.Show();
            openForms.Add(frmCaptain);
        }

        private void btnCatches_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmCatch frmCatch = new Admin_Panel_Buttons.frmCatch();
            frmCatch.Show();
            openForms.Add(frmCatch);
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmFishingTrip frmFishingTrip = new Admin_Panel_Buttons.frmFishingTrip();
            frmFishingTrip.Show();
            openForms.Add(frmFishingTrip);
        }

        private void btnInspector_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmInspector frmInspector = new Admin_Panel_Buttons.frmInspector();
            frmInspector.Show();
            openForms.Add(frmInspector);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmMember frmMember = new Admin_Panel_Buttons.frmMember();
            frmMember.Show();
            openForms.Add(frmMember);
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmOwner frmOwner = new Admin_Panel_Buttons.frmOwner();
            frmOwner.Show();
            openForms.Add(frmOwner);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            Admin_Panel_Buttons.frmOther frmOther = new Admin_Panel_Buttons.frmOther();
            frmOther.Show();
            openForms.Add(frmOther);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logout == DialogResult.Yes)
            {
                foreach (Form form in openForms)
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                }
                this.Hide();
            }
        }
    }
}
