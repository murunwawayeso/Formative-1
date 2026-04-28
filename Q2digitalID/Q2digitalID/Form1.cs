using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate ComboBox
            cmbCitizenship.Items.Add("Citizen");
            cmbCitizenship.Items.Add("Permanent Resident");
            cmbCitizenship.Items.Add("Visitor");

            cmbCitizenship.SelectedIndex = 0; // default selection
        }

        // ==========================
        // VALIDATE BUTTON
        // ==========================
        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Check inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter full name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter ID number.");
                return;
            }

            if (cmbCitizenship.SelectedIndex == -1)
            {
                MessageBox.Show("Please select citizenship.");
                return;
            }

            try
            {
                CitizenProfile profile = new CitizenProfile(
                    txtName.Text.Trim(),
                    txtID.Text.Trim(),
                    cmbCitizenship.Text
                );

                txtResults.Text =
                    "=== VALIDATION RESULT ===\r\n" +
                    profile.ValidateID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ==========================
        // GENERATE PROFILE BUTTON
        // ==========================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter full name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter ID number.");
                return;
            }

            if (cmbCitizenship.SelectedIndex == -1)
            {
                MessageBox.Show("Please select citizenship.");
                return;
            }

            try
            {
                CitizenProfile profile = new CitizenProfile(
                    txtName.Text.Trim(),
                    txtID.Text.Trim(),
                    cmbCitizenship.Text
                );

                string validation = profile.ValidateID();

                txtResults.Text =
                    "===== DIGITAL PROFILE =====\r\n" +
                    $"Full Name: {profile.FullName}\r\n" +
                    $"ID Number: {profile.IDNumber}\r\n" +
                    $"Age: {profile.Age}\r\n" +
                    $"Citizenship Status: {profile.CitizenshipStatus}\r\n" +
                    $"Validation: {validation}\r\n" +
                    $"Processed On: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
    }
}