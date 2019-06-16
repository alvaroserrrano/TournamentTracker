namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNemMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberbutton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhonelabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.lastNametextValue = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.teamNamelabel = new System.Windows.Forms.Label();
            this.deleteSelectedMemberPlayerbutton = new System.Windows.Forms.Button();
            this.createTeambutton = new System.Windows.Forms.Button();
            this.addNemMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(51, 154);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(578, 50);
            this.teamNameValue.TabIndex = 13;
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamLabel.Location = new System.Drawing.Point(38, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(276, 65);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team";
            this.createTeamLabel.Click += new System.EventHandler(this.createTeamLabel_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(161, 361);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(286, 67);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(51, 285);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(578, 53);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(42, 228);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(392, 54);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNemMemberGroupBox
            // 
            this.addNemMemberGroupBox.Controls.Add(this.createMemberbutton);
            this.addNemMemberGroupBox.Controls.Add(this.cellPhoneValue);
            this.addNemMemberGroupBox.Controls.Add(this.cellPhonelabel);
            this.addNemMemberGroupBox.Controls.Add(this.emailValue);
            this.addNemMemberGroupBox.Controls.Add(this.emaillabel);
            this.addNemMemberGroupBox.Controls.Add(this.lastNametextValue);
            this.addNemMemberGroupBox.Controls.Add(this.lastNamelabel);
            this.addNemMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNemMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNemMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNemMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addNemMemberGroupBox.Location = new System.Drawing.Point(51, 472);
            this.addNemMemberGroupBox.Name = "addNemMemberGroupBox";
            this.addNemMemberGroupBox.Size = new System.Drawing.Size(578, 407);
            this.addNemMemberGroupBox.TabIndex = 20;
            this.addNemMemberGroupBox.TabStop = false;
            this.addNemMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberbutton
            // 
            this.createMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberbutton.Location = new System.Drawing.Point(145, 337);
            this.createMemberbutton.Name = "createMemberbutton";
            this.createMemberbutton.Size = new System.Drawing.Size(286, 67);
            this.createMemberbutton.TabIndex = 20;
            this.createMemberbutton.Text = "Create Member";
            this.createMemberbutton.UseVisualStyleBackColor = true;
            this.createMemberbutton.Click += new System.EventHandler(this.createMemberbutton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneValue.Location = new System.Drawing.Point(244, 269);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(311, 55);
            this.cellPhoneValue.TabIndex = 16;
            // 
            // cellPhonelabel
            // 
            this.cellPhonelabel.AutoSize = true;
            this.cellPhonelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhonelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellPhonelabel.Location = new System.Drawing.Point(25, 276);
            this.cellPhonelabel.Name = "cellPhonelabel";
            this.cellPhonelabel.Size = new System.Drawing.Size(189, 48);
            this.cellPhonelabel.TabIndex = 15;
            this.cellPhonelabel.Text = "Cell Phone";
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValue.Location = new System.Drawing.Point(244, 201);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(311, 55);
            this.emailValue.TabIndex = 14;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emaillabel.Location = new System.Drawing.Point(25, 208);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(105, 48);
            this.emaillabel.TabIndex = 13;
            this.emaillabel.Text = "Email";
            // 
            // lastNametextValue
            // 
            this.lastNametextValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNametextValue.Location = new System.Drawing.Point(244, 126);
            this.lastNametextValue.Name = "lastNametextValue";
            this.lastNametextValue.Size = new System.Drawing.Size(311, 55);
            this.lastNametextValue.TabIndex = 12;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNamelabel.Location = new System.Drawing.Point(25, 126);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(187, 48);
            this.lastNamelabel.TabIndex = 11;
            this.lastNamelabel.Text = "Last Name";
            this.lastNamelabel.Click += new System.EventHandler(this.lastNamelabel_Click);
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValue.Location = new System.Drawing.Point(244, 61);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(311, 55);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(25, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(192, 48);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 45;
            this.teamMembersListBox.Location = new System.Drawing.Point(708, 165);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(431, 722);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // teamNamelabel
            // 
            this.teamNamelabel.AutoSize = true;
            this.teamNamelabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNamelabel.Location = new System.Drawing.Point(42, 97);
            this.teamNamelabel.Name = "teamNamelabel";
            this.teamNamelabel.Size = new System.Drawing.Size(231, 54);
            this.teamNamelabel.TabIndex = 12;
            this.teamNamelabel.Text = "Team Name";
            this.teamNamelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // deleteSelectedMemberPlayerbutton
            // 
            this.deleteSelectedMemberPlayerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberPlayerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberPlayerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberPlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberPlayerbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberPlayerbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberPlayerbutton.Location = new System.Drawing.Point(1159, 445);
            this.deleteSelectedMemberPlayerbutton.Name = "deleteSelectedMemberPlayerbutton";
            this.deleteSelectedMemberPlayerbutton.Size = new System.Drawing.Size(203, 107);
            this.deleteSelectedMemberPlayerbutton.TabIndex = 22;
            this.deleteSelectedMemberPlayerbutton.Text = "Delete Selected";
            this.deleteSelectedMemberPlayerbutton.UseVisualStyleBackColor = true;
            // 
            // createTeambutton
            // 
            this.createTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeambutton.Location = new System.Drawing.Point(494, 916);
            this.createTeambutton.Name = "createTeambutton";
            this.createTeambutton.Size = new System.Drawing.Size(353, 79);
            this.createTeambutton.TabIndex = 25;
            this.createTeambutton.Text = "Create Team";
            this.createTeambutton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 1019);
            this.Controls.Add(this.createTeambutton);
            this.Controls.Add(this.deleteSelectedMemberPlayerbutton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNemMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNamelabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.addNemMemberGroupBox.ResumeLayout(false);
            this.addNemMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNemMemberGroupBox;
        private System.Windows.Forms.Button createMemberbutton;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhonelabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox lastNametextValue;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Label teamNamelabel;
        private System.Windows.Forms.Button deleteSelectedMemberPlayerbutton;
        private System.Windows.Forms.Button createTeambutton;
    }
}