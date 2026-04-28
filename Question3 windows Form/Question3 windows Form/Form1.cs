using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace ProgrammingLanguagesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // Check empty input
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check duplicates
            if (lstLanguages.Items.Contains(language))
            {
                MessageBox.Show("This language already exists.",
                    "Duplicate Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Add to list
            lstLanguages.Items.Add(language);

            // Display date & time
            lblDateTime.Text = "Added on: " + DateTime.Now.ToString();

            // Clear textbox
            txtLanguage.Clear();
        }

        // REMOVE BUTTON
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)
            {
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);

                lblDateTime.Text = "Removed on: " + DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Please select a language to remove.",
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}