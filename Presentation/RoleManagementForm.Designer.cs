namespace _420DA3_07451_Projet_Initial.Presentation;

partial class RoleManagementForm {
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
        this.topbarPanel = new Panel();
        this.openModeValueLabel = new Label();
        this.openModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.boutonAction = new Button();
        this.buttonAnnuler = new Button();
        this.mainPanel = new TableLayoutPanel();
        this.mainPanelLeftPanel = new Panel();
        this.mainPanelRightPanel = new Panel();
        this.roleDescriptionTextBox = new TextBox();
        this.roleNameTextBox = new TextBox();
        this.idNumUpDown = new NumericUpDown();
        this.idLabel = new Label();
        this.roleNameLabel = new Label();
        this.label1 = new Label();
        this.topbarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        this.mainPanelLeftPanel.SuspendLayout();
        this.mainPanelRightPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).BeginInit();
        this.SuspendLayout();
        // 
        // topbarPanel
        // 
        this.topbarPanel.Controls.Add(this.openModeValueLabel);
        this.topbarPanel.Controls.Add(this.openModeLabel);
        this.topbarPanel.Dock = DockStyle.Top;
        this.topbarPanel.Location = new Point(0, 0);
        this.topbarPanel.Margin = new Padding(3, 2, 3, 2);
        this.topbarPanel.Name = "topbarPanel";
        this.topbarPanel.Size = new Size(509, 38);
        this.topbarPanel.TabIndex = 6;
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
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Controls.Add(this.boutonAction);
        this.bottomBarPanel.Controls.Add(this.buttonAnnuler);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 266);
        this.bottomBarPanel.Margin = new Padding(3, 2, 3, 2);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(509, 45);
        this.bottomBarPanel.TabIndex = 7;
        // 
        // actionButton
        // 
        this.actionButton.Location = new Point(310, 10);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(106, 23);
        this.actionButton.TabIndex = 3;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(422, 10);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(75, 23);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // boutonAction
        // 
        this.boutonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.boutonAction.FlatStyle = FlatStyle.Flat;
        this.boutonAction.Location = new Point(571, -45);
        this.boutonAction.Margin = new Padding(3, 2, 3, 2);
        this.boutonAction.Name = "boutonAction";
        this.boutonAction.Size = new Size(116, 26);
        this.boutonAction.TabIndex = 1;
        this.boutonAction.Text = "ACTION";
        this.boutonAction.UseVisualStyleBackColor = true;
        // 
        // buttonAnnuler
        // 
        this.buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAnnuler.FlatStyle = FlatStyle.Flat;
        this.buttonAnnuler.Location = new Point(692, -45);
        this.buttonAnnuler.Margin = new Padding(3, 2, 3, 2);
        this.buttonAnnuler.Name = "buttonAnnuler";
        this.buttonAnnuler.Size = new Size(116, 26);
        this.buttonAnnuler.TabIndex = 0;
        this.buttonAnnuler.Text = "Annuler";
        this.buttonAnnuler.UseVisualStyleBackColor = true;
        // 
        // mainPanel
        // 
        this.mainPanel.ColumnCount = 4;
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainPanel.Controls.Add(this.mainPanelLeftPanel, 1, 0);
        this.mainPanel.Controls.Add(this.mainPanelRightPanel, 2, 0);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(0, 38);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.RowCount = 1;
        this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainPanel.Size = new Size(509, 228);
        this.mainPanel.TabIndex = 8;
        // 
        // mainPanelLeftPanel
        // 
        this.mainPanelLeftPanel.Controls.Add(this.label1);
        this.mainPanelLeftPanel.Controls.Add(this.roleNameLabel);
        this.mainPanelLeftPanel.Controls.Add(this.idLabel);
        this.mainPanelLeftPanel.Dock = DockStyle.Fill;
        this.mainPanelLeftPanel.Location = new Point(32, 3);
        this.mainPanelLeftPanel.Name = "mainPanelLeftPanel";
        this.mainPanelLeftPanel.Size = new Size(144, 222);
        this.mainPanelLeftPanel.TabIndex = 0;
        // 
        // mainPanelRightPanel
        // 
        this.mainPanelRightPanel.Controls.Add(this.roleDescriptionTextBox);
        this.mainPanelRightPanel.Controls.Add(this.roleNameTextBox);
        this.mainPanelRightPanel.Controls.Add(this.idNumUpDown);
        this.mainPanelRightPanel.Dock = DockStyle.Fill;
        this.mainPanelRightPanel.Location = new Point(182, 3);
        this.mainPanelRightPanel.Name = "mainPanelRightPanel";
        this.mainPanelRightPanel.Size = new Size(294, 222);
        this.mainPanelRightPanel.TabIndex = 1;
        // 
        // roleDescriptionTextBox
        // 
        this.roleDescriptionTextBox.Enabled = false;
        this.roleDescriptionTextBox.Location = new Point(3, 79);
        this.roleDescriptionTextBox.Multiline = true;
        this.roleDescriptionTextBox.Name = "roleDescriptionTextBox";
        this.roleDescriptionTextBox.Size = new Size(288, 140);
        this.roleDescriptionTextBox.TabIndex = 2;
        // 
        // roleNameTextBox
        // 
        this.roleNameTextBox.Enabled = false;
        this.roleNameTextBox.Location = new Point(3, 50);
        this.roleNameTextBox.Name = "roleNameTextBox";
        this.roleNameTextBox.Size = new Size(288, 23);
        this.roleNameTextBox.TabIndex = 1;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(3, 21);
        this.idNumUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(288, 23);
        this.idNumUpDown.TabIndex = 0;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 20);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(129, 20);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // roleNameLabel
        // 
        this.roleNameLabel.Location = new Point(3, 50);
        this.roleNameLabel.Name = "roleNameLabel";
        this.roleNameLabel.Size = new Size(129, 20);
        this.roleNameLabel.TabIndex = 1;
        this.roleNameLabel.Text = "Nom du rôle:";
        this.roleNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        this.label1.Location = new Point(3, 79);
        this.label1.Name = "label1";
        this.label1.Size = new Size(129, 20);
        this.label1.TabIndex = 2;
        this.label1.Text = "Description du rôle:";
        this.label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(509, 311);
        this.Controls.Add(this.mainPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topbarPanel);
        this.Name = "RoleManagementForm";
        this.Text = "RoleManagementForm";
        this.topbarPanel.ResumeLayout(false);
        this.topbarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanelLeftPanel.ResumeLayout(false);
        this.mainPanelRightPanel.ResumeLayout(false);
        this.mainPanelRightPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topbarPanel;
    private Label openModeValueLabel;
    private Label openModeLabel;
    private Panel bottomBarPanel;
    private Button boutonAction;
    private Button buttonAnnuler;
    private TableLayoutPanel mainPanel;
    private Panel mainPanelLeftPanel;
    private Panel mainPanelRightPanel;
    private NumericUpDown idNumUpDown;
    private TextBox roleNameTextBox;
    private TextBox roleDescriptionTextBox;
    private Button actionButton;
    private Button cancelButton;
    private Label idLabel;
    private Label label1;
    private Label roleNameLabel;
}