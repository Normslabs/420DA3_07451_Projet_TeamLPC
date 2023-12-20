namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ProduitWindow {
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
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.supplierListBox = new ListBox();
        this.label11 = new Label();
        this.clientListBox = new ListBox();
        this.label10 = new Label();
        this.qtyInStockNumeric = new NumericUpDown();
        this.label7 = new Label();
        this.checkBox1 = new CheckBox();
        this.label6 = new Label();
        this.supplierCodeTextBox = new TextBox();
        this.label5 = new Label();
        this.descriptionTextBox = new TextBox();
        this.label4 = new Label();
        this.nameTextBox = new TextBox();
        this.label3 = new Label();
        this.numericUpDown2 = new NumericUpDown();
        this.label2 = new Label();
        this.numericUpDown1 = new NumericUpDown();
        this.label1 = new Label();
        this.panel3 = new Panel();
        this.label8 = new Label();
        this.panel4 = new Panel();
        this.label9 = new Label();
        this.panel1 = new Panel();
        this.cancelBtn = new Button();
        this.actionBtn = new Button();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.qtyInStockNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDown1).BeginInit();
        this.panel3.SuspendLayout();
        this.panel4.SuspendLayout();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(1165, 757);
        this.tableLayoutPanel1.TabIndex = 0;
        this.tableLayoutPanel1.Paint += this.tableLayoutPanel1_Paint;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.supplierListBox);
        this.panel2.Controls.Add(this.label11);
        this.panel2.Controls.Add(this.clientListBox);
        this.panel2.Controls.Add(this.label10);
        this.panel2.Controls.Add(this.qtyInStockNumeric);
        this.panel2.Controls.Add(this.label7);
        this.panel2.Controls.Add(this.checkBox1);
        this.panel2.Controls.Add(this.label6);
        this.panel2.Controls.Add(this.supplierCodeTextBox);
        this.panel2.Controls.Add(this.label5);
        this.panel2.Controls.Add(this.descriptionTextBox);
        this.panel2.Controls.Add(this.label4);
        this.panel2.Controls.Add(this.nameTextBox);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.numericUpDown2);
        this.panel2.Controls.Add(this.label2);
        this.panel2.Controls.Add(this.numericUpDown1);
        this.panel2.Controls.Add(this.label1);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(294, 4);
        this.panel2.Margin = new Padding(3, 4, 3, 4);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(576, 749);
        this.panel2.TabIndex = 0;
        this.panel2.Paint += this.panel2_Paint;
        // 
        // supplierListBox
        // 
        this.supplierListBox.Dock = DockStyle.Top;
        this.supplierListBox.FormattingEnabled = true;
        this.supplierListBox.ItemHeight = 20;
        this.supplierListBox.Location = new Point(0, 534);
        this.supplierListBox.Margin = new Padding(3, 4, 3, 4);
        this.supplierListBox.Name = "supplierListBox";
        this.supplierListBox.Size = new Size(576, 124);
        this.supplierListBox.TabIndex = 18;
        // 
        // label11
        // 
        this.label11.Dock = DockStyle.Top;
        this.label11.Location = new Point(0, 514);
        this.label11.Name = "label11";
        this.label11.Size = new Size(576, 20);
        this.label11.TabIndex = 17;
        this.label11.Text = "Supplier";
        // 
        // clientListBox
        // 
        this.clientListBox.Dock = DockStyle.Top;
        this.clientListBox.FormattingEnabled = true;
        this.clientListBox.ItemHeight = 20;
        this.clientListBox.Location = new Point(0, 390);
        this.clientListBox.Margin = new Padding(3, 4, 3, 4);
        this.clientListBox.Name = "clientListBox";
        this.clientListBox.Size = new Size(576, 124);
        this.clientListBox.TabIndex = 16;
        // 
        // label10
        // 
        this.label10.Dock = DockStyle.Top;
        this.label10.Location = new Point(0, 370);
        this.label10.Name = "label10";
        this.label10.Size = new Size(576, 20);
        this.label10.TabIndex = 15;
        this.label10.Text = "Client";
        // 
        // qtyInStockNumeric
        // 
        this.qtyInStockNumeric.Dock = DockStyle.Top;
        this.qtyInStockNumeric.Location = new Point(0, 343);
        this.qtyInStockNumeric.Margin = new Padding(3, 4, 3, 4);
        this.qtyInStockNumeric.Name = "qtyInStockNumeric";
        this.qtyInStockNumeric.Size = new Size(576, 27);
        this.qtyInStockNumeric.TabIndex = 13;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Dock = DockStyle.Top;
        this.label7.Location = new Point(0, 323);
        this.label7.Name = "label7";
        this.label7.Size = new Size(124, 20);
        this.label7.TabIndex = 12;
        this.label7.Text = "Quantité en stock";
        // 
        // checkBox1
        // 
        this.checkBox1.AutoSize = true;
        this.checkBox1.Dock = DockStyle.Top;
        this.checkBox1.Location = new Point(0, 299);
        this.checkBox1.Margin = new Padding(3, 4, 3, 4);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new Size(576, 24);
        this.checkBox1.TabIndex = 11;
        this.checkBox1.Text = "Yes";
        this.checkBox1.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Dock = DockStyle.Top;
        this.label6.Location = new Point(0, 279);
        this.label6.Name = "label6";
        this.label6.Size = new Size(96, 20);
        this.label6.TabIndex = 10;
        this.label6.Text = "Auto Restock";
        // 
        // supplierCodeTextBox
        // 
        this.supplierCodeTextBox.Dock = DockStyle.Top;
        this.supplierCodeTextBox.Location = new Point(0, 252);
        this.supplierCodeTextBox.Margin = new Padding(3, 4, 3, 4);
        this.supplierCodeTextBox.Name = "supplierCodeTextBox";
        this.supplierCodeTextBox.Size = new Size(576, 27);
        this.supplierCodeTextBox.TabIndex = 9;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Dock = DockStyle.Top;
        this.label5.Location = new Point(0, 232);
        this.label5.Name = "label5";
        this.label5.Size = new Size(103, 20);
        this.label5.TabIndex = 8;
        this.label5.Text = "Supplier Code";
        // 
        // descriptionTextBox
        // 
        this.descriptionTextBox.Dock = DockStyle.Top;
        this.descriptionTextBox.Location = new Point(0, 161);
        this.descriptionTextBox.Margin = new Padding(3, 4, 3, 4);
        this.descriptionTextBox.Multiline = true;
        this.descriptionTextBox.Name = "descriptionTextBox";
        this.descriptionTextBox.Size = new Size(576, 71);
        this.descriptionTextBox.TabIndex = 7;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Dock = DockStyle.Top;
        this.label4.Location = new Point(0, 141);
        this.label4.Name = "label4";
        this.label4.Size = new Size(85, 20);
        this.label4.TabIndex = 6;
        this.label4.Text = "Description";
        // 
        // nameTextBox
        // 
        this.nameTextBox.Dock = DockStyle.Top;
        this.nameTextBox.Location = new Point(0, 114);
        this.nameTextBox.Margin = new Padding(3, 4, 3, 4);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new Size(576, 27);
        this.nameTextBox.TabIndex = 5;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = DockStyle.Top;
        this.label3.Location = new Point(0, 94);
        this.label3.Name = "label3";
        this.label3.Size = new Size(49, 20);
        this.label3.TabIndex = 4;
        this.label3.Text = "Name";
        // 
        // numericUpDown2
        // 
        this.numericUpDown2.Dock = DockStyle.Top;
        this.numericUpDown2.Location = new Point(0, 67);
        this.numericUpDown2.Margin = new Padding(3, 4, 3, 4);
        this.numericUpDown2.Name = "numericUpDown2";
        this.numericUpDown2.Size = new Size(576, 27);
        this.numericUpDown2.TabIndex = 3;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = DockStyle.Top;
        this.label2.Location = new Point(0, 47);
        this.label2.Name = "label2";
        this.label2.Size = new Size(82, 20);
        this.label2.TabIndex = 2;
        this.label2.Text = "UPC Code :";
        // 
        // numericUpDown1
        // 
        this.numericUpDown1.Dock = DockStyle.Top;
        this.numericUpDown1.Location = new Point(0, 20);
        this.numericUpDown1.Margin = new Padding(3, 4, 3, 4);
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new Size(576, 27);
        this.numericUpDown1.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = DockStyle.Top;
        this.label1.Location = new Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(31, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "ID :";
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.label8);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(3, 4);
        this.panel3.Margin = new Padding(3, 4, 3, 4);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(285, 749);
        this.panel3.TabIndex = 1;
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(79, 8);
        this.label8.Name = "label8";
        this.label8.Size = new Size(64, 20);
        this.label8.TabIndex = 0;
        this.label8.Text = "Supplier";
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.label9);
        this.panel4.Dock = DockStyle.Fill;
        this.panel4.Location = new Point(876, 4);
        this.panel4.Margin = new Padding(3, 4, 3, 4);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(286, 749);
        this.panel4.TabIndex = 2;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(86, 8);
        this.label9.Name = "label9";
        this.label9.Size = new Size(47, 20);
        this.label9.TabIndex = 1;
        this.label9.Text = "Client";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.cancelBtn);
        this.panel1.Controls.Add(this.actionBtn);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new Point(0, 686);
        this.panel1.Margin = new Padding(3, 4, 3, 4);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1165, 71);
        this.panel1.TabIndex = 1;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Location = new Point(1039, 19);
        this.cancelBtn.Margin = new Padding(3, 4, 3, 4);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(112, 44);
        this.cancelBtn.TabIndex = 1;
        this.cancelBtn.Text = "Annuler";
        this.cancelBtn.UseVisualStyleBackColor = true;
        // 
        // actionBtn
        // 
        this.actionBtn.Location = new Point(27, 19);
        this.actionBtn.Margin = new Padding(3, 4, 3, 4);
        this.actionBtn.Name = "actionBtn";
        this.actionBtn.Size = new Size(112, 44);
        this.actionBtn.TabIndex = 0;
        this.actionBtn.Text = "Action";
        this.actionBtn.UseVisualStyleBackColor = true;
        // 
        // ProduitWindow
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1165, 757);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "ProduitWindow";
        this.Text = "ProduitWindow";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.qtyInStockNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDown1).EndInit();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Button cancelBtn;
    private Button actionBtn;
    private Panel panel2;
    private Label label1;
    private NumericUpDown numericUpDown1;
    private Label label5;
    private TextBox descriptionTextBox;
    private Label label4;
    private TextBox nameTextBox;
    private Label label3;
    private NumericUpDown numericUpDown2;
    private Label label2;
    private CheckBox checkBox1;
    private Label label6;
    private TextBox supplierCodeTextBox;
    private NumericUpDown qtyInStockNumeric;
    private Label label7;
    private Panel panel3;
    private Label label8;
    private Panel panel4;
    private Label label9;
    private ListBox supplierListBox;
    private Label label11;
    private ListBox clientListBox;
    private Label label10;
}