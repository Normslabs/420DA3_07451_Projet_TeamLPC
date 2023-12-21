using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class LoginForm : Form {
    private readonly AbstractFacade facade;

    public LoginForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    private void LogInButton_Click(object sender, EventArgs e) {
        try {
            if (string.IsNullOrEmpty(this.usernameTextBox.Text)) {
                _ = MessageBox.Show("Nom d'utilisateur vide");
                return;
            }
            if (string.IsNullOrEmpty(this.passwordTextBox.Text)) {
                _ = MessageBox.Show("Mot de passe vide");
                return;
            }
            _ = this.facade.GetService<LoginService>().AttemptLogin(this.usernameTextBox.Text, this.passwordTextBox.Text);

            // if code execution reaches this point, then user has been found and authentified. Invalid usernames and
            // passwords will have caused exceptions to be thrown in AttemptLogin().

            // fermer le form
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            // Nom d'utilisateur ou mot de passe invalide. Afficher message mais ne pas fermer le form
            _ = MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
