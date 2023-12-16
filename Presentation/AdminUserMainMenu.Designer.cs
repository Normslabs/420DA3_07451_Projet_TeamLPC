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
        this.topBarPanel = new Panel();
        this.bottomBarPanel = new Panel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.userManagementPanel = new Panel();
        this.deleteUserButton = new Button();
        this.editUserButton = new Button();
        this.viewUserButton = new Button();
        this.userSelector = new ComboBox();
        this.createUserButton = new Button();
        this.label1 = new Label();
        this.quitButton = new Button();
        this.bottomBarPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.userManagementPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1184, 40);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.quitButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 821);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1184, 40);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 5;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.Controls.Add(this.userManagementPanel, 0, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 40);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Size = new Size(1184, 781);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // userManagementPanel
        // 
        this.userManagementPanel.Controls.Add(this.deleteUserButton);
        this.userManagementPanel.Controls.Add(this.editUserButton);
        this.userManagementPanel.Controls.Add(this.viewUserButton);
        this.userManagementPanel.Controls.Add(this.userSelector);
        this.userManagementPanel.Controls.Add(this.createUserButton);
        this.userManagementPanel.Controls.Add(this.label1);
        this.userManagementPanel.Dock = DockStyle.Fill;
        this.userManagementPanel.Location = new Point(3, 3);
        this.userManagementPanel.Name = "userManagementPanel";
        this.userManagementPanel.Padding = new Padding(10);
        this.userManagementPanel.Size = new Size(230, 384);
        this.userManagementPanel.TabIndex = 0;
        // 
        // deleteUserButton
        // 
        this.deleteUserButton.Dock = DockStyle.Top;
        this.deleteUserButton.Location = new Point(10, 178);
        this.deleteUserButton.Name = "deleteUserButton";
        this.deleteUserButton.Size = new Size(210, 35);
        this.deleteUserButton.TabIndex = 5;
        this.deleteUserButton.Text = "Supprimer l'utilisateur";
        this.deleteUserButton.UseVisualStyleBackColor = true;
        this.deleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // editUserButton
        // 
        this.editUserButton.Dock = DockStyle.Top;
        this.editUserButton.Location = new Point(10, 143);
        this.editUserButton.Name = "editUserButton";
        this.editUserButton.Size = new Size(210, 35);
        this.editUserButton.TabIndex = 4;
        this.editUserButton.Text = "Éditer l'utilisateur";
        this.editUserButton.UseVisualStyleBackColor = true;
        this.editUserButton.Click += this.EditUserButton_Click;
        // 
        // viewUserButton
        // 
        this.viewUserButton.Dock = DockStyle.Top;
        this.viewUserButton.Location = new Point(10, 108);
        this.viewUserButton.Name = "viewUserButton";
        this.viewUserButton.Size = new Size(210, 35);
        this.viewUserButton.TabIndex = 3;
        this.viewUserButton.Text = "Voir détails de l'utilisateur";
        this.viewUserButton.UseVisualStyleBackColor = true;
        this.viewUserButton.Click += this.ViewUserButton_Click;
        // 
        // userSelector
        // 
        this.userSelector.Dock = DockStyle.Top;
        this.userSelector.FormattingEnabled = true;
        this.userSelector.Location = new Point(10, 85);
        this.userSelector.Name = "userSelector";
        this.userSelector.Size = new Size(210, 23);
        this.userSelector.TabIndex = 2;
        this.userSelector.SelectedIndexChanged += this.UserSelector_SelectedIndexChanged;
        // 
        // createUserButton
        // 
        this.createUserButton.Dock = DockStyle.Top;
        this.createUserButton.Location = new Point(10, 50);
        this.createUserButton.Name = "createUserButton";
        this.createUserButton.Size = new Size(210, 35);
        this.createUserButton.TabIndex = 1;
        this.createUserButton.Text = "Créer un utilisateur";
        this.createUserButton.UseVisualStyleBackColor = true;
        this.createUserButton.Click += this.CreateUserButton_Click;
        // 
        // label1
        // 
        this.label1.Dock = DockStyle.Top;
        this.label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(10, 10);
        this.label1.Name = "label1";
        this.label1.Size = new Size(210, 40);
        this.label1.TabIndex = 0;
        this.label1.Text = "Gestion des Utilisateurs";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // quitButton
        // 
        this.quitButton.Location = new Point(1079, 6);
        this.quitButton.Name = "quitButton";
        this.quitButton.Size = new Size(93, 31);
        this.quitButton.TabIndex = 0;
        this.quitButton.Text = "Quitter";
        this.quitButton.UseVisualStyleBackColor = true;
        this.quitButton.Click += this.QuitButton_Click;
        // 
        // AdminUserMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "AdminUserMainMenu";
        this.Text = "AdminUserMainMenu";
        this.bottomBarPanel.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel userManagementPanel;
    private Label label1;
    private Button deleteUserButton;
    private Button editUserButton;
    private Button viewUserButton;
    private ComboBox userSelector;
    private Button createUserButton;
    private Button quitButton;
}