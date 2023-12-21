using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Services;
using System.Diagnostics;

namespace _420DA3_07451_Projet_Initial;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main(string[] args) {
        if (args.Contains("-profTests")) {

            Debug.WriteLine(CryptographyService.HashPassword("potatoes"));
            // Zone de tests pour le prof

        } else if (args.Contains("-olivierTests")) {

            // Zone de tests pour Olivier

        } else if (args.Contains("-mouhamedTests")) {

            // Zone de tests pour Mouhamed

        } else if (args.Contains("-filipeTests")) {

            ApplicationConfiguration.Initialize();

        } else if (args.Contains("-maximilianoTests")) {

            // Zone de tests pour Maximiliano

        } else {
            new GestionEntrepotApplication().Start();
        }
    }
}