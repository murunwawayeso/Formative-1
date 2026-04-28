namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Text = "Full Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Width = 200;

            // lblID
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 70);
            this.lblID.Text = "ID Number:";

            // txtID
            this.txtID.Location = new System.Drawing.Point(150, 70);
            this.txtID.Width = 200;

            // lblCitizenship
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Location = new System.Drawing.Point(30, 110);
            this.lblCitizenship.Text = "Citizenship:";

            // cmbCitizenship
            this.cmbCitizenship.Location = new System.Drawing.Point(150, 110);
            this.cmbCitizenship.Width = 200;

            // btnValidate
            this.btnValidate.Location = new System.Drawing.Point(30, 160);
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // btnGenerate
            this.btnGenerate.Location = new System.Drawing.Point(150, 160);
            this.btnGenerate.Text = "Generate Profile";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // txtResults
            this.txtResults.Location = new System.Drawing.Point(30, 210);
            this.txtResults.Width = 320;
            this.txtResults.Height = 150;
            this.txtResults.Multiline = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCitizenship);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResults);
            this.Text = "Digital Identity Processor";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}