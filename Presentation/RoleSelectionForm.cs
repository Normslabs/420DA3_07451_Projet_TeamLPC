using _420DA3_07451_Projet_Initial.DataAccess.DTOs;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class RoleSelectionForm : Form {
    private Role? selectedRole;
    public RoleSelectionForm() {
        this.InitializeComponent();
    }


    public Role ShowForUser(Utilisateur utilisateur) {
        // empty the panel of all pre-existing buttons and controls
        this.roleSelectionPanel.Controls.Clear();

        if (utilisateur.Roles.Count <= 0) {
            throw new Exception("L'utilisateur n'a pas de rôles assignés!");
        }

        // dynamically create buttons and controls for the user's roles
        this.roleSelectionPanel.SuspendLayout();
        int count = 0;
        foreach (Role role in utilisateur.Roles) {
            Button button = new Button();
            this.roleSelectionPanel.Controls.Add(button);
            button.Text = role.RoleName;
            button.Size = new Size(190, 40);
            button.Location = new Point(0, 20 + (count * 50));
            button.Tag = role;
            button.Click += this.DynamicButtonClickHandler;
            button.Dock = DockStyle.Top;

            Panel separator = new Panel();
            this.roleSelectionPanel.Controls.Add(separator);
            separator.Size = new Size(190, 10);
            separator.Location = new Point(0, 20 + 40 + (count * 50));
            separator.Dock = DockStyle.Top;
        }
        this.roleSelectionPanel.ResumeLayout();
        this.roleSelectionPanel.Refresh();

        // show the form and wait for user selection
        _ = this.ShowDialog();

        // return the role once the user has selected one (during the previous ShowDialog() call
        return this.selectedRole ?? throw new Exception("Selected role was not assigned to property correctly.");
    }

    private void DynamicButtonClickHandler(object? sender, EventArgs e) {
        Button clickedButton = (Button) (sender ?? throw new Exception("Null event handler sender object"));
        this.selectedRole = (Role) clickedButton.Tag;
        this.DialogResult = DialogResult.OK;
    }
}
