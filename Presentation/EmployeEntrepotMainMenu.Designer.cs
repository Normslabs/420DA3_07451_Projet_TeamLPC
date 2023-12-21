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
        this.topBarPanel = new Panel();
        this.bottomBarPanel = new Panel();
        this.mainTableLayoutPanel = new TableLayoutPanel();
        this.column4MainPanel = new Panel();
        this.column4CenterPanel = new Panel();
        this.column4BottomPanel = new Panel();
        this.column4HeaderLabel = new Label();
        this.column3MainPanel = new Panel();
        this.column3CenterPanel = new Panel();
        this.column3BottomPanel = new Panel();
        this.column3HeaderLabel = new Label();
        this.column2MainPanel = new Panel();
        this.column2CenterPanel = new Panel();
        this.column2BottomPanel = new Panel();
        this.column2HeaderLabel = new Label();
        this.column1MainPanel = new Panel();
        this.column1CenterPanel = new Panel();
        this.column1BottomPanel = new Panel();
        this.column1HeaderLabel = new Label();
        this.unassignedSOListBox = new ListBox();
        this.userIncompleteSOListBox = new ListBox();
        this.warehouseIncompletePoListBox = new ListBox();
        this.col1BottomTableLayout = new TableLayoutPanel();
        this.col2BottomTableLayout = new TableLayoutPanel();
        this.col3BottomTableLayout = new TableLayoutPanel();
        this.col1RefreshButton = new Button();
        this.col2RefreshButton = new Button();
        this.col3RefreshButton = new Button();
        this.optionsTableLayout = new TableLayoutPanel();
        this.optionsMainPanel = new Panel();
        this.shipOrderOptionsBox = new GroupBox();
        this.assignToSelfButton = new Button();
        this.markSoAsPickedUpButton = new Button();
        this.markSoAsCompletedButton = new Button();
        this.restockOrderOptionsBox = new GroupBox();
        this.markPoAsCompletedButton = new Button();
        this.quitButton = new Button();
        this.mainTableLayoutPanel.SuspendLayout();
        this.column4MainPanel.SuspendLayout();
        this.column4CenterPanel.SuspendLayout();
        this.column4BottomPanel.SuspendLayout();
        this.column3MainPanel.SuspendLayout();
        this.column3CenterPanel.SuspendLayout();
        this.column3BottomPanel.SuspendLayout();
        this.column2MainPanel.SuspendLayout();
        this.column2CenterPanel.SuspendLayout();
        this.column2BottomPanel.SuspendLayout();
        this.column1MainPanel.SuspendLayout();
        this.column1CenterPanel.SuspendLayout();
        this.column1BottomPanel.SuspendLayout();
        this.col1BottomTableLayout.SuspendLayout();
        this.col2BottomTableLayout.SuspendLayout();
        this.col3BottomTableLayout.SuspendLayout();
        this.optionsTableLayout.SuspendLayout();
        this.optionsMainPanel.SuspendLayout();
        this.shipOrderOptionsBox.SuspendLayout();
        this.restockOrderOptionsBox.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1184, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 811);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1184, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // mainTableLayoutPanel
        // 
        this.mainTableLayoutPanel.ColumnCount = 4;
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.mainTableLayoutPanel.Controls.Add(this.column4MainPanel, 3, 0);
        this.mainTableLayoutPanel.Controls.Add(this.column3MainPanel, 2, 0);
        this.mainTableLayoutPanel.Controls.Add(this.column2MainPanel, 1, 0);
        this.mainTableLayoutPanel.Controls.Add(this.column1MainPanel, 0, 0);
        this.mainTableLayoutPanel.Dock = DockStyle.Fill;
        this.mainTableLayoutPanel.Location = new Point(0, 50);
        this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        this.mainTableLayoutPanel.RowCount = 1;
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayoutPanel.Size = new Size(1184, 761);
        this.mainTableLayoutPanel.TabIndex = 2;
        // 
        // column4MainPanel
        // 
        this.column4MainPanel.Controls.Add(this.column4CenterPanel);
        this.column4MainPanel.Controls.Add(this.column4BottomPanel);
        this.column4MainPanel.Controls.Add(this.column4HeaderLabel);
        this.column4MainPanel.Dock = DockStyle.Fill;
        this.column4MainPanel.Location = new Point(891, 3);
        this.column4MainPanel.Name = "column4MainPanel";
        this.column4MainPanel.Padding = new Padding(5);
        this.column4MainPanel.Size = new Size(290, 755);
        this.column4MainPanel.TabIndex = 3;
        // 
        // column4CenterPanel
        // 
        this.column4CenterPanel.Controls.Add(this.optionsTableLayout);
        this.column4CenterPanel.Dock = DockStyle.Fill;
        this.column4CenterPanel.Location = new Point(5, 55);
        this.column4CenterPanel.Name = "column4CenterPanel";
        this.column4CenterPanel.Padding = new Padding(10);
        this.column4CenterPanel.Size = new Size(280, 645);
        this.column4CenterPanel.TabIndex = 5;
        // 
        // column4BottomPanel
        // 
        this.column4BottomPanel.Controls.Add(this.quitButton);
        this.column4BottomPanel.Dock = DockStyle.Bottom;
        this.column4BottomPanel.Location = new Point(5, 700);
        this.column4BottomPanel.Name = "column4BottomPanel";
        this.column4BottomPanel.Size = new Size(280, 50);
        this.column4BottomPanel.TabIndex = 4;
        // 
        // column4HeaderLabel
        // 
        this.column4HeaderLabel.Dock = DockStyle.Top;
        this.column4HeaderLabel.Location = new Point(5, 5);
        this.column4HeaderLabel.Name = "column4HeaderLabel";
        this.column4HeaderLabel.Size = new Size(280, 50);
        this.column4HeaderLabel.TabIndex = 2;
        this.column4HeaderLabel.Text = "Options";
        this.column4HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column3MainPanel
        // 
        this.column3MainPanel.Controls.Add(this.column3CenterPanel);
        this.column3MainPanel.Controls.Add(this.column3BottomPanel);
        this.column3MainPanel.Controls.Add(this.column3HeaderLabel);
        this.column3MainPanel.Dock = DockStyle.Fill;
        this.column3MainPanel.Location = new Point(595, 3);
        this.column3MainPanel.Name = "column3MainPanel";
        this.column3MainPanel.Padding = new Padding(5);
        this.column3MainPanel.Size = new Size(290, 755);
        this.column3MainPanel.TabIndex = 2;
        // 
        // column3CenterPanel
        // 
        this.column3CenterPanel.Controls.Add(this.warehouseIncompletePoListBox);
        this.column3CenterPanel.Dock = DockStyle.Fill;
        this.column3CenterPanel.Location = new Point(5, 55);
        this.column3CenterPanel.Name = "column3CenterPanel";
        this.column3CenterPanel.Padding = new Padding(5);
        this.column3CenterPanel.Size = new Size(280, 645);
        this.column3CenterPanel.TabIndex = 4;
        // 
        // column3BottomPanel
        // 
        this.column3BottomPanel.Controls.Add(this.col3BottomTableLayout);
        this.column3BottomPanel.Dock = DockStyle.Bottom;
        this.column3BottomPanel.Location = new Point(5, 700);
        this.column3BottomPanel.Name = "column3BottomPanel";
        this.column3BottomPanel.Size = new Size(280, 50);
        this.column3BottomPanel.TabIndex = 3;
        // 
        // column3HeaderLabel
        // 
        this.column3HeaderLabel.Dock = DockStyle.Top;
        this.column3HeaderLabel.Location = new Point(5, 5);
        this.column3HeaderLabel.Name = "column3HeaderLabel";
        this.column3HeaderLabel.Size = new Size(280, 50);
        this.column3HeaderLabel.TabIndex = 2;
        this.column3HeaderLabel.Text = "Ordres de restockage en attente";
        this.column3HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column2MainPanel
        // 
        this.column2MainPanel.Controls.Add(this.column2CenterPanel);
        this.column2MainPanel.Controls.Add(this.column2BottomPanel);
        this.column2MainPanel.Controls.Add(this.column2HeaderLabel);
        this.column2MainPanel.Dock = DockStyle.Fill;
        this.column2MainPanel.Location = new Point(299, 3);
        this.column2MainPanel.Name = "column2MainPanel";
        this.column2MainPanel.Padding = new Padding(5);
        this.column2MainPanel.Size = new Size(290, 755);
        this.column2MainPanel.TabIndex = 1;
        // 
        // column2CenterPanel
        // 
        this.column2CenterPanel.Controls.Add(this.userIncompleteSOListBox);
        this.column2CenterPanel.Dock = DockStyle.Fill;
        this.column2CenterPanel.Location = new Point(5, 55);
        this.column2CenterPanel.Name = "column2CenterPanel";
        this.column2CenterPanel.Padding = new Padding(5);
        this.column2CenterPanel.Size = new Size(280, 645);
        this.column2CenterPanel.TabIndex = 3;
        // 
        // column2BottomPanel
        // 
        this.column2BottomPanel.Controls.Add(this.col2BottomTableLayout);
        this.column2BottomPanel.Dock = DockStyle.Bottom;
        this.column2BottomPanel.Location = new Point(5, 700);
        this.column2BottomPanel.Name = "column2BottomPanel";
        this.column2BottomPanel.Size = new Size(280, 50);
        this.column2BottomPanel.TabIndex = 2;
        // 
        // column2HeaderLabel
        // 
        this.column2HeaderLabel.Dock = DockStyle.Top;
        this.column2HeaderLabel.Location = new Point(5, 5);
        this.column2HeaderLabel.Name = "column2HeaderLabel";
        this.column2HeaderLabel.Size = new Size(280, 50);
        this.column2HeaderLabel.TabIndex = 1;
        this.column2HeaderLabel.Text = "Mes ordres d'expéditions non complétées";
        this.column2HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // column1MainPanel
        // 
        this.column1MainPanel.Controls.Add(this.column1CenterPanel);
        this.column1MainPanel.Controls.Add(this.column1BottomPanel);
        this.column1MainPanel.Controls.Add(this.column1HeaderLabel);
        this.column1MainPanel.Dock = DockStyle.Fill;
        this.column1MainPanel.Location = new Point(3, 3);
        this.column1MainPanel.Name = "column1MainPanel";
        this.column1MainPanel.Padding = new Padding(5);
        this.column1MainPanel.Size = new Size(290, 755);
        this.column1MainPanel.TabIndex = 0;
        // 
        // column1CenterPanel
        // 
        this.column1CenterPanel.Controls.Add(this.unassignedSOListBox);
        this.column1CenterPanel.Dock = DockStyle.Fill;
        this.column1CenterPanel.Location = new Point(5, 55);
        this.column1CenterPanel.Name = "column1CenterPanel";
        this.column1CenterPanel.Padding = new Padding(5);
        this.column1CenterPanel.Size = new Size(280, 645);
        this.column1CenterPanel.TabIndex = 2;
        // 
        // column1BottomPanel
        // 
        this.column1BottomPanel.Controls.Add(this.col1BottomTableLayout);
        this.column1BottomPanel.Dock = DockStyle.Bottom;
        this.column1BottomPanel.Location = new Point(5, 700);
        this.column1BottomPanel.Name = "column1BottomPanel";
        this.column1BottomPanel.Size = new Size(280, 50);
        this.column1BottomPanel.TabIndex = 1;
        // 
        // column1HeaderLabel
        // 
        this.column1HeaderLabel.Dock = DockStyle.Top;
        this.column1HeaderLabel.Location = new Point(5, 5);
        this.column1HeaderLabel.Name = "column1HeaderLabel";
        this.column1HeaderLabel.Size = new Size(280, 50);
        this.column1HeaderLabel.TabIndex = 0;
        this.column1HeaderLabel.Text = "Ordres d'expédition non assignées";
        this.column1HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // unassignedSOListBox
        // 
        this.unassignedSOListBox.Dock = DockStyle.Fill;
        this.unassignedSOListBox.FormattingEnabled = true;
        this.unassignedSOListBox.ItemHeight = 15;
        this.unassignedSOListBox.Location = new Point(5, 5);
        this.unassignedSOListBox.Name = "unassignedSOListBox";
        this.unassignedSOListBox.Size = new Size(270, 635);
        this.unassignedSOListBox.TabIndex = 0;
        // 
        // userIncompleteSOListBox
        // 
        this.userIncompleteSOListBox.Dock = DockStyle.Fill;
        this.userIncompleteSOListBox.FormattingEnabled = true;
        this.userIncompleteSOListBox.ItemHeight = 15;
        this.userIncompleteSOListBox.Location = new Point(5, 5);
        this.userIncompleteSOListBox.Name = "userIncompleteSOListBox";
        this.userIncompleteSOListBox.Size = new Size(270, 635);
        this.userIncompleteSOListBox.TabIndex = 0;
        // 
        // warehouseIncompletePoListBox
        // 
        this.warehouseIncompletePoListBox.Dock = DockStyle.Fill;
        this.warehouseIncompletePoListBox.FormattingEnabled = true;
        this.warehouseIncompletePoListBox.ItemHeight = 15;
        this.warehouseIncompletePoListBox.Location = new Point(5, 5);
        this.warehouseIncompletePoListBox.Name = "warehouseIncompletePoListBox";
        this.warehouseIncompletePoListBox.Size = new Size(270, 635);
        this.warehouseIncompletePoListBox.TabIndex = 0;
        // 
        // col1BottomTableLayout
        // 
        this.col1BottomTableLayout.ColumnCount = 3;
        this.col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.col1BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col1BottomTableLayout.Controls.Add(this.col1RefreshButton, 1, 0);
        this.col1BottomTableLayout.Dock = DockStyle.Fill;
        this.col1BottomTableLayout.Location = new Point(0, 0);
        this.col1BottomTableLayout.Name = "col1BottomTableLayout";
        this.col1BottomTableLayout.RowCount = 1;
        this.col1BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.col1BottomTableLayout.Size = new Size(280, 50);
        this.col1BottomTableLayout.TabIndex = 0;
        // 
        // col2BottomTableLayout
        // 
        this.col2BottomTableLayout.ColumnCount = 3;
        this.col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.col2BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col2BottomTableLayout.Controls.Add(this.col2RefreshButton, 1, 0);
        this.col2BottomTableLayout.Dock = DockStyle.Fill;
        this.col2BottomTableLayout.Location = new Point(0, 0);
        this.col2BottomTableLayout.Name = "col2BottomTableLayout";
        this.col2BottomTableLayout.RowCount = 1;
        this.col2BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.col2BottomTableLayout.Size = new Size(280, 50);
        this.col2BottomTableLayout.TabIndex = 1;
        // 
        // col3BottomTableLayout
        // 
        this.col3BottomTableLayout.ColumnCount = 3;
        this.col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.col3BottomTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.col3BottomTableLayout.Controls.Add(this.col3RefreshButton, 1, 0);
        this.col3BottomTableLayout.Dock = DockStyle.Fill;
        this.col3BottomTableLayout.Location = new Point(0, 0);
        this.col3BottomTableLayout.Name = "col3BottomTableLayout";
        this.col3BottomTableLayout.RowCount = 1;
        this.col3BottomTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.col3BottomTableLayout.Size = new Size(280, 50);
        this.col3BottomTableLayout.TabIndex = 1;
        // 
        // col1RefreshButton
        // 
        this.col1RefreshButton.Location = new Point(43, 3);
        this.col1RefreshButton.Name = "col1RefreshButton";
        this.col1RefreshButton.Size = new Size(194, 35);
        this.col1RefreshButton.TabIndex = 0;
        this.col1RefreshButton.Text = "Mettre à jour";
        this.col1RefreshButton.UseVisualStyleBackColor = true;
        // 
        // col2RefreshButton
        // 
        this.col2RefreshButton.Location = new Point(43, 3);
        this.col2RefreshButton.Name = "col2RefreshButton";
        this.col2RefreshButton.Size = new Size(194, 35);
        this.col2RefreshButton.TabIndex = 1;
        this.col2RefreshButton.Text = "Mettre à jour";
        this.col2RefreshButton.UseVisualStyleBackColor = true;
        // 
        // col3RefreshButton
        // 
        this.col3RefreshButton.Location = new Point(43, 3);
        this.col3RefreshButton.Name = "col3RefreshButton";
        this.col3RefreshButton.Size = new Size(194, 35);
        this.col3RefreshButton.TabIndex = 2;
        this.col3RefreshButton.Text = "Mettre à jour";
        this.col3RefreshButton.UseVisualStyleBackColor = true;
        // 
        // optionsTableLayout
        // 
        this.optionsTableLayout.ColumnCount = 3;
        this.optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        this.optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.optionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.optionsTableLayout.Controls.Add(this.optionsMainPanel, 1, 0);
        this.optionsTableLayout.Dock = DockStyle.Fill;
        this.optionsTableLayout.Location = new Point(10, 10);
        this.optionsTableLayout.Name = "optionsTableLayout";
        this.optionsTableLayout.RowCount = 1;
        this.optionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.optionsTableLayout.Size = new Size(260, 625);
        this.optionsTableLayout.TabIndex = 0;
        // 
        // optionsMainPanel
        // 
        this.optionsMainPanel.Controls.Add(this.restockOrderOptionsBox);
        this.optionsMainPanel.Controls.Add(this.shipOrderOptionsBox);
        this.optionsMainPanel.Dock = DockStyle.Fill;
        this.optionsMainPanel.Location = new Point(23, 3);
        this.optionsMainPanel.Name = "optionsMainPanel";
        this.optionsMainPanel.Size = new Size(194, 619);
        this.optionsMainPanel.TabIndex = 0;
        // 
        // shipOrderOptionsBox
        // 
        this.shipOrderOptionsBox.Controls.Add(this.markSoAsCompletedButton);
        this.shipOrderOptionsBox.Controls.Add(this.markSoAsPickedUpButton);
        this.shipOrderOptionsBox.Controls.Add(this.assignToSelfButton);
        this.shipOrderOptionsBox.Location = new Point(3, 3);
        this.shipOrderOptionsBox.Name = "shipOrderOptionsBox";
        this.shipOrderOptionsBox.Size = new Size(188, 152);
        this.shipOrderOptionsBox.TabIndex = 0;
        this.shipOrderOptionsBox.TabStop = false;
        this.shipOrderOptionsBox.Text = "Ordres d'expédition";
        // 
        // assignToSelfButton
        // 
        this.assignToSelfButton.Location = new Point(6, 22);
        this.assignToSelfButton.Name = "assignToSelfButton";
        this.assignToSelfButton.Size = new Size(176, 35);
        this.assignToSelfButton.TabIndex = 0;
        this.assignToSelfButton.Text = "Assigner à soi-même";
        this.assignToSelfButton.UseVisualStyleBackColor = true;
        // 
        // markSoAsPickedUpButton
        // 
        this.markSoAsPickedUpButton.Location = new Point(6, 63);
        this.markSoAsPickedUpButton.Name = "markSoAsPickedUpButton";
        this.markSoAsPickedUpButton.Size = new Size(176, 35);
        this.markSoAsPickedUpButton.TabIndex = 1;
        this.markSoAsPickedUpButton.Text = "Marquer comme ramassée";
        this.markSoAsPickedUpButton.UseVisualStyleBackColor = true;
        // 
        // markSoAsCompletedButton
        // 
        this.markSoAsCompletedButton.Location = new Point(6, 104);
        this.markSoAsCompletedButton.Name = "markSoAsCompletedButton";
        this.markSoAsCompletedButton.Size = new Size(176, 35);
        this.markSoAsCompletedButton.TabIndex = 2;
        this.markSoAsCompletedButton.Text = "Marquer comme ramassée";
        this.markSoAsCompletedButton.UseVisualStyleBackColor = true;
        // 
        // restockOrderOptionsBox
        // 
        this.restockOrderOptionsBox.Controls.Add(this.markPoAsCompletedButton);
        this.restockOrderOptionsBox.Location = new Point(3, 199);
        this.restockOrderOptionsBox.Name = "restockOrderOptionsBox";
        this.restockOrderOptionsBox.Size = new Size(188, 68);
        this.restockOrderOptionsBox.TabIndex = 1;
        this.restockOrderOptionsBox.TabStop = false;
        this.restockOrderOptionsBox.Text = "Ordres de restockage";
        // 
        // markPoAsCompletedButton
        // 
        this.markPoAsCompletedButton.Location = new Point(6, 22);
        this.markPoAsCompletedButton.Name = "markPoAsCompletedButton";
        this.markPoAsCompletedButton.Size = new Size(176, 35);
        this.markPoAsCompletedButton.TabIndex = 2;
        this.markPoAsCompletedButton.Text = "Marquer comme reçue";
        this.markPoAsCompletedButton.UseVisualStyleBackColor = true;
        // 
        // quitButton
        // 
        this.quitButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.quitButton.Location = new Point(42, 6);
        this.quitButton.Name = "quitButton";
        this.quitButton.Size = new Size(176, 35);
        this.quitButton.TabIndex = 4;
        this.quitButton.Text = "Quitter";
        this.quitButton.UseVisualStyleBackColor = true;
        // 
        // EmployeEntrepotMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "EmployeEntrepotMainMenu";
        this.Text = "EmployeEntrepotMainMenu";
        this.WindowState = FormWindowState.Maximized;
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.column4MainPanel.ResumeLayout(false);
        this.column4CenterPanel.ResumeLayout(false);
        this.column4BottomPanel.ResumeLayout(false);
        this.column3MainPanel.ResumeLayout(false);
        this.column3CenterPanel.ResumeLayout(false);
        this.column3BottomPanel.ResumeLayout(false);
        this.column2MainPanel.ResumeLayout(false);
        this.column2CenterPanel.ResumeLayout(false);
        this.column2BottomPanel.ResumeLayout(false);
        this.column1MainPanel.ResumeLayout(false);
        this.column1CenterPanel.ResumeLayout(false);
        this.column1BottomPanel.ResumeLayout(false);
        this.col1BottomTableLayout.ResumeLayout(false);
        this.col2BottomTableLayout.ResumeLayout(false);
        this.col3BottomTableLayout.ResumeLayout(false);
        this.optionsTableLayout.ResumeLayout(false);
        this.optionsMainPanel.ResumeLayout(false);
        this.shipOrderOptionsBox.ResumeLayout(false);
        this.restockOrderOptionsBox.ResumeLayout(false);
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