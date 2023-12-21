namespace _420DA3_07451_Projet_Initial.Presentation;

partial class PurchaseOrderForm {
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
        this.panel1 = new Panel();
        this.entrepotComboBox = new ComboBox();
        this.Entrepotlabel = new Label();
        this.StatusComboBox = new ComboBox();
        this.Status = new Label();
        this.QTYnumericUpDown = new NumericUpDown();
        this.QTYlabel = new Label();
        this.produitListView = new ListBox();
        this.AnnulerBtn = new Button();
        this.ActionBtn = new Button();
        this.listProduitLabel = new Label();
        this.produitTextBox = new TextBox();
        this.RechercheLabel = new Label();
        this.idNumericUpDown = new NumericUpDown();
        this.poIdLabel = new Label();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.QTYnumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.idNumericUpDown).BeginInit();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.entrepotComboBox);
        this.panel1.Controls.Add(this.Entrepotlabel);
        this.panel1.Controls.Add(this.StatusComboBox);
        this.panel1.Controls.Add(this.Status);
        this.panel1.Controls.Add(this.QTYnumericUpDown);
        this.panel1.Controls.Add(this.QTYlabel);
        this.panel1.Controls.Add(this.produitListView);
        this.panel1.Controls.Add(this.AnnulerBtn);
        this.panel1.Controls.Add(this.ActionBtn);
        this.panel1.Controls.Add(this.listProduitLabel);
        this.panel1.Controls.Add(this.produitTextBox);
        this.panel1.Controls.Add(this.RechercheLabel);
        this.panel1.Controls.Add(this.idNumericUpDown);
        this.panel1.Controls.Add(this.poIdLabel);
        this.panel1.Dock = DockStyle.Fill;
        this.panel1.Location = new Point(124, 4);
        this.panel1.Margin = new Padding(3, 4, 3, 4);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(563, 681);
        this.panel1.TabIndex = 0;
        // 
        // entrepotComboBox
        // 
        this.entrepotComboBox.Dock = DockStyle.Top;
        this.entrepotComboBox.FormattingEnabled = true;
        this.entrepotComboBox.Location = new Point(0, 353);
        this.entrepotComboBox.Margin = new Padding(3, 4, 3, 4);
        this.entrepotComboBox.Name = "entrepotComboBox";
        this.entrepotComboBox.Size = new Size(563, 28);
        this.entrepotComboBox.TabIndex = 20;
        // 
        // Entrepotlabel
        // 
        this.Entrepotlabel.AutoSize = true;
        this.Entrepotlabel.Dock = DockStyle.Top;
        this.Entrepotlabel.Location = new Point(0, 333);
        this.Entrepotlabel.Name = "Entrepotlabel";
        this.Entrepotlabel.Size = new Size(112, 20);
        this.Entrepotlabel.TabIndex = 19;
        this.Entrepotlabel.Text = "Entrepôt stocké";
        // 
        // StatusComboBox
        // 
        this.StatusComboBox.Dock = DockStyle.Top;
        this.StatusComboBox.FormattingEnabled = true;
        this.StatusComboBox.Location = new Point(0, 305);
        this.StatusComboBox.Margin = new Padding(3, 4, 3, 4);
        this.StatusComboBox.Name = "StatusComboBox";
        this.StatusComboBox.Size = new Size(563, 28);
        this.StatusComboBox.TabIndex = 18;
        // 
        // Status
        // 
        this.Status.AutoSize = true;
        this.Status.Dock = DockStyle.Top;
        this.Status.Location = new Point(0, 285);
        this.Status.Name = "Status";
        this.Status.Size = new Size(165, 20);
        this.Status.TabIndex = 17;
        this.Status.Text = "Status de la commande";
        // 
        // QTYnumericUpDown
        // 
        this.QTYnumericUpDown.Dock = DockStyle.Top;
        this.QTYnumericUpDown.Location = new Point(0, 258);
        this.QTYnumericUpDown.Margin = new Padding(3, 4, 3, 4);
        this.QTYnumericUpDown.Name = "QTYnumericUpDown";
        this.QTYnumericUpDown.Size = new Size(563, 27);
        this.QTYnumericUpDown.TabIndex = 16;
        // 
        // QTYlabel
        // 
        this.QTYlabel.AutoSize = true;
        this.QTYlabel.Dock = DockStyle.Top;
        this.QTYlabel.Location = new Point(0, 238);
        this.QTYlabel.Name = "QTYlabel";
        this.QTYlabel.Size = new Size(162, 20);
        this.QTYlabel.TabIndex = 15;
        this.QTYlabel.Text = "Quantité à commander";
        // 
        // produitListView
        // 
        this.produitListView.Dock = DockStyle.Top;
        this.produitListView.FormattingEnabled = true;
        this.produitListView.ItemHeight = 20;
        this.produitListView.Location = new Point(0, 114);
        this.produitListView.Margin = new Padding(3, 4, 3, 4);
        this.produitListView.Name = "produitListView";
        this.produitListView.Size = new Size(563, 124);
        this.produitListView.TabIndex = 14;
        // 
        // AnnulerBtn
        // 
        this.AnnulerBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.AnnulerBtn.Location = new Point(474, 615);
        this.AnnulerBtn.Margin = new Padding(3, 4, 3, 4);
        this.AnnulerBtn.Name = "AnnulerBtn";
        this.AnnulerBtn.Size = new Size(86, 55);
        this.AnnulerBtn.TabIndex = 13;
        this.AnnulerBtn.Text = "Annuler";
        this.AnnulerBtn.UseVisualStyleBackColor = true;
        this.AnnulerBtn.Click += this.AnnulerBtn_Click;
        // 
        // ActionBtn
        // 
        this.ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.ActionBtn.Location = new Point(3, 615);
        this.ActionBtn.Margin = new Padding(3, 4, 3, 4);
        this.ActionBtn.Name = "ActionBtn";
        this.ActionBtn.Size = new Size(86, 55);
        this.ActionBtn.TabIndex = 12;
        this.ActionBtn.Text = "Action";
        this.ActionBtn.UseVisualStyleBackColor = true;
        this.ActionBtn.Click += this.ActionBtn_Click;
        // 
        // listProduitLabel
        // 
        this.listProduitLabel.AutoSize = true;
        this.listProduitLabel.Dock = DockStyle.Top;
        this.listProduitLabel.Location = new Point(0, 94);
        this.listProduitLabel.Name = "listProduitLabel";
        this.listProduitLabel.Size = new Size(125, 20);
        this.listProduitLabel.TabIndex = 4;
        this.listProduitLabel.Tag = "";
        this.listProduitLabel.Text = "Liste des produits";
        // 
        // produitTextBox
        // 
        this.produitTextBox.Dock = DockStyle.Top;
        this.produitTextBox.Location = new Point(0, 67);
        this.produitTextBox.Margin = new Padding(3, 4, 3, 4);
        this.produitTextBox.Name = "produitTextBox";
        this.produitTextBox.Size = new Size(563, 27);
        this.produitTextBox.TabIndex = 3;
        // 
        // RechercheLabel
        // 
        this.RechercheLabel.AutoSize = true;
        this.RechercheLabel.Dock = DockStyle.Top;
        this.RechercheLabel.Location = new Point(0, 47);
        this.RechercheLabel.Name = "RechercheLabel";
        this.RechercheLabel.Size = new Size(125, 20);
        this.RechercheLabel.TabIndex = 2;
        this.RechercheLabel.Text = "Produit recherché";
        // 
        // idNumericUpDown
        // 
        this.idNumericUpDown.Dock = DockStyle.Top;
        this.idNumericUpDown.Location = new Point(0, 20);
        this.idNumericUpDown.Margin = new Padding(3, 4, 3, 4);
        this.idNumericUpDown.Name = "idNumericUpDown";
        this.idNumericUpDown.Size = new Size(563, 27);
        this.idNumericUpDown.TabIndex = 1;
        // 
        // poIdLabel
        // 
        this.poIdLabel.AutoSize = true;
        this.poIdLabel.Dock = DockStyle.Top;
        this.poIdLabel.Location = new Point(0, 0);
        this.poIdLabel.Name = "poIdLabel";
        this.poIdLabel.Size = new Size(96, 20);
        this.poIdLabel.TabIndex = 0;
        this.poIdLabel.Text = "Id du produit";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(813, 689);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // PurchaseOrderForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(813, 689);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "PurchaseOrderForm";
        this.Text = "PurchaseOrderForm";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.QTYnumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idNumericUpDown).EndInit();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private ComboBox entrepotComboBox;
    private Label Entrepotlabel;
    private ComboBox StatusComboBox;
    private Label Status;
    private NumericUpDown QTYnumericUpDown;
    private Label QTYlabel;
    private ListBox produitListView;
    private Button AnnulerBtn;
    private Button ActionBtn;
    private Label listProduitLabel;
    private TextBox produitTextBox;
    private Label RechercheLabel;
    private NumericUpDown idNumericUpDown;
    private Label poIdLabel;
    private TableLayoutPanel tableLayoutPanel1;
}