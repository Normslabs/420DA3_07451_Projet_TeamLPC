using System.Reflection.Emit;

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
        this.quitButton = new Button();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panelGestionShipment = new Panel();
        this.ShipmentViewBtn = new Button();
        this.ShipmentListBox = new ListBox();
        this.ShipmentFiltreTextbox = new TextBox();
        this.ShipmentCreateBtn = new Button();
        this.shipmentMgmtLabel = new Label();
        this.fournisseurPanel = new Panel();
        this.FournisseurDeleteBtn = new Button();
        this.FournisseurEditBtn = new Button();
        this.FournisseurViewBtn = new Button();
        this.FournisseurListBox = new ListBox();
        this.FournisseurFiltreTextBox = new TextBox();
        this.FournisseurCreateBtn = new Button();
        this.fournisseurLabel = new Label();
        this.rolePanel = new Panel();
        this.deleteRoleButton = new Button();
        this.editRoleButton = new Button();
        this.roleViewButton = new Button();
        this.roleSelector = new ComboBox();
        this.createRoleButton = new Button();
        this.roleLabel = new Label();
        this.userManagementPanel = new Panel();
        this.deleteUserButton = new Button();
        this.editUserButton = new Button();
        this.viewUserButton = new Button();
        this.userSelector = new ComboBox();
        this.createUserButton = new Button();
        this.userLabel = new Label();
        this.Clientpanel4 = new Panel();
        this.deletebutton = new Button();
        this.editClientbutton = new Button();
        this.viewClientbutton1 = new Button();
        this.ClientslistBox1 = new ListBox();
        this.filterClienttextBox1 = new TextBox();
        this.createClientbutton1 = new Button();
        this.label2 = new Label();
        this.entrpotPanel = new Panel();
        this.deleteEntrepotButton = new Button();
        this.editEntrepotButton = new Button();
        this.viewEntrepotButton = new Button();
        this.entrepotSelector = new ComboBox();
        this.createEntrepotButton = new Button();
        this.entrepotLabel = new Label();
        this.addressPanel = new Panel();
        this.AdresseDeleteButton = new Button();
        this.AdresseEditButton = new Button();
        this.AdresseViewButton = new Button();
        this.AdresseListBox = new ListBox();
        this.AdresseFiltreTextBox = new TextBox();
        this.createAdresseButton = new Button();
        this.adresseLabel = new Label();
        this.bottomBarPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panelGestionShipment.SuspendLayout();
        this.fournisseurPanel.SuspendLayout();
        this.rolePanel.SuspendLayout();
        this.userManagementPanel.SuspendLayout();
        this.entrpotPanel.SuspendLayout();
        this.addressPanel.SuspendLayout();
        this.Clientpanel4.SuspendLayout();
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
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 5;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tableLayoutPanel1.Controls.Add(this.panelGestionShipment, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.fournisseurPanel, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.rolePanel, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.userManagementPanel, 0, 0); 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.Clientpanel4, 3, 1);
        this.tableLayoutPanel1.Controls.Add(this.entrpotPanel, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.addressPanel, 2, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 40);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Size = new Size(1184, 781);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // panelGestionShipment
        // 
        this.panelGestionShipment.Controls.Add(this.ShipmentViewBtn);
        this.panelGestionShipment.Controls.Add(this.ShipmentListBox);
        this.panelGestionShipment.Controls.Add(this.ShipmentFiltreTextbox);
        this.panelGestionShipment.Controls.Add(this.ShipmentCreateBtn);
        this.panelGestionShipment.Controls.Add(this.shipmentMgmtLabel);
        this.panelGestionShipment.Dock = DockStyle.Fill;
        this.panelGestionShipment.Location = new Point(3, 393);
        this.panelGestionShipment.Name = "panelGestionShipment";
        this.panelGestionShipment.Padding = new Padding(10);
        this.panelGestionShipment.Size = new Size(230, 385);
        this.panelGestionShipment.TabIndex = 3;
        // 
        // ShipmentViewBtn
        // 
        ShipmentViewBtn.Dock = DockStyle.Top;
        ShipmentViewBtn.Location = new Point(10, 202);
        ShipmentViewBtn.Name = "ShipmentViewBtn";
        ShipmentViewBtn.Size = new Size(210, 35);
        ShipmentViewBtn.TabIndex = 5;
        ShipmentViewBtn.Text = "Voir un shipment";
        ShipmentViewBtn.UseVisualStyleBackColor = true;
        ShipmentViewBtn.Click += this.ShipmentViewBtn_Click;
        // 
        // ShipmentListBox
        // 
        ShipmentListBox.Dock = DockStyle.Top;
        ShipmentListBox.FormattingEnabled = true;
        ShipmentListBox.ItemHeight = 15;
        ShipmentListBox.Location = new Point(10, 108);
        ShipmentListBox.Name = "ShipmentListBox";
        ShipmentListBox.Size = new Size(210, 94);
        ShipmentListBox.TabIndex = 4;
        ShipmentListBox.SelectedIndexChanged += this.ShipmentListBox_SelectedIndexChanged;
        // 
        // ShipmentFiltreTextbox
        // 
        ShipmentFiltreTextbox.BackColor = SystemColors.Window;
        ShipmentFiltreTextbox.Dock = DockStyle.Top;
        ShipmentFiltreTextbox.Location = new Point(10, 85);
        ShipmentFiltreTextbox.Name = "ShipmentFiltreTextbox";
        ShipmentFiltreTextbox.Size = new Size(210, 23);
        ShipmentFiltreTextbox.TabIndex = 3;
        ShipmentFiltreTextbox.UseSystemPasswordChar = true;
        // 
        // ShipmentCreateBtn
        // 
        ShipmentCreateBtn.Dock = DockStyle.Top;
        ShipmentCreateBtn.Location = new Point(10, 50);
        ShipmentCreateBtn.Name = "ShipmentCreateBtn";
        ShipmentCreateBtn.Size = new Size(210, 35);
        ShipmentCreateBtn.TabIndex = 2;
        ShipmentCreateBtn.Text = "Créer un shipment";
        ShipmentCreateBtn.UseVisualStyleBackColor = true;
        ShipmentCreateBtn.Click += this.ShipmentCreateBtn_Click;
        // 
        // shipmentMgmtLabel
        // 
        this.shipmentMgmtLabel.Dock = DockStyle.Top;
        this.shipmentMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipmentMgmtLabel.Location = new Point(10, 10);
        this.shipmentMgmtLabel.Name = "shipmentMgmtLabel";
        this.shipmentMgmtLabel.Size = new Size(210, 40);
        this.shipmentMgmtLabel.TabIndex = 0;
        this.shipmentMgmtLabel.Text = "Gestion des shipments";
        this.shipmentMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // fournisseurPanel
        // 
        this.fournisseurPanel.Controls.Add(this.FournisseurDeleteBtn);
        this.fournisseurPanel.Controls.Add(this.FournisseurEditBtn);
        this.fournisseurPanel.Controls.Add(this.FournisseurViewBtn);
        this.fournisseurPanel.Controls.Add(this.FournisseurListBox);
        this.fournisseurPanel.Controls.Add(this.FournisseurFiltreTextBox);
        this.fournisseurPanel.Controls.Add(this.FournisseurCreateBtn);
        this.fournisseurPanel.Controls.Add(this.fournisseurLabel);
        this.fournisseurPanel.Dock = DockStyle.Fill;
        this.fournisseurPanel.Location = new Point(239, 393);
        this.fournisseurPanel.Name = "fournisseurPanel";
        this.fournisseurPanel.Padding = new Padding(10);
        this.fournisseurPanel.Size = new Size(230, 385);
        this.fournisseurPanel.TabIndex = 2;
        // 
        // FournisseurDeleteBtn
        // 
        this.FournisseurDeleteBtn.Dock = DockStyle.Top;
        this.FournisseurDeleteBtn.Location = new Point(10, 272);
        this.FournisseurDeleteBtn.Name = "FournisseurDeleteBtn";
        this.FournisseurDeleteBtn.Size = new Size(210, 35);
        this.FournisseurDeleteBtn.TabIndex = 8;
        this.FournisseurDeleteBtn.Text = "Supprimer un fournisseur";
        this.FournisseurDeleteBtn.UseVisualStyleBackColor = true;
        this.FournisseurDeleteBtn.Click += this.FournisseurDeleteBtn_Click;
        // 
        // FournisseurEditBtn
        // 
        this.FournisseurEditBtn.Dock = DockStyle.Top;
        this.FournisseurEditBtn.Location = new Point(10, 237);
        this.FournisseurEditBtn.Name = "FournisseurEditBtn";
        this.FournisseurEditBtn.Size = new Size(210, 35);
        this.FournisseurEditBtn.TabIndex = 7;
        this.FournisseurEditBtn.Text = "Éditer le fournisseur";
        this.FournisseurEditBtn.UseVisualStyleBackColor = true;
        this.FournisseurEditBtn.Click += this.FournisseurEditBtn_Click;
        // 
        // FournisseurViewBtn
        // 
        this.FournisseurViewBtn.Dock = DockStyle.Top;
        this.FournisseurViewBtn.Location = new Point(10, 202);
        this.FournisseurViewBtn.Name = "FournisseurViewBtn";
        this.FournisseurViewBtn.Size = new Size(210, 35);
        this.FournisseurViewBtn.TabIndex = 6;
        this.FournisseurViewBtn.Text = "Voir détails du fournisseur";
        this.FournisseurViewBtn.UseVisualStyleBackColor = true;
        this.FournisseurViewBtn.Click += this.FournisseurViewBtn_Click;
        // 
        // FournisseurListBox
        // 
        this.FournisseurListBox.Dock = DockStyle.Top;
        this.FournisseurListBox.FormattingEnabled = true;
        this.FournisseurListBox.ItemHeight = 15;
        this.FournisseurListBox.Location = new Point(10, 108);
        this.FournisseurListBox.Name = "FournisseurListBox";
        this.FournisseurListBox.Size = new Size(210, 94);
        this.FournisseurListBox.TabIndex = 5;
        this.FournisseurListBox.SelectedIndexChanged += this.FournisseurListBox_SelectedIndexChanged;
        // 
        // FournisseurFiltreTextBox
        // 
        this.FournisseurFiltreTextBox.Dock = DockStyle.Top;
        this.FournisseurFiltreTextBox.Location = new Point(10, 85);
        this.FournisseurFiltreTextBox.Name = "FournisseurFiltreTextBox";
        this.FournisseurFiltreTextBox.Size = new Size(210, 23);
        this.FournisseurFiltreTextBox.TabIndex = 4;
        this.FournisseurFiltreTextBox.UseSystemPasswordChar = true;
        this.FournisseurFiltreTextBox.TextChanged += this.FournisseurFiltreTextBox_TextChanged;
        // 
        // FournisseurCreateBtn
        // 
        this.FournisseurCreateBtn.Dock = DockStyle.Top;
        this.FournisseurCreateBtn.Location = new Point(10, 50);
        this.FournisseurCreateBtn.Name = "FournisseurCreateBtn";
        this.FournisseurCreateBtn.Size = new Size(210, 35);
        this.FournisseurCreateBtn.TabIndex = 1;
        this.FournisseurCreateBtn.Text = "Créer un fournisseur";
        this.FournisseurCreateBtn.UseVisualStyleBackColor = true;
        this.FournisseurCreateBtn.Click += this.FournisseurCreateBtn_Click;
        // 
        // fournisseurLabel
        // 
        this.fournisseurLabel.Dock = DockStyle.Top;
        this.fournisseurLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.fournisseurLabel.Location = new Point(10, 10);
        this.fournisseurLabel.Name = "fournisseurLabel";
        this.fournisseurLabel.Size = new Size(210, 40);
        this.fournisseurLabel.TabIndex = 0;
        this.fournisseurLabel.Text = "Gestion des Fournisseurs";
        this.fournisseurLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rolePanel
        // 
        this.rolePanel.Controls.Add(this.deleteRoleButton);
        this.rolePanel.Controls.Add(this.editRoleButton);
        this.rolePanel.Controls.Add(this.roleViewButton);
        this.rolePanel.Controls.Add(this.roleSelector);
        this.rolePanel.Controls.Add(this.createRoleButton);
        this.rolePanel.Controls.Add(this.roleLabel);
        this.rolePanel.Dock = DockStyle.Fill;
        this.rolePanel.Location = new Point(475, 393);
        this.rolePanel.Name = "rolePanel";
        this.rolePanel.Padding = new Padding(10);
        this.rolePanel.Size = new Size(230, 385);
        this.rolePanel.TabIndex = 1;
        // 
        // deleteRoleButton
        // 
        this.deleteRoleButton.Dock = DockStyle.Top;
        this.deleteRoleButton.Location = new Point(10, 178);
        this.deleteRoleButton.Name = "deleteRoleButton";
        this.deleteRoleButton.Size = new Size(210, 35);
        this.deleteRoleButton.TabIndex = 5;
        this.deleteRoleButton.Text = "Supprimer le rôle";
        this.deleteRoleButton.UseVisualStyleBackColor = true;
        this.deleteRoleButton.Click += this.DeleteRoleButton_Click;
        // 
        // editRoleButton
        // 
        this.editRoleButton.Dock = DockStyle.Top;
        this.editRoleButton.Location = new Point(10, 143);
        this.editRoleButton.Name = "editRoleButton";
        this.editRoleButton.Size = new Size(210, 35);
        this.editRoleButton.TabIndex = 4;
        this.editRoleButton.Text = "Éditer le rôle";
        this.editRoleButton.UseVisualStyleBackColor = true;
        this.editRoleButton.Click += this.EditRoleButton_Click;
        // 
        // roleViewButton
        // 
        this.roleViewButton.Dock = DockStyle.Top;
        this.roleViewButton.Location = new Point(10, 108);
        this.roleViewButton.Name = "roleViewButton";
        this.roleViewButton.Size = new Size(210, 35);
        this.roleViewButton.TabIndex = 3;
        this.roleViewButton.Text = "Voir détails du rôle";
        this.roleViewButton.UseVisualStyleBackColor = true;
        this.roleViewButton.Click += this.RoleViewButton_Click;
        // 
        // roleSelector
        // 
        this.roleSelector.Dock = DockStyle.Top;
        this.roleSelector.FormattingEnabled = true;
        this.roleSelector.Location = new Point(10, 85);
        this.roleSelector.Name = "roleSelector";
        this.roleSelector.Size = new Size(210, 23);
        this.roleSelector.TabIndex = 2;
        this.roleSelector.SelectedIndexChanged += this.RoleSelector_SelectedIndexChanged;
        // 
        // createRoleButton
        // 
        this.createRoleButton.Dock = DockStyle.Top;
        this.createRoleButton.Location = new Point(10, 50);
        this.createRoleButton.Name = "createRoleButton";
        this.createRoleButton.Size = new Size(210, 35);
        this.createRoleButton.TabIndex = 1;
        this.createRoleButton.Text = "Créer un rôle";
        this.createRoleButton.UseVisualStyleBackColor = true;
        this.createRoleButton.Click += this.CreateRoleButton_Click;
        // 
        // roleLabel
        // 
        this.roleLabel.Dock = DockStyle.Top;
        this.roleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleLabel.Location = new Point(10, 10);
        this.roleLabel.Name = "roleLabel";
        this.roleLabel.Size = new Size(210, 40);
        this.roleLabel.TabIndex = 0;
        this.roleLabel.Text = "Gestion des Rôles";
        this.roleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userManagementPanel
        // 
        this.userManagementPanel.Controls.Add(this.deleteUserButton);
        this.userManagementPanel.Controls.Add(this.editUserButton);
        this.userManagementPanel.Controls.Add(this.viewUserButton);
        this.userManagementPanel.Controls.Add(this.userSelector);
        this.userManagementPanel.Controls.Add(this.createUserButton);
        this.userManagementPanel.Controls.Add(this.userLabel);
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
        // userLabel
        // 
        this.userLabel.Dock = DockStyle.Top;
        this.userLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.userLabel.Location = new Point(10, 10);
        this.userLabel.Name = "userLabel";
        this.userLabel.Size = new Size(210, 40);
        this.userLabel.TabIndex = 0;
        this.userLabel.Text = "Gestion des Utilisateurs";
        this.userLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // entrpotPanel
        // 
        this.entrpotPanel.Controls.Add(this.deleteEntrepotButton);
        this.entrpotPanel.Controls.Add(this.editEntrepotButton);
        this.entrpotPanel.Controls.Add(this.viewEntrepotButton);
        this.entrpotPanel.Controls.Add(this.entrepotSelector);
        this.entrpotPanel.Controls.Add(this.createEntrepotButton);
        this.entrpotPanel.Controls.Add(this.entrepotLabel);
        this.entrpotPanel.Dock = DockStyle.Fill;
        this.entrpotPanel.Location = new Point(239, 3);
        this.entrpotPanel.Name = "entrpotPanel";
        this.entrpotPanel.Padding = new Padding(10, 10, 10, 20);
        this.entrpotPanel.Size = new Size(230, 384);
        this.entrpotPanel.TabIndex = 4;
        // 
        // deleteEntrepotButton
        // 
        this.deleteEntrepotButton.Dock = DockStyle.Top;
        this.deleteEntrepotButton.Location = new Point(10, 178);
        this.deleteEntrepotButton.Name = "deleteEntrepotButton";
        this.deleteEntrepotButton.Size = new Size(210, 35);
        this.deleteEntrepotButton.TabIndex = 6;
        this.deleteEntrepotButton.Text = "Supprimer l'entrepot";
        this.deleteEntrepotButton.UseVisualStyleBackColor = true;
        deleteEntrepotButton.Click += this.deleteEntrepotButton_Click
        // 
        // editEntrepotButton
        // 
        editEntrepotButton.Dock = DockStyle.Top;
        editEntrepotButton.Location = new Point(10, 143);
        editEntrepotButton.Name = "editEntrepotButton";
        editEntrepotButton.Size = new Size(210, 35);
        editEntrepotButton.TabIndex = 5;
        editEntrepotButton.Text = "Éditer l'entrepot";
        editEntrepotButton.UseVisualStyleBackColor = true;
        editEntrepotButton.Click += this.editEntrepotButton_Click;
        // 
        // viewEntrepotButton
        // 
        viewEntrepotButton.Dock = DockStyle.Top;
        viewEntrepotButton.Location = new Point(10, 108);
        viewEntrepotButton.Name = "viewEntrepotButton";
        viewEntrepotButton.Size = new Size(210, 35);
        viewEntrepotButton.TabIndex = 4;
        viewEntrepotButton.Text = "Voir détails de l'entrepot";
        viewEntrepotButton.UseVisualStyleBackColor = true;
        viewEntrepotButton.Click += this.viewEntrepotButton_Click;
        // 
        // entrepotSelector
        // 
        entrepotSelector.Dock = DockStyle.Top;
        entrepotSelector.FormattingEnabled = true;
        entrepotSelector.Location = new Point(10, 85);
        entrepotSelector.Name = "entrepotSelector";
        entrepotSelector.Size = new Size(210, 23);
        entrepotSelector.TabIndex = 3;
        entrepotSelector.SelectedIndexChanged += this.EntrepotSelector_SelectedIndexChanged;
        // 
        // createEntrepotButton
        // 
        createEntrepotButton.Dock = DockStyle.Top;
        createEntrepotButton.Location = new Point(10, 50);
        createEntrepotButton.Name = "createEntrepotButton";
        createEntrepotButton.Size = new Size(210, 35);
        createEntrepotButton.TabIndex = 2;
        createEntrepotButton.Text = "Créer un entrepot";
        createEntrepotButton.UseVisualStyleBackColor = true;
        createEntrepotButton.Click += this.CreateEntrepotButton_Click;
        // 
        // entrepotLabel
        // 
        this.entrepotLabel.Dock = DockStyle.Top;
        this.entrepotLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.entrepotLabel.Location = new Point(10, 10);
        this.entrepotLabel.Name = "entrepotLabel";
        this.entrepotLabel.Size = new Size(210, 40);
        this.entrepotLabel.TabIndex = 1;
        this.entrepotLabel.Text = "Gestion des Entrepots";
        this.entrepotLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressPanel
        // 
        this.addressPanel.Controls.Add(this.AdresseDeleteButton);
        this.addressPanel.Controls.Add(this.AdresseEditButton);
        this.addressPanel.Controls.Add(this.AdresseViewButton);
        this.addressPanel.Controls.Add(this.AdresseListBox);
        this.addressPanel.Controls.Add(this.AdresseFiltreTextBox);
        this.addressPanel.Controls.Add(this.createAdresseButton);
        this.addressPanel.Controls.Add(this.adresseLabel);
        this.addressPanel.Dock = DockStyle.Fill;
        this.addressPanel.Location = new Point(475, 3);
        this.addressPanel.Name = "addressPanel";
        this.addressPanel.Padding = new Padding(10);
        this.addressPanel.Size = new Size(230, 384);
        this.addressPanel.TabIndex = 5;
        // 
        // AdresseDeleteButton
        // 
        this.AdresseDeleteButton.Dock = DockStyle.Top;
        this.AdresseDeleteButton.Location = new Point(10, 272);
        this.AdresseDeleteButton.Name = "AdresseDeleteButton";
        this.AdresseDeleteButton.Size = new Size(210, 35);
        this.AdresseDeleteButton.TabIndex = 9;
        this.AdresseDeleteButton.Text = "Supprimer l'adresse";
        this.AdresseDeleteButton.UseVisualStyleBackColor = true;
        // 
        // AdresseEditButton
        // 
        this.AdresseEditButton.Dock = DockStyle.Top;
        this.AdresseEditButton.Location = new Point(10, 237);
        this.AdresseEditButton.Name = "AdresseEditButton";
        this.AdresseEditButton.Size = new Size(210, 35);
        this.AdresseEditButton.TabIndex = 8;
        this.AdresseEditButton.Text = "Éditer l'adresse";
        this.AdresseEditButton.UseVisualStyleBackColor = true;
        // 
        // AdresseDeleteButton
        // 
        AdresseDeleteButton.Dock = DockStyle.Top;
        AdresseDeleteButton.Location = new Point(10, 272);
        AdresseDeleteButton.Name = "AdresseDeleteButton";
        AdresseDeleteButton.Size = new Size(210, 35);
        AdresseDeleteButton.TabIndex = 9;
        AdresseDeleteButton.Text = "Supprimer l'adresse";
        AdresseDeleteButton.UseVisualStyleBackColor = true;
        // 
        // AdresseEditButton
        // 
        AdresseEditButton.Dock = DockStyle.Top;
        AdresseEditButton.Location = new Point(10, 237);
        AdresseEditButton.Name = "AdresseEditButton";
        AdresseEditButton.Size = new Size(210, 35);
        AdresseEditButton.TabIndex = 8;
        AdresseEditButton.Text = "Éditer l'adresse";
        AdresseEditButton.UseVisualStyleBackColor = true;
        // 
        // AdresseViewButton
        // 
        this.AdresseViewButton.Dock = DockStyle.Top;
        this.AdresseViewButton.Location = new Point(10, 202);
        this.AdresseViewButton.Name = "AdresseViewButton";
        this.AdresseViewButton.Size = new Size(210, 35);
        this.AdresseViewButton.TabIndex = 7;
        this.AdresseViewButton.Text = "Voir détails de l'adresse";
        this.AdresseViewButton.UseVisualStyleBackColor = true;
        // 
        // AdresseListBox
        // 
        this.AdresseListBox.Dock = DockStyle.Top;
        this.AdresseListBox.FormattingEnabled = true;
        this.AdresseListBox.ItemHeight = 15;
        this.AdresseListBox.Location = new Point(10, 108);
        this.AdresseListBox.Name = "AdresseListBox";
        this.AdresseListBox.Size = new Size(210, 94);
        this.AdresseListBox.TabIndex = 6;
        // 
        // AdresseFiltreTextBox
        // 
        this.AdresseFiltreTextBox.BackColor = SystemColors.Window;
        this.AdresseFiltreTextBox.Dock = DockStyle.Top;
        this.AdresseFiltreTextBox.Location = new Point(10, 85);
        this.AdresseFiltreTextBox.Name = "AdresseFiltreTextBox";
        this.AdresseFiltreTextBox.Size = new Size(210, 23);
        this.AdresseFiltreTextBox.TabIndex = 4;
        this.AdresseFiltreTextBox.UseSystemPasswordChar = true;
        // 
        // createAdresseButton
        // 
        this.createAdresseButton.Dock = DockStyle.Top;
        this.createAdresseButton.Location = new Point(10, 50);
        this.createAdresseButton.Name = "createAdresseButton";
        this.createAdresseButton.Size = new Size(210, 35);
        this.createAdresseButton.TabIndex = 3;
        this.createAdresseButton.Text = "Créer une adresse";
        this.createAdresseButton.UseVisualStyleBackColor = true;
        // 
        // adresseLabel
        // 
        this.adresseLabel.Dock = DockStyle.Top;
        this.adresseLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.adresseLabel.Location = new Point(10, 10);
        this.adresseLabel.Name = "adresseLabel";
        this.adresseLabel.Size = new Size(210, 40);
        this.adresseLabel.TabIndex = 2;
        this.adresseLabel.Text = "Gestion des Adresses";
        this.adresseLabel.TextAlign = ContentAlignment.MiddleCenter;
        this.userLabel.Dock = DockStyle.Top;
        this.userLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.userLabel.Location = new Point(11, 13);
        this.userLabel.Name = "userLabel";
        this.userLabel.Size = new Size(242, 53);
        this.userLabel.TabIndex = 0;
        this.userLabel.Text = "Gestion des Utilisateurs";
        this.userLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Clientpanel4
        // 
        this.Clientpanel4.Controls.Add(this.deletebutton);
        this.Clientpanel4.Controls.Add(this.editClientbutton);
        this.Clientpanel4.Controls.Add(this.viewClientbutton1);
        this.Clientpanel4.Controls.Add(this.ClientslistBox1);
        this.Clientpanel4.Controls.Add(this.filterClienttextBox1);
        this.Clientpanel4.Controls.Add(this.createClientbutton1);
        this.Clientpanel4.Controls.Add(this.label2);
        this.Clientpanel4.Dock = DockStyle.Fill;
        this.Clientpanel4.Location = new Point(813, 477);
        this.Clientpanel4.Name = "Clientpanel4";
        this.Clientpanel4.Padding = new Padding(12);
        this.Clientpanel4.Size = new Size(264, 469);
        this.Clientpanel4.TabIndex = 4;
        this.Clientpanel4.Paint += this.Clientpanel4_Paint;
        // 
        // deletebutton
        // 
        this.deletebutton.Dock = DockStyle.Top;
        this.deletebutton.Location = new Point(12, 357);
        this.deletebutton.Margin = new Padding(3, 4, 3, 4);
        this.deletebutton.Name = "deletebutton";
        this.deletebutton.Size = new Size(240, 47);
        this.deletebutton.TabIndex = 9;
        this.deletebutton.Text = "Supprimer client";
        this.deletebutton.UseVisualStyleBackColor = true;
        this.deletebutton.Click += this.deletebutton_Click;
        // 
        // editClientbutton
        // 
        this.editClientbutton.Dock = DockStyle.Top;
        this.editClientbutton.Location = new Point(12, 310);
        this.editClientbutton.Margin = new Padding(3, 4, 3, 4);
        this.editClientbutton.Name = "editClientbutton";
        this.editClientbutton.Size = new Size(240, 47);
        this.editClientbutton.TabIndex = 8;
        this.editClientbutton.Text = "Mettre a jour information clients";
        this.editClientbutton.UseVisualStyleBackColor = true;
        this.editClientbutton.Click += this.editClientbutton_Click;
        // 
        // viewClientbutton1
        // 
        this.viewClientbutton1.Dock = DockStyle.Top;
        this.viewClientbutton1.Location = new Point(12, 263);
        this.viewClientbutton1.Margin = new Padding(3, 4, 3, 4);
        this.viewClientbutton1.Name = "viewClientbutton1";
        this.viewClientbutton1.Size = new Size(240, 47);
        this.viewClientbutton1.TabIndex = 7;
        this.viewClientbutton1.Text = "Voir information du client";
        this.viewClientbutton1.UseVisualStyleBackColor = true;
        this.viewClientbutton1.Click += this.viewClientbutton1_Click;
        // 
        // ClientslistBox1
        // 
        this.ClientslistBox1.Dock = DockStyle.Top;
        this.ClientslistBox1.FormattingEnabled = true;
        this.ClientslistBox1.ItemHeight = 20;
        this.ClientslistBox1.Location = new Point(12, 139);
        this.ClientslistBox1.Margin = new Padding(3, 4, 3, 4);
        this.ClientslistBox1.Name = "ClientslistBox1";
        this.ClientslistBox1.Size = new Size(240, 124);
        this.ClientslistBox1.TabIndex = 6;
        this.ClientslistBox1.SelectedIndexChanged += this.ClientslistBox1_SelectedIndexChanged;
        // 
        // filterClienttextBox1
        // 
        this.filterClienttextBox1.Dock = DockStyle.Top;
        this.filterClienttextBox1.Location = new Point(12, 112);
        this.filterClienttextBox1.Margin = new Padding(3, 4, 3, 4);
        this.filterClienttextBox1.Name = "filterClienttextBox1";
        this.filterClienttextBox1.Size = new Size(240, 27);
        this.filterClienttextBox1.TabIndex = 5;
        this.filterClienttextBox1.UseSystemPasswordChar = true;
        this.filterClienttextBox1.TextChanged += this.filterClienttextBox1_TextChanged;
        // 
        // createClientbutton1
        // 
        this.createClientbutton1.Dock = DockStyle.Top;
        this.createClientbutton1.Location = new Point(12, 65);
        this.createClientbutton1.Margin = new Padding(3, 4, 3, 4);
        this.createClientbutton1.Name = "createClientbutton1";
        this.createClientbutton1.Size = new Size(240, 47);
        this.createClientbutton1.TabIndex = 2;
        this.createClientbutton1.Text = "Créer un client";
        this.createClientbutton1.UseVisualStyleBackColor = true;
        this.createClientbutton1.Click += this.createClientbutton1_Click;
        // 
        // label2
        // 
        this.label2.Dock = DockStyle.Top;
        this.label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label2.Location = new Point(12, 12);
        this.label2.Name = "label2";
        this.label2.Size = new Size(240, 53);
        this.label2.TabIndex = 1;
        this.label2.Text = "Gestion des Clients";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminUserMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "AdminUserMainMenu";
        this.Text = "AdminUserMainMenu";
        this.bottomBarPanel.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panelGestionShipment.ResumeLayout(false);
        this.panelGestionShipment.PerformLayout();
        this.fournisseurPanel.ResumeLayout(false);
        this.fournisseurPanel.PerformLayout();
        this.rolePanel.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.Clientpanel4.ResumeLayout(false);
        this.Clientpanel4.PerformLayout();
        this.entrpotPanel.ResumeLayout(false);
        this.addressPanel.ResumeLayout(false);
        this.addressPanel.PerformLayout();
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
    private Panel rolePanel;
    private Button deleteRoleButton;
    private Button editRoleButton;
    private Button roleViewButton;
    private ComboBox roleSelector;
    private Button createRoleButton;
    private Label roleLabel;
    private Panel fournisseurPanel;
    private Button FournisseurCreateBtn;
    private Label fournisseurLabel;
    private Panel panelGestionShipment;
    private Label shipmentMgmtLabel;
    private ListBox ShipmentListBox;
    private TextBox ShipmentFiltreTextbox;
    private Button ShipmentCreateBtn;
    private TextBox FournisseurFiltreTextBox;
    private ListBox FournisseurListBox;
    private Button ShipmentViewBtn;
    private Button FournisseurDeleteBtn;
    private Button FournisseurEditBtn;
    private Button FournisseurViewBtn;
    private Panel entrpotPanel;
    private Button createEntrepotButton;
    private Label entrepotLabel;
    private Button editEntrepotButton;
    private Button viewEntrepotButton;
    private ComboBox entrepotSelector;
    private Button deleteEntrepotButton;
    private Panel addressPanel;
    private Label adresseLabel;
    private TextBox AdresseFiltreTextBox;
    private Button createAdresseButton;
    private Button AdresseViewButton;
    private ListBox AdresseListBox;
    private Button AdresseEditButton;
    private Button AdresseDeleteButton;
    private Panel Clientpanel4;
    private Button createClientbutton1;
    private Label label2;
    private Button deletebutton;
    private Button editClientbutton;
    private Button viewClientbutton1;
    private ListBox ClientslistBox1;
    private TextBox filterClienttextBox1;
}