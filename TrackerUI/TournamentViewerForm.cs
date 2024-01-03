using System;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void ScoreValue1textbox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(ScoreValue1textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Score of team 1.");
                ScoreValue1textbox.Text = ScoreValue1textbox.Text.Remove(ScoreValue1textbox.Text.Length - 1);
            }
            if(ScoreValue1textbox.TextLength > 2)
            {
                MessageBox.Show("Only 2 char long");
                ScoreValue1textbox.Text = ScoreValue1textbox.Text.Remove(ScoreValue1textbox.Text.Length - 1);
            }
            
        }

        private void ScoreValue2texbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ScoreValue2texbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Score of Team 2.");
                ScoreValue2texbox.Text = ScoreValue1textbox.Text.Remove(ScoreValue2texbox.Text.Length - 1);
            }
            if (ScoreValue2texbox.TextLength > 2)
            {
                MessageBox.Show("Only 2 char long");
                ScoreValue2texbox.Text = ScoreValue1textbox.Text.Remove(ScoreValue2texbox.Text.Length - 1);
            }

        }
    }
}
