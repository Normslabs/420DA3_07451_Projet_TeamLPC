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
        listView1 = new ListView();
        this.SuspendLayout();
        // 
        // roleSearchBox
        // 
        roleSearchBox.Location = new Point(12, 33);
        roleSearchBox.Name = "roleSearchBox";
        roleSearchBox.PlaceholderText = "Search item...";
        roleSearchBox.Size = new Size(332, 23);
        roleSearchBox.TabIndex = 1;
        roleSearchBox.TextChanged += this.TextBox1_TextChanged;
        // 
        // rolesListBox
        // 
        rolesListBox.FormattingEnabled = true;
        rolesListBox.ItemHeight = 15;
        rolesListBox.Location = new Point(12, 62);
        rolesListBox.Name = "rolesListBox";
        rolesListBox.SelectionMode = SelectionMode.MultiExtended;
        rolesListBox.Size = new Size(332, 154);
        rolesListBox.Sorted = true;
        rolesListBox.TabIndex = 2;
        rolesListBox.SelectedIndexChanged += this.ListBox1_SelectedIndexChanged;
        // 
        // comboBox1
        // 
        comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(12, 222);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(332, 23);
        comboBox1.Sorted = true;
        comboBox1.TabIndex = 3;
        comboBox1.SelectedIndexChanged += this.ComboBox1_SelectedIndexChanged;
        // 
        // listView1
        // 
        listView1.FullRowSelect = true;
        listView1.Location = new Point(477, 33);
        listView1.Name = "listView1";
        listView1.Size = new Size(311, 212);
        listView1.TabIndex = 4;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // UtilisateurManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(listView1);
        this.Controls.Add(comboBox1);
        this.Controls.Add(rolesListBox);
        this.Controls.Add(roleSearchBox);
        this.Name = "UtilisateurManagementForm";
        this.Text = "Utilisateur Management Form";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private TextBox roleSearchBox;
    private ListBox rolesListBox;
    private ComboBox comboBox1;
    private ListView listView1;
}