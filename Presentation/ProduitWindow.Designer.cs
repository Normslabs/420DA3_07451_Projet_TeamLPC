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
        tableLayoutPanel1 = new TableLayoutPanel();
        panel2 = new Panel();
        supplierComboBox = new ComboBox();
        supplierLabel = new Label();
        clientComboBox = new ComboBox();
        label10 = new Label();
        qtyInStockNumeric = new NumericUpDown();
        label7 = new Label();
        AutoCheckBox = new CheckBox();
        label6 = new Label();
        supplierCodeTextBox = new TextBox();
        label5 = new Label();
        descriptionTextBox = new TextBox();
        label4 = new Label();
        nameTextBox = new TextBox();
        label3 = new Label();
        upcCodeNumUpDown = new NumericUpDown();
        label2 = new Label();
        idNumUpDown = new NumericUpDown();
        label1 = new Label();
        panel3 = new Panel();
        label8 = new Label();
        panel4 = new Panel();
        label9 = new Label();
        panel1 = new Panel();
        cancelBtn = new Button();
        actionBtn = new Button();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) qtyInStockNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize) upcCodeNumUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize) idNumUpDown).BeginInit();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(panel2, 1, 0);
        tableLayoutPanel1.Controls.Add(panel3, 0, 0);
        tableLayoutPanel1.Controls.Add(panel4, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(1019, 568);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.Paint += this.tableLayoutPanel1_Paint;
        // 
        // panel2
        // 
        panel2.Controls.Add(supplierComboBox);
        panel2.Controls.Add(supplierLabel);
        panel2.Controls.Add(clientComboBox);
        panel2.Controls.Add(label10);
        panel2.Controls.Add(qtyInStockNumeric);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(AutoCheckBox);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(supplierCodeTextBox);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(descriptionTextBox);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(nameTextBox);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(upcCodeNumUpDown);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(idNumUpDown);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(257, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(503, 562);
        panel2.TabIndex = 0;
        panel2.Paint += this.panel2_Paint;
        // 
        // supplierComboBox
        // 
        supplierComboBox.Dock = DockStyle.Top;
        supplierComboBox.FormattingEnabled = true;
        supplierComboBox.Location = new Point(0, 346);
        supplierComboBox.Name = "supplierComboBox";
        supplierComboBox.Size = new Size(503, 23);
        supplierComboBox.TabIndex = 20;
        // 
        // supplierLabel
        // 
        supplierLabel.AutoSize = true;
        supplierLabel.Dock = DockStyle.Top;
        supplierLabel.Location = new Point(0, 331);
        supplierLabel.Name = "supplierLabel";
        supplierLabel.Size = new Size(50, 15);
        supplierLabel.TabIndex = 19;
        supplierLabel.Text = "Supplier";
        // 
        // clientComboBox
        // 
        clientComboBox.Dock = DockStyle.Top;
        clientComboBox.FormattingEnabled = true;
        clientComboBox.Location = new Point(0, 308);
        clientComboBox.Name = "clientComboBox";
        clientComboBox.Size = new Size(503, 23);
        clientComboBox.TabIndex = 18;
        // 
        // label10
        // 
        label10.Dock = DockStyle.Top;
        label10.Location = new Point(0, 293);
        label10.Name = "label10";
        label10.Size = new Size(503, 15);
        label10.TabIndex = 15;
        label10.Text = "Client";
        // 
        // qtyInStockNumeric
        // 
        qtyInStockNumeric.Dock = DockStyle.Top;
        qtyInStockNumeric.Location = new Point(0, 270);
        qtyInStockNumeric.Name = "qtyInStockNumeric";
        qtyInStockNumeric.Size = new Size(503, 23);
        qtyInStockNumeric.TabIndex = 13;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = DockStyle.Top;
        label7.Location = new Point(0, 255);
        label7.Name = "label7";
        label7.Size = new Size(100, 15);
        label7.TabIndex = 12;
        label7.Text = "Quantité en stock";
        // 
        // AutoCheckBox
        // 
        AutoCheckBox.AutoSize = true;
        AutoCheckBox.Dock = DockStyle.Top;
        AutoCheckBox.Location = new Point(0, 236);
        AutoCheckBox.Name = "AutoCheckBox";
        AutoCheckBox.Size = new Size(503, 19);
        AutoCheckBox.TabIndex = 11;
        AutoCheckBox.Text = "Yes";
        AutoCheckBox.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Dock = DockStyle.Top;
        label6.Location = new Point(0, 221);
        label6.Name = "label6";
        label6.Size = new Size(77, 15);
        label6.TabIndex = 10;
        label6.Text = "Auto Restock";
        // 
        // supplierCodeTextBox
        // 
        supplierCodeTextBox.Dock = DockStyle.Top;
        supplierCodeTextBox.Location = new Point(0, 198);
        supplierCodeTextBox.Name = "supplierCodeTextBox";
        supplierCodeTextBox.Size = new Size(503, 23);
        supplierCodeTextBox.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Dock = DockStyle.Top;
        label5.Location = new Point(0, 183);
        label5.Name = "label5";
        label5.Size = new Size(81, 15);
        label5.TabIndex = 8;
        label5.Text = "Supplier Code";
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Dock = DockStyle.Top;
        descriptionTextBox.Location = new Point(0, 129);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(503, 54);
        descriptionTextBox.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Location = new Point(0, 114);
        label4.Name = "label4";
        label4.Size = new Size(67, 15);
        label4.TabIndex = 6;
        label4.Text = "Description";
        // 
        // nameTextBox
        // 
        nameTextBox.Dock = DockStyle.Top;
        nameTextBox.Location = new Point(0, 91);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(503, 23);
        nameTextBox.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = DockStyle.Top;
        label3.Location = new Point(0, 76);
        label3.Name = "label3";
        label3.Size = new Size(39, 15);
        label3.TabIndex = 4;
        label3.Text = "Name";
        // 
        // upcCodeNumUpDown
        // 
        upcCodeNumUpDown.Dock = DockStyle.Top;
        upcCodeNumUpDown.Location = new Point(0, 53);
        upcCodeNumUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        upcCodeNumUpDown.Name = "upcCodeNumUpDown";
        upcCodeNumUpDown.Size = new Size(503, 23);
        upcCodeNumUpDown.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Location = new Point(0, 38);
        label2.Name = "label2";
        label2.Size = new Size(67, 15);
        label2.TabIndex = 2;
        label2.Text = "UPC Code :";
        // 
        // idNumUpDown
        // 
        idNumUpDown.Dock = DockStyle.Top;
        idNumUpDown.Location = new Point(0, 15);
        idNumUpDown.Name = "idNumUpDown";
        idNumUpDown.Size = new Size(503, 23);
        idNumUpDown.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(24, 15);
        label1.TabIndex = 0;
        label1.Text = "ID :";
        // 
        // panel3
        // 
        panel3.Controls.Add(label8);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(3, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(248, 562);
        panel3.TabIndex = 1;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(69, 6);
        label8.Name = "label8";
        label8.Size = new Size(50, 15);
        label8.TabIndex = 0;
        label8.Text = "Supplier";
        // 
        // panel4
        // 
        panel4.Controls.Add(label9);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(766, 3);
        panel4.Name = "panel4";
        panel4.Size = new Size(250, 562);
        panel4.TabIndex = 2;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(75, 6);
        label9.Name = "label9";
        label9.Size = new Size(38, 15);
        label9.TabIndex = 1;
        label9.Text = "Client";
        // 
        // panel1
        // 
        panel1.Controls.Add(cancelBtn);
        panel1.Controls.Add(actionBtn);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 515);
        panel1.Name = "panel1";
        panel1.Size = new Size(1019, 53);
        panel1.TabIndex = 1;
        // 
        // cancelBtn
        // 
        cancelBtn.Location = new Point(909, 14);
        cancelBtn.Name = "cancelBtn";
        cancelBtn.Size = new Size(98, 33);
        cancelBtn.TabIndex = 1;
        cancelBtn.Text = "Annuler";
        cancelBtn.UseVisualStyleBackColor = true;
        cancelBtn.Click += this.cancelBtn_Click;
        // 
        // actionBtn
        // 
        actionBtn.Location = new Point(24, 14);
        actionBtn.Name = "actionBtn";
        actionBtn.Size = new Size(98, 33);
        actionBtn.TabIndex = 0;
        actionBtn.Text = "Action";
        actionBtn.UseVisualStyleBackColor = true;
        actionBtn.Click += this.actionBtn_Click;
        // 
        // ProduitWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1019, 568);
        this.Controls.Add(panel1);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "ProduitWindow";
        this.Text = "ProduitWindow";
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) qtyInStockNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize) upcCodeNumUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) idNumUpDown).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Button cancelBtn;
    private Button actionBtn;
    private Panel panel2;
    private Label label1;
    private NumericUpDown idNumUpDown;
    private Label label5;
    private TextBox descriptionTextBox;
    private Label label4;
    private TextBox nameTextBox;
    private Label label3;
    private NumericUpDown upcCodeNumUpDown;
    private Label label2;
    private CheckBox AutoCheckBox;
    private Label label6;
    private TextBox supplierCodeTextBox;
    private NumericUpDown qtyInStockNumeric;
    private Label label7;
    private Panel panel3;
    private Label label8;
    private Panel panel4;
    private Label label9;
    private Label label10;
    private ComboBox clientComboBox;
    private ComboBox supplierComboBox;
    private Label supplierLabel;
}