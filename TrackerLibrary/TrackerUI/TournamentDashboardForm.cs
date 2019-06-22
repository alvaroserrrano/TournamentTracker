using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboard : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboard()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = nameof(TournamentModel.TournamentName);
        }
        private void createPrizeLabel_Click(object sender, EventArgs e)
        {

        }
        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }
        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = loadExistingTournamentDropDown.SelectedItem as TournamentModel;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}