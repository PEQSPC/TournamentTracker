using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        public List<PersonModel> availableTeamMembers = new List<PersonModel>();
        public List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm()
        {
            InitializeComponent();
            CreateSampleData();
            WireUpLists();

        }
        private void CreateSampleData()
        {

            GlobalConfig.Connection.GetPerson_ALL();
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Andre", LastName = "veloz"});
            availableTeamMembers.Add(new PersonModel { FirstName = "pedro", LastName = "pinoquio" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "ALVARO", LastName = "AE2" });

        }

        private void WireUpLists()
        {
            comboxSelectTeamMember.DataSource = availableTeamMembers;
            comboxSelectTeamMember.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidadeForm())
            {
                PersonModel model = new PersonModel();
                model.FirstName = txtName.Text;
                model.LastName = txtLastName.Text;
                model.EmailAddress = txtEmail.Text;
                model.PhoneNumber = txtCellPhone.Text;

                GlobalConfig.Connection.CreatePerson(model);


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

            if(txtName.Text.Length == 0)
            {
                return output = false;
            }
            if(txtLastName.Text.Length < 0)
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
            if (comboxSelectTeamMember.SelectedItem != null)
            {
                // Get the selected team member
                PersonModel selectedTeamMember = (PersonModel)comboxSelectTeamMember.SelectedItem;

                // Set the selected team member as the new selected item
                comboxSelectTeamMember.SelectedItem = selectedTeamMember;

                // Remove the selected team member from the availableTeamMembers list
                availableTeamMembers.Remove(selectedTeamMember);

                // Add the selected team member to the selectedTeamMembers list
                selectedTeamMembers.Add(selectedTeamMember);
            }
            else
            {
                MessageBox.Show("Select one item in the combobox");
            }



        }
    }
}
