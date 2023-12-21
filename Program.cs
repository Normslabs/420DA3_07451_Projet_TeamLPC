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
        new GestionEntrepotApplication().Start();
    }
}