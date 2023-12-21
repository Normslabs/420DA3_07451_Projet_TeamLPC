namespace _420DA3_07451_Projet_Initial.Presentation;

partial class UtilisateurManagementForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.panel1 = new Panel();
        this.boutonAction = new Button();
        this.buttonAnnuler = new Button();
        this.panel2 = new Panel();
        this.openModeValueLabel = new Label();
        this.openModeLabel = new Label();
        this.panel3 = new Panel();
        this.userDateCreatedTextBox = new TextBox();
        this.userPasswordTextBox = new TextBox();
        this.userPasswordLabel = new Label();
        this.userPasswordAdminResetButton = new Button();
        this.userRolesListbox = new ListBox();
        this.userRolesLabel = new Label();
        this.userWarehouseCombobox = new ComboBox();
        this.userWarehouseLabel = new Label();
        this.userDateCreatedLabel = new Label();
        this.userPasswordHashTextBox = new TextBox();
        this.userPasswordHashLabel = new Label();
        this.userUsernameTextBox = new TextBox();
        this.userUsernameLabel = new Label();
        this.userIdNumericUD = new NumericUpDown();
        this.userIdLabel = new Label();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.userIdNumericUD).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.boutonAction);
        this.panel1.Controls.Add(this.buttonAnnuler);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 347);
        this.panel1.Margin = new Padding(3, 2, 3, 2);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(509, 45);
        this.panel1.TabIndex = 4;
        // 
        // boutonAction
        // 
        this.boutonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.boutonAction.FlatStyle = FlatStyle.Flat;
        this.boutonAction.Location = new Point(262, 10);
        this.boutonAction.Margin = new Padding(3, 2, 3, 2);
        this.boutonAction.Name = "boutonAction";
        this.boutonAction.Size = new Size(116, 26);
        this.boutonAction.TabIndex = 1;
        this.boutonAction.Text = "ACTION";
        this.boutonAction.UseVisualStyleBackColor = true;
        this.boutonAction.Click += this.BoutonAction_Click;
        // 
        // buttonAnnuler
        // 
        this.buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAnnuler.FlatStyle = FlatStyle.Flat;
        this.buttonAnnuler.Location = new Point(383, 10);
        this.buttonAnnuler.Margin = new Padding(3, 2, 3, 2);
        this.buttonAnnuler.Name = "buttonAnnuler";
        this.buttonAnnuler.Size = new Size(116, 26);
        this.buttonAnnuler.TabIndex = 0;
        this.buttonAnnuler.Text = "Annuler";
        this.buttonAnnuler.UseVisualStyleBackColor = true;
        this.buttonAnnuler.Click += this.ButtonAnnuler_Click;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.openModeValueLabel);
        this.panel2.Controls.Add(this.openModeLabel);
        this.panel2.Dock = DockStyle.Top;
        this.panel2.Location = new Point(0, 0);
        this.panel2.Margin = new Padding(3, 2, 3, 2);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(509, 38);
        this.panel2.TabIndex = 5;
        // 
        // openModeValueLabel
        // 
        this.openModeValueLabel.AutoSize = true;
        this.openModeValueLabel.Location = new Point(64, 14);
        this.openModeValueLabel.Name = "openModeValueLabel";
        this.openModeValueLabel.Size = new Size(87, 15);
        this.openModeValueLabel.TabIndex = 6;
        this.openModeValueLabel.Text = "PLACEHOLDER";
        // 
        // openModeLabel
        // 
        this.openModeLabel.AutoSize = true;
        this.openModeLabel.Location = new Point(10, 14);
        this.openModeLabel.Name = "openModeLabel";
        this.openModeLabel.Size = new Size(44, 15);
        this.openModeLabel.TabIndex = 6;
        this.openModeLabel.Text = "Mode :";
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.userDateCreatedTextBox);
        this.panel3.Controls.Add(this.userPasswordTextBox);
        this.panel3.Controls.Add(this.userPasswordLabel);
        this.panel3.Controls.Add(this.userPasswordAdminResetButton);
        this.panel3.Controls.Add(this.userRolesListbox);
        this.panel3.Controls.Add(this.userRolesLabel);
        this.panel3.Controls.Add(this.userWarehouseCombobox);
        this.panel3.Controls.Add(this.userWarehouseLabel);
        this.panel3.Controls.Add(this.userDateCreatedLabel);
        this.panel3.Controls.Add(this.userPasswordHashTextBox);
        this.panel3.Controls.Add(this.userPasswordHashLabel);
        this.panel3.Controls.Add(this.userUsernameTextBox);
        this.panel3.Controls.Add(this.userUsernameLabel);
        this.panel3.Controls.Add(this.userIdNumericUD);
        this.panel3.Controls.Add(this.userIdLabel);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(0, 38);
        this.panel3.Margin = new Padding(3, 2, 3, 2);
        this.panel3.Name = "panel3";
        this.panel3.Padding = new Padding(9, 8, 9, 8);
        this.panel3.Size = new Size(509, 309);
        this.panel3.TabIndex = 6;
        // 
        // userDateCreatedTextBox
        // 
        this.userDateCreatedTextBox.Enabled = false;
        this.userDateCreatedTextBox.Location = new Point(192, 127);
        this.userDateCreatedTextBox.Margin = new Padding(3, 2, 3, 2);
        this.userDateCreatedTextBox.Name = "userDateCreatedTextBox";
        this.userDateCreatedTextBox.Size = new Size(241, 23);
        this.userDateCreatedTextBox.TabIndex = 15;
        // 
        // userPasswordTextBox
        // 
        this.userPasswordTextBox.Location = new Point(192, 81);
        this.userPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
        this.userPasswordTextBox.Name = "userPasswordTextBox";
        this.userPasswordTextBox.PlaceholderText = "New password here";
        this.userPasswordTextBox.Size = new Size(241, 23);
        this.userPasswordTextBox.TabIndex = 14;
        this.userPasswordTextBox.UseSystemPasswordChar = true;
        this.userPasswordTextBox.TextChanged += this.UserPasswordTextBox_Leave;
        this.userPasswordTextBox.Leave += this.UserPasswordTextBox_Leave;
        // 
        // userPasswordLabel
        // 
        this.userPasswordLabel.Location = new Point(11, 80);
        this.userPasswordLabel.Name = "userPasswordLabel";
        this.userPasswordLabel.Size = new Size(175, 21);
        this.userPasswordLabel.TabIndex = 13;
        this.userPasswordLabel.Text = "Password :";
        this.userPasswordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userPasswordAdminResetButton
        // 
        this.userPasswordAdminResetButton.Enabled = false;
        this.userPasswordAdminResetButton.Location = new Point(438, 80);
        this.userPasswordAdminResetButton.Margin = new Padding(3, 2, 3, 2);
        this.userPasswordAdminResetButton.Name = "userPasswordAdminResetButton";
        this.userPasswordAdminResetButton.Size = new Size(62, 21);
        this.userPasswordAdminResetButton.TabIndex = 12;
        this.userPasswordAdminResetButton.Text = "Reset";
        this.userPasswordAdminResetButton.UseVisualStyleBackColor = true;
        this.userPasswordAdminResetButton.Click += this.UserPasswordResetButton_Click;
        // 
        // userRolesListbox
        // 
        this.userRolesListbox.FormattingEnabled = true;
        this.userRolesListbox.ItemHeight = 15;
        this.userRolesListbox.Location = new Point(192, 177);
        this.userRolesListbox.Margin = new Padding(3, 2, 3, 2);
        this.userRolesListbox.Name = "userRolesListbox";
        this.userRolesListbox.Size = new Size(240, 109);
        this.userRolesListbox.TabIndex = 11;
        // 
        // userRolesLabel
        // 
        this.userRolesLabel.Location = new Point(10, 177);
        this.userRolesLabel.Name = "userRolesLabel";
        this.userRolesLabel.Size = new Size(175, 21);
        this.userRolesLabel.TabIndex = 10;
        this.userRolesLabel.Text = "Rôles :";
        this.userRolesLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userWarehouseCombobox
        // 
        this.userWarehouseCombobox.FormattingEnabled = true;
        this.userWarehouseCombobox.Location = new Point(192, 152);
        this.userWarehouseCombobox.Margin = new Padding(3, 2, 3, 2);
        this.userWarehouseCombobox.Name = "userWarehouseCombobox";
        this.userWarehouseCombobox.Size = new Size(240, 23);
        this.userWarehouseCombobox.TabIndex = 9;
        // 
        // userWarehouseLabel
        // 
        this.userWarehouseLabel.Location = new Point(11, 151);
        this.userWarehouseLabel.Name = "userWarehouseLabel";
        this.userWarehouseLabel.Size = new Size(175, 21);
        this.userWarehouseLabel.TabIndex = 8;
        this.userWarehouseLabel.Text = "Entrpôt de travail :";
        this.userWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userDateCreatedLabel
        // 
        this.userDateCreatedLabel.Location = new Point(11, 126);
        this.userDateCreatedLabel.Name = "userDateCreatedLabel";
        this.userDateCreatedLabel.Size = new Size(175, 21);
        this.userDateCreatedLabel.TabIndex = 6;
        this.userDateCreatedLabel.Text = "Date de Création :";
        this.userDateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userPasswordHashTextBox
        // 
        this.userPasswordHashTextBox.Location = new Point(192, 102);
        this.userPasswordHashTextBox.Margin = new Padding(3, 2, 3, 2);
        this.userPasswordHashTextBox.Name = "userPasswordHashTextBox";
        this.userPasswordHashTextBox.ReadOnly = true;
        this.userPasswordHashTextBox.Size = new Size(241, 23);
        this.userPasswordHashTextBox.TabIndex = 5;
        // 
        // userPasswordHashLabel
        // 
        this.userPasswordHashLabel.Location = new Point(11, 101);
        this.userPasswordHashLabel.Name = "userPasswordHashLabel";
        this.userPasswordHashLabel.Size = new Size(175, 21);
        this.userPasswordHashLabel.TabIndex = 4;
        this.userPasswordHashLabel.Text = "Password Hash :";
        this.userPasswordHashLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userUsernameTextBox
        // 
        this.userUsernameTextBox.Location = new Point(191, 56);
        this.userUsernameTextBox.Margin = new Padding(3, 2, 3, 2);
        this.userUsernameTextBox.Name = "userUsernameTextBox";
        this.userUsernameTextBox.Size = new Size(241, 23);
        this.userUsernameTextBox.TabIndex = 3;
        this.userUsernameTextBox.TextChanged += this.UserUsernameTextBox_TextChanged;
        this.userUsernameTextBox.Leave += this.UserUsernameTextBox_Leave;
        // 
        // userUsernameLabel
        // 
        this.userUsernameLabel.Location = new Point(10, 56);
        this.userUsernameLabel.Name = "userUsernameLabel";
        this.userUsernameLabel.Size = new Size(175, 21);
        this.userUsernameLabel.TabIndex = 2;
        this.userUsernameLabel.Text = "Username :";
        this.userUsernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdNumericUD
        // 
        this.userIdNumericUD.Enabled = false;
        this.userIdNumericUD.Location = new Point(191, 32);
        this.userIdNumericUD.Margin = new Padding(3, 2, 3, 2);
        this.userIdNumericUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.userIdNumericUD.Name = "userIdNumericUD";
        this.userIdNumericUD.ReadOnly = true;
        this.userIdNumericUD.Size = new Size(241, 23);
        this.userIdNumericUD.TabIndex = 1;
        // 
        // userIdLabel
        // 
        this.userIdLabel.Location = new Point(10, 30);
        this.userIdLabel.Name = "userIdLabel";
        this.userIdLabel.Size = new Size(175, 21);
        this.userIdLabel.TabIndex = 0;
        this.userIdLabel.Text = "Id :";
        this.userIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UtilisateurManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(509, 392);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Name = "UtilisateurManagementForm";
        this.Text = "Utilisateur Management Form";
        this.panel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.userIdNumericUD).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Button buttonAnnuler;
    private Button boutonAction;
    private Panel panel2;
    private Label openModeValueLabel;
    private Label openModeLabel;
    private Panel panel3;
    private Label userIdLabel;
    private Label userUsernameLabel;
    private NumericUpDown userIdNumericUD;
    private TextBox userUsernameTextBox;
    private Label userPasswordHashLabel;
    private TextBox userPasswordHashTextBox;
    private Label userDateCreatedLabel;
    private ListBox userRolesListbox;
    private Label userRolesLabel;
    private ComboBox userWarehouseCombobox;
    private Label userWarehouseLabel;
    private Button userPasswordAdminResetButton;
    private TextBox userPasswordTextBox;
    private Label userPasswordLabel;
    private TextBox userDateCreatedTextBox;
}