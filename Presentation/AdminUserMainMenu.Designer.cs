namespace _420DA3_07451_Projet_Initial.Presentation;

partial class AdminUserMainMenu {
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
        topBarPanel = new Panel();
        bottomBarPanel = new Panel();
        quitButton = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        deleteRoleButton = new Button();
        editRoleButton = new Button();
        roleViewButton = new Button();
        roleSelector = new ComboBox();
        createRoleButton = new Button();
        roleLabel = new Label();
        userManagementPanel = new Panel();
        deleteUserButton = new Button();
        editUserButton = new Button();
        viewUserButton = new Button();
        userSelector = new ComboBox();
        createUserButton = new Button();
        userLabel = new Label();
        bottomBarPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        userManagementPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(1184, 40);
        topBarPanel.TabIndex = 0;
        topBarPanel.Paint += this.topBarPanel_Paint;
        // 
        // bottomBarPanel
        // 
        bottomBarPanel.Controls.Add(quitButton);
        bottomBarPanel.Dock = DockStyle.Bottom;
        bottomBarPanel.Location = new Point(0, 821);
        bottomBarPanel.Name = "bottomBarPanel";
        bottomBarPanel.Size = new Size(1184, 40);
        bottomBarPanel.TabIndex = 1;
        // 
        // quitButton
        // 
        quitButton.Location = new Point(1079, 6);
        quitButton.Name = "quitButton";
        quitButton.Size = new Size(93, 31);
        quitButton.TabIndex = 0;
        quitButton.Text = "Quitter";
        quitButton.UseVisualStyleBackColor = true;
        quitButton.Click += this.QuitButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 5;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Controls.Add(userManagementPanel, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 40);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(1184, 781);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // panel1
        // 
        panel1.Controls.Add(deleteRoleButton);
        panel1.Controls.Add(editRoleButton);
        panel1.Controls.Add(roleViewButton);
        panel1.Controls.Add(roleSelector);
        panel1.Controls.Add(createRoleButton);
        panel1.Controls.Add(roleLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 393);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(10);
        panel1.Size = new Size(230, 385);
        panel1.TabIndex = 1;
        // 
        // deleteRoleButton
        // 
        deleteRoleButton.Dock = DockStyle.Top;
        deleteRoleButton.Location = new Point(10, 178);
        deleteRoleButton.Name = "deleteRoleButton";
        deleteRoleButton.Size = new Size(210, 35);
        deleteRoleButton.TabIndex = 5;
        deleteRoleButton.Text = "Supprimer le rôle";
        deleteRoleButton.UseVisualStyleBackColor = true;
        deleteRoleButton.Click += this.DeleteRoleButton_Click;
        // 
        // editRoleButton
        // 
        editRoleButton.Dock = DockStyle.Top;
        editRoleButton.Location = new Point(10, 143);
        editRoleButton.Name = "editRoleButton";
        editRoleButton.Size = new Size(210, 35);
        editRoleButton.TabIndex = 4;
        editRoleButton.Text = "Éditer le rôle";
        editRoleButton.UseVisualStyleBackColor = true;
        editRoleButton.Click += this.EditRoleButton_Click;
        // 
        // roleViewButton
        // 
        roleViewButton.Dock = DockStyle.Top;
        roleViewButton.Location = new Point(10, 108);
        roleViewButton.Name = "roleViewButton";
        roleViewButton.Size = new Size(210, 35);
        roleViewButton.TabIndex = 3;
        roleViewButton.Text = "Voir détails du rôle";
        roleViewButton.UseVisualStyleBackColor = true;
        roleViewButton.Click += this.RoleViewButton_Click;
        // 
        // roleSelector
        // 
        roleSelector.Dock = DockStyle.Top;
        roleSelector.FormattingEnabled = true;
        roleSelector.Location = new Point(10, 85);
        roleSelector.Name = "roleSelector";
        roleSelector.Size = new Size(210, 23);
        roleSelector.TabIndex = 2;
        roleSelector.SelectedIndexChanged += this.RoleSelector_SelectedIndexChanged;
        // 
        // createRoleButton
        // 
        createRoleButton.Dock = DockStyle.Top;
        createRoleButton.Location = new Point(10, 50);
        createRoleButton.Name = "createRoleButton";
        createRoleButton.Size = new Size(210, 35);
        createRoleButton.TabIndex = 1;
        createRoleButton.Text = "Créer un rôle";
        createRoleButton.UseVisualStyleBackColor = true;
        createRoleButton.Click += this.CreateRoleButton_Click;
        // 
        // roleLabel
        // 
        roleLabel.Dock = DockStyle.Top;
        roleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        roleLabel.Location = new Point(10, 10);
        roleLabel.Name = "roleLabel";
        roleLabel.Size = new Size(210, 40);
        roleLabel.TabIndex = 0;
        roleLabel.Text = "Gestion des Rôles";
        roleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userManagementPanel
        // 
        userManagementPanel.Controls.Add(deleteUserButton);
        userManagementPanel.Controls.Add(editUserButton);
        userManagementPanel.Controls.Add(viewUserButton);
        userManagementPanel.Controls.Add(userSelector);
        userManagementPanel.Controls.Add(createUserButton);
        userManagementPanel.Controls.Add(userLabel);
        userManagementPanel.Dock = DockStyle.Fill;
        userManagementPanel.Location = new Point(3, 3);
        userManagementPanel.Name = "userManagementPanel";
        userManagementPanel.Padding = new Padding(10);
        userManagementPanel.Size = new Size(230, 384);
        userManagementPanel.TabIndex = 0;
        // 
        // deleteUserButton
        // 
        deleteUserButton.Dock = DockStyle.Top;
        deleteUserButton.Location = new Point(10, 178);
        deleteUserButton.Name = "deleteUserButton";
        deleteUserButton.Size = new Size(210, 35);
        deleteUserButton.TabIndex = 5;
        deleteUserButton.Text = "Supprimer l'utilisateur";
        deleteUserButton.UseVisualStyleBackColor = true;
        deleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // editUserButton
        // 
        editUserButton.Dock = DockStyle.Top;
        editUserButton.Location = new Point(10, 143);
        editUserButton.Name = "editUserButton";
        editUserButton.Size = new Size(210, 35);
        editUserButton.TabIndex = 4;
        editUserButton.Text = "Éditer l'utilisateur";
        editUserButton.UseVisualStyleBackColor = true;
        editUserButton.Click += this.EditUserButton_Click;
        // 
        // viewUserButton
        // 
        viewUserButton.Dock = DockStyle.Top;
        viewUserButton.Location = new Point(10, 108);
        viewUserButton.Name = "viewUserButton";
        viewUserButton.Size = new Size(210, 35);
        viewUserButton.TabIndex = 3;
        viewUserButton.Text = "Voir détails de l'utilisateur";
        viewUserButton.UseVisualStyleBackColor = true;
        viewUserButton.Click += this.ViewUserButton_Click;
        // 
        // userSelector
        // 
        userSelector.Dock = DockStyle.Top;
        userSelector.FormattingEnabled = true;
        userSelector.Location = new Point(10, 85);
        userSelector.Name = "userSelector";
        userSelector.Size = new Size(210, 23);
        userSelector.TabIndex = 2;
        userSelector.SelectedIndexChanged += this.UserSelector_SelectedIndexChanged;
        // 
        // createUserButton
        // 
        createUserButton.Dock = DockStyle.Top;
        createUserButton.Location = new Point(10, 50);
        createUserButton.Name = "createUserButton";
        createUserButton.Size = new Size(210, 35);
        createUserButton.TabIndex = 1;
        createUserButton.Text = "Créer un utilisateur";
        createUserButton.UseVisualStyleBackColor = true;
        createUserButton.Click += this.CreateUserButton_Click;
        // 
        // userLabel
        // 
        userLabel.Dock = DockStyle.Top;
        userLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        userLabel.Location = new Point(10, 10);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(210, 40);
        userLabel.TabIndex = 0;
        userLabel.Text = "Gestion des Utilisateurs";
        userLabel.TextAlign = ContentAlignment.MiddleCenter;
        userLabel.Click += this.userLabel_Click;
        // 
        // AdminUserMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(tableLayoutPanel1);
        this.Controls.Add(bottomBarPanel);
        this.Controls.Add(topBarPanel);
        this.Name = "AdminUserMainMenu";
        this.Text = "AdminUserMainMenu";
        bottomBarPanel.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        userManagementPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel userManagementPanel;
    private Label userLabel;
    private Button deleteUserButton;
    private Button editUserButton;
    private Button viewUserButton;
    private ComboBox userSelector;
    private Button createUserButton;
    private Button quitButton;
    private Panel panel1;
    private Button deleteRoleButton;
    private Button editRoleButton;
    private Button roleViewButton;
    private ComboBox roleSelector;
    private Button createRoleButton;
    private Label roleLabel;
}