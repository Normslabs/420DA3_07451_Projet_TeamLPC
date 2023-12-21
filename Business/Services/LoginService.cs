using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Exceptions;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Diagnostics;

namespace _420DA3_07451_Projet_Initial.Business.Services;
internal class LoginService : AbstractLoginService {
    private readonly LoginForm loginForm;
    private readonly RoleSelectionForm roleSelectionForm;
    public AbstractFacade ParentFacade { get; private set; }

    [Obsolete("Compatibility only. DO NOT USE.")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public LoginService() {
        // This constructor is only for compatibility purposes with my
        // LoginFacade system. Normally, all services require a facade to be passed
        // as a constructor parameter, but Facades also must all receive a LoginService
        // in their constructor (at least, to the AbstractFacade constructor call.
        //
        // Because this is a chicken and egg situation, I needed this bad 'hack' to
        // create a fake LoginService for the LoginFacade that is immediately replaced
        // by a real one in the LoginFacade constructor.
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public LoginService(AbstractFacade facade) {
        facade.RegisterDependent(this);
        this.ParentFacade = facade;
        this.loginForm = new LoginForm(facade);
        this.roleSelectionForm = new RoleSelectionForm();
    }

    public override void Shutdown() {
        if (!this.loginForm.IsDisposed) {
            this.loginForm.Dispose();
        }
    }

    public override Utilisateur GetLoggedInUser() {
        return this.LoggedInUser is null
            ? throw new NoLoggedInUserException("Pas d'utilisateur connecté en ce moment.")
            : this.LoggedInUser;
    }

    public bool RequireLoggedInUser() {
        if (this.LoggedInUser is not null) {
            return true;
        }
        // Show dialog will force either successful login (DialogResult = OK)
        // or cancellation (DialogResult = Cancel).
        DialogResult result = this.loginForm.ShowDialog();
        return result == DialogResult.OK;
    }

    public Utilisateur AttemptLogin(string username, string password) {
        Utilisateur? foundUser = this.ParentFacade.GetService<UtilisateurService>().FindUtilisateurByUsername(username);
        if (foundUser is null) {
            // Utilisateur non trouvé dans la base de donnée
            throw new Exception("Nom d'utilisateur invalide.");

        } else if (!CryptographyService.VerifyPassword(password, foundUser.PasswordHash)) {
            // Mot de passe invalide
            throw new Exception("Mot de passe invalide.");
        }
        // Utilisateur trouvé et mot de passe valide: procéder au login

        // enregistrer l'utilisateur trouvé dans le service de login
        this.LoggedInUser = foundUser;
        return foundUser;
    }

    public Role SelectUserRole(Utilisateur utilisateur) {
        return this.roleSelectionForm.ShowForUser(utilisateur);
    }

}
