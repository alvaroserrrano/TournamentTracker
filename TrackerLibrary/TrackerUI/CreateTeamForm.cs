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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequestor callingForm;

        public CreateTeamForm(ITeamRequestor caller)
        {
            InitializeComponent();
            callingForm = caller;
            //createsampledata();
            WireUpLists();
        }

        private void lastNamelabel_Click(object sender, EventArgs e)
        {

        }
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "David", LastName = "Ullmer" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sara", LastName = "Ullmer" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Frank", LastName = "Ullmer" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Gitta", LastName = "Ullmer" });
        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = nameof(PersonModel.FullName);

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = nameof(PersonModel.FullName);
        }

        private void createMemberbutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNametextValue.Text;
                p.EmailAddress = emailValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNametextValue.Text = "";
                emailValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0) return false;
            if (lastNametextValue.Text.Length == 0) return false;
            if (emailValue.Text.Length == 0) return false;
            return true;
        }
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel selected = selectTeamMemberDropDown.SelectedItem as PersonModel;

            if (selected != null)
            {
                availableTeamMembers.Remove(selected);
                selectedTeamMembers.Add(selected);

                WireUpLists();
            }
        }
        private void deleteSelectedMemberPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel selected = teamMembersListBox.SelectedItem as PersonModel;
            if (selected != null)
            {
                availableTeamMembers.Add(selected);
                selectedTeamMembers.Remove(selected);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel
            {
                TeamName = teamNameValue.Text,
                TeamMembers = selectedTeamMembers
            };

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            Close();
        }
    }
}