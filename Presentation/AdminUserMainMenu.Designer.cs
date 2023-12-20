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
        panelGestionShipment = new Panel();
        ShipmentViewBtn = new Button();
        ShipmentListBox = new ListBox();
        ShipmentFiltreTextbox = new TextBox();
        ShipmentCreateBtn = new Button();
        shipmentMgmtLabel = new Label();
        fournisseurPanel = new Panel();
        FournisseurDeleteBtn = new Button();
        FournisseurEditBtn = new Button();
        FournisseurViewBtn = new Button();
        FournisseurListBox = new ListBox();
        FournisseurFiltreTextBox = new TextBox();
        FournisseurCreateBtn = new Button();
        fournisseurLabel = new Label();
        rolePanel = new Panel();
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
        Clientpanel4 = new Panel();
        deletebutton = new Button();
        editClientbutton = new Button();
        viewClientbutton1 = new Button();
        ClientslistBox1 = new ListBox();
        filterClienttextBox1 = new TextBox();
        createClientbutton1 = new Button();
        label2 = new Label();
        entrpotPanel = new Panel();
        deleteEntrepotButton = new Button();
        editEntrepotButton = new Button();
        viewEntrepotButton = new Button();
        entrepotSelector = new ComboBox();
        createEntrepotButton = new Button();
        entrepotLabel = new Label();
        addressPanel = new Panel();
        AdresseDeleteButton = new Button();
        AdresseEditButton = new Button();
        AdresseViewButton = new Button();
        AdresseListBox = new ListBox();
        AdresseFiltreTextBox = new TextBox();
        createAdresseButton = new Button();
        adresseLabel = new Label();
        bottomBarPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panelGestionShipment.SuspendLayout();
        fournisseurPanel.SuspendLayout();
        rolePanel.SuspendLayout();
        userManagementPanel.SuspendLayout();
        Clientpanel4.SuspendLayout();
        entrpotPanel.SuspendLayout();
        addressPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Margin = new Padding(3, 2, 3, 2);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(1036, 30);
        topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        bottomBarPanel.Controls.Add(quitButton);
        bottomBarPanel.Dock = DockStyle.Bottom;
        bottomBarPanel.Location = new Point(0, 616);
        bottomBarPanel.Margin = new Padding(3, 2, 3, 2);
        bottomBarPanel.Name = "bottomBarPanel";
        bottomBarPanel.Size = new Size(1036, 30);
        bottomBarPanel.TabIndex = 1;
        // 
        // quitButton
        // 
        quitButton.Location = new Point(944, 4);
        quitButton.Margin = new Padding(3, 2, 3, 2);
        quitButton.Name = "quitButton";
        quitButton.Size = new Size(81, 23);
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
        tableLayoutPanel1.Controls.Add(panelGestionShipment, 0, 1);
        tableLayoutPanel1.Controls.Add(fournisseurPanel, 0, 1);
        tableLayoutPanel1.Controls.Add(rolePanel, 0, 1);
        tableLayoutPanel1.Controls.Add(userManagementPanel, 0, 0);
        tableLayoutPanel1.Controls.Add(Clientpanel4, 3, 1);
        tableLayoutPanel1.Controls.Add(entrpotPanel, 1, 0);
        tableLayoutPanel1.Controls.Add(addressPanel, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 30);
        tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(1036, 586);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // panelGestionShipment
        // 
        panelGestionShipment.Controls.Add(ShipmentViewBtn);
        panelGestionShipment.Controls.Add(ShipmentListBox);
        panelGestionShipment.Controls.Add(ShipmentFiltreTextbox);
        panelGestionShipment.Controls.Add(ShipmentCreateBtn);
        panelGestionShipment.Controls.Add(shipmentMgmtLabel);
        panelGestionShipment.Dock = DockStyle.Fill;
        panelGestionShipment.Location = new Point(210, 295);
        panelGestionShipment.Margin = new Padding(3, 2, 3, 2);
        panelGestionShipment.Name = "panelGestionShipment";
        panelGestionShipment.Padding = new Padding(9, 8, 9, 8);
        panelGestionShipment.Size = new Size(201, 289);
        panelGestionShipment.TabIndex = 3;
        // 
        // ShipmentViewBtn
        // 
        ShipmentViewBtn.Dock = DockStyle.Top;
        ShipmentViewBtn.Location = new Point(9, 177);
        ShipmentViewBtn.Margin = new Padding(3, 2, 3, 2);
        ShipmentViewBtn.Name = "ShipmentViewBtn";
        ShipmentViewBtn.Size = new Size(183, 26);
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
        ShipmentListBox.Location = new Point(9, 113);
        ShipmentListBox.Margin = new Padding(3, 2, 3, 2);
        ShipmentListBox.Name = "ShipmentListBox";
        ShipmentListBox.Size = new Size(183, 64);
        ShipmentListBox.TabIndex = 4;
        ShipmentListBox.SelectedIndexChanged += this.ShipmentListBox_SelectedIndexChanged;
        // 
        // ShipmentFiltreTextbox
        // 
        ShipmentFiltreTextbox.BackColor = SystemColors.Window;
        ShipmentFiltreTextbox.Dock = DockStyle.Top;
        ShipmentFiltreTextbox.Location = new Point(9, 90);
        ShipmentFiltreTextbox.Margin = new Padding(3, 2, 3, 2);
        ShipmentFiltreTextbox.Name = "ShipmentFiltreTextbox";
        ShipmentFiltreTextbox.Size = new Size(183, 23);
        ShipmentFiltreTextbox.TabIndex = 3;
        ShipmentFiltreTextbox.UseSystemPasswordChar = true;
        // 
        // ShipmentCreateBtn
        // 
        ShipmentCreateBtn.Dock = DockStyle.Top;
        ShipmentCreateBtn.Location = new Point(9, 64);
        ShipmentCreateBtn.Margin = new Padding(3, 2, 3, 2);
        ShipmentCreateBtn.Name = "ShipmentCreateBtn";
        ShipmentCreateBtn.Size = new Size(183, 26);
        ShipmentCreateBtn.TabIndex = 2;
        ShipmentCreateBtn.Text = "Créer un shipment";
        ShipmentCreateBtn.UseVisualStyleBackColor = true;
        ShipmentCreateBtn.Click += this.ShipmentCreateBtn_Click;
        // 
        // shipmentMgmtLabel
        // 
        shipmentMgmtLabel.Dock = DockStyle.Top;
        shipmentMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        shipmentMgmtLabel.Location = new Point(9, 8);
        shipmentMgmtLabel.Name = "shipmentMgmtLabel";
        shipmentMgmtLabel.Size = new Size(183, 56);
        shipmentMgmtLabel.TabIndex = 0;
        shipmentMgmtLabel.Text = "Gestion des shipments";
        shipmentMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // fournisseurPanel
        // 
        fournisseurPanel.Controls.Add(FournisseurDeleteBtn);
        fournisseurPanel.Controls.Add(FournisseurEditBtn);
        fournisseurPanel.Controls.Add(FournisseurViewBtn);
        fournisseurPanel.Controls.Add(FournisseurListBox);
        fournisseurPanel.Controls.Add(FournisseurFiltreTextBox);
        fournisseurPanel.Controls.Add(FournisseurCreateBtn);
        fournisseurPanel.Controls.Add(fournisseurLabel);
        fournisseurPanel.Dock = DockStyle.Fill;
        fournisseurPanel.Location = new Point(3, 295);
        fournisseurPanel.Margin = new Padding(3, 2, 3, 2);
        fournisseurPanel.Name = "fournisseurPanel";
        fournisseurPanel.Padding = new Padding(9, 8, 9, 8);
        fournisseurPanel.Size = new Size(201, 289);
        fournisseurPanel.TabIndex = 2;
        // 
        // FournisseurDeleteBtn
        // 
        FournisseurDeleteBtn.Dock = DockStyle.Top;
        FournisseurDeleteBtn.Location = new Point(9, 229);
        FournisseurDeleteBtn.Margin = new Padding(3, 2, 3, 2);
        FournisseurDeleteBtn.Name = "FournisseurDeleteBtn";
        FournisseurDeleteBtn.Size = new Size(183, 26);
        FournisseurDeleteBtn.TabIndex = 8;
        FournisseurDeleteBtn.Text = "Supprimer un fournisseur";
        FournisseurDeleteBtn.UseVisualStyleBackColor = true;
        FournisseurDeleteBtn.Click += this.FournisseurDeleteBtn_Click;
        // 
        // FournisseurEditBtn
        // 
        FournisseurEditBtn.Dock = DockStyle.Top;
        FournisseurEditBtn.Location = new Point(9, 203);
        FournisseurEditBtn.Margin = new Padding(3, 2, 3, 2);
        FournisseurEditBtn.Name = "FournisseurEditBtn";
        FournisseurEditBtn.Size = new Size(183, 26);
        FournisseurEditBtn.TabIndex = 7;
        FournisseurEditBtn.Text = "Éditer le fournisseur";
        FournisseurEditBtn.UseVisualStyleBackColor = true;
        FournisseurEditBtn.Click += this.FournisseurEditBtn_Click;
        // 
        // FournisseurViewBtn
        // 
        FournisseurViewBtn.Dock = DockStyle.Top;
        FournisseurViewBtn.Location = new Point(9, 177);
        FournisseurViewBtn.Margin = new Padding(3, 2, 3, 2);
        FournisseurViewBtn.Name = "FournisseurViewBtn";
        FournisseurViewBtn.Size = new Size(183, 26);
        FournisseurViewBtn.TabIndex = 6;
        FournisseurViewBtn.Text = "Voir détails du fournisseur";
        FournisseurViewBtn.UseVisualStyleBackColor = true;
        FournisseurViewBtn.Click += this.FournisseurViewBtn_Click;
        // 
        // FournisseurListBox
        // 
        FournisseurListBox.Dock = DockStyle.Top;
        FournisseurListBox.FormattingEnabled = true;
        FournisseurListBox.ItemHeight = 15;
        FournisseurListBox.Location = new Point(9, 113);
        FournisseurListBox.Margin = new Padding(3, 2, 3, 2);
        FournisseurListBox.Name = "FournisseurListBox";
        FournisseurListBox.Size = new Size(183, 64);
        FournisseurListBox.TabIndex = 5;
        FournisseurListBox.SelectedIndexChanged += this.FournisseurListBox_SelectedIndexChanged;
        // 
        // FournisseurFiltreTextBox
        // 
        FournisseurFiltreTextBox.Dock = DockStyle.Top;
        FournisseurFiltreTextBox.Location = new Point(9, 90);
        FournisseurFiltreTextBox.Margin = new Padding(3, 2, 3, 2);
        FournisseurFiltreTextBox.Name = "FournisseurFiltreTextBox";
        FournisseurFiltreTextBox.Size = new Size(183, 23);
        FournisseurFiltreTextBox.TabIndex = 4;
        FournisseurFiltreTextBox.UseSystemPasswordChar = true;
        FournisseurFiltreTextBox.TextChanged += this.FournisseurFiltreTextBox_TextChanged;
        // 
        // FournisseurCreateBtn
        // 
        FournisseurCreateBtn.Dock = DockStyle.Top;
        FournisseurCreateBtn.Location = new Point(9, 64);
        FournisseurCreateBtn.Margin = new Padding(3, 2, 3, 2);
        FournisseurCreateBtn.Name = "FournisseurCreateBtn";
        FournisseurCreateBtn.Size = new Size(183, 26);
        FournisseurCreateBtn.TabIndex = 1;
        FournisseurCreateBtn.Text = "Créer un fournisseur";
        FournisseurCreateBtn.UseVisualStyleBackColor = true;
        FournisseurCreateBtn.Click += this.FournisseurCreateBtn_Click;
        // 
        // fournisseurLabel
        // 
        fournisseurLabel.Dock = DockStyle.Top;
        fournisseurLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        fournisseurLabel.Location = new Point(9, 8);
        fournisseurLabel.Name = "fournisseurLabel";
        fournisseurLabel.Size = new Size(183, 56);
        fournisseurLabel.TabIndex = 0;
        fournisseurLabel.Text = "Gestion des Fournisseurs";
        fournisseurLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rolePanel
        // 
        rolePanel.Controls.Add(deleteRoleButton);
        rolePanel.Controls.Add(editRoleButton);
        rolePanel.Controls.Add(roleViewButton);
        rolePanel.Controls.Add(roleSelector);
        rolePanel.Controls.Add(createRoleButton);
        rolePanel.Controls.Add(roleLabel);
        rolePanel.Dock = DockStyle.Fill;
        rolePanel.Location = new Point(417, 295);
        rolePanel.Margin = new Padding(3, 2, 3, 2);
        rolePanel.Name = "rolePanel";
        rolePanel.Padding = new Padding(9, 8, 9, 8);
        rolePanel.Size = new Size(201, 289);
        rolePanel.TabIndex = 1;
        // 
        // deleteRoleButton
        // 
        deleteRoleButton.Dock = DockStyle.Top;
        deleteRoleButton.Location = new Point(9, 139);
        deleteRoleButton.Margin = new Padding(3, 2, 3, 2);
        deleteRoleButton.Name = "deleteRoleButton";
        deleteRoleButton.Size = new Size(183, 26);
        deleteRoleButton.TabIndex = 5;
        deleteRoleButton.Text = "Supprimer le rôle";
        deleteRoleButton.UseVisualStyleBackColor = true;
        deleteRoleButton.Click += this.DeleteRoleButton_Click;
        // 
        // editRoleButton
        // 
        editRoleButton.Dock = DockStyle.Top;
        editRoleButton.Location = new Point(9, 113);
        editRoleButton.Margin = new Padding(3, 2, 3, 2);
        editRoleButton.Name = "editRoleButton";
        editRoleButton.Size = new Size(183, 26);
        editRoleButton.TabIndex = 4;
        editRoleButton.Text = "Éditer le rôle";
        editRoleButton.UseVisualStyleBackColor = true;
        editRoleButton.Click += this.EditRoleButton_Click;
        // 
        // roleViewButton
        // 
        roleViewButton.Dock = DockStyle.Top;
        roleViewButton.Location = new Point(9, 87);
        roleViewButton.Margin = new Padding(3, 2, 3, 2);
        roleViewButton.Name = "roleViewButton";
        roleViewButton.Size = new Size(183, 26);
        roleViewButton.TabIndex = 3;
        roleViewButton.Text = "Voir détails du rôle";
        roleViewButton.UseVisualStyleBackColor = true;
        roleViewButton.Click += this.RoleViewButton_Click;
        // 
        // roleSelector
        // 
        roleSelector.Dock = DockStyle.Top;
        roleSelector.FormattingEnabled = true;
        roleSelector.Location = new Point(9, 64);
        roleSelector.Margin = new Padding(3, 2, 3, 2);
        roleSelector.Name = "roleSelector";
        roleSelector.Size = new Size(183, 23);
        roleSelector.TabIndex = 2;
        roleSelector.SelectedIndexChanged += this.RoleSelector_SelectedIndexChanged;
        // 
        // createRoleButton
        // 
        createRoleButton.Dock = DockStyle.Top;
        createRoleButton.Location = new Point(9, 38);
        createRoleButton.Margin = new Padding(3, 2, 3, 2);
        createRoleButton.Name = "createRoleButton";
        createRoleButton.Size = new Size(183, 26);
        createRoleButton.TabIndex = 1;
        createRoleButton.Text = "Créer un rôle";
        createRoleButton.UseVisualStyleBackColor = true;
        createRoleButton.Click += this.CreateRoleButton_Click;
        // 
        // roleLabel
        // 
        roleLabel.Dock = DockStyle.Top;
        roleLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        roleLabel.Location = new Point(9, 8);
        roleLabel.Name = "roleLabel";
        roleLabel.Size = new Size(183, 30);
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
        userManagementPanel.Location = new Point(3, 2);
        userManagementPanel.Margin = new Padding(3, 2, 3, 2);
        userManagementPanel.Name = "userManagementPanel";
        userManagementPanel.Padding = new Padding(9, 8, 9, 8);
        userManagementPanel.Size = new Size(201, 289);
        userManagementPanel.TabIndex = 0;
        // 
        // deleteUserButton
        // 
        deleteUserButton.Dock = DockStyle.Top;
        deleteUserButton.Location = new Point(9, 165);
        deleteUserButton.Margin = new Padding(3, 2, 3, 2);
        deleteUserButton.Name = "deleteUserButton";
        deleteUserButton.Size = new Size(183, 26);
        deleteUserButton.TabIndex = 5;
        deleteUserButton.Text = "Supprimer l'utilisateur";
        deleteUserButton.UseVisualStyleBackColor = true;
        deleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // editUserButton
        // 
        editUserButton.Dock = DockStyle.Top;
        editUserButton.Location = new Point(9, 139);
        editUserButton.Margin = new Padding(3, 2, 3, 2);
        editUserButton.Name = "editUserButton";
        editUserButton.Size = new Size(183, 26);
        editUserButton.TabIndex = 4;
        editUserButton.Text = "Éditer l'utilisateur";
        editUserButton.UseVisualStyleBackColor = true;
        editUserButton.Click += this.EditUserButton_Click;
        // 
        // viewUserButton
        // 
        viewUserButton.Dock = DockStyle.Top;
        viewUserButton.Location = new Point(9, 113);
        viewUserButton.Margin = new Padding(3, 2, 3, 2);
        viewUserButton.Name = "viewUserButton";
        viewUserButton.Size = new Size(183, 26);
        viewUserButton.TabIndex = 3;
        viewUserButton.Text = "Voir détails de l'utilisateur";
        viewUserButton.UseVisualStyleBackColor = true;
        viewUserButton.Click += this.ViewUserButton_Click;
        // 
        // userSelector
        // 
        userSelector.Dock = DockStyle.Top;
        userSelector.FormattingEnabled = true;
        userSelector.Location = new Point(9, 90);
        userSelector.Margin = new Padding(3, 2, 3, 2);
        userSelector.Name = "userSelector";
        userSelector.Size = new Size(183, 23);
        userSelector.TabIndex = 2;
        userSelector.SelectedIndexChanged += this.UserSelector_SelectedIndexChanged;
        // 
        // createUserButton
        // 
        createUserButton.Dock = DockStyle.Top;
        createUserButton.Location = new Point(9, 64);
        createUserButton.Margin = new Padding(3, 2, 3, 2);
        createUserButton.Name = "createUserButton";
        createUserButton.Size = new Size(183, 26);
        createUserButton.TabIndex = 1;
        createUserButton.Text = "Créer un utilisateur";
        createUserButton.UseVisualStyleBackColor = true;
        createUserButton.Click += this.CreateUserButton_Click;
        // 
        // userLabel
        // 
        userLabel.Dock = DockStyle.Top;
        userLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        userLabel.Location = new Point(9, 8);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(183, 56);
        userLabel.TabIndex = 0;
        userLabel.Text = "Gestion des Utilisateurs";
        userLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Clientpanel4
        // 
        Clientpanel4.Controls.Add(deletebutton);
        Clientpanel4.Controls.Add(editClientbutton);
        Clientpanel4.Controls.Add(viewClientbutton1);
        Clientpanel4.Controls.Add(ClientslistBox1);
        Clientpanel4.Controls.Add(filterClienttextBox1);
        Clientpanel4.Controls.Add(createClientbutton1);
        Clientpanel4.Controls.Add(label2);
        Clientpanel4.Dock = DockStyle.Fill;
        Clientpanel4.Location = new Point(624, 295);
        Clientpanel4.Margin = new Padding(3, 2, 3, 2);
        Clientpanel4.Name = "Clientpanel4";
        Clientpanel4.Padding = new Padding(10, 9, 10, 9);
        Clientpanel4.Size = new Size(201, 289);
        Clientpanel4.TabIndex = 4;
        Clientpanel4.Paint += this.Clientpanel4_Paint;
        // 
        // deletebutton
        // 
        deletebutton.Dock = DockStyle.Top;
        deletebutton.Location = new Point(10, 261);
        deletebutton.Name = "deletebutton";
        deletebutton.Size = new Size(181, 35);
        deletebutton.TabIndex = 9;
        deletebutton.Text = "Supprimer client";
        deletebutton.UseVisualStyleBackColor = true;
        deletebutton.Click += this.deletebutton_Click;
        // 
        // editClientbutton
        // 
        editClientbutton.Dock = DockStyle.Top;
        editClientbutton.Location = new Point(10, 226);
        editClientbutton.Name = "editClientbutton";
        editClientbutton.Size = new Size(181, 35);
        editClientbutton.TabIndex = 8;
        editClientbutton.Text = "Mettre a jour information clients";
        editClientbutton.UseVisualStyleBackColor = true;
        editClientbutton.Click += this.editClientbutton_Click;
        // 
        // viewClientbutton1
        // 
        viewClientbutton1.Dock = DockStyle.Top;
        viewClientbutton1.Location = new Point(10, 191);
        viewClientbutton1.Name = "viewClientbutton1";
        viewClientbutton1.Size = new Size(181, 35);
        viewClientbutton1.TabIndex = 7;
        viewClientbutton1.Text = "Voir information du client";
        viewClientbutton1.UseVisualStyleBackColor = true;
        viewClientbutton1.Click += this.viewClientbutton1_Click;
        // 
        // ClientslistBox1
        // 
        ClientslistBox1.Dock = DockStyle.Top;
        ClientslistBox1.FormattingEnabled = true;
        ClientslistBox1.ItemHeight = 15;
        ClientslistBox1.Location = new Point(10, 97);
        ClientslistBox1.Name = "ClientslistBox1";
        ClientslistBox1.Size = new Size(181, 94);
        ClientslistBox1.TabIndex = 6;
        ClientslistBox1.SelectedIndexChanged += this.ClientslistBox1_SelectedIndexChanged;
        // 
        // filterClienttextBox1
        // 
        filterClienttextBox1.Dock = DockStyle.Top;
        filterClienttextBox1.Location = new Point(10, 74);
        filterClienttextBox1.Name = "filterClienttextBox1";
        filterClienttextBox1.Size = new Size(181, 23);
        filterClienttextBox1.TabIndex = 5;
        filterClienttextBox1.UseSystemPasswordChar = true;
        filterClienttextBox1.TextChanged += this.filterClienttextBox1_TextChanged;
        // 
        // createClientbutton1
        // 
        createClientbutton1.Dock = DockStyle.Top;
        createClientbutton1.Location = new Point(10, 39);
        createClientbutton1.Name = "createClientbutton1";
        createClientbutton1.Size = new Size(181, 35);
        createClientbutton1.TabIndex = 2;
        createClientbutton1.Text = "Créer un client";
        createClientbutton1.UseVisualStyleBackColor = true;
        createClientbutton1.Click += this.createClientbutton1_Click;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Top;
        label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(10, 9);
        label2.Name = "label2";
        label2.Size = new Size(181, 30);
        label2.TabIndex = 1;
        label2.Text = "Gestion des Clients";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // entrpotPanel
        // 
        entrpotPanel.Controls.Add(deleteEntrepotButton);
        entrpotPanel.Controls.Add(editEntrepotButton);
        entrpotPanel.Controls.Add(viewEntrepotButton);
        entrpotPanel.Controls.Add(entrepotSelector);
        entrpotPanel.Controls.Add(createEntrepotButton);
        entrpotPanel.Controls.Add(entrepotLabel);
        entrpotPanel.Dock = DockStyle.Fill;
        entrpotPanel.Location = new Point(210, 2);
        entrpotPanel.Margin = new Padding(3, 2, 3, 2);
        entrpotPanel.Name = "entrpotPanel";
        entrpotPanel.Padding = new Padding(9, 8, 9, 15);
        entrpotPanel.Size = new Size(201, 289);
        entrpotPanel.TabIndex = 4;
        // 
        // deleteEntrepotButton
        // 
        deleteEntrepotButton.Dock = DockStyle.Top;
        deleteEntrepotButton.Location = new Point(9, 139);
        deleteEntrepotButton.Margin = new Padding(3, 2, 3, 2);
        deleteEntrepotButton.Name = "deleteEntrepotButton";
        deleteEntrepotButton.Size = new Size(183, 26);
        deleteEntrepotButton.TabIndex = 6;
        deleteEntrepotButton.Text = "Supprimer l'entrepot";
        deleteEntrepotButton.UseVisualStyleBackColor = true;
        deleteEntrepotButton.Click += this.DeleteEntrepotButton_Click;
        // 
        // editEntrepotButton
        // 
        editEntrepotButton.Dock = DockStyle.Top;
        editEntrepotButton.Location = new Point(9, 113);
        editEntrepotButton.Margin = new Padding(3, 2, 3, 2);
        editEntrepotButton.Name = "editEntrepotButton";
        editEntrepotButton.Size = new Size(183, 26);
        editEntrepotButton.TabIndex = 5;
        editEntrepotButton.Text = "Éditer l'entrepot";
        editEntrepotButton.UseVisualStyleBackColor = true;
        editEntrepotButton.Click += this.EditEntrepotButton_Click;
        // 
        // viewEntrepotButton
        // 
        viewEntrepotButton.Dock = DockStyle.Top;
        viewEntrepotButton.Location = new Point(9, 87);
        viewEntrepotButton.Margin = new Padding(3, 2, 3, 2);
        viewEntrepotButton.Name = "viewEntrepotButton";
        viewEntrepotButton.Size = new Size(183, 26);
        viewEntrepotButton.TabIndex = 4;
        viewEntrepotButton.Text = "Voir détails de l'entrepot";
        viewEntrepotButton.UseVisualStyleBackColor = true;
        viewEntrepotButton.Click += this.ViewEntrepotButton_Click;
        // 
        // entrepotSelector
        // 
        entrepotSelector.Dock = DockStyle.Top;
        entrepotSelector.FormattingEnabled = true;
        entrepotSelector.Location = new Point(9, 64);
        entrepotSelector.Margin = new Padding(3, 2, 3, 2);
        entrepotSelector.Name = "entrepotSelector";
        entrepotSelector.Size = new Size(183, 23);
        entrepotSelector.TabIndex = 3;
        entrepotSelector.SelectedIndexChanged += this.EntrepotSelector_SelectedIndexChanged;
        // 
        // createEntrepotButton
        // 
        createEntrepotButton.Dock = DockStyle.Top;
        createEntrepotButton.Location = new Point(9, 38);
        createEntrepotButton.Margin = new Padding(3, 2, 3, 2);
        createEntrepotButton.Name = "createEntrepotButton";
        createEntrepotButton.Size = new Size(183, 26);
        createEntrepotButton.TabIndex = 2;
        createEntrepotButton.Text = "Créer un entrepot";
        createEntrepotButton.UseVisualStyleBackColor = true;
        createEntrepotButton.Click += this.CreateEntrepotButton_Click;
        // 
        // entrepotLabel
        // 
        entrepotLabel.Dock = DockStyle.Top;
        entrepotLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        entrepotLabel.Location = new Point(9, 8);
        entrepotLabel.Name = "entrepotLabel";
        entrepotLabel.Size = new Size(183, 30);
        entrepotLabel.TabIndex = 1;
        entrepotLabel.Text = "Gestion des Entrepots";
        entrepotLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressPanel
        // 
        addressPanel.Controls.Add(AdresseDeleteButton);
        addressPanel.Controls.Add(AdresseEditButton);
        addressPanel.Controls.Add(AdresseViewButton);
        addressPanel.Controls.Add(AdresseListBox);
        addressPanel.Controls.Add(AdresseFiltreTextBox);
        addressPanel.Controls.Add(createAdresseButton);
        addressPanel.Controls.Add(adresseLabel);
        addressPanel.Dock = DockStyle.Fill;
        addressPanel.Location = new Point(417, 2);
        addressPanel.Margin = new Padding(3, 2, 3, 2);
        addressPanel.Name = "addressPanel";
        addressPanel.Padding = new Padding(9, 8, 9, 8);
        addressPanel.Size = new Size(201, 289);
        addressPanel.TabIndex = 5;
        // 
        // AdresseDeleteButton
        // 
        AdresseDeleteButton.Dock = DockStyle.Top;
        AdresseDeleteButton.Location = new Point(9, 218);
        AdresseDeleteButton.Margin = new Padding(3, 2, 3, 2);
        AdresseDeleteButton.Name = "AdresseDeleteButton";
        AdresseDeleteButton.Size = new Size(183, 26);
        AdresseDeleteButton.TabIndex = 9;
        AdresseDeleteButton.Text = "Supprimer l'adresse";
        AdresseDeleteButton.UseVisualStyleBackColor = true;
        AdresseDeleteButton.Click += this.AdresseDeleteButton_Click;
        // 
        // AdresseEditButton
        // 
        AdresseEditButton.Dock = DockStyle.Top;
        AdresseEditButton.Location = new Point(9, 192);
        AdresseEditButton.Margin = new Padding(3, 2, 3, 2);
        AdresseEditButton.Name = "AdresseEditButton";
        AdresseEditButton.Size = new Size(183, 26);
        AdresseEditButton.TabIndex = 8;
        AdresseEditButton.Text = "Éditer l'adresse";
        AdresseEditButton.UseVisualStyleBackColor = true;
        AdresseEditButton.Click += this.AdresseEditButton_Click;
        // 
        // AdresseViewButton
        // 
        AdresseViewButton.Dock = DockStyle.Top;
        AdresseViewButton.Location = new Point(9, 166);
        AdresseViewButton.Margin = new Padding(3, 2, 3, 2);
        AdresseViewButton.Name = "AdresseViewButton";
        AdresseViewButton.Size = new Size(183, 26);
        AdresseViewButton.TabIndex = 7;
        AdresseViewButton.Text = "Voir détails de l'adresse";
        AdresseViewButton.UseVisualStyleBackColor = true;
        AdresseViewButton.Click += this.AdresseViewButton_Click;
        // 
        // AdresseListBox
        // 
        AdresseListBox.Dock = DockStyle.Top;
        AdresseListBox.FormattingEnabled = true;
        AdresseListBox.ItemHeight = 15;
        AdresseListBox.Location = new Point(9, 87);
        AdresseListBox.Margin = new Padding(3, 2, 3, 2);
        AdresseListBox.Name = "AdresseListBox";
        AdresseListBox.Size = new Size(183, 79);
        AdresseListBox.TabIndex = 6;
        AdresseListBox.SelectedIndexChanged += this.AdresseListBox_SelectedIndexChanged;
        // 
        // AdresseFiltreTextBox
        // 
        AdresseFiltreTextBox.BackColor = SystemColors.Window;
        AdresseFiltreTextBox.Dock = DockStyle.Top;
        AdresseFiltreTextBox.Location = new Point(9, 64);
        AdresseFiltreTextBox.Margin = new Padding(3, 2, 3, 2);
        AdresseFiltreTextBox.Name = "AdresseFiltreTextBox";
        AdresseFiltreTextBox.Size = new Size(183, 23);
        AdresseFiltreTextBox.TabIndex = 4;
        AdresseFiltreTextBox.UseSystemPasswordChar = true;
        AdresseFiltreTextBox.TextChanged += this.AdresseFiltreTextBox_TextChanged;
        // 
        // createAdresseButton
        // 
        createAdresseButton.Dock = DockStyle.Top;
        createAdresseButton.Location = new Point(9, 38);
        createAdresseButton.Margin = new Padding(3, 2, 3, 2);
        createAdresseButton.Name = "createAdresseButton";
        createAdresseButton.Size = new Size(183, 26);
        createAdresseButton.TabIndex = 3;
        createAdresseButton.Text = "Créer une adresse";
        createAdresseButton.UseVisualStyleBackColor = true;
        createAdresseButton.Click += this.CreateAdresseButton_Click;
        // 
        // adresseLabel
        // 
        adresseLabel.Dock = DockStyle.Top;
        adresseLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        adresseLabel.Location = new Point(9, 8);
        adresseLabel.Name = "adresseLabel";
        adresseLabel.Size = new Size(183, 30);
        adresseLabel.TabIndex = 2;
        adresseLabel.Text = "Gestion des Adresses";
        adresseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminUserMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1036, 646);
        this.Controls.Add(tableLayoutPanel1);
        this.Controls.Add(bottomBarPanel);
        this.Controls.Add(topBarPanel);
        this.Margin = new Padding(3, 2, 3, 2);
        this.Name = "AdminUserMainMenu";
        this.Text = "AdminUserMainMenu";
        bottomBarPanel.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panelGestionShipment.ResumeLayout(false);
        panelGestionShipment.PerformLayout();
        fournisseurPanel.ResumeLayout(false);
        fournisseurPanel.PerformLayout();
        rolePanel.ResumeLayout(false);
        userManagementPanel.ResumeLayout(false);
        Clientpanel4.ResumeLayout(false);
        Clientpanel4.PerformLayout();
        entrpotPanel.ResumeLayout(false);
        addressPanel.ResumeLayout(false);
        addressPanel.PerformLayout();
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