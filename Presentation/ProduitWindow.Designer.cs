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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.qtyInStockNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.supplierCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upcCodeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.idNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyInStockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcCodeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supplierComboBox);
            this.panel2.Controls.Add(this.supplierLabel);
            this.panel2.Controls.Add(this.clientComboBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.qtyInStockNumeric);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AutoCheckBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.supplierCodeTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.upcCodeNumUpDown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.idNumUpDown);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 562);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(0, 346);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(503, 23);
            this.supplierComboBox.TabIndex = 20;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierLabel.Location = new System.Drawing.Point(0, 331);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(50, 15);
            this.supplierLabel.TabIndex = 19;
            this.supplierLabel.Text = "Supplier";
            // 
            // clientComboBox
            // 
            this.clientComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(0, 308);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(503, 23);
            this.clientComboBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(503, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Client";
            // 
            // qtyInStockNumeric
            // 
            this.qtyInStockNumeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.qtyInStockNumeric.Location = new System.Drawing.Point(0, 270);
            this.qtyInStockNumeric.Name = "qtyInStockNumeric";
            this.qtyInStockNumeric.Size = new System.Drawing.Size(503, 23);
            this.qtyInStockNumeric.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantité en stock";
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoCheckBox.Location = new System.Drawing.Point(0, 236);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(503, 19);
            this.AutoCheckBox.TabIndex = 11;
            this.AutoCheckBox.Text = "Yes";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Auto Restock";
            // 
            // supplierCodeTextBox
            // 
            this.supplierCodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplierCodeTextBox.Location = new System.Drawing.Point(0, 198);
            this.supplierCodeTextBox.Name = "supplierCodeTextBox";
            this.supplierCodeTextBox.Size = new System.Drawing.Size(503, 23);
            this.supplierCodeTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier Code";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 129);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(503, 54);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(0, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(503, 23);
            this.nameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // upcCodeNumUpDown
            // 
            this.upcCodeNumUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.upcCodeNumUpDown.Location = new System.Drawing.Point(0, 53);
            this.upcCodeNumUpDown.Name = "upcCodeNumUpDown";
            this.upcCodeNumUpDown.Size = new System.Drawing.Size(503, 23);
            this.upcCodeNumUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "UPC Code :";
            // 
            // idNumUpDown
            // 
            this.idNumUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.idNumUpDown.Location = new System.Drawing.Point(0, 15);
            this.idNumUpDown.Name = "idNumUpDown";
            this.idNumUpDown.Size = new System.Drawing.Size(503, 23);
            this.idNumUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 562);
            this.panel3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Supplier";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(766, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 562);
            this.panel4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Client";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.actionBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 53);
            this.panel1.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(909, 14);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(24, 14);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(98, 33);
            this.actionBtn.TabIndex = 0;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            // 
            // ProduitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProduitWindow";
            this.Text = "ProduitWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyInStockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcCodeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumUpDown)).EndInit();
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