namespace _420DA3_07451_Projet_Initial.Presentation;

partial class EmployeEntrepotMainMenu {
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
        mainTableLayoutPanel = new TableLayoutPanel();
        column4MainPanel = new Panel();
        column4CenterPanel = new Panel();
        optionsTableLayout = new TableLayoutPanel();
        optionsMainPanel = new Panel();
        restockOrderOptionsBox = new GroupBox();
        markPoAsCompletedButton = new Button();
        shipOrderOptionsBox = new GroupBox();
        markSoAsCompletedButton = new Button();
        markSoAsPickedUpButton = new Button();
        assignToSelfButton = new Button();
        column4BottomPanel = new Panel();
        quitButton = new Button();
        column4HeaderLabel = new Label();
        column3MainPanel = new Panel();
        column3CenterPanel = new Panel();
        warehouseIncompletePoListBox = new ListBox();
        column3BottomPanel = new Panel();
        col3BottomTableLayout = new TableLayoutPanel();
        col3RefreshButton = new Button();
        column3HeaderLabel = new Label();
        column2MainPanel = new Panel();
        column2CenterPanel = new Panel();
        userIncompleteSOListBox = new ListBox();
        column2BottomPanel = new Panel();
        col2BottomTableLayout = new TableLayoutPanel();
        col2RefreshButton = new Button();
        column2HeaderLabel = new Label();
        column1MainPanel = new Panel();
        column1CenterPanel = new Panel();
        unassignedSOListBox = new ListBox();
        column1BottomPanel = new Panel();
        col1BottomTableLayout = new TableLayoutPanel();
        col1RefreshButton = new Button();
        column1HeaderLabel = new Label();
        mainTableLayoutPanel.SuspendLayout();
        column4MainPanel.SuspendLayout();
        column4CenterPanel.SuspendLayout();
        optionsTableLayout.SuspendLayout();
        optionsMainPanel.SuspendLayout();
        restockOrderOptionsBox.SuspendLayout();
        shipOrderOptionsBox.SuspendLayout();
        column4BottomPanel.SuspendLayout();
        column3MainPanel.SuspendLayout();
        column3CenterPanel.SuspendLayout();
        column3BottomPanel.SuspendLayout();
        col3BottomTableLayout.SuspendLayout();
        column2MainPanel.SuspendLayout();
        column2CenterPanel.SuspendLayout();
        column2BottomPanel.SuspendLayout();
        col2BottomTableLayout.SuspendLayout();
        column1MainPanel.SuspendLayout();
        column1CenterPanel.SuspendLayout();
        column1BottomPanel.SuspendLayout();
        col1BottomTableLayout.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(1184, 50);
        topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        bottomBarPanel.Dock = DockStyle.Bottom;
        bottomBarPanel.Location = new Point(0, 811);
        bottomBarPanel.Name = "bottomBarPanel";
        bottomBarPanel.Size = new Size(1184, 50);
        bottomBarPanel.TabIndex = 1;
        // 
        // mainTableLayoutPanel
        // 
        mainTableLayoutPanel.ColumnCount = 4;
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        mainTableLayoutPanel.Controls.Add(column4MainPanel, 3, 0);
        mainTableLayoutPanel.Controls.Add(column3MainPanel, 2, 0);
        mainTableLayoutPanel.Controls.Add(column2MainPanel, 1, 0);
        mainTableLayoutPanel.Controls.Add(column1MainPanel, 0, 0);
        mainTableLayoutPanel.Dock = DockStyle.Fill;
        mainTableLayoutPanel.Location = new Point(0, 50);
        mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        mainTableLayoutPanel.RowCount = 1;
        mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainTableLayoutPanel.Size = new Size(1184, 761);
        mainTableLayoutPanel.TabIndex = 2;
        // 
        // column4MainPanel
        // 
        column4MainPanel.Controls.Add(column4CenterPanel);
        column4MainPanel.Controls.Add(column4BottomPanel);
        column4MainPanel.Controls.Add(column4HeaderLabel);
        column4MainPanel.Dock = DockStyle.Fill;
        column4MainPanel.Location = new Point(891, 3);
        column4MainPanel.Name = "column4MainPanel";
        column4MainPanel.Padding = new Padding(5);
        column4MainPanel.Size = new Size(290, 755);
        column4MainPanel.TabIndex = 3;
        // 
        // column4CenterPanel
        // 
        column4CenterPanel.Controls.Add(optionsTableLayout);
        column4CenterPanel.Dock = DockStyle.Fill;
        column4CenterPanel.Location = new Point(5, 55);
        column4CenterPanel.Name = "column4CenterPanel";
        column4CenterPanel.Padding = new Padding(10);
        column4CenterPanel.Size = new Size(280, 645);
        column4CenterPanel.TabIndex = 5;
        // 
        // optionsTableLayout
        // 
        optionsTableLayout.ColumnCount = 3;
        optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        optionsTableLayout.Controls.Add(optionsMainPanel, 1, 0);
        optionsTableLayout.Dock = DockStyle.Fill;
        optionsTableLayout.Location = new Point(10, 10);
        optionsTableLayout.Name = "optionsTableLayout";
        optionsTableLayout.RowCount = 1;
        optionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        optionsTableLayout.Size = new Size(260, 625);
        optionsTableLayout.TabIndex = 0;
        // 
        // optionsMainPanel
        // 
        optionsMainPanel.Controls.Add(restockOrderOptionsBox);
        optionsMainPanel.Controls.Add(shipOrderOptionsBox);
        optionsMainPanel.Dock = DockStyle.Fill;
        optionsMainPanel.Location = new Point(23, 3);
        optionsMainPanel.Name = "optionsMainPanel";
        optionsMainPanel.Size = new Size(194, 619);
        optionsMainPanel.TabIndex = 0;
        // 
        // restockOrderOptionsBox
        // 
        restockOrderOptionsBox.Controls.Add(markPoAsCompletedButton);
        restockOrderOptionsBox.Location = new Point(3, 199);
        restockOrderOptionsBox.Name = "restockOrderOptionsBox";
        restockOrderOptionsBox.Size = new Size(188, 68);
        restockOrderOptionsBox.TabIndex = 1;
        restockOrderOptionsBox.TabStop = false;
        restockOrderOptionsBox.Text = "Ordres de restockage";
        // 
        // markPoAsCompletedButton
        // 
        markPoAsCompletedButton.Enabled = false;
        markPoAsCompletedButton.Location = new Point(6, 22);
        markPoAsCompletedButton.Name = "markPoAsCompletedButton";
        markPoAsCompletedButton.Size = new Size(176, 35);
        markPoAsCompletedButton.TabIndex = 2;
        markPoAsCompletedButton.Text = "Marquer comme reçue";
        markPoAsCompletedButton.UseVisualStyleBackColor = true;
        markPoAsCompletedButton.Click += this.markPoAsCompletedButton_Click;
        // 
        // shipOrderOptionsBox
        // 
        shipOrderOptionsBox.Controls.Add(markSoAsCompletedButton);
        shipOrderOptionsBox.Controls.Add(markSoAsPickedUpButton);
        shipOrderOptionsBox.Controls.Add(assignToSelfButton);
        shipOrderOptionsBox.Location = new Point(3, 3);
        shipOrderOptionsBox.Name = "shipOrderOptionsBox";
        shipOrderOptionsBox.Size = new Size(188, 152);
        shipOrderOptionsBox.TabIndex = 0;
        shipOrderOptionsBox.TabStop = false;
        shipOrderOptionsBox.Text = "Ordres d'expédition";
        // 
        // markSoAsCompletedButton
        // 
        markSoAsCompletedButton.Enabled = false;
        markSoAsCompletedButton.Location = new Point(6, 104);
        markSoAsCompletedButton.Name = "markSoAsCompletedButton";
        markSoAsCompletedButton.Size = new Size(176, 35);
        markSoAsCompletedButton.TabIndex = 2;
        markSoAsCompletedButton.Text = "Marquer comme completer";
        markSoAsCompletedButton.UseVisualStyleBackColor = true;
        markSoAsCompletedButton.Click += this.markSoAsCompletedButton_Click;
        // 
        // markSoAsPickedUpButton
        // 
        markSoAsPickedUpButton.Enabled = false;
        markSoAsPickedUpButton.Location = new Point(6, 63);
        markSoAsPickedUpButton.Name = "markSoAsPickedUpButton";
        markSoAsPickedUpButton.Size = new Size(176, 35);
        markSoAsPickedUpButton.TabIndex = 1;
        markSoAsPickedUpButton.Text = "Marquer comme ramassée";
        markSoAsPickedUpButton.UseVisualStyleBackColor = true;
        markSoAsPickedUpButton.Click += this.markSoAsPickedUpButton_Click;
        // 
        // assignToSelfButton
        // 
        assignToSelfButton.Enabled = false;
        assignToSelfButton.Location = new Point(6, 22);
        assignToSelfButton.Name = "assignToSelfButton";
        assignToSelfButton.Size = new Size(176, 35);
        assignToSelfButton.TabIndex = 0;
        assignToSelfButton.Text = "Assigner à soi-même";
        assignToSelfButton.UseVisualStyleBackColor = true;
        assignToSelfButton.Click += this.assignToSelfButton_Click;
        // 
        // column4BottomPanel
        // 
        column4BottomPanel.Controls.Add(quitButton);
        column4BottomPanel.Dock = DockStyle.Bottom;
        column4BottomPanel.Location = new Point(5, 700);
        column4BottomPanel.Name = "column4BottomPanel";
        column4BottomPanel.Size = new Size(280, 50);
        column4BottomPanel.TabIndex = 4;
        // 
        // quitButton
        // 
        quitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        quitButton.Location = new Point(42, 6);
        quitButton.Name = "quitButton";
        quitButton.Size = new Size(176, 35);
        quitButton.TabIndex = 4;
        quitButton.Text = "Quitter";
        quitButton.UseVisualStyleBackColor = true;
        quitButton.Click += this.quitButton_Click;
        // 
        // column4HeaderLabel
        // 
        column4HeaderLabel.Dock = DockStyle.Top;
        column4HeaderLabel.Location = new Point(5, 5);
        column4HeaderLabel.Name = "column4HeaderLabel";
        column4HeaderLabel.Size = new Size(280, 50);
        column4HeaderLabel.TabIndex = 2;
        column4HeaderLabel.Text = "Options";
        column4HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column3MainPanel
        // 
        column3MainPanel.Controls.Add(column3CenterPanel);
        column3MainPanel.Controls.Add(column3BottomPanel);
        column3MainPanel.Controls.Add(column3HeaderLabel);
        column3MainPanel.Dock = DockStyle.Fill;
        column3MainPanel.Location = new Point(595, 3);
        column3MainPanel.Name = "column3MainPanel";
        column3MainPanel.Padding = new Padding(5);
        column3MainPanel.Size = new Size(290, 755);
        column3MainPanel.TabIndex = 2;
        // 
        // column3CenterPanel
        // 
        column3CenterPanel.Controls.Add(warehouseIncompletePoListBox);
        column3CenterPanel.Dock = DockStyle.Fill;
        column3CenterPanel.Location = new Point(5, 55);
        column3CenterPanel.Name = "column3CenterPanel";
        column3CenterPanel.Padding = new Padding(5);
        column3CenterPanel.Size = new Size(280, 645);
        column3CenterPanel.TabIndex = 4;
        // 
        // warehouseIncompletePoListBox
        // 
        warehouseIncompletePoListBox.Dock = DockStyle.Fill;
        warehouseIncompletePoListBox.FormattingEnabled = true;
        warehouseIncompletePoListBox.ItemHeight = 15;
        warehouseIncompletePoListBox.Location = new Point(5, 5);
        warehouseIncompletePoListBox.Name = "warehouseIncompletePoListBox";
        warehouseIncompletePoListBox.Size = new Size(270, 635);
        warehouseIncompletePoListBox.TabIndex = 0;
        warehouseIncompletePoListBox.SelectedIndexChanged += this.warehouseIncompletePoListBox_SelectedIndexChanged;
        // 
        // column3BottomPanel
        // 
        column3BottomPanel.Controls.Add(col3BottomTableLayout);
        column3BottomPanel.Dock = DockStyle.Bottom;
        column3BottomPanel.Location = new Point(5, 700);
        column3BottomPanel.Name = "column3BottomPanel";
        column3BottomPanel.Size = new Size(280, 50);
        column3BottomPanel.TabIndex = 3;
        // 
        // col3BottomTableLayout
        // 
        col3BottomTableLayout.ColumnCount = 3;
        col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col3BottomTableLayout.Controls.Add(col3RefreshButton, 1, 0);
        col3BottomTableLayout.Dock = DockStyle.Fill;
        col3BottomTableLayout.Location = new Point(0, 0);
        col3BottomTableLayout.Name = "col3BottomTableLayout";
        col3BottomTableLayout.RowCount = 1;
        col3BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        col3BottomTableLayout.Size = new Size(280, 50);
        col3BottomTableLayout.TabIndex = 1;
        // 
        // col3RefreshButton
        // 
        col3RefreshButton.Location = new Point(43, 3);
        col3RefreshButton.Name = "col3RefreshButton";
        col3RefreshButton.Size = new Size(194, 35);
        col3RefreshButton.TabIndex = 2;
        col3RefreshButton.Text = "Mettre à jour";
        col3RefreshButton.UseVisualStyleBackColor = true;
        col3RefreshButton.Click += this.col3RefreshButton_Click;
        // 
        // column3HeaderLabel
        // 
        column3HeaderLabel.Dock = DockStyle.Top;
        column3HeaderLabel.Location = new Point(5, 5);
        column3HeaderLabel.Name = "column3HeaderLabel";
        column3HeaderLabel.Size = new Size(280, 50);
        column3HeaderLabel.TabIndex = 2;
        column3HeaderLabel.Text = "Ordres de restockage en attente";
        column3HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column2MainPanel
        // 
        column2MainPanel.Controls.Add(column2CenterPanel);
        column2MainPanel.Controls.Add(column2BottomPanel);
        column2MainPanel.Controls.Add(column2HeaderLabel);
        column2MainPanel.Dock = DockStyle.Fill;
        column2MainPanel.Location = new Point(299, 3);
        column2MainPanel.Name = "column2MainPanel";
        column2MainPanel.Padding = new Padding(5);
        column2MainPanel.Size = new Size(290, 755);
        column2MainPanel.TabIndex = 1;
        // 
        // column2CenterPanel
        // 
        column2CenterPanel.Controls.Add(userIncompleteSOListBox);
        column2CenterPanel.Dock = DockStyle.Fill;
        column2CenterPanel.Location = new Point(5, 55);
        column2CenterPanel.Name = "column2CenterPanel";
        column2CenterPanel.Padding = new Padding(5);
        column2CenterPanel.Size = new Size(280, 645);
        column2CenterPanel.TabIndex = 3;
        // 
        // userIncompleteSOListBox
        // 
        userIncompleteSOListBox.Dock = DockStyle.Fill;
        userIncompleteSOListBox.FormattingEnabled = true;
        userIncompleteSOListBox.ItemHeight = 15;
        userIncompleteSOListBox.Location = new Point(5, 5);
        userIncompleteSOListBox.Name = "userIncompleteSOListBox";
        userIncompleteSOListBox.Size = new Size(270, 635);
        userIncompleteSOListBox.TabIndex = 0;
        userIncompleteSOListBox.SelectedIndexChanged += this.userIncompleteSOListBox_SelectedIndexChanged;
        // 
        // column2BottomPanel
        // 
        column2BottomPanel.Controls.Add(col2BottomTableLayout);
        column2BottomPanel.Dock = DockStyle.Bottom;
        column2BottomPanel.Location = new Point(5, 700);
        column2BottomPanel.Name = "column2BottomPanel";
        column2BottomPanel.Size = new Size(280, 50);
        column2BottomPanel.TabIndex = 2;
        // 
        // col2BottomTableLayout
        // 
        col2BottomTableLayout.ColumnCount = 3;
        col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col2BottomTableLayout.Controls.Add(col2RefreshButton, 1, 0);
        col2BottomTableLayout.Dock = DockStyle.Fill;
        col2BottomTableLayout.Location = new Point(0, 0);
        col2BottomTableLayout.Name = "col2BottomTableLayout";
        col2BottomTableLayout.RowCount = 1;
        col2BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        col2BottomTableLayout.Size = new Size(280, 50);
        col2BottomTableLayout.TabIndex = 1;
        // 
        // col2RefreshButton
        // 
        col2RefreshButton.Location = new Point(43, 3);
        col2RefreshButton.Name = "col2RefreshButton";
        col2RefreshButton.Size = new Size(194, 35);
        col2RefreshButton.TabIndex = 1;
        col2RefreshButton.Text = "Mettre à jour";
        col2RefreshButton.UseVisualStyleBackColor = true;
        col2RefreshButton.Click += this.col2RefreshButton_Click;
        // 
        // column2HeaderLabel
        // 
        column2HeaderLabel.Dock = DockStyle.Top;
        column2HeaderLabel.Location = new Point(5, 5);
        column2HeaderLabel.Name = "column2HeaderLabel";
        column2HeaderLabel.Size = new Size(280, 50);
        column2HeaderLabel.TabIndex = 1;
        column2HeaderLabel.Text = "Mes ordres d'expéditions non complétées";
        column2HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column1MainPanel
        // 
        column1MainPanel.Controls.Add(column1CenterPanel);
        column1MainPanel.Controls.Add(column1BottomPanel);
        column1MainPanel.Controls.Add(column1HeaderLabel);
        column1MainPanel.Dock = DockStyle.Fill;
        column1MainPanel.Location = new Point(3, 3);
        column1MainPanel.Name = "column1MainPanel";
        column1MainPanel.Padding = new Padding(5);
        column1MainPanel.Size = new Size(290, 755);
        column1MainPanel.TabIndex = 0;
        // 
        // column1CenterPanel
        // 
        column1CenterPanel.Controls.Add(unassignedSOListBox);
        column1CenterPanel.Dock = DockStyle.Fill;
        column1CenterPanel.Location = new Point(5, 55);
        column1CenterPanel.Name = "column1CenterPanel";
        column1CenterPanel.Padding = new Padding(5);
        column1CenterPanel.Size = new Size(280, 645);
        column1CenterPanel.TabIndex = 2;
        // 
        // unassignedSOListBox
        // 
        unassignedSOListBox.Dock = DockStyle.Fill;
        unassignedSOListBox.FormattingEnabled = true;
        unassignedSOListBox.ItemHeight = 15;
        unassignedSOListBox.Location = new Point(5, 5);
        unassignedSOListBox.Name = "unassignedSOListBox";
        unassignedSOListBox.Size = new Size(270, 635);
        unassignedSOListBox.TabIndex = 0;
        unassignedSOListBox.SelectedIndexChanged += this.unassignedSOListBox_SelectedIndexChanged;
        // 
        // column1BottomPanel
        // 
        column1BottomPanel.Controls.Add(col1BottomTableLayout);
        column1BottomPanel.Dock = DockStyle.Bottom;
        column1BottomPanel.Location = new Point(5, 700);
        column1BottomPanel.Name = "column1BottomPanel";
        column1BottomPanel.Size = new Size(280, 50);
        column1BottomPanel.TabIndex = 1;
        // 
        // col1BottomTableLayout
        // 
        col1BottomTableLayout.ColumnCount = 3;
        col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        col1BottomTableLayout.Controls.Add(col1RefreshButton, 1, 0);
        col1BottomTableLayout.Dock = DockStyle.Fill;
        col1BottomTableLayout.Location = new Point(0, 0);
        col1BottomTableLayout.Name = "col1BottomTableLayout";
        col1BottomTableLayout.RowCount = 1;
        col1BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        col1BottomTableLayout.Size = new Size(280, 50);
        col1BottomTableLayout.TabIndex = 0;
        // 
        // col1RefreshButton
        // 
        col1RefreshButton.Location = new Point(43, 3);
        col1RefreshButton.Name = "col1RefreshButton";
        col1RefreshButton.Size = new Size(194, 35);
        col1RefreshButton.TabIndex = 0;
        col1RefreshButton.Text = "Mettre à jour";
        col1RefreshButton.UseVisualStyleBackColor = true;
        col1RefreshButton.Click += this.col1RefreshButton_Click;
        // 
        // column1HeaderLabel
        // 
        column1HeaderLabel.Dock = DockStyle.Top;
        column1HeaderLabel.Location = new Point(5, 5);
        column1HeaderLabel.Name = "column1HeaderLabel";
        column1HeaderLabel.Size = new Size(280, 50);
        column1HeaderLabel.TabIndex = 0;
        column1HeaderLabel.Text = "Ordres d'expédition non assignées";
        column1HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // EmployeEntrepotMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(mainTableLayoutPanel);
        this.Controls.Add(bottomBarPanel);
        this.Controls.Add(topBarPanel);
        this.Name = "EmployeEntrepotMainMenu";
        this.Text = "EmployeEntrepotMainMenu";
        this.WindowState = FormWindowState.Maximized;
        mainTableLayoutPanel.ResumeLayout(false);
        column4MainPanel.ResumeLayout(false);
        column4CenterPanel.ResumeLayout(false);
        optionsTableLayout.ResumeLayout(false);
        optionsMainPanel.ResumeLayout(false);
        restockOrderOptionsBox.ResumeLayout(false);
        shipOrderOptionsBox.ResumeLayout(false);
        column4BottomPanel.ResumeLayout(false);
        column3MainPanel.ResumeLayout(false);
        column3CenterPanel.ResumeLayout(false);
        column3BottomPanel.ResumeLayout(false);
        col3BottomTableLayout.ResumeLayout(false);
        column2MainPanel.ResumeLayout(false);
        column2CenterPanel.ResumeLayout(false);
        column2BottomPanel.ResumeLayout(false);
        col2BottomTableLayout.ResumeLayout(false);
        column1MainPanel.ResumeLayout(false);
        column1CenterPanel.ResumeLayout(false);
        column1BottomPanel.ResumeLayout(false);
        col1BottomTableLayout.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel mainTableLayoutPanel;
    private Panel column4MainPanel;
    private Panel column3MainPanel;
    private Label column3HeaderLabel;
    private Panel column2MainPanel;
    private Label column2HeaderLabel;
    private Panel column1MainPanel;
    private Label column1HeaderLabel;
    private Label column4HeaderLabel;
    private Panel column4CenterPanel;
    private Panel column4BottomPanel;
    private Panel column3CenterPanel;
    private Panel column3BottomPanel;
    private Panel column2CenterPanel;
    private Panel column2BottomPanel;
    private Panel column1CenterPanel;
    private Panel column1BottomPanel;
    private ListBox warehouseIncompletePoListBox;
    private ListBox userIncompleteSOListBox;
    private ListBox unassignedSOListBox;
    private TableLayoutPanel col3BottomTableLayout;
    private TableLayoutPanel col2BottomTableLayout;
    private TableLayoutPanel col1BottomTableLayout;
    private Button col1RefreshButton;
    private Button col3RefreshButton;
    private Button col2RefreshButton;
    private TableLayoutPanel optionsTableLayout;
    private Panel optionsMainPanel;
    private GroupBox shipOrderOptionsBox;
    private GroupBox restockOrderOptionsBox;
    private Button markPoAsCompletedButton;
    private Button markSoAsCompletedButton;
    private Button markSoAsPickedUpButton;
    private Button assignToSelfButton;
    private Button quitButton;
}