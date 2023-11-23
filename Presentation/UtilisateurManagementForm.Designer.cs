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
        roleSearchBox = new TextBox();
        rolesListBox = new ListBox();
        comboBox1 = new ComboBox();
        panel1 = new Panel();
        boutonAction = new Button();
        buttonAnnuler = new Button();
        menuStrip1 = new MenuStrip();
        propertyGrid1 = new PropertyGrid();
        button1 = new Button();
        panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // roleSearchBox
        // 
        roleSearchBox.Location = new Point(14, 44);
        roleSearchBox.Margin = new Padding(3, 4, 3, 4);
        roleSearchBox.Name = "roleSearchBox";
        roleSearchBox.PlaceholderText = "Search item...";
        roleSearchBox.Size = new Size(379, 27);
        roleSearchBox.TabIndex = 1;
        roleSearchBox.TextChanged += this.TextBox1_TextChanged;
        // 
        // rolesListBox
        // 
        rolesListBox.FormattingEnabled = true;
        rolesListBox.ItemHeight = 20;
        rolesListBox.Location = new Point(14, 83);
        rolesListBox.Margin = new Padding(3, 4, 3, 4);
        rolesListBox.Name = "rolesListBox";
        rolesListBox.SelectionMode = SelectionMode.MultiExtended;
        rolesListBox.Size = new Size(379, 204);
        rolesListBox.Sorted = true;
        rolesListBox.TabIndex = 2;
        rolesListBox.SelectedIndexChanged += this.ListBox1_SelectedIndexChanged;
        // 
        // comboBox1
        // 
        comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(521, 44);
        comboBox1.Margin = new Padding(3, 4, 3, 4);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(379, 28);
        comboBox1.Sorted = true;
        comboBox1.TabIndex = 3;
        comboBox1.SelectedIndexChanged += this.ComboBox1_SelectedIndexChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(boutonAction);
        panel1.Controls.Add(buttonAnnuler);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 540);
        panel1.Name = "panel1";
        panel1.Size = new Size(914, 60);
        panel1.TabIndex = 4;
        // 
        // boutonAction
        // 
        boutonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        boutonAction.FlatStyle = FlatStyle.Flat;
        boutonAction.Location = new Point(632, 13);
        boutonAction.Name = "boutonAction";
        boutonAction.Size = new Size(132, 35);
        boutonAction.TabIndex = 1;
        boutonAction.Text = "ACTION";
        boutonAction.UseVisualStyleBackColor = true;
        boutonAction.Click += this.boutonAction_Click;
        // 
        // buttonAnnuler
        // 
        buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        buttonAnnuler.FlatStyle = FlatStyle.Flat;
        buttonAnnuler.Location = new Point(770, 13);
        buttonAnnuler.Name = "buttonAnnuler";
        buttonAnnuler.Size = new Size(132, 35);
        buttonAnnuler.TabIndex = 0;
        buttonAnnuler.Text = "Annuler";
        buttonAnnuler.UseVisualStyleBackColor = true;
        buttonAnnuler.Click += this.buttonAnnuler_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(914, 24);
        menuStrip1.TabIndex = 11;
        menuStrip1.Text = "menuStrip1";
        // 
        // propertyGrid1
        // 
        propertyGrid1.Location = new Point(538, 218);
        propertyGrid1.Name = "propertyGrid1";
        propertyGrid1.Size = new Size(300, 275);
        propertyGrid1.TabIndex = 12;
        // 
        // button1
        // 
        button1.BackColor = Color.Lime;
        button1.FlatAppearance.BorderColor = Color.Lime;
        button1.FlatAppearance.BorderSize = 3;
        button1.FlatAppearance.MouseOverBackColor = Color.White;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(182, 373);
        button1.Name = "button1";
        button1.Size = new Size(252, 72);
        button1.TabIndex = 13;
        button1.Text = "DEMO";
        button1.UseVisualStyleBackColor = false;
        // 
        // UtilisateurManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(914, 600);
        this.Controls.Add(button1);
        this.Controls.Add(propertyGrid1);
        this.Controls.Add(panel1);
        this.Controls.Add(comboBox1);
        this.Controls.Add(rolesListBox);
        this.Controls.Add(roleSearchBox);
        this.Controls.Add(menuStrip1);
        this.MainMenuStrip = menuStrip1;
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "UtilisateurManagementForm";
        this.Text = "Utilisateur Management Form";
        panel1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private TextBox roleSearchBox;
    private ListBox rolesListBox;
    private ComboBox comboBox1;
    private Panel panel1;
    private Button buttonAnnuler;
    private Button boutonAction;
    private MenuStrip menuStrip1;
    private PropertyGrid propertyGrid1;
    private Button button1;
}