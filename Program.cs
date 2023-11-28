using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Configuration;
using System.Diagnostics;

namespace _420DA3_07451_Projet_Initial;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main(string[] args) {
        if (args.Contains("-profTests")) {

            // Zone de tests pour le prof
            ApplicationConfiguration.Initialize();
            Application.Run(new UtilisateurManagementForm());

        } else if (args.Contains("-olivierTests")) { 

            // Zone de tests pour Olivier

        } else if (args.Contains("-mouhamedTests")) {

            // Zone de tests pour Mouhamed

        } else if (args.Contains("-filipeTests")) {

            // Zone de tests pour Filipe

        } else if (args.Contains("-maximilianoTests")) {

            // Zone de tests pour Maximiliano

        } else {
            new ExampleApp().Start();
        }
    }
}