using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        public List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_ALL();
        public List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public List<TeamModel> availableTeams = new List<TeamModel>();


        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();

        }

        private void CreateSampleData()
        {



            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Andre", LastName = "veloz" });
            availableTeamMembers.Add(new PersonModel { FirstName = "pedro", LastName = "pinoquio" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "ALVARO", LastName = "AE2" });

        }

        private void WireUpLists()
        {

            comboxSelectTeamMember.DataSource = null;

            // availableTeamMembers = GlobalConfig.Connection.GetPerson_ALL();
            comboxSelectTeamMember.DataSource = availableTeamMembers;
            comboxSelectTeamMember.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

            comboxSelectTeamMember.Refresh();
            teamMembersListBox.Refresh();
        }


        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidadeForm())
            {
                PersonModel model = new PersonModel
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    EmailAddress = txtEmail.Text,
                    PhoneNumber = txtCellPhone.Text
                };

                model = GlobalConfig.Connection.CreatePerson(model);
                selectedTeamMembers.Add(model);
                WireUpLists();

                txtName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "@";
                txtCellPhone.Text = "+";
                // comboxSelectTeamMember.Update();

                // MessageBox.Show(model.Id.ToString());

            }
            else
            {
                MessageBox.Show("This Form has invalid information");
            }





        }


        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidadeForm()
        {
            bool output = true;

            if (txtName.Text.Length == 0)
            {
                return output = false;
            }
            if (txtLastName.Text.Length < 0)
            {
                return output = false;
            }

            if (!txtEmail.Text.Contains("@") && IsValidEmail(txtEmail.Text))
            {
                return output = false;
            }

            if (!txtCellPhone.Text.StartsWith("+"))
            {
                return output = false;
            }

            return output;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)comboxSelectTeamMember.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
            }

        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                WireUpLists();
            }

        }
        public bool ValidadeTeamCreate(out string message)
        {
            bool output = true;

            if (txtTeamName.Text == "")
            {
                message = "Team doesnt have a name";
                return false;
            }
            if (teamMembersListBox.Items.Count < 5)
            {
                message = "Team needs to have at least 5 members";
                return false;
            }

            availableTeams = GlobalConfig.Connection.GetAllTeams();


            foreach (TeamModel team in availableTeams)
            {
                string nome = team.TeamName;
                nome = nome.ToLower().Replace(" ", "");
                txtTeamName.Text = txtTeamName.Text.ToLower().Replace(" ", "");
                if (nome == txtTeamName.Text)
                {
                    message = "Exists one team with the same name";
                    return false;
                }
            }


            message = "";
            return output;
        }


        private void createTeamButton_Click(object sender, EventArgs e)
        {
            string message;
            if (ValidadeTeamCreate(out message))
            {

                TeamModel modelTeam = new TeamModel();
                modelTeam.TeamName = txtTeamName.Text;


                TeamModel modelid = GlobalConfig.Connection.CreateTeam(modelTeam);

                foreach (PersonModel team in teamMembersListBox.Items)
                {

                    modelTeam.TeamMembers.Add(team);
                    GlobalConfig.Connection.CreateTeamMembers(team, modelTeam);
                }

            }
            else
            {
                MessageBox.Show(message, "ERROR");
            }

        }
    }
}
