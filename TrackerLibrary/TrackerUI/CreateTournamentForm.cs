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
    public partial class CreateTournamentForm : Form, IPrizeRequestor, ITeamRequestor
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectTeamDropDown.DataSource = null;
            tournamentPlayersListBox.DataSource = null;
            prizesListBox.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = nameof(TeamModel.TeamName);

            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = nameof(TeamModel.TeamName);

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = nameof(PrizeModel.PlaceName);
        }
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel selected = selectTeamDropDown.SelectedItem as TeamModel;

            if (selected != null)
            {
                availableTeams.Remove(selected);
                selectedTeams.Add(selected);
            }

            WireUpList();
        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // call the create prize form
            // Get back from the form a prize
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            //Take the prize and put it in the List
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void createTeamLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();

        }
        private void teamDelete_Click(object sender, EventArgs e)
        {
            TeamModel selected = tournamentPlayersListBox.SelectedItem as TeamModel;

            if (selected != null)
            {
                availableTeams.Add(selected);
                selectedTeams.Remove(selected);

                WireUpList();
            }

        }
        private void prizesDelete_Click(object sender, EventArgs e)
        {
            PrizeModel selected = prizesListBox.SelectedItem as PrizeModel;

            if (selected != null)
            {
                selectedPrizes.Remove(selected);

                WireUpList();
            }
        }
        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out decimal fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid fee",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Create our Tounrnament mode
            TournamentModel tm = new TournamentModel
            {
                TournamentName = tournamentNameValue.Text,
                EntryFee = fee,
                Prizes = selectedPrizes,
                EnteredTeams = selectedTeams
            };


            // wire up Matchups
            TournamentLogic.CreateRounds(tm);

            // Create Tournament Entry
            // Create all of the PrizesEntrys
            // Create all of the TeamEntrys
            GlobalConfig.Connection.CreateTournament(tm);
            tm.AlertUsersToNewRound();

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }
    }
}