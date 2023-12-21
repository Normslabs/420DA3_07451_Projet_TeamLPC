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
        panel1 = new Panel();
        entrepotComboBox = new ComboBox();
        Entrepotlabel = new Label();
        StatusComboBox = new ComboBox();
        Status = new Label();
        QTYnumericUpDown = new NumericUpDown();
        QTYlabel = new Label();
        produitListView = new ListBox();
        AnnulerBtn = new Button();
        ActionBtn = new Button();
        listProduitLabel = new Label();
        produitTextBox = new TextBox();
        RechercheLabel = new Label();
        idNumericUpDown = new NumericUpDown();
        poIdLabel = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) QTYnumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize) idNumericUpDown).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(entrepotComboBox);
        panel1.Controls.Add(Entrepotlabel);
        panel1.Controls.Add(StatusComboBox);
        panel1.Controls.Add(Status);
        panel1.Controls.Add(QTYnumericUpDown);
        panel1.Controls.Add(QTYlabel);
        panel1.Controls.Add(produitListView);
        panel1.Controls.Add(AnnulerBtn);
        panel1.Controls.Add(ActionBtn);
        panel1.Controls.Add(listProduitLabel);
        panel1.Controls.Add(produitTextBox);
        panel1.Controls.Add(RechercheLabel);
        panel1.Controls.Add(idNumericUpDown);
        panel1.Controls.Add(poIdLabel);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(109, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(491, 511);
        panel1.TabIndex = 0;
        // 
        // entrepotComboBox
        // 
        entrepotComboBox.Dock = DockStyle.Top;
        entrepotComboBox.FormattingEnabled = true;
        entrepotComboBox.Location = new Point(0, 276);
        entrepotComboBox.Name = "entrepotComboBox";
        entrepotComboBox.Size = new Size(491, 23);
        entrepotComboBox.TabIndex = 20;
        // 
        // Entrepotlabel
        // 
        Entrepotlabel.AutoSize = true;
        Entrepotlabel.Dock = DockStyle.Top;
        Entrepotlabel.Location = new Point(0, 261);
        Entrepotlabel.Name = "Entrepotlabel";
        Entrepotlabel.Size = new Size(89, 15);
        Entrepotlabel.TabIndex = 19;
        Entrepotlabel.Text = "Entrepôt stocké";
        // 
        // StatusComboBox
        // 
        StatusComboBox.Dock = DockStyle.Top;
        StatusComboBox.FormattingEnabled = true;
        StatusComboBox.Location = new Point(0, 238);
        StatusComboBox.Name = "StatusComboBox";
        StatusComboBox.Size = new Size(491, 23);
        StatusComboBox.TabIndex = 18;
        // 
        // Status
        // 
        Status.AutoSize = true;
        Status.Dock = DockStyle.Top;
        Status.Location = new Point(0, 223);
        Status.Name = "Status";
        Status.Size = new Size(131, 15);
        Status.TabIndex = 17;
        Status.Text = "Status de la commande";
        // 
        // QTYnumericUpDown
        // 
        QTYnumericUpDown.Dock = DockStyle.Top;
        QTYnumericUpDown.Location = new Point(0, 200);
        QTYnumericUpDown.Name = "QTYnumericUpDown";
        QTYnumericUpDown.Size = new Size(491, 23);
        QTYnumericUpDown.TabIndex = 16;
        // 
        // QTYlabel
        // 
        QTYlabel.AutoSize = true;
        QTYlabel.Dock = DockStyle.Top;
        QTYlabel.Location = new Point(0, 185);
        QTYlabel.Name = "QTYlabel";
        QTYlabel.Size = new Size(130, 15);
        QTYlabel.TabIndex = 15;
        QTYlabel.Text = "Quantité à commander";
        // 
        // produitListView
        // 
        produitListView.Dock = DockStyle.Top;
        produitListView.FormattingEnabled = true;
        produitListView.ItemHeight = 15;
        produitListView.Location = new Point(0, 91);
        produitListView.Name = "produitListView";
        produitListView.Size = new Size(491, 94);
        produitListView.TabIndex = 14;
        // 
        // AnnulerBtn
        // 
        AnnulerBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        AnnulerBtn.Location = new Point(413, 461);
        AnnulerBtn.Name = "AnnulerBtn";
        AnnulerBtn.Size = new Size(75, 41);
        AnnulerBtn.TabIndex = 13;
        AnnulerBtn.Text = "Annuler";
        AnnulerBtn.UseVisualStyleBackColor = true;
        AnnulerBtn.Click += this.AnnulerBtn_Click;
        // 
        // ActionBtn
        // 
        ActionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        ActionBtn.Location = new Point(3, 461);
        ActionBtn.Name = "ActionBtn";
        ActionBtn.Size = new Size(75, 41);
        ActionBtn.TabIndex = 12;
        ActionBtn.Text = "Action";
        ActionBtn.UseVisualStyleBackColor = true;
        ActionBtn.Click += this.ActionBtn_Click;
        // 
        // listProduitLabel
        // 
        listProduitLabel.AutoSize = true;
        listProduitLabel.Dock = DockStyle.Top;
        listProduitLabel.Location = new Point(0, 76);
        listProduitLabel.Name = "listProduitLabel";
        listProduitLabel.Size = new Size(99, 15);
        listProduitLabel.TabIndex = 4;
        listProduitLabel.Tag = "";
        listProduitLabel.Text = "Liste des produits";
        // 
        // produitTextBox
        // 
        produitTextBox.Dock = DockStyle.Top;
        produitTextBox.Location = new Point(0, 53);
        produitTextBox.Name = "produitTextBox";
        produitTextBox.Size = new Size(491, 23);
        produitTextBox.TabIndex = 3;
        // 
        // RechercheLabel
        // 
        RechercheLabel.AutoSize = true;
        RechercheLabel.Dock = DockStyle.Top;
        RechercheLabel.Location = new Point(0, 38);
        RechercheLabel.Name = "RechercheLabel";
        RechercheLabel.Size = new Size(101, 15);
        RechercheLabel.TabIndex = 2;
        RechercheLabel.Text = "Produit recherché";
        // 
        // idNumericUpDown
        // 
        idNumericUpDown.Dock = DockStyle.Top;
        idNumericUpDown.Location = new Point(0, 15);
        idNumericUpDown.Name = "idNumericUpDown";
        idNumericUpDown.Size = new Size(491, 23);
        idNumericUpDown.TabIndex = 1;
        // 
        // poIdLabel
        // 
        poIdLabel.AutoSize = true;
        poIdLabel.Dock = DockStyle.Top;
        poIdLabel.Location = new Point(0, 0);
        poIdLabel.Name = "poIdLabel";
        poIdLabel.Size = new Size(76, 15);
        poIdLabel.TabIndex = 0;
        poIdLabel.Text = "Id du produit";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.Controls.Add(panel1, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(711, 517);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // PurchaseOrderForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(711, 517);
        this.Controls.Add(tableLayoutPanel1);
        this.Name = "PurchaseOrderForm";
        this.Text = "PurchaseOrderForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) QTYnumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) idNumericUpDown).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
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