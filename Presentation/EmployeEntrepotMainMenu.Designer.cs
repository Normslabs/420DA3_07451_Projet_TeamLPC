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
        this.mainTableLayoutPanel.SuspendLayout();
        this.column4MainPanel.SuspendLayout();
        this.column3MainPanel.SuspendLayout();
        this.column3CenterPanel.SuspendLayout();
        this.column2MainPanel.SuspendLayout();
        this.column2CenterPanel.SuspendLayout();
        this.column1MainPanel.SuspendLayout();
        this.column1CenterPanel.SuspendLayout();
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
        this.column4CenterPanel.Dock = DockStyle.Fill;
        this.column4CenterPanel.Location = new Point(5, 55);
        this.column4CenterPanel.Name = "column4CenterPanel";
        this.column4CenterPanel.Padding = new Padding(5);
        this.column4CenterPanel.Size = new Size(280, 645);
        this.column4CenterPanel.TabIndex = 5;
        // 
        // column4BottomPanel
        // 
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
        this.column3MainPanel.ResumeLayout(false);
        this.column3CenterPanel.ResumeLayout(false);
        this.column2MainPanel.ResumeLayout(false);
        this.column2CenterPanel.ResumeLayout(false);
        this.column1MainPanel.ResumeLayout(false);
        this.column1CenterPanel.ResumeLayout(false);
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
}