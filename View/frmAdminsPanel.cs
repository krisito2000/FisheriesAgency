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
        public static List<Form> openForms = new List<Form>();

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
                openForms.ForEach(form =>
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                });
                this.Close();
            }
        }
        // Users
        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnUsers);
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnUsers);
        }

        private void btnUsers_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnUsers);
        }
        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnUsers);
        }
        // Vessels
        private void btnVessels_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnVessels);
        }

        private void btnVessels_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnVessels);
        }

        private void btnVessels_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnVessels);
        }

        private void btnVessels_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnVessels);
        }
        // Permits
        private void btnFishingPermits_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnFishingPermits);
        }

        private void btnFishingPermits_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnFishingPermits);
        }

        private void btnFishingPermits_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnFishingPermits);
        }

        private void btnFishingPermits_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnFishingPermits);
        }
        // Tickets

        private void btnTickets_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnTickets);
        }

        private void btnTickets_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnTickets);
        }

        private void btnTickets_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnTickets);
        }

        private void btnTickets_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnTickets);
        }
        //Captains
        private void btnCaptains_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCaptains);
        }

        private void btnCaptains_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCaptains);
        }

        private void btnCaptains_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCaptains);
        }

        private void btnCaptains_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCaptains);
        }
        //Cataches

        private void btnCatches_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCatches);
        }

        private void btnCatches_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCatches);
        }

        private void btnCatches_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnCatches);
        }

        private void btnCatches_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnCatches);
        }
        //Trips
        private void btnTrips_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnTrips);
        }

        private void btnTrips_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnTrips);
        }

        private void btnTrips_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnTrips);
        }

        private void btnTrips_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnTrips);
        }
        //Inspector
        private void btnInspector_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnInspector);
        }

        private void btnInspector_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnInspector);
        }

        private void btnInspector_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnInspector);
        }

        private void btnInspector_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnInspector);
        }
        //Members
        private void btnMembers_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnMembers);
        }

        private void btnMembers_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnMembers);
        }

        private void btnMembers_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnMembers);
        }

        private void btnMembers_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnMembers);
        }
        //Owners
        private void btnOwners_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnOwners);
        }

        private void btnOwners_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnOwners);
        }

        private void btnOwners_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnOwners);
        }

        private void btnOwners_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnOwners);
        }
        //Other
        private void btnOther_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnOther);
        }

        private void btnOther_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnOther);
        }

        private void btnOther_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnOther);
        }
        private void btnOther_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnOther);
        }
        //Logout
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogout);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogout);
        }

        private void btnLogout_Enter(object sender, EventArgs e)
        {
            btnMouse.btnEnter(btnLogout);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnMouse.btnLeave(btnLogout);
        }
    }
}
