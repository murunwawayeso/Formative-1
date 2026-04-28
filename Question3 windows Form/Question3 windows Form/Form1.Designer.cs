namespace ProgrammingLanguagesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Label lblDateTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 25);
            this.lblTitle.Text = "Programming Languages";

            // txtLanguage
            this.txtLanguage.Location = new System.Drawing.Point(65, 70);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(200, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(280, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnRemove
            this.btnRemove.Location = new System.Drawing.Point(280, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // lstLanguages
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.ItemHeight = 15;
            this.lstLanguages.Location = new System.Drawing.Point(65, 110);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(200, 139);

            // lblDateTime
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(65, 270);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 15);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstLanguages);
            this.Controls.Add(this.lblDateTime);
            this.Name = "Form1";
            this.Text = "Languages App";
            //this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}