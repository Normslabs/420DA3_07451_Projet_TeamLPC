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
        panel3 = new Panel();
        ShipmentViewBtn = new Button();
        ShipmentListBox = new ListBox();
        ShipmentFiltreTextbox = new TextBox();
        ShipmentCreateBtn = new Button();
        label1 = new Label();
        panel2 = new Panel();
        FournisseurDeleteBtn = new Button();
        FournisseurEditBtn = new Button();
        FournisseurViewBtn = new Button();
        FournisseurListBox = new ListBox();
        FournisseurFiltreTextBox = new TextBox();
        FournisseurCreateBtn = new Button();
        fournisseurLabel = new Label();
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
        adressePanel = new Panel();
        deleteEntrepotButton = new Button();
        editEntrepotButton = new Button();
        viewEntrepotButton = new Button();
        entrepotSelector = new ComboBox();
        createEntrepotButton = new Button();
        entrepotLabel = new Label();
        entrepotPanel = new Panel();
        AdresseViewButton = new Button();
        AdresseListBox = new ListBox();
        AdresseFiltreTextBox = new TextBox();
        createAdresseButton = new Button();
        adresseLabel = new Label();
        AdresseEditButton = new Button();
        AdresseDeleteButton = new Button();
        bottomBarPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        userManagementPanel.SuspendLayout();
        adressePanel.SuspendLayout();
        entrepotPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(1184, 40);
        topBarPanel.TabIndex = 0;
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
        tableLayoutPanel1.Controls.Add(panel3, 0, 1);
        tableLayoutPanel1.Controls.Add(panel2, 0, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Controls.Add(userManagementPanel, 0, 0);
        tableLayoutPanel1.Controls.Add(adressePanel, 1, 0);
        tableLayoutPanel1.Controls.Add(entrepotPanel, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 40);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(1184, 781);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.Controls.Add(ShipmentViewBtn);
        panel3.Controls.Add(ShipmentListBox);
        panel3.Controls.Add(ShipmentFiltreTextbox);
        panel3.Controls.Add(ShipmentCreateBtn);
        panel3.Controls.Add(label1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(3, 393);
        panel3.Name = "panel3";
        panel3.Padding = new Padding(10);
        panel3.Size = new Size(230, 385);
        panel3.TabIndex = 3;
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
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(10, 10);
        label1.Name = "label1";
        label1.Size = new Size(210, 40);
        label1.TabIndex = 0;
        label1.Text = "Gestion des shipments";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(FournisseurDeleteBtn);
        panel2.Controls.Add(FournisseurEditBtn);
        panel2.Controls.Add(FournisseurViewBtn);
        panel2.Controls.Add(FournisseurListBox);
        panel2.Controls.Add(FournisseurFiltreTextBox);
        panel2.Controls.Add(FournisseurCreateBtn);
        panel2.Controls.Add(fournisseurLabel);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(239, 393);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(10);
        panel2.Size = new Size(230, 385);
        panel2.TabIndex = 2;
        // 
        // FournisseurDeleteBtn
        // 
        FournisseurDeleteBtn.Dock = DockStyle.Top;
        FournisseurDeleteBtn.Location = new Point(10, 272);
        FournisseurDeleteBtn.Name = "FournisseurDeleteBtn";
        FournisseurDeleteBtn.Size = new Size(210, 35);
        FournisseurDeleteBtn.TabIndex = 8;
        FournisseurDeleteBtn.Text = "Supprimer un fournisseur";
        FournisseurDeleteBtn.UseVisualStyleBackColor = true;
        FournisseurDeleteBtn.Click += this.FournisseurDeleteBtn_Click;
        // 
        // FournisseurEditBtn
        // 
        FournisseurEditBtn.Dock = DockStyle.Top;
        FournisseurEditBtn.Location = new Point(10, 237);
        FournisseurEditBtn.Name = "FournisseurEditBtn";
        FournisseurEditBtn.Size = new Size(210, 35);
        FournisseurEditBtn.TabIndex = 7;
        FournisseurEditBtn.Text = "Éditer le fournisseur";
        FournisseurEditBtn.UseVisualStyleBackColor = true;
        FournisseurEditBtn.Click += this.FournisseurEditBtn_Click;
        // 
        // FournisseurViewBtn
        // 
        FournisseurViewBtn.Dock = DockStyle.Top;
        FournisseurViewBtn.Location = new Point(10, 202);
        FournisseurViewBtn.Name = "FournisseurViewBtn";
        FournisseurViewBtn.Size = new Size(210, 35);
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
        FournisseurListBox.Location = new Point(10, 108);
        FournisseurListBox.Name = "FournisseurListBox";
        FournisseurListBox.Size = new Size(210, 94);
        FournisseurListBox.TabIndex = 5;
        FournisseurListBox.SelectedIndexChanged += this.FournisseurListBox_SelectedIndexChanged;
        // 
        // FournisseurFiltreTextBox
        // 
        FournisseurFiltreTextBox.Dock = DockStyle.Top;
        FournisseurFiltreTextBox.Location = new Point(10, 85);
        FournisseurFiltreTextBox.Name = "FournisseurFiltreTextBox";
        FournisseurFiltreTextBox.Size = new Size(210, 23);
        FournisseurFiltreTextBox.TabIndex = 4;
        FournisseurFiltreTextBox.UseSystemPasswordChar = true;
        FournisseurFiltreTextBox.TextChanged += this.FournisseurFiltreTextBox_TextChanged;
        // 
        // FournisseurCreateBtn
        // 
        FournisseurCreateBtn.Dock = DockStyle.Top;
        FournisseurCreateBtn.Location = new Point(10, 50);
        FournisseurCreateBtn.Name = "FournisseurCreateBtn";
        FournisseurCreateBtn.Size = new Size(210, 35);
        FournisseurCreateBtn.TabIndex = 1;
        FournisseurCreateBtn.Text = "Créer un fournisseur";
        FournisseurCreateBtn.UseVisualStyleBackColor = true;
        FournisseurCreateBtn.Click += this.FournisseurCreateBtn_Click;
        // 
        // fournisseurLabel
        // 
        fournisseurLabel.Dock = DockStyle.Top;
        fournisseurLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        fournisseurLabel.Location = new Point(10, 10);
        fournisseurLabel.Name = "fournisseurLabel";
        fournisseurLabel.Size = new Size(210, 40);
        fournisseurLabel.TabIndex = 0;
        fournisseurLabel.Text = "Gestion des Fournisseurs";
        fournisseurLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        panel1.Location = new Point(475, 393);
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
        // 
        // adressePanel
        // 
        adressePanel.Controls.Add(deleteEntrepotButton);
        adressePanel.Controls.Add(editEntrepotButton);
        adressePanel.Controls.Add(viewEntrepotButton);
        adressePanel.Controls.Add(entrepotSelector);
        adressePanel.Controls.Add(createEntrepotButton);
        adressePanel.Controls.Add(entrepotLabel);
        adressePanel.Dock = DockStyle.Fill;
        adressePanel.Location = new Point(239, 3);
        adressePanel.Name = "adressePanel";
        adressePanel.Padding = new Padding(10, 10, 10, 20);
        adressePanel.Size = new Size(230, 384);
        adressePanel.TabIndex = 4;
        // 
        // deleteEntrepotButton
        // 
        deleteEntrepotButton.Dock = DockStyle.Top;
        deleteEntrepotButton.Location = new Point(10, 178);
        deleteEntrepotButton.Name = "deleteEntrepotButton";
        deleteEntrepotButton.Size = new Size(210, 35);
        deleteEntrepotButton.TabIndex = 6;
        deleteEntrepotButton.Text = "Supprimer l'entrepot";
        deleteEntrepotButton.UseVisualStyleBackColor = true;
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
        // 
        // entrepotSelector
        // 
        entrepotSelector.Dock = DockStyle.Top;
        entrepotSelector.FormattingEnabled = true;
        entrepotSelector.Location = new Point(10, 85);
        entrepotSelector.Name = "entrepotSelector";
        entrepotSelector.Size = new Size(210, 23);
        entrepotSelector.TabIndex = 3;
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
        // 
        // entrepotLabel
        // 
        entrepotLabel.Dock = DockStyle.Top;
        entrepotLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        entrepotLabel.Location = new Point(10, 10);
        entrepotLabel.Name = "entrepotLabel";
        entrepotLabel.Size = new Size(210, 40);
        entrepotLabel.TabIndex = 1;
        entrepotLabel.Text = "Gestion des Entrepots";
        entrepotLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // entrepotPanel
        // 
        entrepotPanel.Controls.Add(AdresseDeleteButton);
        entrepotPanel.Controls.Add(AdresseEditButton);
        entrepotPanel.Controls.Add(AdresseViewButton);
        entrepotPanel.Controls.Add(AdresseListBox);
        entrepotPanel.Controls.Add(AdresseFiltreTextBox);
        entrepotPanel.Controls.Add(createAdresseButton);
        entrepotPanel.Controls.Add(adresseLabel);
        entrepotPanel.Dock = DockStyle.Fill;
        entrepotPanel.Location = new Point(475, 3);
        entrepotPanel.Name = "entrepotPanel";
        entrepotPanel.Padding = new Padding(10);
        entrepotPanel.Size = new Size(230, 384);
        entrepotPanel.TabIndex = 5;
        // 
        // AdresseViewButton
        // 
        AdresseViewButton.Dock = DockStyle.Top;
        AdresseViewButton.Location = new Point(10, 202);
        AdresseViewButton.Name = "AdresseViewButton";
        AdresseViewButton.Size = new Size(210, 35);
        AdresseViewButton.TabIndex = 7;
        AdresseViewButton.Text = "Voir détails de l'adresse";
        AdresseViewButton.UseVisualStyleBackColor = true;
        // 
        // AdresseListBox
        // 
        AdresseListBox.Dock = DockStyle.Top;
        AdresseListBox.FormattingEnabled = true;
        AdresseListBox.ItemHeight = 15;
        AdresseListBox.Location = new Point(10, 108);
        AdresseListBox.Name = "AdresseListBox";
        AdresseListBox.Size = new Size(210, 94);
        AdresseListBox.TabIndex = 6;
        // 
        // AdresseFiltreTextBox
        // 
        AdresseFiltreTextBox.BackColor = SystemColors.Window;
        AdresseFiltreTextBox.Dock = DockStyle.Top;
        AdresseFiltreTextBox.Location = new Point(10, 85);
        AdresseFiltreTextBox.Name = "AdresseFiltreTextBox";
        AdresseFiltreTextBox.Size = new Size(210, 23);
        AdresseFiltreTextBox.TabIndex = 4;
        AdresseFiltreTextBox.UseSystemPasswordChar = true;
        // 
        // createAdresseButton
        // 
        createAdresseButton.Dock = DockStyle.Top;
        createAdresseButton.Location = new Point(10, 50);
        createAdresseButton.Name = "createAdresseButton";
        createAdresseButton.Size = new Size(210, 35);
        createAdresseButton.TabIndex = 3;
        createAdresseButton.Text = "Créer une adresse";
        createAdresseButton.UseVisualStyleBackColor = true;
        // 
        // adresseLabel
        // 
        adresseLabel.Dock = DockStyle.Top;
        adresseLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        adresseLabel.Location = new Point(10, 10);
        adresseLabel.Name = "adresseLabel";
        adresseLabel.Size = new Size(210, 40);
        adresseLabel.TabIndex = 2;
        adresseLabel.Text = "Gestion des Adresses";
        adresseLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        userManagementPanel.ResumeLayout(false);
        adressePanel.ResumeLayout(false);
        entrepotPanel.ResumeLayout(false);
        entrepotPanel.PerformLayout();
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
    private Panel panel2;
    private Button FournisseurCreateBtn;
    private Label fournisseurLabel;
    private Panel panel3;
    private Label label1;
    private ListBox ShipmentListBox;
    private TextBox ShipmentFiltreTextbox;
    private Button ShipmentCreateBtn;
    private TextBox FournisseurFiltreTextBox;
    private ListBox FournisseurListBox;
    private Button ShipmentViewBtn;
    private Button FournisseurDeleteBtn;
    private Button FournisseurEditBtn;
    private Button FournisseurViewBtn;
    private Panel adressePanel;
    private Button createEntrepotButton;
    private Label entrepotLabel;
    private Button editEntrepotButton;
    private Button viewEntrepotButton;
    private ComboBox entrepotSelector;
    private Button deleteEntrepotButton;
    private Panel entrepotPanel;
    private Label adresseLabel;
    private TextBox AdresseFiltreTextBox;
    private Button createAdresseButton;
    private Button AdresseViewButton;
    private ListBox AdresseListBox;
    private Button AdresseEditButton;
    private Button AdresseDeleteButton;
}