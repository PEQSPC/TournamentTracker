namespace TrackerUI
{
    partial class TournamentDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadTournament = new System.Windows.Forms.Button();
            this.label_TournamentDashboard = new System.Windows.Forms.Label();
            this.label_LoadExisting = new System.Windows.Forms.Label();
            this.comboBox_LoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.btn_CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LoadTournament
            // 
            this.btn_LoadTournament.BackColor = System.Drawing.Color.DarkGray;
            this.btn_LoadTournament.Location = new System.Drawing.Point(92, 264);
            this.btn_LoadTournament.Name = "btn_LoadTournament";
            this.btn_LoadTournament.Size = new System.Drawing.Size(333, 41);
            this.btn_LoadTournament.TabIndex = 0;
            this.btn_LoadTournament.Text = "Load Tournament";
            this.btn_LoadTournament.UseVisualStyleBackColor = false;
            // 
            // label_TournamentDashboard
            // 
            this.label_TournamentDashboard.AutoSize = true;
            this.label_TournamentDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TournamentDashboard.Location = new System.Drawing.Point(112, 49);
            this.label_TournamentDashboard.Name = "label_TournamentDashboard";
            this.label_TournamentDashboard.Size = new System.Drawing.Size(313, 32);
            this.label_TournamentDashboard.TabIndex = 4;
            this.label_TournamentDashboard.Text = "Tournament Dashboard";
            // 
            // label_LoadExisting
            // 
            this.label_LoadExisting.AutoSize = true;
            this.label_LoadExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoadExisting.Location = new System.Drawing.Point(95, 174);
            this.label_LoadExisting.Name = "label_LoadExisting";
            this.label_LoadExisting.Size = new System.Drawing.Size(346, 32);
            this.label_LoadExisting.TabIndex = 5;
            this.label_LoadExisting.Text = "Load Existing Tournament";
            // 
            // comboBox_LoadExistingTournament
            // 
            this.comboBox_LoadExistingTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoadExistingTournament.FormattingEnabled = true;
            this.comboBox_LoadExistingTournament.Location = new System.Drawing.Point(92, 220);
            this.comboBox_LoadExistingTournament.Name = "comboBox_LoadExistingTournament";
            this.comboBox_LoadExistingTournament.Size = new System.Drawing.Size(333, 24);
            this.comboBox_LoadExistingTournament.TabIndex = 6;
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.DarkGray;
            this.btn_CreateTournament.Location = new System.Drawing.Point(92, 422);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(333, 82);
            this.btn_CreateTournament.TabIndex = 7;
            this.btn_CreateTournament.Text = "Create Tournament";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 536);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.comboBox_LoadExistingTournament);
            this.Controls.Add(this.label_LoadExisting);
            this.Controls.Add(this.label_TournamentDashboard);
            this.Controls.Add(this.btn_LoadTournament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TournamentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadTournament;
        private System.Windows.Forms.Label label_TournamentDashboard;
        private System.Windows.Forms.Label label_LoadExisting;
        private System.Windows.Forms.ComboBox comboBox_LoadExistingTournament;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}